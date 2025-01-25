using AresPro.WinFormsUi.Helpers;

namespace AresPro.WinFormsUi.Views;

public partial class MainForm : Form
{
    public const string TreeViewCollapsedImageKey = "collapsed";
    public const string TreeViewExpandedImageKey = "expanded";
    public const string TreeViewWrestlerImageKey = "wrestler";
    public const string TreeViewTeamImageKey = "team";
    public const string TreeViewTitleImageKey = "title";
    public const string TreeViewCommentatorImageKey = "commentator";
    public const string TreeViewRefereeImageKey = "referee";

    public readonly TreeNode WrestlersTreeNode = new("Singles Roster");
    public readonly TreeNode TeamsTreeNode = new("Team Roster");
    public readonly TreeNode TitlesTreeNode = new("Titles");
    public readonly TreeNode CommentatorsTreeNode = new("Commentators");
    public readonly TreeNode RefereesTreeNode = new("Referees");

    public EventHandler? NewFederation;
    public EventHandler<string>? OpenFederation;
    public EventHandler<string>? SaveFederation;
    public EventHandler? CloseApplication;

    public EventHandler<string>? EditCommentaryFile;
    public EventHandler<string>? EditMovesFile;
    public EventHandler<string>? EditGimmickFile;
    public EventHandler? EditCommercials;
    public EventHandler<string>? ImportFile;

    public EventHandler? EditFederationOptions;
    public EventHandler<string?>? EditWrestler;
    public EventHandler<string?>? EditTeam;
    public EventHandler<string?>? EditTitle;
    public EventHandler<string?>? EditCommentator;
    public EventHandler<string?>? EditReferee;

    public EventHandler<string>? DeleteWrestler;
    public EventHandler<string>? DeleteTeam;
    public EventHandler<string>? DeleteTitle;
    public EventHandler<string>? DeleteCommentator;
    public EventHandler<string>? DeleteReferee;

    public bool IsSaved { get; set; } = true;
    public string? FederationFilename { get; set; }

    public MainForm()
    {
        InitializeComponent();
    }

    public void InitializeForm()
    {
        CenterToScreen();
        Icon = Properties.Resources.a_pro;
        Text += VersionHelper.GetVersionString();

        // Create ImageList for TreeView icons
        RosterTreeView.ImageList = new();
        RosterTreeView.ImageList.Images.Add(TreeViewCollapsedImageKey, Properties.Resources.root_closed);
        RosterTreeView.ImageList.Images.Add(TreeViewExpandedImageKey, Properties.Resources.root_open);
        RosterTreeView.ImageList.Images.Add(TreeViewWrestlerImageKey, Properties.Resources.wrestler);
        RosterTreeView.ImageList.Images.Add(TreeViewTeamImageKey, Properties.Resources.tag_team);
        RosterTreeView.ImageList.Images.Add(TreeViewTitleImageKey, Properties.Resources.title_belt);
        RosterTreeView.ImageList.Images.Add(TreeViewCommentatorImageKey, Properties.Resources.commentator);
        RosterTreeView.ImageList.Images.Add(TreeViewRefereeImageKey, Properties.Resources.referee);

        // Assign images to root nodes and add to TreeView.
        foreach (TreeNode rootNode in new[] { WrestlersTreeNode, TeamsTreeNode, TitlesTreeNode, CommentatorsTreeNode, RefereesTreeNode })
        {
            rootNode.ImageKey = TreeViewCollapsedImageKey;
            rootNode.SelectedImageKey = TreeViewCollapsedImageKey;
            RosterTreeView.Nodes.Add(rootNode);
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!IsSaved && ShowSaveDiscardPrompt() == DialogResult.Cancel)
            e.Cancel = true;
        else
            CloseApplication?.Invoke(this, EventArgs.Empty);
    }

    private void RosterTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
        if (e.Node == null)
            return;

