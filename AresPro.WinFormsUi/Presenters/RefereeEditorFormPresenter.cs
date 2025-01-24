using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class RefereeEditorFormPresenter
{
    private readonly RefereeModel _refereeModel;
    private readonly RefereeEditorForm _refereeEditorForm;

    public RefereeEditorFormPresenter(RefereeModel refereeModel, RefereeEditorForm refereeEditorForm)
    {
        _refereeModel = refereeModel;
        _refereeEditorForm = refereeEditorForm;

        PopulateForm();
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

    public DialogResult ShowDialog(IWin32Window owner)
    {
        DialogResult result = _refereeEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
            UpdateModel();
        return result;
    }
}
