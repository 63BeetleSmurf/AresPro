namespace AresPro.WinFormsUi.Views.Editors;

partial class WrestlerEditorForm
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
        HeightTextBox = new TextBox();
        grpStats = new GroupBox();
        CharismaDecreaseButton = new Button();
        CharismaIncreaseButton = new Button();
        CharismaProgressBar = new ProgressBar();
        VitalityDecreaseButton = new Button();
        VitalityIncreaseButton = new Button();
        VitalityProgressBar = new ProgressBar();
        SpeedDecreaseButton = new Button();
        SpeedIncreaseButton = new Button();
        SpeedProgressBar = new ProgressBar();
        StrengthDecreaseButton = new Button();
        StrengthIncreaseButton = new Button();
        LosesTextBox = new TextBox();
        StrengthProgressBar = new ProgressBar();
        WeightTextBox = new TextBox();
        lblLoses = new Label();
        WinsTextBox = new TextBox();
        lblWins = new Label();
        lblHeight = new Label();
        lblWeight = new Label();
        lblStrength = new Label();
        lblSpeed = new Label();
        lblVitality = new Label();
        lblCharisma = new Label();
        AddMoveButton = new Button();
        RemoveMoveButton = new Button();
        EditMoveButton = new Button();
        MovesListBox = new ListBox();
        grpMoves = new GroupBox();
        CancelButton = new Button();
        OkButton = new Button();
        ExportZimButton = new Button();
        ExportHTMLButton = new Button();
        grpTitles = new GroupBox();
        TitlesListBox = new ListBox();
        RemoveTitleButton = new Button();
        AddTitleButton = new Button();
        EscortInterferesCheckBox = new CheckBox();
        PushTextBox = new TextBox();
        lblPush = new Label();
        EscortComboBox = new ComboBox();
        lblEscort = new Label();
        RingIntroTextBox = new TextBox();
        lblRingIntro = new Label();
        StableTextBox = new TextBox();
        lblStable = new Label();
        AffiliationComboBox = new ComboBox();
        lblAffiliation = new Label();
        HometownTextBox = new TextBox();
        lblHometown = new Label();
        NamesTextBox = new TextBox();
        lblNames = new Label();
        grpStats.SuspendLayout();
        grpMoves.SuspendLayout();
        grpTitles.SuspendLayout();
        SuspendLayout();
        // 
        // HeightTextBox
        // 
        HeightTextBox.Location = new Point(62, 138);
        HeightTextBox.Margin = new Padding(4, 3, 4, 3);
        HeightTextBox.MaxLength = 5;
        HeightTextBox.Name = "HeightTextBox";
        HeightTextBox.Size = new Size(47, 23);
        HeightTextBox.TabIndex = 24;
        // 
        // grpStats
        // 
        grpStats.Controls.Add(CharismaDecreaseButton);
        grpStats.Controls.Add(CharismaIncreaseButton);
        grpStats.Controls.Add(CharismaProgressBar);
        grpStats.Controls.Add(VitalityDecreaseButton);
        grpStats.Controls.Add(VitalityIncreaseButton);
        grpStats.Controls.Add(VitalityProgressBar);
        grpStats.Controls.Add(SpeedDecreaseButton);
        grpStats.Controls.Add(SpeedIncreaseButton);
        grpStats.Controls.Add(SpeedProgressBar);
        grpStats.Controls.Add(StrengthDecreaseButton);
        grpStats.Controls.Add(HeightTextBox);
        grpStats.Controls.Add(StrengthIncreaseButton);
        grpStats.Controls.Add(LosesTextBox);
        grpStats.Controls.Add(StrengthProgressBar);
        grpStats.Controls.Add(WeightTextBox);
        grpStats.Controls.Add(lblLoses);
        grpStats.Controls.Add(WinsTextBox);
        grpStats.Controls.Add(lblWins);
        grpStats.Controls.Add(lblHeight);
        grpStats.Controls.Add(lblWeight);
        grpStats.Controls.Add(lblStrength);
        grpStats.Controls.Add(lblSpeed);
        grpStats.Controls.Add(lblVitality);
        grpStats.Controls.Add(lblCharisma);
        grpStats.Location = new Point(13, 12);
        grpStats.Margin = new Padding(4, 3, 4, 3);
        grpStats.Name = "grpStats";
        grpStats.Padding = new Padding(4, 3, 4, 3);
        grpStats.Size = new Size(213, 167);
        grpStats.TabIndex = 38;
        grpStats.TabStop = false;
        grpStats.Text = "Stats";
        // 
        // CharismaDecreaseButton
        // 
        CharismaDecreaseButton.Location = new Point(72, 88);
        CharismaDecreaseButton.Name = "CharismaDecreaseButton";
        CharismaDecreaseButton.Size = new Size(15, 15);
        CharismaDecreaseButton.TabIndex = 20;
        CharismaDecreaseButton.UseVisualStyleBackColor = true;
        CharismaDecreaseButton.Click += CharismaDecreaseButton_Click;
        // 
        // CharismaIncreaseButton
        // 
        CharismaIncreaseButton.Location = new Point(190, 88);
        CharismaIncreaseButton.Name = "CharismaIncreaseButton";
        CharismaIncreaseButton.Size = new Size(15, 15);
        CharismaIncreaseButton.TabIndex = 22;
        CharismaIncreaseButton.UseVisualStyleBackColor = true;
        CharismaIncreaseButton.Click += CharismaIncreaseButton_Click;
        // 
        // CharismaProgressBar
        // 
        CharismaProgressBar.Location = new Point(93, 88);
        CharismaProgressBar.Name = "CharismaProgressBar";
        CharismaProgressBar.Size = new Size(91, 15);
        CharismaProgressBar.TabIndex = 21;
        // 
        // VitalityDecreaseButton
        // 
        VitalityDecreaseButton.Location = new Point(72, 68);
        VitalityDecreaseButton.Name = "VitalityDecreaseButton";
        VitalityDecreaseButton.Size = new Size(15, 15);
        VitalityDecreaseButton.TabIndex = 17;
        VitalityDecreaseButton.UseVisualStyleBackColor = true;
        VitalityDecreaseButton.Click += VitalityDecreaseButton_Click;
        // 
        // VitalityIncreaseButton
        // 
        VitalityIncreaseButton.Location = new Point(190, 67);
        VitalityIncreaseButton.Name = "VitalityIncreaseButton";
        VitalityIncreaseButton.Size = new Size(15, 15);
        VitalityIncreaseButton.TabIndex = 19;
        VitalityIncreaseButton.UseVisualStyleBackColor = true;
        VitalityIncreaseButton.Click += VitalityIncreaseButton_Click;
        // 
        // VitalityProgressBar
        // 
        VitalityProgressBar.Location = new Point(93, 67);
        VitalityProgressBar.Name = "VitalityProgressBar";
        VitalityProgressBar.Size = new Size(91, 15);
        VitalityProgressBar.TabIndex = 18;
        // 
        // SpeedDecreaseButton
        // 
        SpeedDecreaseButton.Location = new Point(72, 47);
        SpeedDecreaseButton.Name = "SpeedDecreaseButton";
        SpeedDecreaseButton.Size = new Size(15, 15);
        SpeedDecreaseButton.TabIndex = 14;
        SpeedDecreaseButton.UseVisualStyleBackColor = true;
        SpeedDecreaseButton.Click += SpeedDecreaseButton_Click;
        // 
        // SpeedIncreaseButton
        // 
        SpeedIncreaseButton.Location = new Point(190, 46);
        SpeedIncreaseButton.Name = "SpeedIncreaseButton";
        SpeedIncreaseButton.Size = new Size(15, 15);
        SpeedIncreaseButton.TabIndex = 16;
        SpeedIncreaseButton.UseVisualStyleBackColor = true;
        SpeedIncreaseButton.Click += SpeedIncreaseButton_Click;
        // 
        // SpeedProgressBar
        // 
        SpeedProgressBar.Location = new Point(93, 46);
        SpeedProgressBar.Name = "SpeedProgressBar";
        SpeedProgressBar.Size = new Size(91, 15);
        SpeedProgressBar.TabIndex = 15;
        // 
        // StrengthDecreaseButton
        // 
        StrengthDecreaseButton.Location = new Point(72, 25);
        StrengthDecreaseButton.Name = "StrengthDecreaseButton";
        StrengthDecreaseButton.Size = new Size(15, 15);
        StrengthDecreaseButton.TabIndex = 11;
        StrengthDecreaseButton.UseVisualStyleBackColor = true;
        StrengthDecreaseButton.Click += StrengthDecreaseButton_Click;
        // 
        // StrengthIncreaseButton
        // 
        StrengthIncreaseButton.Location = new Point(190, 25);
        StrengthIncreaseButton.Name = "StrengthIncreaseButton";
        StrengthIncreaseButton.Size = new Size(15, 15);
        StrengthIncreaseButton.TabIndex = 13;
        StrengthIncreaseButton.UseVisualStyleBackColor = true;
        StrengthIncreaseButton.Click += StrengthIncreaseButton_Click;
        // 
        // LosesTextBox
        // 
        LosesTextBox.Location = new Point(158, 138);
        LosesTextBox.Margin = new Padding(4, 3, 4, 3);
        LosesTextBox.MaxLength = 4;
        LosesTextBox.Name = "LosesTextBox";
        LosesTextBox.Size = new Size(47, 23);
        LosesTextBox.TabIndex = 26;
        // 
        // StrengthProgressBar
        // 
        StrengthProgressBar.Location = new Point(93, 25);
        StrengthProgressBar.Name = "StrengthProgressBar";
        StrengthProgressBar.Size = new Size(91, 15);
        StrengthProgressBar.TabIndex = 12;
        // 
        // WeightTextBox
        // 
        WeightTextBox.Location = new Point(62, 109);
        WeightTextBox.Margin = new Padding(4, 3, 4, 3);
        WeightTextBox.MaxLength = 5;
        WeightTextBox.Name = "WeightTextBox";
        WeightTextBox.Size = new Size(47, 23);
        WeightTextBox.TabIndex = 23;
        // 
        // lblLoses
        // 
        lblLoses.AutoSize = true;
        lblLoses.Location = new Point(114, 141);
        lblLoses.Margin = new Padding(4, 0, 4, 0);
        lblLoses.Name = "lblLoses";
        lblLoses.Size = new Size(36, 15);
        lblLoses.TabIndex = 14;
        lblLoses.Text = "Loses";
        // 
        // WinsTextBox
        // 
        WinsTextBox.Location = new Point(158, 109);
        WinsTextBox.Margin = new Padding(4, 3, 4, 3);
        WinsTextBox.MaxLength = 4;
        WinsTextBox.Name = "WinsTextBox";
        WinsTextBox.Size = new Size(47, 23);
        WinsTextBox.TabIndex = 25;
        // 
        // lblWins
        // 
        lblWins.AutoSize = true;
        lblWins.Location = new Point(114, 112);
        lblWins.Margin = new Padding(4, 0, 4, 0);
        lblWins.Name = "lblWins";
        lblWins.Size = new Size(33, 15);
        lblWins.TabIndex = 12;
        lblWins.Text = "Wins";
        // 
        // lblHeight
        // 
        lblHeight.AutoSize = true;
        lblHeight.Location = new Point(8, 141);
        lblHeight.Margin = new Padding(4, 0, 4, 0);
        lblHeight.Name = "lblHeight";
        lblHeight.Size = new Size(43, 15);
        lblHeight.TabIndex = 10;
        lblHeight.Text = "Height";
        // 
        // lblWeight
        // 
        lblWeight.AutoSize = true;
        lblWeight.Location = new Point(8, 112);
        lblWeight.Margin = new Padding(4, 0, 4, 0);
        lblWeight.Name = "lblWeight";
        lblWeight.Size = new Size(45, 15);
        lblWeight.TabIndex = 8;
        lblWeight.Text = "Weight";
        // 
        // lblStrength
        // 
        lblStrength.AutoSize = true;
        lblStrength.Location = new Point(8, 25);
        lblStrength.Margin = new Padding(4, 0, 4, 0);
        lblStrength.Name = "lblStrength";
        lblStrength.Size = new Size(52, 15);
        lblStrength.TabIndex = 0;
        lblStrength.Text = "Strength";
        // 
        // lblSpeed
        // 
        lblSpeed.AutoSize = true;
        lblSpeed.Location = new Point(8, 46);
        lblSpeed.Margin = new Padding(4, 0, 4, 0);
        lblSpeed.Name = "lblSpeed";
        lblSpeed.Size = new Size(39, 15);
        lblSpeed.TabIndex = 2;
        lblSpeed.Text = "Speed";
        // 
        // lblVitality
        // 
        lblVitality.AutoSize = true;
        lblVitality.Location = new Point(8, 68);
        lblVitality.Margin = new Padding(4, 0, 4, 0);
        lblVitality.Name = "lblVitality";
        lblVitality.Size = new Size(43, 15);
        lblVitality.TabIndex = 4;
        lblVitality.Text = "Vitality";
        // 
        // lblCharisma
        // 
        lblCharisma.AutoSize = true;
        lblCharisma.Location = new Point(8, 88);
        lblCharisma.Margin = new Padding(4, 0, 4, 0);
        lblCharisma.Name = "lblCharisma";
        lblCharisma.Size = new Size(57, 15);
        lblCharisma.TabIndex = 6;
        lblCharisma.Text = "Charisma";
        // 
        // AddMoveButton
        // 
        AddMoveButton.Location = new Point(8, 122);
        AddMoveButton.Margin = new Padding(4, 3, 4, 3);
        AddMoveButton.Name = "AddMoveButton";
        AddMoveButton.Size = new Size(60, 27);
        AddMoveButton.TabIndex = 28;
        AddMoveButton.Text = "Add";
        AddMoveButton.UseVisualStyleBackColor = true;
        AddMoveButton.Click += AddMoveButton_Click;
        // 
        // RemoveMoveButton
        // 
        RemoveMoveButton.Location = new Point(145, 122);
        RemoveMoveButton.Margin = new Padding(4, 3, 4, 3);
        RemoveMoveButton.Name = "RemoveMoveButton";
        RemoveMoveButton.Size = new Size(60, 27);
        RemoveMoveButton.TabIndex = 30;
        RemoveMoveButton.Text = "Remove";
        RemoveMoveButton.UseVisualStyleBackColor = true;
        RemoveMoveButton.Click += RemoveMoveButton_Click;
        // 
        // EditMoveButton
        // 
        EditMoveButton.Location = new Point(76, 122);
        EditMoveButton.Margin = new Padding(4, 3, 4, 3);
        EditMoveButton.Name = "EditMoveButton";
        EditMoveButton.Size = new Size(61, 27);
        EditMoveButton.TabIndex = 29;
        EditMoveButton.Text = "Edit";
        EditMoveButton.UseVisualStyleBackColor = true;
        EditMoveButton.Click += EditMoveButton_Click;
        // 
        // MovesListBox
        // 
        MovesListBox.DisplayMember = "Value";
        MovesListBox.FormattingEnabled = true;
        MovesListBox.ItemHeight = 15;
        MovesListBox.Location = new Point(8, 22);
        MovesListBox.Margin = new Padding(4, 3, 4, 3);
        MovesListBox.Name = "MovesListBox";
        MovesListBox.Size = new Size(197, 94);
        MovesListBox.TabIndex = 27;
        MovesListBox.ValueMember = "Key";
        MovesListBox.MouseDoubleClick += MovesListBox_MouseDoubleClick;
        // 
        // grpMoves
        // 
        grpMoves.Controls.Add(RemoveMoveButton);
        grpMoves.Controls.Add(MovesListBox);
        grpMoves.Controls.Add(EditMoveButton);
        grpMoves.Controls.Add(AddMoveButton);
        grpMoves.Location = new Point(13, 185);
        grpMoves.Margin = new Padding(4, 3, 4, 3);
        grpMoves.Name = "grpMoves";
        grpMoves.Padding = new Padding(4, 3, 4, 3);
        grpMoves.Size = new Size(213, 155);
        grpMoves.TabIndex = 39;
        grpMoves.TabStop = false;
        grpMoves.Text = "Moves List";
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(462, 318);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(68, 26);
        CancelButton.TabIndex = 34;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(386, 318);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(68, 26);
        OkButton.TabIndex = 33;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // ExportZimButton
        // 
        ExportZimButton.Location = new Point(310, 318);
        ExportZimButton.Margin = new Padding(4, 3, 4, 3);
        ExportZimButton.Name = "ExportZimButton";
        ExportZimButton.Size = new Size(68, 26);
        ExportZimButton.TabIndex = 32;
        ExportZimButton.Text = ".ZIM";
        ExportZimButton.UseVisualStyleBackColor = true;
        ExportZimButton.Click += ExportZimButton_Click;
        // 
        // ExportHTMLButton
        // 
        ExportHTMLButton.Location = new Point(234, 318);
        ExportHTMLButton.Margin = new Padding(4, 3, 4, 3);
        ExportHTMLButton.Name = "ExportHTMLButton";
        ExportHTMLButton.Size = new Size(68, 26);
        ExportHTMLButton.TabIndex = 31;
        ExportHTMLButton.Text = ".HTML";
        ExportHTMLButton.UseVisualStyleBackColor = true;
        ExportHTMLButton.Click += ExportHTMLButton_Click;
        // 
        // grpTitles
        // 
        grpTitles.Controls.Add(TitlesListBox);
        grpTitles.Controls.Add(RemoveTitleButton);
        grpTitles.Controls.Add(AddTitleButton);
        grpTitles.Location = new Point(234, 215);
        grpTitles.Margin = new Padding(4, 3, 4, 3);
        grpTitles.Name = "grpTitles";
        grpTitles.Padding = new Padding(4, 3, 4, 3);
        grpTitles.Size = new Size(296, 97);
        grpTitles.TabIndex = 37;
        grpTitles.TabStop = false;
        grpTitles.Text = "Titles";
        // 
        // TitlesListBox
        // 
        TitlesListBox.DisplayMember = "Value";
        TitlesListBox.FormattingEnabled = true;
        TitlesListBox.ItemHeight = 15;
        TitlesListBox.Location = new Point(7, 22);
        TitlesListBox.Margin = new Padding(4, 3, 4, 3);
        TitlesListBox.Name = "TitlesListBox";
        TitlesListBox.Size = new Size(210, 64);
        TitlesListBox.TabIndex = 8;
        TitlesListBox.ValueMember = "Key";
        // 
        // RemoveTitleButton
        // 
        RemoveTitleButton.Location = new Point(225, 59);
        RemoveTitleButton.Margin = new Padding(4, 3, 4, 3);
        RemoveTitleButton.Name = "RemoveTitleButton";
        RemoveTitleButton.Size = new Size(63, 27);
        RemoveTitleButton.TabIndex = 10;
        RemoveTitleButton.Text = "Remove";
        RemoveTitleButton.UseVisualStyleBackColor = true;
        RemoveTitleButton.Click += RemoveTitleButton_Click;
        // 
        // AddTitleButton
        // 
        AddTitleButton.Location = new Point(225, 26);
        AddTitleButton.Margin = new Padding(4, 3, 4, 3);
        AddTitleButton.Name = "AddTitleButton";
        AddTitleButton.Size = new Size(63, 27);
        AddTitleButton.TabIndex = 9;
        AddTitleButton.Text = "Add";
        AddTitleButton.UseVisualStyleBackColor = true;
        AddTitleButton.Click += AddTitleButton_Click;
        // 
        // EscortInterferesCheckBox
        // 
        EscortInterferesCheckBox.AutoSize = true;
        EscortInterferesCheckBox.Location = new Point(420, 188);
        EscortInterferesCheckBox.Margin = new Padding(4, 3, 4, 3);
        EscortInterferesCheckBox.Name = "EscortInterferesCheckBox";
        EscortInterferesCheckBox.Size = new Size(110, 19);
        EscortInterferesCheckBox.TabIndex = 6;
        EscortInterferesCheckBox.Text = "Escort Interferes";
        EscortInterferesCheckBox.UseVisualStyleBackColor = true;
        // 
        // PushTextBox
        // 
        PushTextBox.Location = new Point(309, 186);
        PushTextBox.Margin = new Padding(4, 3, 4, 3);
        PushTextBox.MaxLength = 4;
        PushTextBox.Name = "PushTextBox";
        PushTextBox.Size = new Size(63, 23);
        PushTextBox.TabIndex = 7;
        // 
        // lblPush
        // 
        lblPush.AutoSize = true;
        lblPush.Location = new Point(234, 189);
        lblPush.Margin = new Padding(4, 0, 4, 0);
        lblPush.Name = "lblPush";
        lblPush.Size = new Size(33, 15);
        lblPush.TabIndex = 34;
        lblPush.Text = "Push";
        // 
        // EscortComboBox
        // 
        EscortComboBox.DisplayMember = "Value";
        EscortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        EscortComboBox.FormattingEnabled = true;
        EscortComboBox.Location = new Point(309, 157);
        EscortComboBox.Margin = new Padding(4, 3, 4, 3);
        EscortComboBox.Name = "EscortComboBox";
        EscortComboBox.Size = new Size(221, 23);
        EscortComboBox.TabIndex = 5;
        EscortComboBox.ValueMember = "Key";
        // 
        // lblEscort
        // 
        lblEscort.AutoSize = true;
        lblEscort.Location = new Point(234, 160);
        lblEscort.Margin = new Padding(4, 0, 4, 0);
        lblEscort.Name = "lblEscort";
        lblEscort.Size = new Size(39, 15);
        lblEscort.TabIndex = 32;
        lblEscort.Text = "Escort";
        // 
        // RingIntroTextBox
        // 
        RingIntroTextBox.Location = new Point(309, 128);
        RingIntroTextBox.Margin = new Padding(4, 3, 4, 3);
        RingIntroTextBox.Name = "RingIntroTextBox";
        RingIntroTextBox.Size = new Size(221, 23);
        RingIntroTextBox.TabIndex = 4;
        // 
        // lblRingIntro
        // 
        lblRingIntro.AutoSize = true;
        lblRingIntro.Location = new Point(234, 131);
        lblRingIntro.Margin = new Padding(4, 0, 4, 0);
        lblRingIntro.Name = "lblRingIntro";
        lblRingIntro.Size = new Size(59, 15);
        lblRingIntro.TabIndex = 30;
        lblRingIntro.Text = "Ring Intro";
        // 
        // StableTextBox
        // 
        StableTextBox.Location = new Point(309, 99);
        StableTextBox.Margin = new Padding(4, 3, 4, 3);
        StableTextBox.Name = "StableTextBox";
        StableTextBox.Size = new Size(221, 23);
        StableTextBox.TabIndex = 3;
        // 
        // lblStable
        // 
        lblStable.AutoSize = true;
        lblStable.Location = new Point(234, 102);
        lblStable.Margin = new Padding(4, 0, 4, 0);
        lblStable.Name = "lblStable";
        lblStable.Size = new Size(39, 15);
        lblStable.TabIndex = 28;
        lblStable.Text = "Stable";
        // 
        // AffiliationComboBox
        // 
        AffiliationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        AffiliationComboBox.FormattingEnabled = true;
        AffiliationComboBox.Location = new Point(309, 70);
        AffiliationComboBox.Margin = new Padding(4, 3, 4, 3);
        AffiliationComboBox.Name = "AffiliationComboBox";
        AffiliationComboBox.Size = new Size(221, 23);
        AffiliationComboBox.TabIndex = 2;
        // 
        // lblAffiliation
        // 
        lblAffiliation.AutoSize = true;
        lblAffiliation.Location = new Point(234, 73);
        lblAffiliation.Margin = new Padding(4, 0, 4, 0);
        lblAffiliation.Name = "lblAffiliation";
        lblAffiliation.Size = new Size(59, 15);
        lblAffiliation.TabIndex = 26;
        lblAffiliation.Text = "Affiliation";
        // 
        // HometownTextBox
        // 
        HometownTextBox.Location = new Point(309, 41);
        HometownTextBox.Margin = new Padding(4, 3, 4, 3);
        HometownTextBox.Name = "HometownTextBox";
        HometownTextBox.Size = new Size(221, 23);
        HometownTextBox.TabIndex = 1;
        // 
        // lblHometown
        // 
        lblHometown.AutoSize = true;
        lblHometown.Location = new Point(234, 44);
        lblHometown.Margin = new Padding(4, 0, 4, 0);
        lblHometown.Name = "lblHometown";
        lblHometown.Size = new Size(67, 15);
        lblHometown.TabIndex = 24;
        lblHometown.Text = "Hometown";
        // 
        // NamesTextBox
        // 
        NamesTextBox.Location = new Point(309, 12);
        NamesTextBox.Margin = new Padding(4, 3, 4, 3);
        NamesTextBox.Name = "NamesTextBox";
        NamesTextBox.Size = new Size(221, 23);
        NamesTextBox.TabIndex = 0;
        // 
        // lblNames
        // 
        lblNames.AutoSize = true;
        lblNames.Location = new Point(234, 15);
        lblNames.Margin = new Padding(4, 0, 4, 0);
        lblNames.Name = "lblNames";
        lblNames.Size = new Size(44, 15);
        lblNames.TabIndex = 22;
        lblNames.Text = "Names";
        // 
        // WrestlerEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(543, 356);
        Controls.Add(grpStats);
        Controls.Add(grpMoves);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        Controls.Add(ExportZimButton);
        Controls.Add(ExportHTMLButton);
        Controls.Add(grpTitles);
        Controls.Add(EscortInterferesCheckBox);
        Controls.Add(PushTextBox);
        Controls.Add(lblPush);
        Controls.Add(EscortComboBox);
        Controls.Add(lblEscort);
        Controls.Add(RingIntroTextBox);
        Controls.Add(lblRingIntro);
        Controls.Add(StableTextBox);
        Controls.Add(lblStable);
        Controls.Add(AffiliationComboBox);
        Controls.Add(lblAffiliation);
        Controls.Add(HometownTextBox);
        Controls.Add(lblHometown);
        Controls.Add(NamesTextBox);
        Controls.Add(lblNames);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "WrestlerEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Wrestler Information";
        FormClosing += WrestlerEditorForm_FormClosing;
        grpStats.ResumeLayout(false);
        grpStats.PerformLayout();
        grpMoves.ResumeLayout(false);
        grpTitles.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.TextBox HeightTextBox;
    internal System.Windows.Forms.GroupBox grpStats;
    internal System.Windows.Forms.TextBox LosesTextBox;
    internal System.Windows.Forms.TextBox WeightTextBox;
    internal System.Windows.Forms.Label lblLoses;
    internal System.Windows.Forms.TextBox WinsTextBox;
    internal System.Windows.Forms.Label lblWins;
    internal System.Windows.Forms.Label lblHeight;
    internal System.Windows.Forms.Label lblWeight;
    internal System.Windows.Forms.Label lblStrength;
    internal System.Windows.Forms.Label lblSpeed;
    internal System.Windows.Forms.Label lblVitality;
    internal System.Windows.Forms.Label lblCharisma;
    internal System.Windows.Forms.Button AddMoveButton;
    internal System.Windows.Forms.Button RemoveMoveButton;
    internal System.Windows.Forms.Button EditMoveButton;
    internal System.Windows.Forms.ListBox MovesListBox;
    internal System.Windows.Forms.GroupBox grpMoves;
    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.Button ExportZimButton;
    internal System.Windows.Forms.Button ExportHTMLButton;
    internal System.Windows.Forms.GroupBox grpTitles;
    internal System.Windows.Forms.ListBox TitlesListBox;
    internal System.Windows.Forms.Button RemoveTitleButton;
    internal System.Windows.Forms.Button AddTitleButton;
    internal System.Windows.Forms.CheckBox EscortInterferesCheckBox;
    internal System.Windows.Forms.TextBox PushTextBox;
    internal System.Windows.Forms.Label lblPush;
    internal System.Windows.Forms.ComboBox EscortComboBox;
    internal System.Windows.Forms.Label lblEscort;
    internal System.Windows.Forms.TextBox RingIntroTextBox;
    internal System.Windows.Forms.Label lblRingIntro;
    internal System.Windows.Forms.TextBox StableTextBox;
    internal System.Windows.Forms.Label lblStable;
    internal System.Windows.Forms.ComboBox AffiliationComboBox;
    internal System.Windows.Forms.Label lblAffiliation;
    internal System.Windows.Forms.TextBox HometownTextBox;
    internal System.Windows.Forms.Label lblHometown;
    internal System.Windows.Forms.TextBox NamesTextBox;
    internal System.Windows.Forms.Label lblNames;
    internal System.Windows.Forms.Button StrengthDecreaseButton;
    internal System.Windows.Forms.Button StrengthIncreaseButton;
    internal System.Windows.Forms.ProgressBar StrengthProgressBar;
    internal System.Windows.Forms.Button CharismaDecreaseButton;
    internal System.Windows.Forms.Button CharismaIncreaseButton;
    internal System.Windows.Forms.ProgressBar CharismaProgressBar;
    internal System.Windows.Forms.Button VitalityDecreaseButton;
    internal System.Windows.Forms.Button VitalityIncreaseButton;
    internal System.Windows.Forms.ProgressBar VitalityProgressBar;
    internal System.Windows.Forms.Button SpeedDecreaseButton;
    internal System.Windows.Forms.Button SpeedIncreaseButton;
    internal System.Windows.Forms.ProgressBar SpeedProgressBar;
}
