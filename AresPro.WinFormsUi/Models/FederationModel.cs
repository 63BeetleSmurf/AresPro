namespace AresPro.WinFormsUi.Models;

public class FederationModel
{
    public string Name { get; set; } = "None";
    public string Owner { get; set; } = "None";
    public string Website { get; set; } = "None";
    public bool IncludeCommentary { get; set; } = true;
    public bool MovesInBlockFormat { get; set; } = true;
    public bool ShowOnlyEndings { get; set; } = false;
    public bool IncludeMatchHeading { get; set; } = true;
    public int StatMax { get; set; } = 10;
    public string BackgroundColor { get; set; } = "white";
    public string FontColor { get; set; } = "black";
    public Dictionary<string, WrestlerModel> Wrestlers { get; set; } = [];
    public Dictionary<string, TeamModel> Teams { get; set; } = [];
    public Dictionary<string, TitleModel> Titles { get; set; } = [];
    public Dictionary<string, CommentatorModel> Commentators { get; set; } = [];
    public Dictionary<string, RefereeModel> Referees { get; set; } = [];
}
