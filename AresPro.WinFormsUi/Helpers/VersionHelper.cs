using System.Reflection;

namespace AresPro.WinFormsUi.Helpers;

public static class VersionHelper
{
    public static Version? GetVersion()
    {
        return Assembly.GetExecutingAssembly().GetName().Version;
    }

    public static string GetVersionString()
    {
        Version version = GetVersion() ?? new Version();
        return $"{version.Major}.{version.Minor}.{version.Revision}";
    }
}
