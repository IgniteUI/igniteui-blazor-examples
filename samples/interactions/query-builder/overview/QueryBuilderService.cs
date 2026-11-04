using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using IgniteUI.Blazor.Controls;

namespace Infragistics.Samples
{
    /// <summary>
    /// Executes queries against local mock customers and orders after a one-second
    /// simulated network delay, including filters, subqueries, and field selection.
    /// </summary>
    public class QueryBuilderService
    {
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private static readonly Dictionary<string, object>[] Customers =
        [
            new() { ["customerId"] = "ALFKI", ["companyName"] = "Alfreds Futterkiste", ["contactName"] = "Maria Anders", ["contactTitle"] = "Sales Representative" },
            new() { ["customerId"] = "ANATR", ["companyName"] = "Ana Trujillo Emparedados y helados", ["contactName"] = "Ana Trujillo", ["contactTitle"] = "Owner" },
            new() { ["customerId"] = "ANTON", ["companyName"] = "Antonio Moreno Taqueria", ["contactName"] = "Antonio Moreno", ["contactTitle"] = "Owner" },
            new() { ["customerId"] = "AROUT", ["companyName"] = "Around the Horn", ["contactName"] = "Thomas Hardy", ["contactTitle"] = "Sales Representative" }
        ];

        private static readonly Dictionary<string, object>[] Orders = Enumerable.Range(0, 60)
            .Select(index => new Dictionary<string, object>
            {
                ["orderId"] = 10248 + index,
                ["customerId"] = Customers[index % Customers.Length]["customerId"],
                ["employeeId"] = index % 9 + 1,
                ["shipperId"] = index % 3 + 1,
                ["orderDate"] = new DateTime(2025, 1, 1).AddDays(index),
                ["requiredDate"] = new DateTime(2025, 1, 1).AddDays(index + 28),
                ["shipVia"] = new[] { "Speedy Express", "United Package", "Federal Shipping" }[index % 3],
                ["freight"] = 10m + index * 2.75m,
                ["shipName"] = Customers[index % Customers.Length]["companyName"],
                ["completed"] = index % 3 != 0
            }).ToArray();

        public async Task<QueryResponse> ExecuteQueryAsync(string expressionJson)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            var expression = JsonSerializer.Deserialize<QueryExpression>(expressionJson, JsonOptions)
                ?? throw new ArgumentException("A query expression is required.", nameof(expressionJson));
            return ExecuteQuery(expression);
        }

        private static QueryResponse ExecuteQuery(QueryExpression expression)
        {
            var records = expression.Entity switch
            {
                "Customers" => Customers,
                "Orders" => Orders,
                _ => throw new ArgumentException($"Unknown entity: {expression.Entity}")
            };
            var fields = expression.ReturnFields;
            if (fields == null || fields.Length == 0 || fields.Contains("*"))
            {
                fields = records[0].Keys.ToArray();
            }

            if (fields.Any(field => !records[0].ContainsKey(field)))
            {
                throw new ArgumentException("The query contains an unknown return field.");
            }

            return new QueryResponse
            {
                Fields = fields,
                Items = records
                    .Where(record => MatchesTree(record, expression.FilteringOperands, expression.Operator))
                    .Select(record => fields.ToDictionary(field => field, field => record[field]))
                    .ToArray()
            };
        }

        private static bool MatchesTree(Dictionary<string, object> record,
            QueryExpression[] operands, FilteringLogic logic)
        {
            if (operands == null || operands.Length == 0)
            {
                return true;
            }

            return logic == FilteringLogic.Or
                ? operands.Any(operand => MatchesOperand(record, operand))
                : operands.All(operand => MatchesOperand(record, operand));
        }

