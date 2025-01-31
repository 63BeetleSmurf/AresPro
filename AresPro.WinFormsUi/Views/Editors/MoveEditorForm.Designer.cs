namespace AresPro.WinFormsUi.Views.Editors;

partial class MoveEditorForm
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
        RecStandingAfterCheckBox = new CheckBox();
        RecStandingBeforeCheckBox = new CheckBox();
        AttStandingAfterCheckBox = new CheckBox();
        AttStandingBeforeCheckBox = new CheckBox();
        grpPositions = new GroupBox();
        Text3TextBox = new TextBox();
        Text2TextBox = new TextBox();
        Text1TextBox = new TextBox();
        CancelButton = new Button();
        grpTexts = new GroupBox();
        HighRiskCheckBox = new CheckBox();
        IllegalCheckBox = new CheckBox();
        LiftCheckBox = new CheckBox();
        TypeComboBox = new ComboBox();
        NameTextBox = new TextBox();
        lblType = new Label();
        lblName = new Label();
        lblDamage = new Label();
        DamageDecreaseButton = new Button();
        DamageIncreaseButton = new Button();
        DamageProgressBar = new ProgressBar();
        grpPositions.SuspendLayout();
        grpTexts.SuspendLayout();
        SuspendLayout();
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(359, 231);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(63, 27);
        OkButton.TabIndex = 15;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // RecStandingAfterCheckBox
        // 
        RecStandingAfterCheckBox.AutoSize = true;
        RecStandingAfterCheckBox.Location = new Point(173, 47);
        RecStandingAfterCheckBox.Margin = new Padding(4, 3, 4, 3);
        RecStandingAfterCheckBox.Name = "RecStandingAfterCheckBox";
        RecStandingAfterCheckBox.Size = new Size(149, 19);
        RecStandingAfterCheckBox.TabIndex = 14;
        RecStandingAfterCheckBox.Text = "Reciever Standing After";
        RecStandingAfterCheckBox.UseVisualStyleBackColor = true;
        // 
        // RecStandingBeforeCheckBox
        // 
        RecStandingBeforeCheckBox.AutoSize = true;
        RecStandingBeforeCheckBox.Location = new Point(173, 22);
        RecStandingBeforeCheckBox.Margin = new Padding(4, 3, 4, 3);
        RecStandingBeforeCheckBox.Name = "RecStandingBeforeCheckBox";
        RecStandingBeforeCheckBox.Size = new Size(157, 19);
        RecStandingBeforeCheckBox.TabIndex = 13;
        RecStandingBeforeCheckBox.Text = "Reciever Standing Before";
        RecStandingBeforeCheckBox.UseVisualStyleBackColor = true;
        // 
        // AttStandingAfterCheckBox
        // 
        AttStandingAfterCheckBox.AutoSize = true;
        AttStandingAfterCheckBox.Location = new Point(8, 47);
        AttStandingAfterCheckBox.Margin = new Padding(4, 3, 4, 3);
        AttStandingAfterCheckBox.Name = "AttStandingAfterCheckBox";
        AttStandingAfterCheckBox.Size = new Size(149, 19);
        AttStandingAfterCheckBox.TabIndex = 12;
        AttStandingAfterCheckBox.Text = "Attacker Standing After";
        AttStandingAfterCheckBox.UseVisualStyleBackColor = true;
        // 
        // AttStandingBeforeCheckBox
        // 
        AttStandingBeforeCheckBox.AutoSize = true;
        AttStandingBeforeCheckBox.Location = new Point(8, 22);
        AttStandingBeforeCheckBox.Margin = new Padding(4, 3, 4, 3);
        AttStandingBeforeCheckBox.Name = "AttStandingBeforeCheckBox";
        AttStandingBeforeCheckBox.Size = new Size(157, 19);
        AttStandingBeforeCheckBox.TabIndex = 11;
        AttStandingBeforeCheckBox.Text = "Attacker Standing Before";
        AttStandingBeforeCheckBox.UseVisualStyleBackColor = true;
        // 
        // grpPositions
        // 
        grpPositions.Controls.Add(RecStandingAfterCheckBox);
        grpPositions.Controls.Add(RecStandingBeforeCheckBox);
        grpPositions.Controls.Add(AttStandingAfterCheckBox);
        grpPositions.Controls.Add(AttStandingBeforeCheckBox);
        grpPositions.Location = new Point(13, 186);
        grpPositions.Margin = new Padding(4, 3, 4, 3);
        grpPositions.Name = "grpPositions";
        grpPositions.Padding = new Padding(4, 3, 4, 3);
        grpPositions.Size = new Size(338, 72);
        grpPositions.TabIndex = 23;
        grpPositions.TabStop = false;
        grpPositions.Text = "Positions";
        // 
        // Text3TextBox
        // 
        Text3TextBox.Location = new Point(8, 81);
        Text3TextBox.Margin = new Padding(4, 3, 4, 3);
        Text3TextBox.Name = "Text3TextBox";
        Text3TextBox.Size = new Size(464, 23);
        Text3TextBox.TabIndex = 10;
        // 
        // Text2TextBox
        // 
        Text2TextBox.Location = new Point(8, 52);
        Text2TextBox.Margin = new Padding(4, 3, 4, 3);
        Text2TextBox.Name = "Text2TextBox";
        Text2TextBox.Size = new Size(464, 23);
        Text2TextBox.TabIndex = 9;
        // 
        // Text1TextBox
        // 
        Text1TextBox.Location = new Point(8, 22);
        Text1TextBox.Margin = new Padding(4, 3, 4, 3);
        Text1TextBox.Name = "Text1TextBox";
        Text1TextBox.Size = new Size(464, 23);
        Text1TextBox.TabIndex = 8;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(430, 231);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(63, 27);
        CancelButton.TabIndex = 16;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // grpTexts
        // 
        grpTexts.Controls.Add(Text3TextBox);
        grpTexts.Controls.Add(Text2TextBox);
        grpTexts.Controls.Add(Text1TextBox);
        grpTexts.Location = new Point(13, 70);
        grpTexts.Margin = new Padding(4, 3, 4, 3);
        grpTexts.Name = "grpTexts";
        grpTexts.Padding = new Padding(4, 3, 4, 3);
        grpTexts.Size = new Size(480, 110);
        grpTexts.TabIndex = 22;
        grpTexts.TabStop = false;
        grpTexts.Text = "Texts for the move";
        // 
        // HighRiskCheckBox
        // 
        HighRiskCheckBox.AutoSize = true;
        HighRiskCheckBox.Location = new Point(382, 43);
        HighRiskCheckBox.Margin = new Padding(4, 3, 4, 3);
        HighRiskCheckBox.Name = "HighRiskCheckBox";
        HighRiskCheckBox.Size = new Size(76, 19);
        HighRiskCheckBox.TabIndex = 7;
        HighRiskCheckBox.Text = "High Risk";
        HighRiskCheckBox.UseVisualStyleBackColor = true;
        // 
        // IllegalCheckBox
        // 
        IllegalCheckBox.AutoSize = true;
        IllegalCheckBox.Location = new Point(317, 43);
        IllegalCheckBox.Margin = new Padding(4, 3, 4, 3);
        IllegalCheckBox.Name = "IllegalCheckBox";
        IllegalCheckBox.Size = new Size(57, 19);
        IllegalCheckBox.TabIndex = 6;
        IllegalCheckBox.Text = "Illegal";
        IllegalCheckBox.UseVisualStyleBackColor = true;
        // 
        // LiftCheckBox
        // 
        LiftCheckBox.AutoSize = true;
        LiftCheckBox.Location = new Point(266, 43);
        LiftCheckBox.Margin = new Padding(4, 3, 4, 3);
        LiftCheckBox.Name = "LiftCheckBox";
        LiftCheckBox.Size = new Size(43, 19);
        LiftCheckBox.TabIndex = 5;
        LiftCheckBox.Text = "Lift";
        LiftCheckBox.UseVisualStyleBackColor = true;
        // 
        // TypeComboBox
        // 
        TypeComboBox.FormattingEnabled = true;
        TypeComboBox.Items.AddRange(new object[] { "Match Prepare", "Without Advantage", "With Advantage", "Cover (Pin)", "Knock Out Finisher", "Submission Finisher" });
        TypeComboBox.Location = new Point(52, 41);
        TypeComboBox.Margin = new Padding(4, 3, 4, 3);
        TypeComboBox.Name = "TypeComboBox";
        TypeComboBox.Size = new Size(206, 23);
        TypeComboBox.TabIndex = 4;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(258, 12);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(235, 23);
        NameTextBox.TabIndex = 0;
        // 
        // lblType
        // 
        lblType.AutoSize = true;
        lblType.Location = new Point(13, 44);
        lblType.Margin = new Padding(4, 0, 4, 0);
        lblType.Name = "lblType";
        lblType.Size = new Size(31, 15);
        lblType.TabIndex = 17;
        lblType.Text = "Type";
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(211, 15);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(39, 15);
        lblName.TabIndex = 15;
        lblName.Text = "Name";
        // 
        // lblDamage
        // 
        lblDamage.AutoSize = true;
        lblDamage.Location = new Point(13, 15);
        lblDamage.Margin = new Padding(4, 0, 4, 0);
        lblDamage.Name = "lblDamage";
        lblDamage.Size = new Size(51, 15);
        lblDamage.TabIndex = 13;
        lblDamage.Text = "Damage";
        // 
        // DamageDecreaseButton
        // 
        DamageDecreaseButton.Location = new Point(71, 15);
        DamageDecreaseButton.Name = "DamageDecreaseButton";
        DamageDecreaseButton.Size = new Size(15, 15);
        DamageDecreaseButton.TabIndex = 1;
        DamageDecreaseButton.UseVisualStyleBackColor = true;
        DamageDecreaseButton.Click += DamageDecreaseButton_Click;
        // 
        // DamageIncreaseButton
        // 
        DamageIncreaseButton.Location = new Point(189, 15);
        DamageIncreaseButton.Name = "DamageIncreaseButton";
        DamageIncreaseButton.Size = new Size(15, 15);
        DamageIncreaseButton.TabIndex = 3;
        DamageIncreaseButton.UseVisualStyleBackColor = true;
        DamageIncreaseButton.Click += DamageIncreaseButton_Click;
        // 
        // DamageProgressBar
        // 
        DamageProgressBar.Location = new Point(92, 15);
        DamageProgressBar.Maximum = 10;
        DamageProgressBar.Name = "DamageProgressBar";
        DamageProgressBar.Size = new Size(91, 15);
        DamageProgressBar.TabIndex = 2;
        // 
        // MoveEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(506, 270);
        Controls.Add(DamageDecreaseButton);
        Controls.Add(DamageIncreaseButton);
        Controls.Add(DamageProgressBar);
        Controls.Add(OkButton);
        Controls.Add(grpPositions);
        Controls.Add(CancelButton);
        Controls.Add(grpTexts);
        Controls.Add(HighRiskCheckBox);
        Controls.Add(IllegalCheckBox);
        Controls.Add(LiftCheckBox);
        Controls.Add(TypeComboBox);
        Controls.Add(NameTextBox);
        Controls.Add(lblType);
        Controls.Add(lblName);
        Controls.Add(lblDamage);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MoveEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Move Editor";
        FormClosing += MoveEditorForm_FormClosing;
        grpPositions.ResumeLayout(false);
        grpPositions.PerformLayout();
        grpTexts.ResumeLayout(false);
        grpTexts.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.CheckBox RecStandingAfterCheckBox;
    internal System.Windows.Forms.CheckBox RecStandingBeforeCheckBox;
    internal System.Windows.Forms.CheckBox AttStandingAfterCheckBox;
    internal System.Windows.Forms.CheckBox AttStandingBeforeCheckBox;
    internal System.Windows.Forms.GroupBox grpPositions;
    internal System.Windows.Forms.TextBox Text3TextBox;
    internal System.Windows.Forms.TextBox Text2TextBox;
    internal System.Windows.Forms.TextBox Text1TextBox;
    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.GroupBox grpTexts;
    internal System.Windows.Forms.CheckBox HighRiskCheckBox;
    internal System.Windows.Forms.CheckBox IllegalCheckBox;
    internal System.Windows.Forms.CheckBox LiftCheckBox;
    internal System.Windows.Forms.ComboBox TypeComboBox;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.Label lblType;
    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.Label lblDamage;
    private Button DamageDecreaseButton;
    private Button DamageIncreaseButton;
    internal ProgressBar DamageProgressBar;
}
