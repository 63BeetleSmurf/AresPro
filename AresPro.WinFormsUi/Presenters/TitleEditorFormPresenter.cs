using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class TitleEditorFormPresenter
{
    private readonly TitleModel _titleModel;
    private readonly TitleEditorForm _titleEditorForm;

    public TitleEditorFormPresenter(TitleModel titleModel, TitleEditorForm titleEditorForm)
    {
        _titleModel = titleModel;
        _titleEditorForm = titleEditorForm;

        PopulateForm();
    }

    private void PopulateForm()
    {

    }

    private void UpdateModel()
    {

    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        DialogResult result = _titleEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
            UpdateModel();
        return result;
    }
}
