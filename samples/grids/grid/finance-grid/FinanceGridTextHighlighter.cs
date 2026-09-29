using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    /// <summary>One run of the source text, flagged when the query matched it.</summary>
    public class FinanceGridTextSegment
    {
        public FinanceGridTextSegment(string text, bool hit)
        {
            Text = text;
            Hit = hit;
        }

        public string Text { get; }

        public bool Hit { get; }
    }

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
        /// Splits text into alternating plain and matching runs. Case-insensitive, and it walks the
        /// string instead of building a Regex, so a query such as "C++" or "(" matches literally.
        /// </summary>
        public static List<FinanceGridTextSegment> SplitOnMatches(string text, string query)
        {
            text ??= string.Empty;
            var segments = new List<FinanceGridTextSegment>();
            var needle = Normalize(query);
            if (needle.Length == 0)
            {
                segments.Add(new FinanceGridTextSegment(text, false));
                return segments;
            }

            var haystack = text.ToLowerInvariant();
            var cursor = 0;
            var match = haystack.IndexOf(needle, StringComparison.Ordinal);

            while (match != -1)
            {
                if (match > cursor)
                {
                    segments.Add(new FinanceGridTextSegment(text.Substring(cursor, match - cursor), false));
                }

                segments.Add(new FinanceGridTextSegment(text.Substring(match, needle.Length), true));
                cursor = match + needle.Length;
                match = haystack.IndexOf(needle, cursor, StringComparison.Ordinal);
            }

            if (cursor < text.Length)
            {
                segments.Add(new FinanceGridTextSegment(text.Substring(cursor), false));
            }

            return segments;
        }
    }
}
