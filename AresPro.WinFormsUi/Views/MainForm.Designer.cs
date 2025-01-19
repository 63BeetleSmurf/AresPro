namespace AresPro.WinFormsUi.Views;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnBookEvent = new ToolStripButton();
        mnuBookEventItem = new ToolStripMenuItem();
        mnuTitleHistoryItem = new ToolStripMenuItem();
        mnuRankItem = new ToolStripMenuItem();
        mnuHelpMenu = new ToolStripMenuItem();
        mnuHelpItem = new ToolStripMenuItem();
        ToolStripMenuItem4 = new ToolStripSeparator();
        mnuAboutItem = new ToolStripMenuItem();
        ToolStrip = new ToolStrip();
        btnOpenFed = new ToolStripButton();
        btnSaveFed = new ToolStripButton();
        ToolStripSeparator2 = new ToolStripSeparator();
        btnNewWrestler = new ToolStripButton();
        btnNewTeam = new ToolStripButton();
        btnNewTitle = new ToolStripButton();
        btnNewCommentator = new ToolStripButton();
        btnNewReferee = new ToolStripButton();
        ToolStripSeparator3 = new ToolStripSeparator();
        btnEditSelection = new ToolStripButton();
        btnDeleteSelection = new ToolStripButton();
        ToolStripSeparator4 = new ToolStripSeparator();
        ToolStripMenuItem3 = new ToolStripSeparator();
        tvwRoster = new TreeView();
        mnuDeleteSelectionItem = new ToolStripMenuItem();
        MenuStrip = new MenuStrip();
        mnuFileMenu = new ToolStripMenuItem();
        mnuNewItem = new ToolStripMenuItem();
        ToolStripMenuItem1 = new ToolStripSeparator();
        mnuOpenItem = new ToolStripMenuItem();
        mnuSaveItem = new ToolStripMenuItem();
        mnuSaveAsItem = new ToolStripMenuItem();
        ToolStripMenuItem2 = new ToolStripSeparator();
        mnuExitItem = new ToolStripMenuItem();
        mnuResourcesMenu = new ToolStripMenuItem();
        mnuCommentaryItem = new ToolStripMenuItem();
        mnuMovesItem = new ToolStripMenuItem();
        mnuGimmicksItem = new ToolStripMenuItem();
        mnuCommercialsItem = new ToolStripMenuItem();
        mnuImportWrestlerItem = new ToolStripMenuItem();
        mnuFedMenu = new ToolStripMenuItem();
        mnuFedOptionsItem = new ToolStripMenuItem();
        mnuNewWrestlerItem = new ToolStripMenuItem();
        mnuNewTagTeamItem = new ToolStripMenuItem();
        mnuNewTitleItem = new ToolStripMenuItem();
        mnuNewCommentatorItem = new ToolStripMenuItem();
        mnuNewRefereeItem = new ToolStripMenuItem();
        mnuEditSelectionItem = new ToolStripMenuItem();
        ToolStrip.SuspendLayout();
        MenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // btnBookEvent
        // 
        btnBookEvent.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnBookEvent.Image = Properties.Resources.ring;
        btnBookEvent.ImageScaling = ToolStripItemImageScaling.None;
        btnBookEvent.ImageTransparentColor = Color.Magenta;
        btnBookEvent.Name = "btnBookEvent";
        btnBookEvent.Size = new Size(23, 22);
        btnBookEvent.ToolTipText = "Book Event";
        // 
        // mnuBookEventItem
        // 
        mnuBookEventItem.Name = "mnuBookEventItem";
        mnuBookEventItem.ShortcutKeys = Keys.Control | Keys.E;
        mnuBookEventItem.Size = new Size(180, 22);
        mnuBookEventItem.Text = "&Book Event";
        // 
        // mnuTitleHistoryItem
        // 
        mnuTitleHistoryItem.Name = "mnuTitleHistoryItem";
        mnuTitleHistoryItem.Size = new Size(180, 22);
        mnuTitleHistoryItem.Text = "&Title History";
        // 
        // mnuRankItem
        // 
        mnuRankItem.Name = "mnuRankItem";
        mnuRankItem.Size = new Size(180, 22);
        mnuRankItem.Text = "&Rank";
        // 
        // mnuHelpMenu
        // 
        mnuHelpMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpItem, ToolStripMenuItem4, mnuAboutItem });
        mnuHelpMenu.Name = "mnuHelpMenu";
        mnuHelpMenu.Size = new Size(44, 20);
        mnuHelpMenu.Text = "&Help";
        // 
        // mnuHelpItem
        // 
        mnuHelpItem.Name = "mnuHelpItem";
        mnuHelpItem.Size = new Size(180, 22);
        mnuHelpItem.Text = "Help";
        // 
        // ToolStripMenuItem4
        // 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4";
        ToolStripMenuItem4.Size = new Size(104, 6);
        // 
        // mnuAboutItem
        // 
        mnuAboutItem.Name = "mnuAboutItem";
        mnuAboutItem.Size = new Size(107, 22);
        mnuAboutItem.Text = "&About";
        // 
        // ToolStrip
        // 
        ToolStrip.Items.AddRange(new ToolStripItem[] { btnOpenFed, btnSaveFed, ToolStripSeparator2, btnNewWrestler, btnNewTeam, btnNewTitle, btnNewCommentator, btnNewReferee, ToolStripSeparator3, btnEditSelection, btnDeleteSelection, ToolStripSeparator4, btnBookEvent });
        ToolStrip.Location = new Point(0, 24);
        ToolStrip.Name = "ToolStrip";
        ToolStrip.Size = new Size(933, 25);
        ToolStrip.TabIndex = 4;
        ToolStrip.Text = "ToolStrip";
        // 
        // btnOpenFed
        // 
        btnOpenFed.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnOpenFed.Image = Properties.Resources.open;
        btnOpenFed.ImageScaling = ToolStripItemImageScaling.None;
        btnOpenFed.ImageTransparentColor = Color.Magenta;
        btnOpenFed.Name = "btnOpenFed";
        btnOpenFed.Size = new Size(23, 22);
        btnOpenFed.ToolTipText = "Open Fed";
        // 
        // btnSaveFed
        // 
        btnSaveFed.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnSaveFed.Image = Properties.Resources.save;
        btnSaveFed.ImageScaling = ToolStripItemImageScaling.None;
        btnSaveFed.ImageTransparentColor = Color.Magenta;
        btnSaveFed.Name = "btnSaveFed";
        btnSaveFed.Size = new Size(23, 22);
        btnSaveFed.ToolTipText = "Save Fed";
        // 
        // ToolStripSeparator2
        // 
        ToolStripSeparator2.Name = "ToolStripSeparator2";
        ToolStripSeparator2.Size = new Size(6, 25);
        // 
        // btnNewWrestler
        // 
        btnNewWrestler.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnNewWrestler.Image = Properties.Resources.wrestler;
        btnNewWrestler.ImageScaling = ToolStripItemImageScaling.None;
        btnNewWrestler.ImageTransparentColor = Color.Magenta;
        btnNewWrestler.Name = "btnNewWrestler";
        btnNewWrestler.Size = new Size(23, 22);
        btnNewWrestler.ToolTipText = "New Wrestler";
        // 
        // btnNewTeam
        // 
        btnNewTeam.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnNewTeam.Image = Properties.Resources.tag_team;
        btnNewTeam.ImageScaling = ToolStripItemImageScaling.None;
        btnNewTeam.ImageTransparentColor = Color.Magenta;
        btnNewTeam.Name = "btnNewTeam";
        btnNewTeam.Size = new Size(23, 22);
        btnNewTeam.ToolTipText = "New Tag Team";
        // 
        // btnNewTitle
        // 
        btnNewTitle.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnNewTitle.Image = Properties.Resources.title_belt;
        btnNewTitle.ImageScaling = ToolStripItemImageScaling.None;
        btnNewTitle.ImageTransparentColor = Color.Magenta;
        btnNewTitle.Name = "btnNewTitle";
        btnNewTitle.Size = new Size(23, 22);
        btnNewTitle.ToolTipText = "New Title Belt";
        // 
        // btnNewCommentator
        // 
        btnNewCommentator.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnNewCommentator.Image = Properties.Resources.commentator;
        btnNewCommentator.ImageScaling = ToolStripItemImageScaling.None;
        btnNewCommentator.ImageTransparentColor = Color.Magenta;
        btnNewCommentator.Name = "btnNewCommentator";
        btnNewCommentator.Size = new Size(23, 22);
        btnNewCommentator.ToolTipText = "New Commentator";
        // 
        // btnNewReferee
        // 
        btnNewReferee.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnNewReferee.Image = Properties.Resources.referee;
        btnNewReferee.ImageScaling = ToolStripItemImageScaling.None;
        btnNewReferee.ImageTransparentColor = Color.Magenta;
        btnNewReferee.Name = "btnNewReferee";
        btnNewReferee.Size = new Size(23, 22);
        btnNewReferee.ToolTipText = "New Referee";
        // 
        // ToolStripSeparator3
        // 
        ToolStripSeparator3.Name = "ToolStripSeparator3";
        ToolStripSeparator3.Size = new Size(6, 25);
        // 
        // btnEditSelection
        // 
        btnEditSelection.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnEditSelection.Image = Properties.Resources.edit;
        btnEditSelection.ImageScaling = ToolStripItemImageScaling.None;
        btnEditSelection.ImageTransparentColor = Color.Magenta;
        btnEditSelection.Name = "btnEditSelection";
        btnEditSelection.Size = new Size(23, 22);
        btnEditSelection.ToolTipText = "Edit Selection";
        // 
        // btnDeleteSelection
        // 
        btnDeleteSelection.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnDeleteSelection.Image = Properties.Resources.delete;
        btnDeleteSelection.ImageScaling = ToolStripItemImageScaling.None;
        btnDeleteSelection.ImageTransparentColor = Color.Magenta;
        btnDeleteSelection.Name = "btnDeleteSelection";
        btnDeleteSelection.Size = new Size(23, 22);
        btnDeleteSelection.ToolTipText = "Delete Selection";
        // 
        // ToolStripSeparator4
        // 
        ToolStripSeparator4.Name = "ToolStripSeparator4";
        ToolStripSeparator4.Size = new Size(6, 25);
        // 
        // ToolStripMenuItem3
        // 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3";
        ToolStripMenuItem3.Size = new Size(173, 6);
        // 
        // tvwRoster
        // 
        tvwRoster.Dock = DockStyle.Fill;
        tvwRoster.Location = new Point(0, 24);
        tvwRoster.Margin = new Padding(4, 3, 4, 3);
        tvwRoster.Name = "tvwRoster";
        tvwRoster.ShowLines = false;
        tvwRoster.ShowPlusMinus = false;
        tvwRoster.ShowRootLines = false;
        tvwRoster.Size = new Size(933, 495);
        tvwRoster.TabIndex = 5;
        // 
        // mnuDeleteSelectionItem
        // 
        mnuDeleteSelectionItem.Name = "mnuDeleteSelectionItem";
        mnuDeleteSelectionItem.Size = new Size(176, 22);
        mnuDeleteSelectionItem.Text = "Delete Selection";
        // 
        // MenuStrip
        // 
        MenuStrip.Items.AddRange(new ToolStripItem[] { mnuFileMenu, mnuResourcesMenu, mnuFedMenu, mnuHelpMenu });
        MenuStrip.Location = new Point(0, 0);
        MenuStrip.Name = "MenuStrip";
        MenuStrip.Padding = new Padding(7, 2, 0, 2);
        MenuStrip.Size = new Size(933, 24);
        MenuStrip.TabIndex = 3;
        MenuStrip.Text = "MenuStrip";
        // 
        // mnuFileMenu
        // 
        mnuFileMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuNewItem, ToolStripMenuItem1, mnuOpenItem, mnuSaveItem, mnuSaveAsItem, ToolStripMenuItem2, mnuExitItem });
        mnuFileMenu.Name = "mnuFileMenu";
        mnuFileMenu.Size = new Size(37, 20);
        mnuFileMenu.Text = "&File";
        // 
        // mnuNewItem
        // 
        mnuNewItem.Name = "mnuNewItem";
        mnuNewItem.ShortcutKeys = Keys.Control | Keys.N;
        mnuNewItem.Size = new Size(146, 22);
        mnuNewItem.Text = "&New";
        // 
        // ToolStripMenuItem1
        // 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1";
        ToolStripMenuItem1.Size = new Size(143, 6);
        // 
        // mnuOpenItem
        // 
        mnuOpenItem.Name = "mnuOpenItem";
        mnuOpenItem.ShortcutKeys = Keys.Control | Keys.O;
        mnuOpenItem.Size = new Size(146, 22);
        mnuOpenItem.Text = "&Open";
        // 
        // mnuSaveItem
        // 
        mnuSaveItem.Name = "mnuSaveItem";
        mnuSaveItem.ShortcutKeys = Keys.Control | Keys.S;
        mnuSaveItem.Size = new Size(146, 22);
        mnuSaveItem.Text = "&Save";
        // 
        // mnuSaveAsItem
        // 
        mnuSaveAsItem.Name = "mnuSaveAsItem";
        mnuSaveAsItem.Size = new Size(146, 22);
        mnuSaveAsItem.Text = "Save &As";
        // 
        // ToolStripMenuItem2
        // 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2";
        ToolStripMenuItem2.Size = new Size(143, 6);
        // 
        // mnuExitItem
        // 
        mnuExitItem.Name = "mnuExitItem";
        mnuExitItem.Size = new Size(146, 22);
        mnuExitItem.Text = "&Exit";
        // 
        // mnuResourcesMenu
        // 
        mnuResourcesMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuCommentaryItem, mnuMovesItem, mnuGimmicksItem, mnuCommercialsItem, mnuImportWrestlerItem });
        mnuResourcesMenu.Name = "mnuResourcesMenu";
        mnuResourcesMenu.Size = new Size(72, 20);
        mnuResourcesMenu.Text = "&Resources";
        // 
        // mnuCommentaryItem
        // 
        mnuCommentaryItem.Name = "mnuCommentaryItem";
        mnuCommentaryItem.Size = new Size(169, 22);
        mnuCommentaryItem.Text = "&Commentary";
        // 
        // mnuMovesItem
        // 
        mnuMovesItem.Name = "mnuMovesItem";
        mnuMovesItem.ShortcutKeys = Keys.Control | Keys.M;
        mnuMovesItem.Size = new Size(169, 22);
        mnuMovesItem.Text = "&Moves";
        // 
        // mnuGimmicksItem
        // 
        mnuGimmicksItem.Name = "mnuGimmicksItem";
        mnuGimmicksItem.ShortcutKeys = Keys.Control | Keys.G;
        mnuGimmicksItem.Size = new Size(169, 22);
        mnuGimmicksItem.Text = "&Gimmicks";
        // 
        // mnuCommercialsItem
        // 
        mnuCommercialsItem.Name = "mnuCommercialsItem";
        mnuCommercialsItem.Size = new Size(180, 22);
        mnuCommercialsItem.Text = "Co&mmercials";
        // 
        // mnuImportWrestlerItem
        // 
        mnuImportWrestlerItem.Name = "mnuImportWrestlerItem";
        mnuImportWrestlerItem.Size = new Size(169, 22);
        mnuImportWrestlerItem.Text = "&Import Wrestler";
        // 
        // mnuFedMenu
        // 
        mnuFedMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuFedOptionsItem, mnuNewWrestlerItem, mnuNewTagTeamItem, mnuNewTitleItem, mnuNewCommentatorItem, mnuNewRefereeItem, mnuEditSelectionItem, mnuDeleteSelectionItem, ToolStripMenuItem3, mnuBookEventItem, mnuTitleHistoryItem, mnuRankItem });
        mnuFedMenu.Name = "mnuFedMenu";
        mnuFedMenu.Size = new Size(38, 20);
        mnuFedMenu.Text = "F&ed";
        // 
        // mnuFedOptionsItem
        // 
        mnuFedOptionsItem.Name = "mnuFedOptionsItem";
        mnuFedOptionsItem.Size = new Size(176, 22);
        mnuFedOptionsItem.Text = "&Fed Options";
        // 
        // mnuNewWrestlerItem
        // 
        mnuNewWrestlerItem.Name = "mnuNewWrestlerItem";
        mnuNewWrestlerItem.Size = new Size(176, 22);
        mnuNewWrestlerItem.Text = "New Wrestler";
        // 
        // mnuNewTagTeamItem
        // 
        mnuNewTagTeamItem.Name = "mnuNewTagTeamItem";
        mnuNewTagTeamItem.Size = new Size(176, 22);
        mnuNewTagTeamItem.Text = "New Tag Team";
        // 
        // mnuNewTitleItem
        // 
        mnuNewTitleItem.Name = "mnuNewTitleItem";
        mnuNewTitleItem.Size = new Size(176, 22);
        mnuNewTitleItem.Text = "New Title";
        // 
        // mnuNewCommentatorItem
        // 
        mnuNewCommentatorItem.Name = "mnuNewCommentatorItem";
        mnuNewCommentatorItem.Size = new Size(176, 22);
        mnuNewCommentatorItem.Text = "New Commentator";
        // 
        // mnuNewRefereeItem
        // 
        mnuNewRefereeItem.Name = "mnuNewRefereeItem";
        mnuNewRefereeItem.Size = new Size(176, 22);
        mnuNewRefereeItem.Text = "New Referee";
        // 
        // mnuEditSelectionItem
        // 
        mnuEditSelectionItem.Name = "mnuEditSelectionItem";
        mnuEditSelectionItem.Size = new Size(176, 22);
        mnuEditSelectionItem.Text = "Edit Selection";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(933, 519);
        Controls.Add(ToolStrip);
        Controls.Add(tvwRoster);
        Controls.Add(MenuStrip);
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        Text = "MainForm";
        ToolStrip.ResumeLayout(false);
        ToolStrip.PerformLayout();
        MenuStrip.ResumeLayout(false);
        MenuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.ToolStripButton btnBookEvent;
    internal System.Windows.Forms.ToolStripMenuItem mnuBookEventItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuTitleHistoryItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuRankItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuHelpMenu;
    internal System.Windows.Forms.ToolStripMenuItem mnuHelpItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
    internal System.Windows.Forms.ToolStripMenuItem mnuAboutItem;
    internal System.Windows.Forms.ToolStrip ToolStrip;
    internal System.Windows.Forms.ToolStripButton btnOpenFed;
    internal System.Windows.Forms.ToolStripButton btnSaveFed;
    internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
    internal System.Windows.Forms.ToolStripButton btnNewWrestler;
    internal System.Windows.Forms.ToolStripButton btnNewTeam;
    internal System.Windows.Forms.ToolStripButton btnNewTitle;
    internal System.Windows.Forms.ToolStripButton btnNewCommentator;
    internal System.Windows.Forms.ToolStripButton btnNewReferee;
    internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
    internal System.Windows.Forms.ToolStripButton btnEditSelection;
    internal System.Windows.Forms.ToolStripButton btnDeleteSelection;
    internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
    internal System.Windows.Forms.TreeView tvwRoster;
    internal System.Windows.Forms.ToolStripMenuItem mnuDeleteSelectionItem;
    internal System.Windows.Forms.MenuStrip MenuStrip;
    internal System.Windows.Forms.ToolStripMenuItem mnuFileMenu;
    internal System.Windows.Forms.ToolStripMenuItem mnuNewItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
    internal System.Windows.Forms.ToolStripMenuItem mnuOpenItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuSaveItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuSaveAsItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
    internal System.Windows.Forms.ToolStripMenuItem mnuExitItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuResourcesMenu;
    internal System.Windows.Forms.ToolStripMenuItem mnuCommentaryItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuMovesItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuGimmicksItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuCommercialsItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuImportWrestlerItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuFedMenu;
    internal System.Windows.Forms.ToolStripMenuItem mnuFedOptionsItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuNewWrestlerItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuNewTagTeamItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuNewTitleItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuNewCommentatorItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuNewRefereeItem;
    internal System.Windows.Forms.ToolStripMenuItem mnuEditSelectionItem;
}
