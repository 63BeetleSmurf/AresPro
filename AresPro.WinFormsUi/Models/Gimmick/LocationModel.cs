namespace AresPro.WinFormsUi.Models.Gimmick;

public class LocationModel
{
    public string Name { get; set; }
    public List<TransitionModel> Transitions { get; } = [];
    public string Floor { get; set; }
    public bool PinfallsAtLoc { get; set; }
    public bool SubmissionsAtLoc { get; set; }
    public bool AttackerWinsIfHere { get; set; }
    public bool CanTagHere { get; set; }
    public bool CountOutAtLoc { get; set; }
    public bool DQAtLoc { get; set; }
    public bool WeaponsAtLoc { get; set; }
    public bool CanFightHere { get; set; }
}
