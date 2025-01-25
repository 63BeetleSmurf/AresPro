namespace AresPro.WinFormsUi.Models.Common;

public class SelectionListItem(string display, object value)
{
    public string Display { get; set; } = display;
    public object Value { get; set; } = value;
}
