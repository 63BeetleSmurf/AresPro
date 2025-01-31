using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class MoveModel
{
    public string Name { get; set; } = string.Empty;
    public int Damage { get; set; } = 4;
    public MoveTypes Type { get; set; } = MoveTypes.MatchPrepare;
    public bool IsLift { get; set; }
    public bool IsIllegal { get; set; }
    public bool IsHighRisk { get; set; }
    public string[] Texts { get; set; } = ["", "", ""];
    public bool AttStandingBefore { get; set; }
    public bool AttStandingAfter { get; set; }
    public bool RecStandingBefore { get; set; }
    public bool RecStandingAfter { get; set; }
}
