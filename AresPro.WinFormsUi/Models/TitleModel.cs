using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Models;

public class TitleModel
{
    public string Name { get; set; } = string.Empty;
    public TitleTypes Type { get; set; } = TitleTypes.Singles;

    public string? Holder { get; set; }
}