        private static bool MatchesOperand(Dictionary<string, object> record,
            QueryExpression filter)
        {
            if (filter.FilteringOperands != null)
            {
                return MatchesTree(record, filter.FilteringOperands, filter.Operator);
            }

            var condition = filter.Condition?.Name ?? filter.ConditionName;
            // The builder can emit a partial expression while a condition is being edited.
            if (string.IsNullOrEmpty(condition) || string.IsNullOrEmpty(filter.FieldName))
            {
                return true;
            }

            if (!record.TryGetValue(filter.FieldName, out var value))
            {
                throw new ArgumentException($"Unknown field: {filter.FieldName}");
            }

            object searchValue = filter.SearchVal.ValueKind switch
            {
                JsonValueKind.String => filter.SearchVal.GetString(),
                JsonValueKind.Number => filter.SearchVal.GetDecimal(),
                JsonValueKind.True => true,
                JsonValueKind.False => false,
                JsonValueKind.Null or JsonValueKind.Undefined => null,
                _ => throw new ArgumentException("The search value must be a string, number, boolean, or null.")
            };
            var comparison = filter.IgnoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            var text = Convert.ToString(value, CultureInfo.InvariantCulture) ?? string.Empty;
            var searchText = Convert.ToString(searchValue, CultureInfo.InvariantCulture) ?? string.Empty;

            return condition switch
            {
                "null" => value == null,
                "notNull" => value != null,
                "empty" => value == null || text.Length == 0,
                "notEmpty" => value != null && text.Length != 0,
                "true" => value is true,
                "false" => value is false,
                "contains" => text.Contains(searchText, comparison),
                "doesNotContain" => !text.Contains(searchText, comparison),
                "startsWith" => text.StartsWith(searchText, comparison),
                "endsWith" => text.EndsWith(searchText, comparison),
                "equals" => Compare(value, searchValue, comparison) == 0,
                "doesNotEqual" => Compare(value, searchValue, comparison) != 0,
                "greaterThan" or "after" => Compare(value, searchValue, comparison) > 0,
                "greaterThanOrEqualTo" => Compare(value, searchValue, comparison) >= 0,
                "lessThan" or "before" => Compare(value, searchValue, comparison) < 0,
                "lessThanOrEqualTo" => Compare(value, searchValue, comparison) <= 0,
                "in" => MatchesSubquery(value, filter.SearchTree, comparison),
                "notIn" => !MatchesSubquery(value, filter.SearchTree, comparison),
                "today" or "yesterday" or "tomorrow" or "thisMonth" or "lastMonth" or "nextMonth"
                    or "thisYear" or "lastYear" or "nextYear" => MatchesDate(value, condition),
                _ => throw new NotSupportedException($"Unsupported condition: {condition}")
            };
        }

        private static int Compare(object value, object searchValue, StringComparison comparison)
        {
            if (value == null || searchValue == null)
            {
                return value == searchValue ? 0 : value == null ? -1 : 1;
            }

            return value switch
            {
                string text => string.Compare(text, Convert.ToString(searchValue, CultureInfo.InvariantCulture), comparison),
                DateTime date => date.Date.CompareTo(Convert.ToDateTime(searchValue, CultureInfo.InvariantCulture).Date),
                bool boolean => boolean.CompareTo(Convert.ToBoolean(searchValue, CultureInfo.InvariantCulture)),
                _ => Convert.ToDecimal(value, CultureInfo.InvariantCulture)
                    .CompareTo(Convert.ToDecimal(searchValue, CultureInfo.InvariantCulture))
            };
        }

        private static bool MatchesSubquery(object value, QueryExpression tree, StringComparison comparison)
        {
            if (tree == null)
            {
                throw new ArgumentException("Select a subquery for the IN condition.");
            }

            var response = ExecuteQuery(tree);
            if (response.Fields.Length != 1)
            {
                throw new ArgumentException("A subquery must return exactly one field.");
            }

            return response.Items.Any(row => Compare(value, row[response.Fields[0]], comparison) == 0);
        }

        private static bool MatchesDate(object value, string condition)
        {
            if (value == null)
            {
                return false;
            }

            var date = Convert.ToDateTime(value, CultureInfo.InvariantCulture).Date;
            var today = DateTime.Today;
            return condition switch
            {
                "today" => date == today,
                "yesterday" => date == today.AddDays(-1),
                "tomorrow" => date == today.AddDays(1),
                "thisMonth" => date.Year == today.Year && date.Month == today.Month,
                "lastMonth" => date.Year == today.AddMonths(-1).Year && date.Month == today.AddMonths(-1).Month,
                "nextMonth" => date.Year == today.AddMonths(1).Year && date.Month == today.AddMonths(1).Month,
                "thisYear" => date.Year == today.Year,
                "lastYear" => date.Year == today.Year - 1,
                "nextYear" => date.Year == today.Year + 1,
                _ => throw new NotSupportedException($"Unsupported date condition: {condition}")
            };
        }
    }

    public class QueryExpression
    {
        public string Entity { get; set; }
        public string[] ReturnFields { get; set; }
        public QueryExpression[] FilteringOperands { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter<FilteringLogic>))]
        public FilteringLogic Operator { get; set; }
        public string FieldName { get; set; }
        public QueryCondition Condition { get; set; }
        public string ConditionName { get; set; }
        public JsonElement SearchVal { get; set; }
        public QueryExpression SearchTree { get; set; }
        public bool IgnoreCase { get; set; }
    }

    public class QueryCondition
    {
        public string Name { get; set; }
    }

    public class QueryResponse
    {
        public Dictionary<string, object>[] Items { get; set; }
        public string[] Fields { get; set; }
    }
}
