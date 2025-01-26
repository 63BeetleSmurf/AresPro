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
        BookEventMenuItem = new ToolStripMenuItem();
        TitleHistoryMenuItem = new ToolStripMenuItem();
        RankMenuItem = new ToolStripMenuItem();
        HelpMenuMenuItem = new ToolStripMenuItem();
        HelpMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem4 = new ToolStripSeparator();
        AboutMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem3 = new ToolStripSeparator();
        DeleteSelectionMenuItem = new ToolStripMenuItem();
        MenuStrip = new MenuStrip();
        FileMenuMenuItem = new ToolStripMenuItem();
        NewMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem1 = new ToolStripSeparator();
        OpenMenuItem = new ToolStripMenuItem();
        SaveMenuItem = new ToolStripMenuItem();
        SaveAsMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem2 = new ToolStripSeparator();
        ExitMenuItem = new ToolStripMenuItem();
        ResourcesMenuMenuItem = new ToolStripMenuItem();
        CommentaryMenuItem = new ToolStripMenuItem();
        MovesMenuItem = new ToolStripMenuItem();
        GimmicksMenuItem = new ToolStripMenuItem();
        CommercialsMenuItem = new ToolStripMenuItem();
        ImportZimFileMenuItem = new ToolStripMenuItem();
        FedMenuMenuItem = new ToolStripMenuItem();
        FedOptionsMenuItem = new ToolStripMenuItem();
        NewWrestlerMenuItem = new ToolStripMenuItem();
        NewTagTeamMenuItem = new ToolStripMenuItem();
        NewTitleMenuItem = new ToolStripMenuItem();
        NewCommentatorMenuItem = new ToolStripMenuItem();
        NewRefereeMenuItem = new ToolStripMenuItem();
        EditSelectionMenuItem = new ToolStripMenuItem();
        toolStripContainer1 = new ToolStripContainer();
        RosterTreeView = new TreeView();
        ToolStrip = new ToolStrip();
        toolStripSeparator1 = new ToolStripSeparator();
        OpenFedToolButton = new ToolStripButton();
        SaveFedToolButton = new ToolStripButton();
        ToolStripSeparator2 = new ToolStripSeparator();
        NewWrestlerToolButton = new ToolStripButton();
        NewTeamToolButton = new ToolStripButton();
        NewTitleToolButton = new ToolStripButton();
        NewCommentatorToolButton = new ToolStripButton();
        NewRefereeToolButton = new ToolStripButton();
        ToolStripSeparator3 = new ToolStripSeparator();
        EditSelectionToolButton = new ToolStripButton();
        DeleteSelectionToolButton = new ToolStripButton();
        ToolStripSeparator4 = new ToolStripSeparator();
        BookEventToolButton = new ToolStripButton();
        MenuStrip.SuspendLayout();
        toolStripContainer1.ContentPanel.SuspendLayout();
        toolStripContainer1.TopToolStripPanel.SuspendLayout();
        toolStripContainer1.SuspendLayout();
        ToolStrip.SuspendLayout();
        SuspendLayout();
        // 
        // BookEventMenuItem
        // 
        BookEventMenuItem.Name = "BookEventMenuItem";
        BookEventMenuItem.ShortcutKeys = Keys.Control | Keys.E;
        BookEventMenuItem.Size = new Size(176, 22);
        BookEventMenuItem.Text = "&Book Event";
        BookEventMenuItem.Click += BookEventMenuItem_Click;
        // 
        // TitleHistoryMenuItem
        // 
        TitleHistoryMenuItem.Name = "TitleHistoryMenuItem";
        TitleHistoryMenuItem.Size = new Size(176, 22);
        TitleHistoryMenuItem.Text = "&Title History";
        TitleHistoryMenuItem.Click += TitleHistoryMenuItem_Click;
        // 
        // RankMenuItem
        // 
        RankMenuItem.Name = "RankMenuItem";
        RankMenuItem.Size = new Size(176, 22);
        RankMenuItem.Text = "&Rank";
        RankMenuItem.Click += RankMenuItem_Click;
        // 
        // HelpMenuMenuItem
        // 
        HelpMenuMenuItem.DropDownItems.AddRange(new ToolStripItem[] { HelpMenuItem, ToolStripMenuItem4, AboutMenuItem });
        HelpMenuMenuItem.Name = "HelpMenuMenuItem";
        HelpMenuMenuItem.Size = new Size(44, 20);
        HelpMenuMenuItem.Text = "&Help";
        // 
        // HelpMenuItem
        // 
        HelpMenuItem.Name = "HelpMenuItem";
        HelpMenuItem.Size = new Size(107, 22);
        HelpMenuItem.Text = "Help";
        HelpMenuItem.Click += HelpMenuItem_Click;
        // 
        // ToolStripMenuItem4
        // 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4";
        ToolStripMenuItem4.Size = new Size(104, 6);
        // 
        // AboutMenuItem
        // 
        AboutMenuItem.Name = "AboutMenuItem";
        AboutMenuItem.Size = new Size(107, 22);
        AboutMenuItem.Text = "&About";
        AboutMenuItem.Click += AboutMenuItem_Click;
        // 
        // ToolStripMenuItem3
        // 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3";
        ToolStripMenuItem3.Size = new Size(173, 6);
        // 
        // DeleteSelectionMenuItem
        // 
        DeleteSelectionMenuItem.Name = "DeleteSelectionMenuItem";
        DeleteSelectionMenuItem.Size = new Size(176, 22);
        DeleteSelectionMenuItem.Text = "Delete Selection";
        DeleteSelectionMenuItem.Click += DeleteSelectionMenuItem_Click;
        // 
        // MenuStrip
        // 
        MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuMenuItem, ResourcesMenuMenuItem, FedMenuMenuItem, HelpMenuMenuItem });
        MenuStrip.Location = new Point(0, 0);
        MenuStrip.Name = "MenuStrip";
        MenuStrip.Padding = new Padding(7, 2, 0, 2);
        MenuStrip.Size = new Size(933, 24);
        MenuStrip.TabIndex = 3;
        MenuStrip.Text = "MenuStrip";
        // 
        // FileMenuMenuItem
        // 
        FileMenuMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, ToolStripMenuItem1, OpenMenuItem, SaveMenuItem, SaveAsMenuItem, ToolStripMenuItem2, ExitMenuItem });
        FileMenuMenuItem.Name = "FileMenuMenuItem";
        FileMenuMenuItem.Size = new Size(37, 20);
        FileMenuMenuItem.Text = "&File";
        // 
        // NewMenuItem
        // 
        NewMenuItem.Name = "NewMenuItem";
        NewMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        NewMenuItem.Size = new Size(146, 22);
        NewMenuItem.Text = "&New";
        NewMenuItem.Click += NewMenuItem_Click;
        // 
        // ToolStripMenuItem1
        // 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1";
        ToolStripMenuItem1.Size = new Size(143, 6);
        // 
        // OpenMenuItem
        // 
        OpenMenuItem.Name = "OpenMenuItem";
        OpenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        OpenMenuItem.Size = new Size(146, 22);
        OpenMenuItem.Text = "&Open";
        OpenMenuItem.Click += OpenMenuItem_Click;
        // 
        // SaveMenuItem
        // 
        SaveMenuItem.Name = "SaveMenuItem";
        SaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        SaveMenuItem.Size = new Size(146, 22);
        SaveMenuItem.Text = "&Save";
        SaveMenuItem.Click += SaveMenuItem_Click;
        // 
        // SaveAsMenuItem
        // 
        SaveAsMenuItem.Name = "SaveAsMenuItem";
        SaveAsMenuItem.Size = new Size(146, 22);
        SaveAsMenuItem.Text = "Save &As";
        SaveAsMenuItem.Click += SaveAsMenuItem_Click;
        // 
        // ToolStripMenuItem2
        // 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2";
        ToolStripMenuItem2.Size = new Size(143, 6);
        // 
        // ExitMenuItem
        // 
        ExitMenuItem.Name = "ExitMenuItem";
        ExitMenuItem.Size = new Size(146, 22);
        ExitMenuItem.Text = "&Exit";
        ExitMenuItem.Click += ExitMenuItem_Click;
        // 
        // ResourcesMenuMenuItem
        // 
        ResourcesMenuMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CommentaryMenuItem, MovesMenuItem, GimmicksMenuItem, CommercialsMenuItem, ImportZimFileMenuItem });
        ResourcesMenuMenuItem.Name = "ResourcesMenuMenuItem";
        ResourcesMenuMenuItem.Size = new Size(72, 20);
        ResourcesMenuMenuItem.Text = "&Resources";
        // 
        // CommentaryMenuItem
        // 
        CommentaryMenuItem.Name = "CommentaryMenuItem";
        CommentaryMenuItem.Size = new Size(169, 22);
        CommentaryMenuItem.Text = "&Commentary";
        CommentaryMenuItem.Click += CommentaryMenuItem_Click;
        // 
        // MovesMenuItem
        // 
        MovesMenuItem.Name = "MovesMenuItem";
        MovesMenuItem.ShortcutKeys = Keys.Control | Keys.M;
        MovesMenuItem.Size = new Size(169, 22);
        MovesMenuItem.Text = "&Moves";
        MovesMenuItem.Click += MovesMenuItem_Click;
        // 
        // GimmicksMenuItem
        // 
        GimmicksMenuItem.Name = "GimmicksMenuItem";
        GimmicksMenuItem.ShortcutKeys = Keys.Control | Keys.G;
        GimmicksMenuItem.Size = new Size(169, 22);
        GimmicksMenuItem.Text = "&Gimmicks";
        GimmicksMenuItem.Click += GimmicksMenuItem_Click;
        // 
        // CommercialsMenuItem
        // 
        CommercialsMenuItem.Name = "CommercialsMenuItem";
        CommercialsMenuItem.Size = new Size(169, 22);
        CommercialsMenuItem.Text = "Co&mmercials";
        CommercialsMenuItem.Click += CommercialsMenuItem_Click;
        // 
        // ImportZimFileMenuItem
        // 
        ImportZimFileMenuItem.Name = "ImportZimFileMenuItem";
        ImportZimFileMenuItem.Size = new Size(169, 22);
        ImportZimFileMenuItem.Text = "&Import Wrestler";
        ImportZimFileMenuItem.Click += ImportZimFileMenuItem_Click;
        // 
        // FedMenuMenuItem
        // 
        FedMenuMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FedOptionsMenuItem, NewWrestlerMenuItem, NewTagTeamMenuItem, NewTitleMenuItem, NewCommentatorMenuItem, NewRefereeMenuItem, EditSelectionMenuItem, DeleteSelectionMenuItem, ToolStripMenuItem3, BookEventMenuItem, TitleHistoryMenuItem, RankMenuItem });
        FedMenuMenuItem.Name = "FedMenuMenuItem";
        FedMenuMenuItem.Size = new Size(38, 20);
        FedMenuMenuItem.Text = "F&ed";
        // 
        // FedOptionsMenuItem
        // 
        FedOptionsMenuItem.Name = "FedOptionsMenuItem";
        FedOptionsMenuItem.Size = new Size(176, 22);
        FedOptionsMenuItem.Text = "&Fed Options";
        FedOptionsMenuItem.Click += FedOptionsMenuItem_Click;
        // 
        // NewWrestlerMenuItem
        // 
        NewWrestlerMenuItem.Name = "NewWrestlerMenuItem";
        NewWrestlerMenuItem.Size = new Size(176, 22);
        NewWrestlerMenuItem.Text = "New Wrestler";
        NewWrestlerMenuItem.Click += NewWrestlerMenuItem_Click;
        // 
        // NewTagTeamMenuItem
        // 
        NewTagTeamMenuItem.Name = "NewTagTeamMenuItem";
        NewTagTeamMenuItem.Size = new Size(176, 22);
        NewTagTeamMenuItem.Text = "New Tag Team";
        NewTagTeamMenuItem.Click += NewTagTeamMenuItem_Click;
        // 
        // NewTitleMenuItem
        // 
        NewTitleMenuItem.Name = "NewTitleMenuItem";
        NewTitleMenuItem.Size = new Size(176, 22);
        NewTitleMenuItem.Text = "New Title";
        NewTitleMenuItem.Click += NewTitleMenuItem_Click;
        // 
        // NewCommentatorMenuItem
        // 
        NewCommentatorMenuItem.Name = "NewCommentatorMenuItem";
        NewCommentatorMenuItem.Size = new Size(176, 22);
        NewCommentatorMenuItem.Text = "New Commentator";
        NewCommentatorMenuItem.Click += NewCommentatorMenuItem_Click;
        // 
        // NewRefereeMenuItem
        // 
        NewRefereeMenuItem.Name = "NewRefereeMenuItem";
        NewRefereeMenuItem.Size = new Size(176, 22);
        NewRefereeMenuItem.Text = "New Referee";
        NewRefereeMenuItem.Click += NewRefereeMenuItem_Click;
        // 
        // EditSelectionMenuItem
        // 
        EditSelectionMenuItem.Name = "EditSelectionMenuItem";
        EditSelectionMenuItem.Size = new Size(176, 22);
        EditSelectionMenuItem.Text = "Edit Selection";
        EditSelectionMenuItem.Click += EditSelectionMenuItem_Click;
        // 
        // toolStripContainer1
        // 
        // 
        // toolStripContainer1.ContentPanel
        // 
        toolStripContainer1.ContentPanel.Controls.Add(RosterTreeView);
        toolStripContainer1.ContentPanel.Size = new Size(933, 470);
        toolStripContainer1.Dock = DockStyle.Fill;
        toolStripContainer1.Location = new Point(0, 24);
        toolStripContainer1.Name = "toolStripContainer1";
        toolStripContainer1.Size = new Size(933, 495);
        toolStripContainer1.TabIndex = 6;
        toolStripContainer1.Text = "toolStripContainer1";
        // 
        // toolStripContainer1.TopToolStripPanel
        // 
        toolStripContainer1.TopToolStripPanel.Controls.Add(ToolStrip);
        toolStripContainer1.TopToolStripPanel.RenderMode = ToolStripRenderMode.System;
        // 
        // RosterTreeView
        // 
        RosterTreeView.Dock = DockStyle.Fill;
        RosterTreeView.Location = new Point(0, 0);
        RosterTreeView.Margin = new Padding(4, 3, 4, 3);
        RosterTreeView.Name = "RosterTreeView";
        RosterTreeView.ShowLines = false;
        RosterTreeView.ShowPlusMinus = false;
        RosterTreeView.ShowRootLines = false;
        RosterTreeView.Size = new Size(933, 470);
        RosterTreeView.TabIndex = 6;
        RosterTreeView.AfterCollapse += RosterTreeView_AfterCollapse;
        RosterTreeView.BeforeExpand += RosterTreeView_BeforeExpand;
        RosterTreeView.NodeMouseClick += RosterTreeView_NodeMouseClick;
        RosterTreeView.NodeMouseDoubleClick += RosterTreeView_NodeMouseDoubleClick;
        RosterTreeView.KeyDown += RosterTreeView_KeyDown;
        // 
        // ToolStrip
        // 
        ToolStrip.Dock = DockStyle.None;
        ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
        ToolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, OpenFedToolButton, SaveFedToolButton, ToolStripSeparator2, NewWrestlerToolButton, NewTeamToolButton, NewTitleToolButton, NewCommentatorToolButton, NewRefereeToolButton, ToolStripSeparator3, EditSelectionToolButton, DeleteSelectionToolButton, ToolStripSeparator4, BookEventToolButton });
        ToolStrip.Location = new Point(3, 0);
        ToolStrip.Name = "ToolStrip";
        ToolStrip.RenderMode = ToolStripRenderMode.System;
        ToolStrip.Size = new Size(257, 25);
        ToolStrip.TabIndex = 5;
        ToolStrip.Text = "ToolStrip";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 25);
        // 
        // OpenFedToolButton
        // 
        OpenFedToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        OpenFedToolButton.Image = Properties.Resources.open;
        OpenFedToolButton.ImageScaling = ToolStripItemImageScaling.None;
        OpenFedToolButton.ImageTransparentColor = Color.Magenta;
        OpenFedToolButton.Name = "OpenFedToolButton";
        OpenFedToolButton.Size = new Size(23, 22);
        OpenFedToolButton.ToolTipText = "Open Fed";
        OpenFedToolButton.Click += OpenFedToolButton_Click;
        // 
        // SaveFedToolButton
        // 
        SaveFedToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        SaveFedToolButton.Image = Properties.Resources.save;
        SaveFedToolButton.ImageScaling = ToolStripItemImageScaling.None;
        SaveFedToolButton.ImageTransparentColor = Color.Magenta;
        SaveFedToolButton.Name = "SaveFedToolButton";
        SaveFedToolButton.Size = new Size(23, 22);
        SaveFedToolButton.ToolTipText = "Save Fed";
        SaveFedToolButton.Click += SaveFedToolButton_Click;
        // 
        // ToolStripSeparator2
        // 
        ToolStripSeparator2.Name = "ToolStripSeparator2";
        ToolStripSeparator2.Size = new Size(6, 25);
        // 
        // NewWrestlerToolButton
        // 
        NewWrestlerToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        NewWrestlerToolButton.Image = Properties.Resources.wrestler;
        NewWrestlerToolButton.ImageScaling = ToolStripItemImageScaling.None;
        NewWrestlerToolButton.ImageTransparentColor = Color.Magenta;
        NewWrestlerToolButton.Name = "NewWrestlerToolButton";
        NewWrestlerToolButton.Size = new Size(23, 22);
        NewWrestlerToolButton.ToolTipText = "New Wrestler";
        NewWrestlerToolButton.Click += NewWrestlerToolButton_Click;
        // 
        // NewTeamToolButton
        // 
        NewTeamToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        NewTeamToolButton.Image = Properties.Resources.tag_team;
        NewTeamToolButton.ImageScaling = ToolStripItemImageScaling.None;
        NewTeamToolButton.ImageTransparentColor = Color.Magenta;
        NewTeamToolButton.Name = "NewTeamToolButton";
        NewTeamToolButton.Size = new Size(23, 22);
        NewTeamToolButton.ToolTipText = "New Tag Team";
        NewTeamToolButton.Click += NewTeamToolButton_Click;
        // 
        // NewTitleToolButton
        // 
        NewTitleToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        NewTitleToolButton.Image = Properties.Resources.title_belt;
        NewTitleToolButton.ImageScaling = ToolStripItemImageScaling.None;
        NewTitleToolButton.ImageTransparentColor = Color.Magenta;
        NewTitleToolButton.Name = "NewTitleToolButton";
        NewTitleToolButton.Size = new Size(23, 22);
        NewTitleToolButton.ToolTipText = "New Title Belt";
        NewTitleToolButton.Click += NewTitleToolButton_Click;
        // 
        // NewCommentatorToolButton
        // 
        NewCommentatorToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        NewCommentatorToolButton.Image = Properties.Resources.commentator;
        NewCommentatorToolButton.ImageScaling = ToolStripItemImageScaling.None;
        NewCommentatorToolButton.ImageTransparentColor = Color.Magenta;
        NewCommentatorToolButton.Name = "NewCommentatorToolButton";
        NewCommentatorToolButton.Size = new Size(23, 22);
        NewCommentatorToolButton.ToolTipText = "New Commentator";
        NewCommentatorToolButton.Click += NewCommentatorToolButton_Click;
        // 
        // NewRefereeToolButton
        // 
        NewRefereeToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        NewRefereeToolButton.Image = Properties.Resources.referee;
        NewRefereeToolButton.ImageScaling = ToolStripItemImageScaling.None;
        NewRefereeToolButton.ImageTransparentColor = Color.Magenta;
        NewRefereeToolButton.Name = "NewRefereeToolButton";
        NewRefereeToolButton.Size = new Size(23, 22);
        NewRefereeToolButton.ToolTipText = "New Referee";
        NewRefereeToolButton.Click += NewRefereeToolButton_Click;
        // 
        // ToolStripSeparator3
        // 
        ToolStripSeparator3.Name = "ToolStripSeparator3";
        ToolStripSeparator3.Size = new Size(6, 25);
        // 
        // EditSelectionToolButton
        // 
        EditSelectionToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        EditSelectionToolButton.Image = Properties.Resources.edit;
        EditSelectionToolButton.ImageScaling = ToolStripItemImageScaling.None;
        EditSelectionToolButton.ImageTransparentColor = Color.Magenta;
        EditSelectionToolButton.Name = "EditSelectionToolButton";
        EditSelectionToolButton.Size = new Size(23, 22);
        EditSelectionToolButton.ToolTipText = "Edit Selection";
        EditSelectionToolButton.Click += EditSelectionToolButton_Click;
        // 
        // DeleteSelectionToolButton
        // 
        DeleteSelectionToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        DeleteSelectionToolButton.Image = Properties.Resources.delete;
        DeleteSelectionToolButton.ImageScaling = ToolStripItemImageScaling.None;
        DeleteSelectionToolButton.ImageTransparentColor = Color.Magenta;
        DeleteSelectionToolButton.Name = "DeleteSelectionToolButton";
        DeleteSelectionToolButton.Size = new Size(23, 22);
        DeleteSelectionToolButton.ToolTipText = "Delete Selection";
        DeleteSelectionToolButton.Click += DeleteSelectionToolButton_Click;
        // 
        // ToolStripSeparator4
        // 
        ToolStripSeparator4.Name = "ToolStripSeparator4";
        ToolStripSeparator4.Size = new Size(6, 25);
        // 
        // BookEventToolButton
        // 
        BookEventToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        BookEventToolButton.Image = Properties.Resources.ring;
        BookEventToolButton.ImageScaling = ToolStripItemImageScaling.None;
        BookEventToolButton.ImageTransparentColor = Color.Magenta;
        BookEventToolButton.Name = "BookEventToolButton";
        BookEventToolButton.Size = new Size(23, 22);
        BookEventToolButton.ToolTipText = "Book Event";
        BookEventToolButton.Click += BookEventToolButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(933, 519);
        Controls.Add(toolStripContainer1);
        Controls.Add(MenuStrip);
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        StartPosition = FormStartPosition.WindowsDefaultBounds;
        Text = "Ares Pro ";
        FormClosing += MainForm_FormClosing;
        MenuStrip.ResumeLayout(false);
        MenuStrip.PerformLayout();
        toolStripContainer1.ContentPanel.ResumeLayout(false);
        toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
        toolStripContainer1.TopToolStripPanel.PerformLayout();
        toolStripContainer1.ResumeLayout(false);
        toolStripContainer1.PerformLayout();
        ToolStrip.ResumeLayout(false);
        ToolStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    internal System.Windows.Forms.ToolStripMenuItem BookEventMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem TitleHistoryMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem RankMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem HelpMenuMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
    internal System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
    internal System.Windows.Forms.ToolStripMenuItem DeleteSelectionMenuItem;
    internal System.Windows.Forms.MenuStrip MenuStrip;
    internal System.Windows.Forms.ToolStripMenuItem FileMenuMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem NewMenuItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
    internal System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
    internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
    internal System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem ResourcesMenuMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem CommentaryMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem MovesMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem GimmicksMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem CommercialsMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem ImportZimFileMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem FedMenuMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem FedOptionsMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem NewWrestlerMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem NewTagTeamMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem NewTitleMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem NewCommentatorMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem NewRefereeMenuItem;
    internal System.Windows.Forms.ToolStripMenuItem EditSelectionMenuItem;
    private ToolStripContainer toolStripContainer1;
    internal TreeView RosterTreeView;
    internal ToolStrip ToolStrip;
    internal ToolStripButton OpenFedToolButton;
    internal ToolStripButton SaveFedToolButton;
    internal ToolStripSeparator ToolStripSeparator2;
    internal ToolStripButton NewWrestlerToolButton;
    internal ToolStripButton NewTeamToolButton;
    internal ToolStripButton NewTitleToolButton;
    internal ToolStripButton NewCommentatorToolButton;
    internal ToolStripButton NewRefereeToolButton;
    internal ToolStripSeparator ToolStripSeparator3;
    internal ToolStripButton EditSelectionToolButton;
    internal ToolStripButton DeleteSelectionToolButton;
    internal ToolStripSeparator ToolStripSeparator4;
    internal ToolStripButton BookEventToolButton;
    private ToolStripSeparator toolStripSeparator1;
}
