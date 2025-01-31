using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class RefereeEditorFormPresenter
{
    private readonly RefereeModel _refereeModel;
    private readonly RefereeEditorForm _refereeEditorForm;

    private readonly IEnumerable<string> _fedReferees;

    public RefereeEditorFormPresenter(RefereeModel refereeModel, RefereeEditorForm refereeEditorForm,
        IEnumerable<string> fedReferees)
    {
        _refereeModel = refereeModel;
        _refereeEditorForm = refereeEditorForm;

        _fedReferees = fedReferees;

        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _refereeEditorForm.ValidateForm += OnValidateForm;
    }

    private void PopulateForm()
    {
        _refereeEditorForm.NameTextBox.Text = _refereeModel.Name;
        _refereeEditorForm.CountSpeedTrackBar.Value = _refereeModel.CountSpeed;
        _refereeEditorForm.StringencyTrackBar.Value = _refereeModel.Stringency;
    }

    private void UpdateModel()
    {
        _refereeModel.Name = _refereeEditorForm.NameTextBox.Text;
        _refereeModel.CountSpeed = _refereeEditorForm.CountSpeedTrackBar.Value;
        _refereeModel.Stringency = _refereeEditorForm.StringencyTrackBar.Value;
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _refereeModel.Name;
        newKey = originalKey;

        DialogResult result = _refereeEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _refereeModel.Name)
                newKey = _refereeModel.Name;
        }

        return result;
    }

    private string? OnValidateForm()
    {
        if (_refereeEditorForm.NameTextBox.Text.Length == 0)
            return "The Referee Must be given a name";
        else if (_fedReferees.Contains(_refereeEditorForm.NameTextBox.Text))
            return "There is already a referee with this name in the roster";

        return null;
    }
}
