using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models.Gimmick;

namespace AresPro.WinFormsUi.Helpers;

public static class GimmickHelper
{
    public static GimmickModel GetStandardGimmick()
    {
        try
        {
            using StreamReader reader = new(
                Path.Combine(DirectoryHelper.GimmicksPath, "standard.z3g")
            );
            return LoadZeusFileHelper.LoadGimmick(reader);
        }
        catch
        {

        }

        return new GimmickModel(); // To do, should fail more gracefully
    }

    public static Dictionary<string, List<MatchWinTypes>> GetLocationWinTypes(GimmickModel gimmick)
    {
        Dictionary<string, List<MatchWinTypes>> locationWinTypes = [];

        foreach (LocationModel location in gimmick.Locations.Values)
        {
            List<MatchWinTypes> winTypes = [];

            if (location.PinfallsAtLoc)
                winTypes.Add(MatchWinTypes.Pinfall);
            if (location.SubmissionsAtLoc)
                winTypes.Add(MatchWinTypes.Submission);
            if (location.DQAtLoc)
                winTypes.Add(MatchWinTypes.Disqualification);
            if (location.CountOutAtLoc)
                winTypes.Add(MatchWinTypes.CountOut);

            if (winTypes.Count > 0)
                locationWinTypes.Add(location.Name, winTypes);
        }

        return locationWinTypes;
    }
}
