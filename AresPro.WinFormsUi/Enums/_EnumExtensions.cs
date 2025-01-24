using System.ComponentModel.DataAnnotations;

namespace AresPro.WinFormsUi.Enums;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attribute = fieldInfo?.GetCustomAttributes(typeof(DisplayAttribute), false)
                                  .FirstOrDefault() as DisplayAttribute;

        return attribute?.Name ?? value.ToString();
    }
}
