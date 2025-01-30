using System.Text.RegularExpressions;

namespace AresPro.WinFormsUi.Helpers;

public static partial class StringHelper
{
    [GeneratedRegex(@"#(\w+)#")]
    private static partial Regex PlaceholderRegex();

    public static string ReplacePlaceholders(string text, Dictionary<string, string?> placeholders)
    {
        return PlaceholderRegex().Replace(text, match =>
        {
            string key = match.Groups[0].Value;
            return placeholders.TryGetValue(key, out string? value) ? value ?? string.Empty : match.Value;
        });
    }
}
