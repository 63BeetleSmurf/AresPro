using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class MoveModel
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public MoveTypes Type { get; set; }
    public bool IsLift { get; set; }
    public bool IsIllegal { get; set; }
    public bool IsHighRisk { get; set; }
    public string[] Texts { get; set; } = [];
    public bool AttStandingBefore { get; set; }
    public bool AttStandingAfter { get; set; }
    public bool RecStandingBefore { get; set; }
    public bool RecStandingAfter { get; set; }
}
