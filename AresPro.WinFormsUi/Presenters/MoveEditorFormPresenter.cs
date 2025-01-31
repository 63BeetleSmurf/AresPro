using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class MoveEditorFormPresenter
{
    private readonly MoveModel _MoveModel;
    private readonly MoveEditorForm _MoveEditorForm;

    private readonly IEnumerable<string> _existingMoves;

    public MoveEditorFormPresenter(MoveModel MoveModel, MoveEditorForm MoveEditorForm,
        IEnumerable<string> existingMoves)
    {
        _MoveModel = MoveModel;
        _MoveEditorForm = MoveEditorForm;

        _existingMoves = existingMoves;

        _MoveEditorForm.InitializeForm();
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _MoveEditorForm.ValidateForm += OnValidateForm;
    }

    private void PopulateForm()
    {
        _MoveEditorForm.NameTextBox.Text = _MoveModel.Name;
        _MoveEditorForm.DamageProgressBar.Value = _MoveModel.Damage;
        _MoveEditorForm.TypeComboBox.SelectedValue = _MoveModel.Type;
        _MoveEditorForm.LiftCheckBox.Checked = _MoveModel.IsLift;
        _MoveEditorForm.IllegalCheckBox.Checked = _MoveModel.IsIllegal;
        _MoveEditorForm.HighRiskCheckBox.Checked = _MoveModel.IsHighRisk;
        _MoveEditorForm.Text1TextBox.Text = _MoveModel.Texts[0];
        _MoveEditorForm.Text2TextBox.Text = _MoveModel.Texts[1];
        _MoveEditorForm.Text3TextBox.Text = _MoveModel.Texts[2];
        _MoveEditorForm.AttStandingBeforeCheckBox.Checked = _MoveModel.AttStandingBefore;
        _MoveEditorForm.AttStandingAfterCheckBox.Checked = _MoveModel.AttStandingAfter;
        _MoveEditorForm.RecStandingBeforeCheckBox.Checked = _MoveModel.RecStandingBefore;
        _MoveEditorForm.RecStandingAfterCheckBox.Checked = _MoveModel.RecStandingAfter;
    }

    private void UpdateModel()
    {
        _MoveModel.Name = _MoveEditorForm.NameTextBox.Text;
        _MoveModel.Damage = _MoveEditorForm.DamageProgressBar.Value;
        _MoveModel.Type = (MoveTypes)(_MoveEditorForm.TypeComboBox.SelectedValue ?? 0);
        _MoveModel.IsLift = _MoveEditorForm.LiftCheckBox.Checked;
        _MoveModel.IsIllegal = _MoveEditorForm.IllegalCheckBox.Checked;
        _MoveModel.IsHighRisk = _MoveEditorForm.HighRiskCheckBox.Checked;
        _MoveModel.Texts[0] = _MoveEditorForm.Text1TextBox.Text;
        _MoveModel.Texts[1] = _MoveEditorForm.Text2TextBox.Text;
        _MoveModel.Texts[2] = _MoveEditorForm.Text3TextBox.Text;
        _MoveModel.AttStandingBefore = _MoveEditorForm.AttStandingBeforeCheckBox.Checked;
        _MoveModel.AttStandingAfter = _MoveEditorForm.AttStandingAfterCheckBox.Checked;
        _MoveModel.RecStandingBefore = _MoveEditorForm.RecStandingBeforeCheckBox.Checked;
        _MoveModel.RecStandingAfter = _MoveEditorForm.RecStandingAfterCheckBox.Checked;
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _MoveModel.Name;
        newKey = originalKey;

        DialogResult result = _MoveEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _MoveModel.Name)
                newKey = _MoveModel.Name;
        }

        return result;
    }

    private string? OnValidateForm()
    {
        if (_MoveEditorForm.NameTextBox.Text.Length == 0)
            return "Each move must be given a unique name";
        else if (_existingMoves.Contains(_MoveEditorForm.NameTextBox.Text))
            return "Each move must be given a unique name";
        else if (_MoveEditorForm.Text1TextBox.Text.Length == 0 && _MoveEditorForm.Text2TextBox.Text.Length == 0 && _MoveEditorForm.Text3TextBox.Text.Length == 0)
            return "Each move must contain at least one move text.";

        return null;
    }
}
