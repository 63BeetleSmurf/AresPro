using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models.Common;

namespace AresPro.WinFormsUi.Views.Editors;

public partial class MoveEditorForm : Form
{
    private static readonly SelectionListItem[] _moveTypesList = [
        new SelectionListItem(MoveTypes.MatchPrepare.GetDisplayName(), MoveTypes.MatchPrepare),
        new SelectionListItem(MoveTypes.WithoutAdvantage.GetDisplayName(), MoveTypes.WithoutAdvantage),
        new SelectionListItem(MoveTypes.WithAdvantage.GetDisplayName(), MoveTypes.WithoutAdvantage),
        new SelectionListItem(MoveTypes.Cover.GetDisplayName(), MoveTypes.Cover),
        new SelectionListItem(MoveTypes.KnockoutFinisher.GetDisplayName(), MoveTypes.KnockoutFinisher),
        new SelectionListItem(MoveTypes.SubmissionFinisher.GetDisplayName(), MoveTypes.SubmissionFinisher)
    ];

    public MoveEditorForm()
    {
        InitializeComponent();
    }

    public void InitializeForm()
    {
        TypeComboBox.DataSource = _moveTypesList;
        TypeComboBox.DisplayMember = "Display";
        TypeComboBox.ValueMember = "Value";
    }

    private void DamageDecreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Decrease(DamageProgressBar);
    }

    private void DamageIncreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Increase(DamageProgressBar);
    }
}
