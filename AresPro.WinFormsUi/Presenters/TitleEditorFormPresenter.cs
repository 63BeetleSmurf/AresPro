using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class TitleEditorFormPresenter
{
    private readonly TitleModel _titleModel;
    private readonly TitleEditorForm _titleEditorForm;

    private readonly IEnumerable<string> _fedTitles;

    public TitleEditorFormPresenter(TitleModel titleModel, TitleEditorForm titleEditorForm,
        IEnumerable<string> fedTitles)
    {
        _titleModel = titleModel;
        _titleEditorForm = titleEditorForm;

        _fedTitles = fedTitles;

        ConnectHandlers();
        PopulateForm();
    }
    private void ConnectHandlers()
    {
        _titleEditorForm.ValidateForm += OnValidateForm;
    }

    private void PopulateForm()
    {
        _titleEditorForm.NameTextBox.Text = _titleModel.Name;
        if (_titleModel.Type == TitleTypes.Singles)
            _titleEditorForm.SinglesTitleRadioButton.Checked = true;
        else
            _titleEditorForm.TeamTitleRadioButton.Checked = true;
    }

    private void UpdateModel()
    {
        _titleModel.Name = _titleEditorForm.NameTextBox.Text;
        _titleModel.Type = _titleEditorForm.SinglesTitleRadioButton.Checked ? TitleTypes.Singles : TitleTypes.Team;
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _titleModel.Name;
        newKey = originalKey;

        DialogResult result = _titleEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _titleModel.Name)
                newKey = _titleModel.Name;
        }

        return result;
    }

    private string? OnValidateForm()
    {
        if (_titleEditorForm.NameTextBox.Text.Length == 0)
            return "The Title Must be given a name";
        else if (_fedTitles.Contains(_titleEditorForm.NameTextBox.Text))
            return "There is already a title with this name in the roster";

        return null;
    }
}
