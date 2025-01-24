using System.ComponentModel.DataAnnotations;

namespace AresPro.WinFormsUi.Enums;

public enum Affiliations
{
    [Display(Name ="Face")]
    Face = 0,
    [Display(Name = "Neutral")]
    Neutral = 1,
    [Display(Name = "Heel")]
    Heel = 2
}
