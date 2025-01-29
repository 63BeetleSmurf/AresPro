namespace AresPro.WinFormsUi.Helpers;

public static class NameHelper
{
    public static string GetNewName(string baseName, IEnumerable<string> existingNames)
    {
        string name = string.Empty;

        for (int i = 1; i <= 1024; i++)
        {
            name = $"New {baseName} {i}";
            if (!existingNames.Contains(name))
                break;
        }

        return name;
    }
}
