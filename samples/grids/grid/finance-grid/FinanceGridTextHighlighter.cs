using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    /// <summary>
    /// The toolbar filter's matching rules, shared by the row filter and the highlight, so what
    /// lights up is exactly what kept the row on screen.
    /// </summary>
    public static class FinanceGridTextHighlighter
    {
        /// <summary>The query as it is compared: trimmed and lower-cased.</summary>
        public static string Normalize(string query)
        {
            return (query ?? string.Empty).Trim().ToLowerInvariant();
        }

        /// <summary>True when the normalized query is empty or occurs in the text.</summary>
        public static bool Matches(string text, string normalizedQuery)
        {
            return normalizedQuery.Length == 0
                || (text ?? string.Empty).ToLowerInvariant().Contains(normalizedQuery, StringComparison.Ordinal);
        }

        /// <summary>
        /// Splits text into alternating plain and matching runs, for the Asset cell's highlight: the
        /// entries at even indexes are plain, those at odd indexes matched the query, and the first
        /// and last entries are plain (empty when the text starts or ends with a match).
        /// Case-insensitive, and it walks the string instead of building a Regex, so a query such as
        /// "C++" or "(" matches literally.
        /// </summary>
        public static string[] SplitOnMatches(string text, string normalizedQuery)
        {
            text ??= string.Empty;
            if (normalizedQuery.Length == 0)
            {
                return new[] { text };
            }

            var runs = new List<string>();
            var haystack = text.ToLowerInvariant();
            var cursor = 0;
            var match = haystack.IndexOf(normalizedQuery, StringComparison.Ordinal);

            while (match != -1)
            {
                runs.Add(text.Substring(cursor, match - cursor));
                runs.Add(text.Substring(match, normalizedQuery.Length));
                cursor = match + normalizedQuery.Length;
                match = haystack.IndexOf(normalizedQuery, cursor, StringComparison.Ordinal);
            }

            runs.Add(text.Substring(cursor));
            return runs.ToArray();
        }
    }
}
