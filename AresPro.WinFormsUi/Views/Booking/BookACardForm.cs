using System.ComponentModel;
using System.Reflection;

using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models.Common;

namespace AresPro.WinFormsUi.Views.Booking;

public partial class BookACardForm : Form
{
    private static readonly SelectionListItem[] _segmentTypesList = [
        new SelectionListItem(SegmentTypes.SinglesMatch.GetDisplayName(), SegmentTypes.SinglesMatch),
        new SelectionListItem(SegmentTypes.ThreeWaySinglesMatch.GetDisplayName(), SegmentTypes.ThreeWaySinglesMatch),
        new SelectionListItem(SegmentTypes.FourWaySinglesMatch.GetDisplayName(), SegmentTypes.FourWaySinglesMatch),
        new SelectionListItem(SegmentTypes.TagMatch.GetDisplayName(), SegmentTypes.TagMatch),
        new SelectionListItem(SegmentTypes.ThreeWayTagMatch.GetDisplayName(), SegmentTypes.ThreeWayTagMatch),
        new SelectionListItem(SegmentTypes.FourWayTagMatch.GetDisplayName(), SegmentTypes.FourWayTagMatch),
        new SelectionListItem(SegmentTypes.EliminationTagMatch.GetDisplayName(), SegmentTypes.EliminationTagMatch),
        new SelectionListItem(SegmentTypes.BattleRoyalMatch.GetDisplayName(), SegmentTypes.BattleRoyalMatch),
        new SelectionListItem(SegmentTypes.TextBlock.GetDisplayName(), SegmentTypes.TextBlock),
        new SelectionListItem(SegmentTypes.CommercialBreak.GetDisplayName(), SegmentTypes.CommercialBreak),
        new SelectionListItem(SegmentTypes.StaffChange.GetDisplayName(), SegmentTypes.StaffChange),
        new SelectionListItem(SegmentTypes.TournamentMatch.GetDisplayName(), SegmentTypes.TournamentMatch)
    ];

    public EventHandler<SegmentTypes>? AddSegment;
    public EventHandler<int>? MoveSegmentUp;
    public EventHandler<int>? MoveSegmentDown;
    public EventHandler<int>? RemoveSegment;
    public EventHandler? RunCard;

    public BookACardForm()
    {
        InitializeComponent();
    }

    public void InitializeForm(BindingList<SelectionListItem> bookedSegmentsDataSource)
    {
        AvailableSegmentsListBox.DataSource = _segmentTypesList;
        AvailableSegmentsListBox.DisplayMember = "Display";
        AvailableSegmentsListBox.ValueMember = "Value";

        BookedSegmentsListBox.DataSource = bookedSegmentsDataSource;
        BookedSegmentsListBox.DisplayMember = "Display";
        BookedSegmentsListBox.ValueMember = "Value";
    }

    private void AvailableSegmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        AddButton_Click(sender, e);
    }

    private void BookedSegmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (BookedSegmentsListBox.SelectedItem == null)
            return;

        PropertyInfo? property = BookedSegmentsListBox.SelectedItem.GetType().GetProperty(BookedSegmentsListBox.DisplayMember);
        if (property != null)
            SelectedSegmentTextBox.Text = property.GetValue(BookedSegmentsListBox.SelectedItem)?.ToString() ?? string.Empty;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (AvailableSegmentsListBox.SelectedValue == null)
            return;

        AddSegment?.Invoke(this, (SegmentTypes)AvailableSegmentsListBox.SelectedValue);
    }

    private void MoveUpButton_Click(object sender, EventArgs e)
    {
        MoveSegmentUp?.Invoke(this, BookedSegmentsListBox.SelectedIndex);
    }

    private void MoveDownButton_Click(object sender, EventArgs e)
    {
        MoveSegmentDown?.Invoke(this, BookedSegmentsListBox.SelectedIndex);
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        RemoveSegment?.Invoke(this, BookedSegmentsListBox.SelectedIndex);
    }

    private void RunCardButton_Click(object sender, EventArgs e)
    {
        RunCard?.Invoke(this, EventArgs.Empty);
    }
}