        e.Node.ImageKey = TreeViewExpandedImageKey;
        e.Node.SelectedImageKey = TreeViewExpandedImageKey;
    }

    private void RosterTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        if (e.Node == null)
            return;

        e.Node.ImageKey = TreeViewCollapsedImageKey;
        e.Node.SelectedImageKey = TreeViewCollapsedImageKey;
    }

    // Menu

    // - File menu

    private void NewMenuItem_Click(object sender, EventArgs e)
    {
        if (!IsSaved && ShowSaveDiscardPrompt() == DialogResult.Cancel)
            return;

        NewFederation?.Invoke(this, EventArgs.Empty);
    }

    private void OpenMenuItem_Click(object sender, EventArgs e)
    {
        if (!IsSaved && ShowSaveDiscardPrompt() == DialogResult.Cancel)
            return;

        if (
            FileDialogsHelper.ShowOpenDialog(
                this,
                Properties.Resources.FederationFileDialogFilter,
                DirectoryHelper.FederationsPath,
                $"*.{Properties.Resources.FederationFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
            OpenFederation?.Invoke(this, fileName);
    }

    private void SaveMenuItem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(FederationFilename))
            _ = ShowSaveFederationDialog();
        else
            SaveFederation?.Invoke(this, FederationFilename);
    }

    private void SaveAsMenuItem_Click(object sender, EventArgs e)
    {
        _ = ShowSaveFederationDialog();
    }

    private void ExitMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    // - Resources menu

    private void CommentaryMenuItem_Click(object sender, EventArgs e)
    {
        if (
            FileDialogsHelper.ShowOpenDialog(
                this,
                Properties.Resources.CommentaryFileDialogFilter,
                DirectoryHelper.CommentaryPath,
                $"*.{Properties.Resources.CommentaryFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
            EditCommentaryFile?.Invoke(this, fileName);
    }

    private void MovesMenuItem_Click(object sender, EventArgs e)
    {
        if (
            FileDialogsHelper.ShowOpenDialog(
                this,
                Properties.Resources.MovesFileDialogFilter,
                DirectoryHelper.MovesPath,
                $"*.{Properties.Resources.MovesFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
            EditMovesFile?.Invoke(this, fileName);
    }

    private void GimmicksMenuItem_Click(object sender, EventArgs e)
    {
        if (
            FileDialogsHelper.ShowOpenDialog(
                this,
                Properties.Resources.GimmickFileDialogFilter,
                DirectoryHelper.GimmicksPath,
                $"*.{Properties.Resources.GimmickFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
            EditGimmickFile?.Invoke(this, fileName);
    }

    private void CommercialsMenuItem_Click(object sender, EventArgs e)
    {
        EditCommercials?.Invoke(this, EventArgs.Empty);
    }

    private void ImportZimFileMenuItem_Click(object sender, EventArgs e)
    {
        if (
            FileDialogsHelper.ShowOpenDialog(
                this,
                Properties.Resources.ImportFileDialogFilter,
                DirectoryHelper.ImportFilePath,
                $"*.{Properties.Resources.ImportFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
            ImportFile?.Invoke(this, fileName);
    }

    // - Fed menu

    private void FedOptionsMenuItem_Click(object sender, EventArgs e)
    {
        EditFederationOptions?.Invoke(this, EventArgs.Empty);
    }

    private void NewWrestlerMenuItem_Click(object sender, EventArgs e)
    {
        EditWrestler?.Invoke(this, null);
    }

    private void NewTagTeamMenuItem_Click(object sender, EventArgs e)
    {
        EditTeam?.Invoke(this, null);
    }

    private void NewTitleMenuItem_Click(object sender, EventArgs e)
    {
        EditTitle?.Invoke(this, null);
    }

    private void NewCommentatorMenuItem_Click(object sender, EventArgs e)
    {
        EditCommentator?.Invoke(this, null);
    }

    private void NewRefereeMenuItem_Click(object sender, EventArgs e)
    {
        EditReferee?.Invoke(this, null);
    }

    private void EditSelectionMenuItem_Click(object sender, EventArgs e)
    {
        TreeNode selectedNode = RosterTreeView.SelectedNode;
        // Using ImageKey to identify what type of item was selected
        switch (selectedNode.ImageKey)
        {
            case TreeViewWrestlerImageKey:
                EditWrestler?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewTeamImageKey:
                EditTeam?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewTitleImageKey:
                EditTitle?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewCommentatorImageKey:
                EditCommentator?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewRefereeImageKey:
                EditReferee?.Invoke(this, selectedNode.Name);
                break;
        }
    }

    private void DeleteSelectionMenuItem_Click(object sender, EventArgs e)
    {
        TreeNode selectedNode = RosterTreeView.SelectedNode;

        if (
            MessageBox.Show(
                $"Delete {selectedNode.Text}?",
                "Zeus Message",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes
        )
            return;

        // Using ImageKey to identify what type of item was selected
        switch (selectedNode.ImageKey)
        {
            case TreeViewWrestlerImageKey:
                DeleteWrestler?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewTeamImageKey:
                DeleteTeam?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewTitleImageKey:
                DeleteTitle?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewCommentatorImageKey:
                DeleteCommentator?.Invoke(this, selectedNode.Name);
                break;
            case TreeViewRefereeImageKey:
                DeleteReferee?.Invoke(this, selectedNode.Name);
                break;
        }
    }

    private void BookEventMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void TitleHistoryMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void RankMenuItem_Click(object sender, EventArgs e)
    {

    }

    // - Help menu

    private void HelpMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void AboutMenuItem_Click(object sender, EventArgs e)
    {
        new AboutForm().ShowDialog(this);
    }

    // Toolbar

    private void OpenFedToolButton_Click(object sender, EventArgs e)
    {
        OpenMenuItem_Click(sender, e);
    }

    private void SaveFedToolButton_Click(object sender, EventArgs e)
    {
        SaveAsMenuItem_Click(sender, e);
    }

    private void NewWrestlerToolButton_Click(object sender, EventArgs e)
    {
        NewWrestlerMenuItem_Click(sender, e);
    }

    private void NewTeamToolButton_Click(object sender, EventArgs e)
    {
        NewTagTeamMenuItem_Click(sender, e);
    }

    private void NewTitleToolButton_Click(object sender, EventArgs e)
    {
        NewTitleMenuItem_Click(sender, e);
    }

    private void NewCommentatorToolButton_Click(object sender, EventArgs e)
    {
        NewCommentatorMenuItem_Click(sender, e);
    }

    private void NewRefereeToolButton_Click(object sender, EventArgs e)
    {
        NewRefereeMenuItem_Click(sender, e);
    }

    private void EditSelectionToolButton_Click(object sender, EventArgs e)
    {
        EditSelectionMenuItem_Click(sender, e);
    }

    private void DeleteSelectionToolButton_Click(object sender, EventArgs e)
    {
        DeleteSelectionMenuItem_Click(sender, e);
    }

    private void BookEventToolButton_Click(object sender, EventArgs e)
    {
        BookEventMenuItem_Click(sender, e);
    }

    // TreeView

    private void RosterTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        EditSelectionMenuItem_Click(sender, e);
    }

    private void RosterTreeView_KeyDown(object sender, KeyEventArgs e)
    {
        DeleteSelectionMenuItem_Click(sender, e);
    }

    private DialogResult ShowSaveFederationDialog()
    {
        DialogResult result = FileDialogsHelper.ShowOpenDialog(
            this,
            Properties.Resources.FederationFileDialogFilter,
            DirectoryHelper.GetPathDirectory(FederationFilename) ?? DirectoryHelper.FederationsPath,
            DirectoryHelper.GetPathFileName(FederationFilename) ?? $"*.{Properties.Resources.FederationFileExtension}",
            out string fileName // fileName defined here as out parameter
        );

        if (result == DialogResult.OK)
            SaveFederation?.Invoke(this, fileName);

        return result;
    }

    private DialogResult ShowSaveDiscardPrompt()
    {
        DialogResult result = MessageBox.Show(
            "Fed has changed. Save changes?",
            "Zeus Message",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
            result = ShowSaveFederationDialog(); // Return save dialog result encase user cancels there

        return result;
    }
}
