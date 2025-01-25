using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class WrestlerEditorFormPresenter
{
    private readonly WrestlerModel _wrestlerModel;
    private readonly WrestlerEditorForm _wrestlerEditorForm;

    public WrestlerEditorFormPresenter(WrestlerModel wrestlerModel, WrestlerEditorForm wrestlerEditorForm)
    {
        _wrestlerModel = wrestlerModel;
        _wrestlerEditorForm = wrestlerEditorForm;

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
        string originalKey = _wrestlerModel.Name;
        newKey = originalKey;

        DialogResult result = _wrestlerEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _wrestlerModel.Name)
                newKey = _wrestlerModel.Name;
        }

        return result;
    }
}
