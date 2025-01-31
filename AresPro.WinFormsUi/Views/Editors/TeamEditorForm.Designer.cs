namespace AresPro.WinFormsUi.Views.Editors;

partial class TeamEditorForm
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
        OkButton = new Button();
        MembersListBox = new ListBox();
        RemoveMemberButton = new Button();
        AddMemberButton = new Button();
        grpMembers = new GroupBox();
        AddTitleButton = new Button();
        grpStats = new GroupBox();
        LosesTextBox = new TextBox();
        lblLoses = new Label();
        WinsTextBox = new TextBox();
        lblWins = new Label();
        TitlesListBox = new ListBox();
        RemoveTitleButton = new Button();
        CancelationButton = new Button();
        grpTitles = new GroupBox();
        EscortInterferesCheckBox = new CheckBox();
        EscortComboBox = new ComboBox();
        lblEscort = new Label();
        IntroductionTextBox = new TextBox();
        lblRingIntro = new Label();
        FinisherTextBox = new TextBox();
        lblFinisher = new Label();
        NameTextBox = new TextBox();
        lblName = new Label();
        grpMembers.SuspendLayout();
        grpStats.SuspendLayout();
        grpTitles.SuspendLayout();
        SuspendLayout();
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(375, 310);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(68, 27);
        OkButton.TabIndex = 13;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // MembersListBox
        // 
        MembersListBox.DisplayMember = "Value";
        MembersListBox.FormattingEnabled = true;
        MembersListBox.ItemHeight = 15;
        MembersListBox.Location = new Point(7, 22);
        MembersListBox.Margin = new Padding(4, 3, 4, 3);
        MembersListBox.Name = "MembersListBox";
        MembersListBox.Size = new Size(205, 169);
        MembersListBox.TabIndex = 10;
        MembersListBox.ValueMember = "Key";
        // 
        // RemoveMemberButton
        // 
        RemoveMemberButton.Location = new Point(113, 198);
        RemoveMemberButton.Margin = new Padding(4, 3, 4, 3);
        RemoveMemberButton.Name = "RemoveMemberButton";
        RemoveMemberButton.Size = new Size(99, 27);
        RemoveMemberButton.TabIndex = 12;
        RemoveMemberButton.Text = "Remove";
        RemoveMemberButton.UseVisualStyleBackColor = true;
        RemoveMemberButton.Click += RemoveMemberButton_Click;
        // 
        // AddMemberButton
        // 
        AddMemberButton.Location = new Point(7, 198);
        AddMemberButton.Margin = new Padding(4, 3, 4, 3);
        AddMemberButton.Name = "AddMemberButton";
        AddMemberButton.Size = new Size(99, 27);
        AddMemberButton.TabIndex = 11;
        AddMemberButton.Text = "Add";
        AddMemberButton.UseVisualStyleBackColor = true;
        AddMemberButton.Click += AddMemberButton_Click;
        // 
        // grpMembers
        // 
        grpMembers.Controls.Add(MembersListBox);
        grpMembers.Controls.Add(RemoveMemberButton);
        grpMembers.Controls.Add(AddMemberButton);
        grpMembers.Location = new Point(13, 99);
        grpMembers.Margin = new Padding(4, 3, 4, 3);
        grpMembers.Name = "grpMembers";
        grpMembers.Padding = new Padding(4, 3, 4, 3);
        grpMembers.Size = new Size(219, 232);
        grpMembers.TabIndex = 20;
        grpMembers.TabStop = false;
        grpMembers.Text = "Team Members";
        // 
        // AddTitleButton
        // 
        AddTitleButton.Location = new Point(208, 27);
        AddTitleButton.Margin = new Padding(4, 3, 4, 3);
        AddTitleButton.Name = "AddTitleButton";
        AddTitleButton.Size = new Size(64, 27);
        AddTitleButton.TabIndex = 4;
        AddTitleButton.Text = "Add";
        AddTitleButton.UseVisualStyleBackColor = true;
        AddTitleButton.Click += AddTitleButton_Click;
        // 
        // grpStats
        // 
        grpStats.Controls.Add(LosesTextBox);
        grpStats.Controls.Add(lblLoses);
        grpStats.Controls.Add(WinsTextBox);
        grpStats.Controls.Add(lblWins);
        grpStats.Location = new Point(240, 198);
        grpStats.Margin = new Padding(4, 3, 4, 3);
        grpStats.Name = "grpStats";
        grpStats.Padding = new Padding(4, 3, 4, 3);
        grpStats.Size = new Size(279, 52);
        grpStats.TabIndex = 22;
        grpStats.TabStop = false;
        grpStats.Text = "Stats";
        // 
        // LosesTextBox
        // 
        LosesTextBox.Location = new Point(153, 22);
        LosesTextBox.Margin = new Padding(4, 3, 4, 3);
        LosesTextBox.Name = "LosesTextBox";
        LosesTextBox.Size = new Size(47, 23);
        LosesTextBox.TabIndex = 7;
        // 
        // lblLoses
        // 
        lblLoses.AutoSize = true;
        lblLoses.Location = new Point(105, 25);
        lblLoses.Margin = new Padding(4, 0, 4, 0);
        lblLoses.Name = "lblLoses";
        lblLoses.Size = new Size(36, 15);
        lblLoses.TabIndex = 2;
        lblLoses.Text = "Loses";
        // 
        // WinsTextBox
        // 
        WinsTextBox.Location = new Point(50, 22);
        WinsTextBox.Margin = new Padding(4, 3, 4, 3);
        WinsTextBox.Name = "WinsTextBox";
        WinsTextBox.Size = new Size(47, 23);
        WinsTextBox.TabIndex = 6;
        // 
        // lblWins
        // 
        lblWins.AutoSize = true;
        lblWins.Location = new Point(7, 25);
        lblWins.Margin = new Padding(4, 0, 4, 0);
        lblWins.Name = "lblWins";
        lblWins.Size = new Size(33, 15);
        lblWins.TabIndex = 0;
        lblWins.Text = "Wins";
        // 
        // TitlesListBox
        // 
        TitlesListBox.DisplayMember = "Value";
        TitlesListBox.FormattingEnabled = true;
        TitlesListBox.ItemHeight = 15;
        TitlesListBox.Location = new Point(7, 22);
        TitlesListBox.Margin = new Padding(4, 3, 4, 3);
        TitlesListBox.Name = "TitlesListBox";
        TitlesListBox.Size = new Size(193, 64);
        TitlesListBox.TabIndex = 3;
        TitlesListBox.ValueMember = "Key";
        // 
        // RemoveTitleButton
        // 
        RemoveTitleButton.Location = new Point(208, 60);
        RemoveTitleButton.Margin = new Padding(4, 3, 4, 3);
        RemoveTitleButton.Name = "RemoveTitleButton";
        RemoveTitleButton.Size = new Size(64, 27);
        RemoveTitleButton.TabIndex = 5;
        RemoveTitleButton.Text = "Remove";
        RemoveTitleButton.UseVisualStyleBackColor = true;
        RemoveTitleButton.Click += RemoveTitleButton_Click;
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(451, 310);
        CancelationButton.Margin = new Padding(4, 3, 4, 3);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(68, 27);
        CancelationButton.TabIndex = 14;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // grpTitles
        // 
        grpTitles.Controls.Add(TitlesListBox);
        grpTitles.Controls.Add(RemoveTitleButton);
        grpTitles.Controls.Add(AddTitleButton);
        grpTitles.Location = new Point(240, 99);
        grpTitles.Margin = new Padding(4, 3, 4, 3);
        grpTitles.Name = "grpTitles";
        grpTitles.Padding = new Padding(4, 3, 4, 3);
        grpTitles.Size = new Size(279, 93);
        grpTitles.TabIndex = 21;
        grpTitles.TabStop = false;
        grpTitles.Text = "Titles";
        // 
        // EscortInterferesCheckBox
        // 
        EscortInterferesCheckBox.AutoSize = true;
        EscortInterferesCheckBox.Location = new Point(409, 285);
        EscortInterferesCheckBox.Margin = new Padding(4, 3, 4, 3);
        EscortInterferesCheckBox.Name = "EscortInterferesCheckBox";
        EscortInterferesCheckBox.Size = new Size(110, 19);
        EscortInterferesCheckBox.TabIndex = 9;
        EscortInterferesCheckBox.Text = "Escort Interferes";
        EscortInterferesCheckBox.UseVisualStyleBackColor = true;
        // 
        // EscortComboBox
        // 
        EscortComboBox.DisplayMember = "Value";
        EscortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        EscortComboBox.FormattingEnabled = true;
        EscortComboBox.Location = new Point(287, 256);
        EscortComboBox.Margin = new Padding(4, 3, 4, 3);
        EscortComboBox.Name = "EscortComboBox";
        EscortComboBox.Size = new Size(232, 23);
        EscortComboBox.TabIndex = 8;
        EscortComboBox.ValueMember = "Key";
        // 
        // lblEscort
        // 
        lblEscort.AutoSize = true;
        lblEscort.Location = new Point(240, 259);
        lblEscort.Margin = new Padding(4, 0, 4, 0);
        lblEscort.Name = "lblEscort";
        lblEscort.Size = new Size(39, 15);
        lblEscort.TabIndex = 23;
        lblEscort.Text = "Escort";
        // 
        // IntroductionTextBox
        // 
        IntroductionTextBox.Location = new Point(94, 70);
        IntroductionTextBox.Margin = new Padding(4, 3, 4, 3);
        IntroductionTextBox.Name = "IntroductionTextBox";
        IntroductionTextBox.Size = new Size(425, 23);
        IntroductionTextBox.TabIndex = 2;
        // 
        // lblRingIntro
        // 
        lblRingIntro.AutoSize = true;
        lblRingIntro.Location = new Point(13, 73);
        lblRingIntro.Margin = new Padding(4, 0, 4, 0);
        lblRingIntro.Name = "lblRingIntro";
        lblRingIntro.Size = new Size(73, 15);
        lblRingIntro.TabIndex = 18;
        lblRingIntro.Text = "Introduction";
        // 
        // FinisherTextBox
        // 
        FinisherTextBox.Location = new Point(94, 41);
        FinisherTextBox.Margin = new Padding(4, 3, 4, 3);
        FinisherTextBox.Name = "FinisherTextBox";
        FinisherTextBox.Size = new Size(425, 23);
        FinisherTextBox.TabIndex = 1;
        // 
        // lblFinisher
        // 
        lblFinisher.AutoSize = true;
        lblFinisher.Location = new Point(13, 44);
        lblFinisher.Margin = new Padding(4, 0, 4, 0);
        lblFinisher.Name = "lblFinisher";
        lblFinisher.Size = new Size(48, 15);
        lblFinisher.TabIndex = 16;
        lblFinisher.Text = "Finisher";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(94, 12);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(425, 23);
        NameTextBox.TabIndex = 0;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(13, 15);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(70, 15);
        lblName.TabIndex = 14;
        lblName.Text = "Team Name";
        // 
        // TeamEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(532, 349);
        Controls.Add(OkButton);
        Controls.Add(grpMembers);
        Controls.Add(grpStats);
        Controls.Add(CancelationButton);
        Controls.Add(grpTitles);
        Controls.Add(EscortInterferesCheckBox);
        Controls.Add(EscortComboBox);
        Controls.Add(lblEscort);
        Controls.Add(IntroductionTextBox);
        Controls.Add(lblRingIntro);
        Controls.Add(FinisherTextBox);
        Controls.Add(lblFinisher);
        Controls.Add(NameTextBox);
        Controls.Add(lblName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TeamEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Team";
        FormClosing += TeamEditorForm_FormClosing;
        grpMembers.ResumeLayout(false);
        grpStats.ResumeLayout(false);
        grpStats.PerformLayout();
        grpTitles.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.ListBox MembersListBox;
    internal System.Windows.Forms.Button RemoveMemberButton;
    internal System.Windows.Forms.Button AddMemberButton;
    internal System.Windows.Forms.GroupBox grpMembers;
    internal System.Windows.Forms.Button AddTitleButton;
    internal System.Windows.Forms.GroupBox grpStats;
    internal System.Windows.Forms.TextBox LosesTextBox;
    internal System.Windows.Forms.Label lblLoses;
    internal System.Windows.Forms.TextBox WinsTextBox;
    internal System.Windows.Forms.Label lblWins;
    internal System.Windows.Forms.ListBox TitlesListBox;
    internal System.Windows.Forms.Button RemoveTitleButton;
    internal System.Windows.Forms.Button CancelationButton;
    internal System.Windows.Forms.GroupBox grpTitles;
    internal System.Windows.Forms.CheckBox EscortInterferesCheckBox;
    internal System.Windows.Forms.ComboBox EscortComboBox;
    internal System.Windows.Forms.Label lblEscort;
    internal System.Windows.Forms.TextBox IntroductionTextBox;
    internal System.Windows.Forms.Label lblRingIntro;
    internal System.Windows.Forms.TextBox FinisherTextBox;
    internal System.Windows.Forms.Label lblFinisher;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.Label lblName;
}
