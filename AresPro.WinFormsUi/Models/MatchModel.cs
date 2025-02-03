using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models.Gimmick;

namespace AresPro.WinFormsUi.Models;

public class MatchModel
{
    public string? PredeterminedWinner { get; set; }
    public List<IParticipant> Participants { get; } = [];
    public Dictionary<string, List<string>> Interferers { get; } = [];
    public GimmickModel Gimmick { get; set; } = GimmickHelper.GetStandardGimmick();
    public string? TitleName { get; set; }
    public string? WinLocation { get; set; }
    public MatchWinTypes? WinType { get; set; }
    public CommentatorModel RingAnnouncer { get; set; }
    public List<CommentatorModel> Commentators { get; set; }
    public RefereeModel Referee { get; set; }
}
