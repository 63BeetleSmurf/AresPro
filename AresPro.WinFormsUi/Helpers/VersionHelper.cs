using System.Reflection;

namespace AresPro.WinFormsUi.Helpers;

public static class VersionHelper
{
    private static readonly int? _releasePhase = 0; // 0 = Alpha, 1 = Beta, null = Release
    private static readonly int? _releasePhaseVersion = 0;

    public static Version? GetVersion()
    {
        return Assembly.GetExecutingAssembly().GetName().Version;
    }

    public static string GetVersionString()
    {
        Version version = GetVersion() ?? new Version();
        switch (_releasePhase)
        {
            case 0:
                return $"{version.Major}.{version.Minor}.{version.Revision} - Alpha {_releasePhaseVersion}";
            case 1:
                return $"{version.Major}.{version.Minor}.{version.Revision} - Beta {_releasePhaseVersion}";
            default:
                return $"{version.Major}.{version.Minor}.{version.Revision}";
        }
    }
}
