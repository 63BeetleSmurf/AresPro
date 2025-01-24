using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views;

namespace AresPro.WinFormsUi.Presenters;

public class FedOptionsFormPresenter
{
    private readonly FederationModel _federationModel;
    private readonly FedOptionsForm _fedOptionsForm;

    public FedOptionsFormPresenter(FederationModel model, FedOptionsForm form)
    {
        _federationModel = model;
        _fedOptionsForm = form;

        PopulateForm();
    }

    private void PopulateForm()
    {
        _fedOptionsForm.NameTextBox.Text = _federationModel.Name;
        _fedOptionsForm.OwnerTextBox.Text = _federationModel.Owner;
        _fedOptionsForm.WebsiteTextBox.Text = _federationModel.Website;
        
        _fedOptionsForm.IncludeCommentaryCheckBox.Checked = _federationModel.IncludeCommentary;
        _fedOptionsForm.ShowOnlyEndingsCheckBox.Checked = _federationModel.ShowOnlyEndings;
        _fedOptionsForm.MovesInBlockFormatCheckBox.Checked = _federationModel.MovesInBlockFormat;
        _fedOptionsForm.IncludeMatchHeadingCheckBox.Checked = _federationModel.IncludeMatchHeading;
        
        _fedOptionsForm.StatMaxTextBox.Text = _federationModel.StatMax.ToString();
        _fedOptionsForm.BackgroundColorTextBox.Text = _federationModel.BackgroundColor;
        _fedOptionsForm.FontColorTextBox.Text = _federationModel.FontColor;
    }

    private void UpdateModel()
    {
        _federationModel.Name = _fedOptionsForm.NameTextBox.Text;
        _federationModel.Owner = _fedOptionsForm.OwnerTextBox.Text;
        _federationModel.Website = _fedOptionsForm.WebsiteTextBox.Text;

        _federationModel.IncludeCommentary = _fedOptionsForm.IncludeCommentaryCheckBox.Checked;
        _federationModel.ShowOnlyEndings = _fedOptionsForm.ShowOnlyEndingsCheckBox.Checked;
        _federationModel.MovesInBlockFormat = _fedOptionsForm.MovesInBlockFormatCheckBox.Checked;
        _federationModel.IncludeMatchHeading = _fedOptionsForm.IncludeMatchHeadingCheckBox.Checked;

        _federationModel.StatMax = int.Parse(_fedOptionsForm.StatMaxTextBox.Text);
        _federationModel.BackgroundColor = _fedOptionsForm.BackgroundColorTextBox.Text;
        _federationModel.FontColor = _fedOptionsForm.FontColorTextBox.Text;
    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        DialogResult result = _fedOptionsForm.ShowDialog(owner);
        if (result == DialogResult.OK)
            UpdateModel();
        return result;
    }
}
