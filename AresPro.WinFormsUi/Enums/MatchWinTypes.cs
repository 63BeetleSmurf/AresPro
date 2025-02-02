using System.ComponentModel.DataAnnotations;

namespace AresPro.WinFormsUi.Enums;

public enum MatchWinTypes
{
    [Display(Name = "Pin")]
    Pinfall = 0,
    [Display(Name = "Submission")]
    Submission = 1,
    [Display(Name = "DQ")]
    Disqualification = 2,
    [Display(Name = "Countout")]
    CountOut = 3
}
