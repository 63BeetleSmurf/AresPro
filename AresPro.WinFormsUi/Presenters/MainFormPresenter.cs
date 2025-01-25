using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class MainFormPresenter
{
    private FederationModel _federationModel;
    private readonly MainForm _mainForm;

    public MainFormPresenter(FederationModel federationModel, MainForm mainForm)
    {
        _federationModel = federationModel;
        _mainForm = mainForm;

        new SplashForm().Show(_mainForm);

        _mainForm.InitializeForm();
        ConnectHandlers();
        PopulateTreeView();
        _mainForm.Show();
    }

    private void ConnectHandlers()
    {
        _mainForm.NewFederation += OnNewFederation;
        _mainForm.OpenFederation += OnOpenFederation;
        _mainForm.SaveFederation += OnSaveFederation;
        _mainForm.CloseApplication += OnCloseApplication;

        _mainForm.EditCommentaryFile += OnEditCommentaryFile;
        _mainForm.EditMovesFile += OnEditMovesFile;
        _mainForm.EditGimmickFile += OnEditGimmickFile;
        _mainForm.EditCommercials += OnEditCommercials;
        _mainForm.ImportFile += OnImportFile;

        _mainForm.EditFederationOptions += OnEditFederationOptions;
        _mainForm.EditWrestler += OnEditWrestler;
        _mainForm.EditTeam += OnEditTeam;
        _mainForm.EditTitle += OnEditTitle;
        _mainForm.EditCommentator += OnEditCommentator;
        _mainForm.EditReferee += OnEditReferee;

        _mainForm.DeleteWrestler += OnDeleteWrestler;
        _mainForm.DeleteTeam += OnDeleteTeam;
        _mainForm.DeleteTitle += OnDeleteTitle;
        _mainForm.DeleteCommentator += OnDeleteCommentator;
        _mainForm.DeleteReferee += OnDeleteReferee;
    }

    private void PopulateTreeView()
    {
        PopulateTreeNodes(_mainForm.WrestlersTreeNode, _federationModel.Wrestlers.Keys, MainForm.TreeViewWrestlerImageKey);
        PopulateTreeNodes(_mainForm.TeamsTreeNode, _federationModel.Teams.Keys, MainForm.TreeViewTeamImageKey);
        PopulateTreeNodes(_mainForm.TitlesTreeNode, _federationModel.Titles.Keys, MainForm.TreeViewTitleImageKey);
        PopulateTreeNodes(_mainForm.CommentatorsTreeNode, _federationModel.Commentators.Keys, MainForm.TreeViewCommentatorImageKey);
        PopulateTreeNodes(_mainForm.RefereesTreeNode, _federationModel.Referees.Keys, MainForm.TreeViewRefereeImageKey);
    }

    private static void PopulateTreeNodes(TreeNode rootNode, IEnumerable<string> nodeNames, string imageKey)
    {
        rootNode.Nodes.Clear();
        foreach (string name in nodeNames)
            AddTreeNode(rootNode, name, imageKey);
    }

    private static void AddTreeNode(TreeNode rootNode, string nodeName, string imageKey)
    {
        rootNode.Nodes.Add(
            new TreeNode(nodeName)
            {
                ImageKey = imageKey,
                Name = nodeName,
                SelectedImageKey = imageKey
            }
        );
    }

    private static void UpdateTreeNode(TreeNode rootNode, string oldKey, string newKey)
    {
        TreeNode treeNode = rootNode.Nodes[oldKey]
            ?? throw new KeyNotFoundException();
        treeNode.Name = newKey;
        treeNode.Text = newKey;
    }

    private void OnNewFederation(object? sender, EventArgs e)
    {
        _federationModel = new();
        PopulateTreeView();
        _mainForm.FederationFilename = null;
        _mainForm.IsSaved = true;
    }

    private void OnOpenFederation(object? sender, string fileName)
    {
        try
        {
            using StreamReader reader = new(fileName);
            _federationModel = LoadZeusFileHelper.LoadFederation(reader);

            PopulateTreeView();
            _mainForm.FederationFilename = null;
            _mainForm.IsSaved = true;
        }
        catch
        {
            
        }
    }

    private void OnSaveFederation(object? sender, string fileName)
    {
        try
        {
            using StreamWriter writer = new(fileName);
            SaveZeusFileHelper.SaveFederation(_federationModel, writer);

            _mainForm.IsSaved = true;
        }
        catch
        {

        }
    }

    private void OnCloseApplication(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    private void OnEditCommentaryFile(object? sender, string fileName)
    {

    }

    private void OnEditMovesFile(object? sender, string fileName)
    {

    }

    private void OnEditGimmickFile(object? sender, string fileName)
    {

    }

    private void OnEditCommercials(object? sender, EventArgs e)
    {

    }

    private void OnImportFile(object? sender, string fileName)
    {
        try
        {
            using StreamReader reader = new(fileName);
            WrestlerModel wrestlerModel = LoadZeusFileHelper.LoadWrestler(reader);

            _federationModel.Wrestlers.Add(wrestlerModel.Name, wrestlerModel);
            _mainForm.WrestlersTreeNode.Nodes.Add(
                new TreeNode(wrestlerModel.Name)
                {
                    Name = wrestlerModel.Name,
                    ImageKey = MainForm.TreeViewWrestlerImageKey
                }
            );
            _mainForm.IsSaved = false;
        }
        catch
        {

        }
    }

    private void OnEditFederationOptions(object? sender, EventArgs e)
    {
        FedOptionsForm fedOptionsForm = new();
        FedOptionsFormPresenter fedOptionsFormPresenter = new(_federationModel, fedOptionsForm);
        if (fedOptionsFormPresenter.ShowDialog(_mainForm) == DialogResult.OK)
            _mainForm.IsSaved = false;
    }

    private void OnEditWrestler(object? sender, string? key)
    {
        WrestlerModel wrestlerModel = (key != null) ? _federationModel.Wrestlers[key] : new();
        WrestlerEditorForm wrestlerEditorForm = new();
        WrestlerEditorFormPresenter wrestlerEditorFormPresenter = new(wrestlerModel, wrestlerEditorForm);
        if (wrestlerEditorFormPresenter.ShowDialog(_mainForm, out string newKey) != DialogResult.OK) // newKey defined here
            return;

        if (key == null) // New
        {
            _federationModel.Wrestlers.Add(newKey, wrestlerModel);
            AddTreeNode(_mainForm.WrestlersTreeNode, newKey, MainForm.TreeViewWrestlerImageKey);
        }
        else if (key != newKey) // Updated name
        {
            _federationModel.Wrestlers.Remove(key);
            _federationModel.Wrestlers.Add(newKey, wrestlerModel);
            UpdateTreeNode(_mainForm.WrestlersTreeNode, key, newKey);
        }
        _mainForm.IsSaved = false;
    }

    private void OnEditTeam(object? sender, string? key)
    {
        TeamModel teamModel = (key != null) ? _federationModel.Teams[key] : new();
        TeamEditorForm teamEditorForm = new();
        TeamEditorFormPresenter teamEditorFormPresenter = new(teamModel, teamEditorForm);
        if (teamEditorFormPresenter.ShowDialog(_mainForm, out string newKey) != DialogResult.OK) // newKey defined here
            return;

        if (key == null) // New
        {
            _federationModel.Teams.Add(newKey, teamModel);
            AddTreeNode(_mainForm.TeamsTreeNode, newKey, MainForm.TreeViewTeamImageKey);
        }
        else if (key != newKey) // Updated name
        {
            _federationModel.Teams.Remove(key);
            _federationModel.Teams.Add(newKey, teamModel);
            UpdateTreeNode(_mainForm.TeamsTreeNode, key, newKey);
        }
        _mainForm.IsSaved = false;
    }

    private void OnEditTitle(object? sender, string? key)
    {
        TitleModel titleModel = (key != null) ? _federationModel.Titles[key] : new();
        TitleEditorForm titleEditorForm = new();
        TitleEditorFormPresenter titleEditorFormPresenter = new(titleModel, titleEditorForm);
        if (titleEditorFormPresenter.ShowDialog(_mainForm, out string newKey) != DialogResult.OK) // newKey defined here
            return;

        if (key == null) // New
        {
            _federationModel.Titles.Add(newKey, titleModel);
            AddTreeNode(_mainForm.TitlesTreeNode, newKey, MainForm.TreeViewTitleImageKey);
        }
        else if (key != newKey) // Updated name
        {
            _federationModel.Titles.Remove(key);
            _federationModel.Titles.Add(newKey, titleModel);
            UpdateTreeNode(_mainForm.TitlesTreeNode, key, newKey);
        }
        _mainForm.IsSaved = false;
    }

    private void OnEditCommentator(object? sender, string? key)
    {
        CommentatorModel commentatorModel = (key != null) ? _federationModel.Commentators[key] : new();
        CommentatorEditorForm commentatorEditorForm = new();
        CommentatorEditorFormPresenter commentatorEditorFormPresenter = new(commentatorModel, commentatorEditorForm);
        if (commentatorEditorFormPresenter.ShowDialog(_mainForm, out string newKey) != DialogResult.OK) // newKey defined here
            return;

        if (key == null) // New
        {
            _federationModel.Commentators.Add(newKey, commentatorModel);
            AddTreeNode(_mainForm.CommentatorsTreeNode, newKey, MainForm.TreeViewCommentatorImageKey);
        }
        else if (key != newKey) // Updated name
        {
            _federationModel.Commentators.Remove(key);
            _federationModel.Commentators.Add(newKey, commentatorModel);
            UpdateTreeNode(_mainForm.CommentatorsTreeNode, key, newKey);
        }
        _mainForm.IsSaved = false;
    }

    private void OnEditReferee(object? sender, string? key)
    {
        RefereeModel refereeModel = (key != null) ? _federationModel.Referees[key] : new();
        RefereeEditorForm refereeEditorForm = new();
        RefereeEditorFormPresenter refereeEditorFormPresenter = new(refereeModel, refereeEditorForm);
        if (refereeEditorFormPresenter.ShowDialog(_mainForm, out string newKey) != DialogResult.OK) // newKey defined here
            return;

        if (key == null) // New
        {
            _federationModel.Referees.Add(newKey, refereeModel);
            AddTreeNode(_mainForm.RefereesTreeNode, newKey, MainForm.TreeViewRefereeImageKey);
        }
        else if (key != newKey) // Updated name
        {
            _federationModel.Referees.Remove(key);
            _federationModel.Referees.Add(newKey, refereeModel);
            UpdateTreeNode(_mainForm.RefereesTreeNode, key, newKey);
        }
        _mainForm.IsSaved = false;
    }

    private void OnDeleteWrestler(object? sender, string key)
    {
        _federationModel.Wrestlers.Remove(key);
        _mainForm.WrestlersTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }

    private void OnDeleteTeam(object? sender, string key)
    {
        _federationModel.Teams.Remove(key);
        _mainForm.TeamsTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }

    private void OnDeleteTitle(object? sender, string key)
    {
        _federationModel.Titles.Remove(key);
        _mainForm.TitlesTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }

    private void OnDeleteCommentator(object? sender, string key)
    {
        _federationModel.Commentators.Remove(key);
        _mainForm.CommentatorsTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }

    private void OnDeleteReferee(object? sender, string key)
    {
        _federationModel.Referees.Remove(key);
        _mainForm.RefereesTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }
}
