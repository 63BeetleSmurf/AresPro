using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class CommentatorModel()
{
    public string Name { get; set; } = string.Empty;
    public string FileName { get; set; } = "default.zcm";
    public Affiliations Affiliation { get; set; }
}
