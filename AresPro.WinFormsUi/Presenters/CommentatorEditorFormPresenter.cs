﻿using AresPro.WinFormsUi.Enums;
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
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _commentatorEditorForm.CommentaryFileSelected += OnCommentaryFileSelected;
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

    public void OnCommentaryFileSelected(object? sender, string fileName)
    {
        _commentatorEditorForm.FileTextBox.Text = Path.GetFileName(fileName);
    }
}
