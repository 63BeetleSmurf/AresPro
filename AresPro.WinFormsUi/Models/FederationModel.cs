namespace AresPro.WinFormsUi.Models;

public class FederationModel
{
    public string Name { get; set; } = "None";
    public string Owver { get; set; } = "None";
    public string Website { get; set; } = "None";
    public bool IncludeCommentary { get; set; } = true;
    public bool MovesInBlockFormat { get; set; } = true;
    public bool ShowOnlyEndings { get; set; } = false;
    public bool IncludeMatchHeading { get; set; } = true;
    public int StatMax { get; set; } = 10;
    public string BackgroundColor { get; set; } = "white";
    public string FontColor { get; set; } = "black";
    public List<WrestlerModel> Wrestlers { get; set; } = [];
    public List<TeamModel> Teams { get; set; } = [];
    public List<TitleModel> Titles { get; set; } = [];
    public List<CommentatorModel> Commentators { get; set; } = [];
    public List<RefereeModel> Referees { get; set; } = [];
}
