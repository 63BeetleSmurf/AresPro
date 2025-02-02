using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class WrestlerModel : IParticipant
{
    public string[] Names { get; set; } = [ string.Empty ];
    public string Name => Names[0];
    public string? Hometown { get; set; }
    public Affiliations Affiliation { get; set; }
    public string? Stable { get; set; }
    public string? RingIntro { get; set; }
    public string? EscortName { get; set; }
    public bool EscortInterferes { get; set; }
    public int? Push { get; set; } = 50;
    public List<string> TitleNames { get; set; } = [];
    public int Strength { get; set; } = 5;
    public int Speed { get; set; } = 5;
    public int Vitality { get; set; } = 5;
    public int Charisma { get; set; } = 5;
    public int Weight { get; set; } = 225;
    public string Height { get; set; } = "6'3\"";
    public int Wins { get; set; }
    public int Loses { get; set; }
    public Dictionary<string, MoveModel> Moves { get; set; } = [];

    public List<string> Teams { get; set; } = [];
}
