using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class TeamEditorFormPresenter
{
    private readonly TeamModel _teamModel;
    private readonly TeamEditorForm _teamEditorForm;

    public TeamEditorFormPresenter(TeamModel teamModel, TeamEditorForm teamEditorForm)
    {
        _teamModel = teamModel;
        _teamEditorForm = teamEditorForm;

        PopulateForm();
    }

    private void PopulateForm()
    {

    }

    private void UpdateModel()
    {

    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _teamModel.Name;
        newKey = originalKey;

        DialogResult result = _teamEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _teamModel.Name)
                newKey = _teamModel.Name;
        }

        return result;
    }
}
