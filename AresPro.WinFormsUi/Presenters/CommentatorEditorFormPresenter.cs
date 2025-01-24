using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class CommentatorEditorFormPresenter
{
    private readonly CommentatorModel _commentatorModel;
    private readonly CommentatorEditorForm _commentatorEditorForm;

    public CommentatorEditorFormPresenter(CommentatorModel commentatorModel, CommentatorEditorForm commentatorEditorForm)
    {
        _commentatorModel = commentatorModel;
        _commentatorEditorForm = commentatorEditorForm;

        _commentatorEditorForm.InitializeForm();
        PopulateForm();
    }

    private void PopulateForm()
    {
        _commentatorEditorForm.NameTextBox.Text = _commentatorModel.Name;
        _commentatorEditorForm.FileTextBox.Text = _commentatorModel.FileName;
        _commentatorEditorForm.AffliliationComboBox.SelectedValue = _commentatorModel.Affiliation;
    }

    private void UpdateModel()
    {
        _commentatorModel.Name = _commentatorEditorForm.NameTextBox.Text;
        _commentatorModel.FileName = _commentatorEditorForm.FileTextBox.Text;
        _commentatorModel.Affiliation = (Affiliations)(_commentatorEditorForm.AffliliationComboBox.SelectedValue ?? 0);
    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        DialogResult result = _commentatorEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
            UpdateModel();
        return result;
    }
}
