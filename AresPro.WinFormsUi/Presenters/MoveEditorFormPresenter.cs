using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class MoveEditorFormPresenter
{
    private readonly MoveModel _moveModel;
    private readonly MoveEditorForm _moveEditorForm;

    private readonly string _originalName;

    private readonly IEnumerable<string> _existingMoves;

    public MoveEditorFormPresenter(MoveModel MoveModel, MoveEditorForm MoveEditorForm,
        IEnumerable<string> existingMoves)
    {
        _moveModel = MoveModel;
        _moveEditorForm = MoveEditorForm;

        _originalName = _moveModel.Name;

        _existingMoves = existingMoves;

        _moveEditorForm.InitializeForm();
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _moveEditorForm.ValidateForm += OnValidateForm;
    }

    private void PopulateForm()
    {
        _moveEditorForm.NameTextBox.Text = _moveModel.Name;
        _moveEditorForm.DamageProgressBar.Value = _moveModel.Damage;
        _moveEditorForm.TypeComboBox.SelectedValue = _moveModel.Type;
        _moveEditorForm.LiftCheckBox.Checked = _moveModel.IsLift;
        _moveEditorForm.IllegalCheckBox.Checked = _moveModel.IsIllegal;
        _moveEditorForm.HighRiskCheckBox.Checked = _moveModel.IsHighRisk;
        _moveEditorForm.Text1TextBox.Text = _moveModel.Texts[0];
        _moveEditorForm.Text2TextBox.Text = _moveModel.Texts[1];
        _moveEditorForm.Text3TextBox.Text = _moveModel.Texts[2];
        _moveEditorForm.AttStandingBeforeCheckBox.Checked = _moveModel.AttStandingBefore;
        _moveEditorForm.AttStandingAfterCheckBox.Checked = _moveModel.AttStandingAfter;
        _moveEditorForm.RecStandingBeforeCheckBox.Checked = _moveModel.RecStandingBefore;
        _moveEditorForm.RecStandingAfterCheckBox.Checked = _moveModel.RecStandingAfter;
    }

    private void UpdateModel()
    {
        _moveModel.Name = _moveEditorForm.NameTextBox.Text;
        _moveModel.Damage = _moveEditorForm.DamageProgressBar.Value;
        _moveModel.Type = (MoveTypes)(_moveEditorForm.TypeComboBox.SelectedValue ?? 0);
        _moveModel.IsLift = _moveEditorForm.LiftCheckBox.Checked;
        _moveModel.IsIllegal = _moveEditorForm.IllegalCheckBox.Checked;
        _moveModel.IsHighRisk = _moveEditorForm.HighRiskCheckBox.Checked;
        _moveModel.Texts[0] = _moveEditorForm.Text1TextBox.Text;
        _moveModel.Texts[1] = _moveEditorForm.Text2TextBox.Text;
        _moveModel.Texts[2] = _moveEditorForm.Text3TextBox.Text;
        _moveModel.AttStandingBefore = _moveEditorForm.AttStandingBeforeCheckBox.Checked;
        _moveModel.AttStandingAfter = _moveEditorForm.AttStandingAfterCheckBox.Checked;
        _moveModel.RecStandingBefore = _moveEditorForm.RecStandingBeforeCheckBox.Checked;
        _moveModel.RecStandingAfter = _moveEditorForm.RecStandingAfterCheckBox.Checked;
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _moveModel.Name;
        newKey = originalKey;

        DialogResult result = _moveEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _moveModel.Name)
                newKey = _moveModel.Name;
        }

        return result;
    }

    private string? OnValidateForm()
    {
        if (_moveEditorForm.NameTextBox.Text.Length == 0)
            return "Each move must be given a unique name";
        else if (_originalName != _moveModel.Name && _existingMoves.Contains(_moveEditorForm.NameTextBox.Text))
            return "Each move must be given a unique name";
        else if (_moveEditorForm.Text1TextBox.Text.Length == 0 && _moveEditorForm.Text2TextBox.Text.Length == 0 && _moveEditorForm.Text3TextBox.Text.Length == 0)
            return "Each move must contain at least one move text.";

        return null;
    }
}
