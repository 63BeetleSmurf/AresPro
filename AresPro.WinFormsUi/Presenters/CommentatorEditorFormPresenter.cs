using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class CommentatorEditorFormPresenter
{
    private readonly CommentatorModel _commentatorModel;
    private readonly CommentatorEditorForm _commentatorEditorForm;

    private readonly string _originalName;

    private readonly IEnumerable<string> _fedCommentators;

    public CommentatorEditorFormPresenter(CommentatorModel commentatorModel, CommentatorEditorForm commentatorEditorForm,
        IEnumerable<string> fedCommentators)
    {
        _commentatorModel = commentatorModel;
        _commentatorEditorForm = commentatorEditorForm;

        _originalName = _commentatorModel.Name;

        _fedCommentators = fedCommentators;

        _commentatorEditorForm.InitializeForm();
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _commentatorEditorForm.ValidateForm += OnValidateForm;

        _commentatorEditorForm.CommentaryFileSelected += OnCommentaryFileSelected;
    }

    private void PopulateForm()
    {
        _commentatorEditorForm.NameTextBox.Text = _commentatorModel.Name;
        _commentatorEditorForm.FileTextBox.Text = _commentatorModel.FileName;
        _commentatorEditorForm.AffiliationComboBox.SelectedValue = _commentatorModel.Affiliation;
    }

    private void UpdateModel()
    {
        _commentatorModel.Name = _commentatorEditorForm.NameTextBox.Text;
        _commentatorModel.FileName = _commentatorEditorForm.FileTextBox.Text;
        _commentatorModel.Affiliation = (Affiliations)(_commentatorEditorForm.AffiliationComboBox.SelectedValue ?? 0);
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _commentatorModel.Name;
        newKey = originalKey;

        DialogResult result = _commentatorEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _commentatorModel.Name)
                newKey = _commentatorModel.Name;
        }

        return result;
    }

    private string? OnValidateForm()
    {
        if (_commentatorEditorForm.NameTextBox.Text.Length == 0)
            return "The Commentator Must be given a name";
        else if (_originalName != _commentatorModel.Name && _fedCommentators.Contains(_commentatorEditorForm.NameTextBox.Text))
            return "There is already a commentator with this name in the roster";

        return null;
    }

    public void OnCommentaryFileSelected(object? sender, string fileName)
    {
        _commentatorEditorForm.FileTextBox.Text = Path.GetFileName(fileName);
    }
}
