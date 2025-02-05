using System.ComponentModel;

using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Models.Common;
using AresPro.WinFormsUi.Views.Booking;

namespace AresPro.WinFormsUi.Presenters.Booking;

public class BookACardFormPresenter
{
    private readonly FederationModel _federationModel;
    private readonly BookACardForm _bookACardForm;

    private readonly BindingList<SelectionListItem> _bookedSegmentsList = [];
    private readonly Dictionary<string, object> _bookedSegments = [];

    public BookACardFormPresenter(FederationModel federationModel, BookACardForm bookACardForm)
    {
        _federationModel = federationModel;
        _bookACardForm = bookACardForm;

        _bookACardForm.InitializeForm(_bookedSegmentsList);
        ConnectHandlers();
    }

    private void ConnectHandlers()
    {
        _bookACardForm.AddSegment += OnAddSegment;
        _bookACardForm.MoveSegmentUp += OnMoveSegmentUp;
        _bookACardForm.MoveSegmentDown += OnMoveSegmentDown;
        _bookACardForm.RemoveSegment += OnRemoveSegment;
        _bookACardForm.RunCard += OnRunCard;
    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        return _bookACardForm.ShowDialog(owner);
    }

    private void OnAddSegment(object? sender, SegmentTypes segmentType)
    {
        switch (segmentType)
        {
            case SegmentTypes.SinglesMatch:
                AddSinglesMatchSegment();
                break;
            case SegmentTypes.ThreeWaySinglesMatch:
                AddThreeWaySinglesMatchSegment();
                break;
            case SegmentTypes.FourWaySinglesMatch:
                AddFourWaySinglesMatchSegment();
                break;
            case SegmentTypes.TagMatch:
                AddTagMatchSegment();
                break;
            case SegmentTypes.ThreeWayTagMatch:
                AddThreeWayTagMatchSegment();
                break;
            case SegmentTypes.FourWayTagMatch:
                AddFourWayTagMatchSegment();
                break;
            case SegmentTypes.EliminationTagMatch:
                AddEliminationTagMatchSegment();
                break;
            case SegmentTypes.BattleRoyalMatch:
                AddBattleRoyalMatchSegment();
                break;
            case SegmentTypes.TextBlock:
                AddTextBlockSegment();
                break;
            case SegmentTypes.CommercialBreak:
                AddCommercialBreakSegment();
                break;
            case SegmentTypes.StaffChange:
                AddStaffChangeSegment();
                break;
            case SegmentTypes.TournamentMatch:
                AddTournamentMatchSegment();
                break;

        }
    }

    private void AddSinglesMatchSegment()
    {

    }

    private void AddThreeWaySinglesMatchSegment()
    {

    }

    private void AddFourWaySinglesMatchSegment()
    {

    }

    private void AddTagMatchSegment()
    {

    }

    private void AddThreeWayTagMatchSegment()
    {

    }

    private void AddFourWayTagMatchSegment()
    {

    }

    private void AddEliminationTagMatchSegment()
    {

    }

    private void AddBattleRoyalMatchSegment()
    {

    }

    private void AddTextBlockSegment()
    {

    }

    private void AddCommercialBreakSegment()
    {

    }

    private void AddStaffChangeSegment()
    {

    }

    private void AddTournamentMatchSegment()
    {

    }

    private void OnMoveSegmentUp(object? sender, int index)
    {
        if (index <= 0)
            return;

        SelectionListItem segment = _bookedSegmentsList[index];
        _bookedSegmentsList.RemoveAt(index);
        _bookedSegmentsList.Insert(index - 1, segment);
    }

    private void OnMoveSegmentDown(object? sender, int index)
    {
        if (index < 0 || index >= _bookedSegmentsList.Count - 1)
            return;

        SelectionListItem segment = _bookedSegmentsList[index];
        _bookedSegmentsList.RemoveAt(index);
        _bookedSegmentsList.Insert(index + 1, segment);
    }

    private void OnRemoveSegment(object? sender, int index)
    {
        if (index == -1)
            return;

        _bookedSegments.Remove((string)_bookedSegmentsList[index].Value);
        _bookedSegmentsList.RemoveAt(index);
    }

    private void OnRunCard(object? sender, EventArgs e)
    {

    }
}
