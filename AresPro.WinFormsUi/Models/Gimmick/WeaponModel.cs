namespace AresPro.WinFormsUi.Models.Gimmick;

public class WeaponModel
{
    public string Name { get; set; } = string.Empty;
    public bool SwingAtOpponent { get; set; }
    public bool UsedToChoke { get; set; }
    public bool UsedAsAWhip { get; set; }
    public bool SlammedOn { get; set; }
    public bool ThrownInto { get; set; }
    public bool ThrownAtOpponent { get; set; }
    public bool UsedToCutOpponent { get; set; }
    public bool CausesBleeding { get; set; }
    public bool ShootsAtOpponent { get; set; }
    public bool WillBreak { get; set; }
    public int AvailableAtLocation { get; set; } // 0 will be all locations
}
