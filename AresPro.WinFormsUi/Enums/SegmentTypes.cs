using System.ComponentModel.DataAnnotations;

namespace AresPro.WinFormsUi.Enums;

public enum SegmentTypes
{
    [Display(Name = "Singles Match")]
    SinglesMatch = 0,
    [Display(Name = "3 way singles match")]
    ThreeWaySinglesMatch = 1,
    [Display(Name = "4 way singles match")]
    FourWaySinglesMatch = 2,

    [Display(Name = "Tag match")]
    TagMatch = 3,
    [Display(Name = "3 way tag match")]
    ThreeWayTagMatch = 4,
    [Display(Name = "4 way tag match")]
    FourWayTagMatch = 5,
    [Display(Name = "Tag elimination match")]
    EliminationTagMatch = 6,

    [Display(Name = "Battle Royal")]
    BattleRoyalMatch = 7,

    [Display(Name = "Custom Text Block")]
    TextBlock = 8,
    [Display(Name = "Commercial Break")]
    CommercialBreak = 9,
    [Display(Name = "Switch/Set Commentators/Referee/Announcer")]
    StaffChange = 10,

    [Display(Name = "Tournament")]
    TournamentMatch = 11,
}
