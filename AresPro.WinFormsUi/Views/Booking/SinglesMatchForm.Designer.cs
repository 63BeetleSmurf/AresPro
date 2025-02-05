namespace AresPro.WinFormsUi.Views.Booking;

partial class SinglesMatchForm
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
        AresDecidesWinnerRadioButton = new RadioButton();
        Participant1WinsRadioButton = new RadioButton();
        Participant2WinsRadioButton = new RadioButton();
        Participant1ComboBox = new ComboBox();
        label1 = new Label();
        Participant2ComboBox = new ComboBox();
        groupBox1 = new GroupBox();
        AttacksParticipant2CheckBox = new CheckBox();
        AttacksParticipant1CheckBox = new CheckBox();
        InterferenceListBox = new ListBox();
        groupBox2 = new GroupBox();
        GimmickFileBrowseButton = new Button();
        GimmickFileNameTextBox = new TextBox();
        groupBox3 = new GroupBox();
        TitleComboBox = new ComboBox();
        groupBox4 = new GroupBox();
        WinsByComboBox = new ComboBox();
        OkButton = new Button();
        CancelationButton = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // AresDecidesWinnerRadioButton
        // 
        AresDecidesWinnerRadioButton.AutoSize = true;
        AresDecidesWinnerRadioButton.Location = new Point(12, 12);
        AresDecidesWinnerRadioButton.Name = "AresDecidesWinnerRadioButton";
        AresDecidesWinnerRadioButton.Size = new Size(133, 19);
        AresDecidesWinnerRadioButton.TabIndex = 0;
        AresDecidesWinnerRadioButton.TabStop = true;
        AresDecidesWinnerRadioButton.Text = "Ares Decides Winner";
        AresDecidesWinnerRadioButton.UseVisualStyleBackColor = true;
        // 
        // Participant1WinsRadioButton
        // 
        Participant1WinsRadioButton.AutoSize = true;
        Participant1WinsRadioButton.Location = new Point(153, 12);
        Participant1WinsRadioButton.Name = "Participant1WinsRadioButton";
        Participant1WinsRadioButton.Size = new Size(86, 19);
        Participant1WinsRadioButton.TabIndex = 1;
        Participant1WinsRadioButton.TabStop = true;
        Participant1WinsRadioButton.Text = "# One Wins";
        Participant1WinsRadioButton.UseVisualStyleBackColor = true;
        // 
        // Participant2WinsRadioButton
        // 
        Participant2WinsRadioButton.AutoSize = true;
        Participant2WinsRadioButton.Location = new Point(281, 12);
        Participant2WinsRadioButton.Name = "Participant2WinsRadioButton";
        Participant2WinsRadioButton.Size = new Size(85, 19);
        Participant2WinsRadioButton.TabIndex = 2;
        Participant2WinsRadioButton.TabStop = true;
        Participant2WinsRadioButton.Text = "# Two Wins";
        Participant2WinsRadioButton.UseVisualStyleBackColor = true;
        // 
        // Participant1ComboBox
        // 
        Participant1ComboBox.FormattingEnabled = true;
        Participant1ComboBox.Location = new Point(12, 37);
        Participant1ComboBox.Name = "Participant1ComboBox";
        Participant1ComboBox.Size = new Size(170, 23);
        Participant1ComboBox.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(196, 40);
        label1.Name = "label1";
        label1.Size = new Size(22, 15);
        label1.TabIndex = 4;
        label1.Text = "Vs.";
        // 
        // Participant2ComboBox
        // 
        Participant2ComboBox.FormattingEnabled = true;
        Participant2ComboBox.Location = new Point(232, 37);
        Participant2ComboBox.Name = "Participant2ComboBox";
        Participant2ComboBox.Size = new Size(170, 23);
        Participant2ComboBox.TabIndex = 4;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(AttacksParticipant2CheckBox);
        groupBox1.Controls.Add(AttacksParticipant1CheckBox);
        groupBox1.Controls.Add(InterferenceListBox);
        groupBox1.Location = new Point(12, 66);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(390, 92);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Interference";
        // 
        // AttacksParticipant2CheckBox
        // 
        AttacksParticipant2CheckBox.AutoSize = true;
        AttacksParticipant2CheckBox.Location = new Point(220, 56);
        AttacksParticipant2CheckBox.Name = "AttacksParticipant2CheckBox";
        AttacksParticipant2CheckBox.Size = new Size(99, 19);
        AttacksParticipant2CheckBox.TabIndex = 7;
        AttacksParticipant2CheckBox.Text = "Attacks # Two";
        AttacksParticipant2CheckBox.UseVisualStyleBackColor = true;
        // 
        // AttacksParticipant1CheckBox
        // 
        AttacksParticipant1CheckBox.AutoSize = true;
        AttacksParticipant1CheckBox.Location = new Point(220, 31);
        AttacksParticipant1CheckBox.Name = "AttacksParticipant1CheckBox";
        AttacksParticipant1CheckBox.Size = new Size(100, 19);
        AttacksParticipant1CheckBox.TabIndex = 6;
        AttacksParticipant1CheckBox.Text = "Attacks # One";
        AttacksParticipant1CheckBox.UseVisualStyleBackColor = true;
        // 
        // InterferenceListBox
        // 
        InterferenceListBox.FormattingEnabled = true;
        InterferenceListBox.ItemHeight = 15;
        InterferenceListBox.Location = new Point(6, 22);
        InterferenceListBox.Name = "InterferenceListBox";
        InterferenceListBox.Size = new Size(175, 64);
        InterferenceListBox.TabIndex = 5;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(GimmickFileBrowseButton);
        groupBox2.Controls.Add(GimmickFileNameTextBox);
        groupBox2.Location = new Point(12, 164);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(214, 51);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        groupBox2.Text = "Gimmick";
        // 
        // GimmickFileBrowseButton
        // 
        GimmickFileBrowseButton.Location = new Point(143, 22);
        GimmickFileBrowseButton.Name = "GimmickFileBrowseButton";
        GimmickFileBrowseButton.Size = new Size(65, 23);
        GimmickFileBrowseButton.TabIndex = 9;
        GimmickFileBrowseButton.Text = "Change";
        GimmickFileBrowseButton.UseVisualStyleBackColor = true;
        // 
        // GimmickFileNameTextBox
        // 
        GimmickFileNameTextBox.Location = new Point(6, 22);
        GimmickFileNameTextBox.Name = "GimmickFileNameTextBox";
        GimmickFileNameTextBox.ReadOnly = true;
        GimmickFileNameTextBox.Size = new Size(131, 23);
        GimmickFileNameTextBox.TabIndex = 8;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(TitleComboBox);
        groupBox3.Location = new Point(232, 164);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(170, 51);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "Title up for grabs";
        // 
        // TitleComboBox
        // 
        TitleComboBox.FormattingEnabled = true;
        TitleComboBox.Location = new Point(6, 22);
        TitleComboBox.Name = "TitleComboBox";
        TitleComboBox.Size = new Size(158, 23);
        TitleComboBox.TabIndex = 10;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(WinsByComboBox);
        groupBox4.Location = new Point(12, 221);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(228, 51);
        groupBox4.TabIndex = 9;
        groupBox4.TabStop = false;
        groupBox4.Text = "Wins by";
        // 
        // WinsByComboBox
        // 
        WinsByComboBox.FormattingEnabled = true;
        WinsByComboBox.Location = new Point(6, 22);
        WinsByComboBox.Name = "WinsByComboBox";
        WinsByComboBox.Size = new Size(216, 23);
        WinsByComboBox.TabIndex = 11;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(246, 249);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(75, 23);
        OkButton.TabIndex = 12;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(327, 249);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(75, 23);
        CancelationButton.TabIndex = 13;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // SinglesMatchForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(414, 284);
        Controls.Add(CancelationButton);
        Controls.Add(OkButton);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(Participant2ComboBox);
        Controls.Add(label1);
        Controls.Add(Participant1ComboBox);
        Controls.Add(Participant2WinsRadioButton);
        Controls.Add(Participant1WinsRadioButton);
        Controls.Add(AresDecidesWinnerRadioButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SinglesMatchForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Singles Match";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RadioButton AresDecidesWinnerRadioButton;
    private RadioButton Participant1WinsRadioButton;
    private RadioButton Participant2WinsRadioButton;
    private ComboBox Participant1ComboBox;
    private Label label1;
    private ComboBox Participant2ComboBox;
    private GroupBox groupBox1;
    private CheckBox AttacksParticipant2CheckBox;
    private CheckBox AttacksParticipant1CheckBox;
    private ListBox InterferenceListBox;
    private GroupBox groupBox2;
    private Button GimmickFileBrowseButton;
    private TextBox GimmickFileNameTextBox;
    private GroupBox groupBox3;
    private ComboBox TitleComboBox;
    private GroupBox groupBox4;
    private ComboBox WinsByComboBox;
    private Button OkButton;
    private Button CancelationButton;
}