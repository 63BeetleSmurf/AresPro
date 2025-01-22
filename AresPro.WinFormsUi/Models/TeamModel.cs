namespace AresPro.WinFormsUi.Models;

public class TeamModel
{
    public string Name { get; set; }
    public string? Finisher { get; set; }
    public string? Introduction { get; set; }
    public List<string> TitleNames { get; } = [];
    public int Wins { get; set; }
    public int Loses { get; set; }
    public string? EscortName { get; set; }
    public bool EscortInterferes { get; set; }
    public List<string> MemberNames { get; } = [];
}
