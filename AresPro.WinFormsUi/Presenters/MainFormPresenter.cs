using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views;
using AresPro.WinFormsUi.Views.Booking;
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
    }

    private void ConnectHandlers()
    {
        _mainForm.NewFederation += OnNewFederation;
        _mainForm.OpenFederation += OnOpenFederation;
        _mainForm.SaveFederation += OnSaveFederation;

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

        _mainForm.BookEvent += OnBookEvent;
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
            AddTreeNode(_mainForm.WrestlersTreeNode, wrestlerModel.Name, MainForm.TreeViewWrestlerImageKey);
            _mainForm.IsSaved = false;
        }
        catch
        {

        }
    }

    private void OnEditFederationOptions(object? sender, EventArgs e)
    {
        FedOptionsForm fedOptionsForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        FedOptionsFormPresenter fedOptionsFormPresenter = new(_federationModel, fedOptionsForm);
        if (fedOptionsFormPresenter.ShowDialog(_mainForm) == DialogResult.OK)
            _mainForm.IsSaved = false;
    }

    private void OnEditWrestler(object? sender, string? key)
    {
        WrestlerModel wrestlerModel = (key != null) ? _federationModel.Wrestlers[key] : new() { Names = [ NameHelper.GetNewName("Wrestler", _federationModel.Wrestlers.Keys) ] };
        WrestlerEditorForm wrestlerEditorForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        WrestlerEditorFormPresenter wrestlerEditorFormPresenter = new(
            wrestlerModel,
            wrestlerEditorForm,
            _federationModel.Wrestlers.Values.Select(w => w.Name).ToArray(),
            _federationModel.Titles.Values.Where(t => t.Type == TitleTypes.Singles).Select(t => t.Name).ToArray(),
            _federationModel.StatMax,
            _federationModel.BackgroundColor,
            _federationModel.FontColor
        );
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

            // Update teams
            foreach (string teamName in wrestlerModel.Teams)
            {
                _federationModel.Teams[teamName].MemberNames.Remove(key);
                _federationModel.Teams[teamName].MemberNames.Add(newKey);
            }
        }

        // Update title holders
        if (wrestlerModel.TitleNames.Count != 0)
            foreach (string titleName in wrestlerModel.TitleNames)
                UpdateTitleHolder(titleName, wrestlerModel.Name);

        _mainForm.IsSaved = false;
    }

    private void OnEditTeam(object? sender, string? key)
    {
        TeamModel teamModel = (key != null) ? _federationModel.Teams[key] : new() { Name = NameHelper.GetNewName("Team", _federationModel.Teams.Keys) };
        TeamEditorForm teamEditorForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        TeamEditorFormPresenter teamEditorFormPresenter = new(
            teamModel,
            teamEditorForm,
            _federationModel.Teams.Values.Select(t => t.Name).ToArray(),
            _federationModel.Wrestlers.Values.Select(w => w.Name).ToArray(),
            _federationModel.Titles.Values.Where(t => t.Type == TitleTypes.Team).Select(t => t.Name).ToArray()
        );
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

        // Update members
        foreach (string memberName in teamModel.MemberNames)
        {
            if (!_federationModel.Wrestlers[memberName].Teams.Contains(teamModel.Name))
                _federationModel.Wrestlers[memberName].Teams.Add(teamModel.Name);

            if (key != null && key != newKey && _federationModel.Wrestlers[memberName].Teams.Contains(key))
                _federationModel.Wrestlers[memberName].Teams.Remove(key);
        }

        // Update title holders
        if (teamModel.TitleNames.Count != 0)
            foreach (string titleName in teamModel.TitleNames)
                UpdateTitleHolder(titleName, teamModel.Name);

        _mainForm.IsSaved = false;
    }

    private void OnEditTitle(object? sender, string? key)
    {
        TitleModel titleModel = (key != null) ? _federationModel.Titles[key] : new() { Name = NameHelper.GetNewName("Title", _federationModel.Titles.Keys) };
        TitleEditorForm titleEditorForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        TitleEditorFormPresenter titleEditorFormPresenter = new(
            titleModel,
            titleEditorForm,
            _federationModel.Titles.Values.Select(t => t.Name).ToArray()
        );
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

            // Update holders title list
            if (!string.IsNullOrEmpty(titleModel.Holder))
            {
                List<string> holderTitlesList = (titleModel.Type == TitleTypes.Singles) ? _federationModel.Wrestlers[titleModel.Holder].TitleNames : _federationModel.Teams[titleModel.Holder].TitleNames;
                holderTitlesList.Remove(key);
                holderTitlesList.Add(newKey);
            }
        }
        _mainForm.IsSaved = false;
    }

    private void OnEditCommentator(object? sender, string? key)
    {
        CommentatorModel commentatorModel = (key != null) ? _federationModel.Commentators[key] : new() { Name = NameHelper.GetNewName("Commentator", _federationModel.Commentators.Keys) };
        CommentatorEditorForm commentatorEditorForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        CommentatorEditorFormPresenter commentatorEditorFormPresenter = new(
            commentatorModel,
            commentatorEditorForm,
            _federationModel.Commentators.Values.Select(t => t.Name).ToArray()
        );
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
        RefereeModel refereeModel = (key != null) ? _federationModel.Referees[key] : new() { Name = NameHelper.GetNewName("Referee", _federationModel.Referees.Keys) };
        RefereeEditorForm refereeEditorForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        RefereeEditorFormPresenter refereeEditorFormPresenter = new(
            refereeModel,
            refereeEditorForm,
            _federationModel.Referees.Values.Select(t => t.Name).ToArray()
        );
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
        WrestlerModel wrestler = _federationModel.Wrestlers[key];

        // Remove from teams
        foreach (string teamName in wrestler.Teams)
            _federationModel.Teams[teamName].MemberNames.Remove(wrestler.Name);

        // Remove titles
        foreach (string titleName in wrestler.TitleNames)
            _federationModel.Titles[titleName].Holder = null;

        _federationModel.Wrestlers.Remove(key);
        _mainForm.WrestlersTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }

    private void OnDeleteTeam(object? sender, string key)
    {
        TeamModel team = _federationModel.Teams[key];

        // Remove wrestlers from team
        foreach (string wrestlerName in team.MemberNames)
            _federationModel.Wrestlers[wrestlerName].Teams.Remove(team.Name);

        // Remove titles
        foreach (string titleName in team.TitleNames)
            _federationModel.Titles[titleName].Holder = null;

        _federationModel.Teams.Remove(key);
        _mainForm.TeamsTreeNode.Nodes.RemoveByKey(key);
        _mainForm.IsSaved = false;
    }

    private void OnDeleteTitle(object? sender, string key)
    {
        TitleModel title = _federationModel.Titles[key];

        // Remove from holder
        if (!string.IsNullOrEmpty(title.Holder))
        {
            if (title.Type == TitleTypes.Singles)
                _federationModel.Wrestlers[title.Holder].TitleNames.Remove(title.Name);
            else
                _federationModel.Teams[title.Holder].TitleNames.Remove(title.Name);
        }

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

    private void OnBookEvent(object? sender, EventArgs e)
    {
        if (_federationModel.Wrestlers.Count == 0)
        {
            MessageBox.Show("There must be two wrestlers to book a card", "Zeus Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        else if (_federationModel.Commentators.Count == 0 || _federationModel.Referees.Count == 0)
        {
            MessageBox.Show("You must have a commentator and a referee to book a card.", "Zeus Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        BookACardForm bookACardForm = new()
        {
            Left = _mainForm.Left + 20,
            Top = _mainForm.Top + 40
        };
        BookACardFormPresenter bookACardFormPresenter = new(_federationModel, bookACardForm);
        bookACardFormPresenter.ShowDialog(_mainForm);
    }

    private void UpdateTitleHolder(string titleName, string newHolderName)
    {
        TitleModel title = _federationModel.Titles[titleName];
        if (!string.IsNullOrEmpty(title.Holder) && title.Holder != newHolderName)
        {
            // Check if key exists encase it's been a rename of a wrestler/team
            if (title.Type == TitleTypes.Singles && _federationModel.Wrestlers.ContainsKey(title.Holder))
                _federationModel.Wrestlers[title.Holder].TitleNames.Remove(title.Name);
            else if(title.Type == TitleTypes.Team && _federationModel.Teams.ContainsKey(title.Holder))
                _federationModel.Teams[title.Holder].TitleNames.Remove(title.Name);
        }
        title.Holder = newHolderName;
    }
}
