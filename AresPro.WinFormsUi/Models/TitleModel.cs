using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class TitleModel
{
    public string Name { get; set; }
    public TitleTypes Type { get; set; }

    public string? Holder { get; set; }
}
