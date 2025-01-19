using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class WrestlerModel
{
    public string[] Names { get; set; }
    public string? Hometown { get; set; }
    public Affiliations Affiliation { get; set; }
    public string? Stable { get; set; }
    public string? RingIntro { get; set; }
    public string? EscortName { get; set; }
    public bool EscortInterferes { get; set; }
    public int? Push { get; set; }
    public List<string> TitleNames { get; set; } = [];
    public int Strength { get; set; }
    public int Speed { get; set; }
    public int Vitality { get; set; }
    public int Charisma { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public int Wins { get; set; }
    public int Loses { get; set; }
    public List<MoveModel> Moves { get; set; } = [];

    public List<string> Teams { get; set; } = [];
}
