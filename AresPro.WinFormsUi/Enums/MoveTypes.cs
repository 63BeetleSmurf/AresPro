using System.ComponentModel.DataAnnotations;

namespace AresPro.WinFormsUi.Enums;

public enum MoveTypes
{
    [Display(Name = "Match Prepare")]
    MatchPrepare = 0,
    [Display(Name = "Without Advantage")]
    WithoutAdvantage = 1,
    [Display(Name = "With Advantage")]
    WithAdvantage = 2,
    [Display(Name = "Cover (Pin)")]
    Cover = 3,
    [Display(Name = "Knock Out Finisher")]
    KnockoutFinisher = 4,
    [Display(Name = "Submission Finisher")]
    SubmissionFinisher = 5
}
