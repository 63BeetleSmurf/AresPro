namespace AresPro.WinFormsUi.Models;

public class TeamModel
{
    public string Name { get; set; }
    public string? Finisher { get; set; }
    public string? Ringintro { get; set; }
    public List<string> Titles { get; } = [];
    public int Wins { get; set; }
    public int Loses { get; set; }
    public string? Escort { get; set; }
    public bool EscortInterferes { get; set; }
    public List<WrestlerModel> Members { get; } = [];
}
