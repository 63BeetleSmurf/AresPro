namespace AresPro.WinFormsUi.Views.Booking;

partial class BattleRoyalForm
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
        groupBox1 = new GroupBox();
        WrestlersListBox = new ListBox();
        RemoveButton = new Button();
        AddButton = new Button();
        groupBox2 = new GroupBox();
        ParticipantListBox = new ListBox();
        groupBox3 = new GroupBox();
        WinnerComboBox = new ComboBox();
        groupBox4 = new GroupBox();
        TitleComboBox = new ComboBox();
        groupBox5 = new GroupBox();
        GimmickFileBrowseButton = new Button();
        GimmickFileNameTextBox = new TextBox();
        CancelationButton = new Button();
        OkButton = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(WrestlersListBox);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(162, 197);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Singles Roster";
        // 
        // WrestlersListBox
        // 
        WrestlersListBox.FormattingEnabled = true;
        WrestlersListBox.ItemHeight = 15;
        WrestlersListBox.Location = new Point(6, 22);
        WrestlersListBox.Name = "WrestlersListBox";
        WrestlersListBox.Size = new Size(150, 169);
        WrestlersListBox.TabIndex = 0;
        // 
        // RemoveButton
        // 
        RemoveButton.Location = new Point(180, 32);
        RemoveButton.Name = "RemoveButton";
        RemoveButton.Size = new Size(28, 80);
        RemoveButton.TabIndex = 1;
        RemoveButton.Text = "<-";
        RemoveButton.UseVisualStyleBackColor = true;
        // 
        // AddButton
        // 
        AddButton.Location = new Point(180, 118);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(28, 80);
        AddButton.TabIndex = 2;
        AddButton.Text = "->";
        AddButton.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(ParticipantListBox);
        groupBox2.Location = new Point(214, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(162, 197);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        groupBox2.Text = "Battle Royal Participants";
        // 
        // ParticipantListBox
        // 
        ParticipantListBox.FormattingEnabled = true;
        ParticipantListBox.ItemHeight = 15;
        ParticipantListBox.Location = new Point(6, 22);
        ParticipantListBox.Name = "ParticipantListBox";
        ParticipantListBox.Size = new Size(150, 169);
        ParticipantListBox.TabIndex = 3;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(WinnerComboBox);
        groupBox3.Location = new Point(12, 215);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(188, 51);
        groupBox3.TabIndex = 4;
        groupBox3.TabStop = false;
        groupBox3.Text = "Winner";
        // 
        // WinnerComboBox
        // 
        WinnerComboBox.FormattingEnabled = true;
        WinnerComboBox.Location = new Point(6, 22);
        WinnerComboBox.Name = "WinnerComboBox";
        WinnerComboBox.Size = new Size(176, 23);
        WinnerComboBox.TabIndex = 4;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(TitleComboBox);
        groupBox4.Location = new Point(206, 215);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(170, 51);
        groupBox4.TabIndex = 10;
        groupBox4.TabStop = false;
        groupBox4.Text = "Title";
        // 
        // TitleComboBox
        // 
        TitleComboBox.FormattingEnabled = true;
        TitleComboBox.Location = new Point(6, 22);
        TitleComboBox.Name = "TitleComboBox";
        TitleComboBox.Size = new Size(158, 23);
        TitleComboBox.TabIndex = 5;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(GimmickFileBrowseButton);
        groupBox5.Controls.Add(GimmickFileNameTextBox);
        groupBox5.Location = new Point(12, 272);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(214, 51);
        groupBox5.TabIndex = 9;
        groupBox5.TabStop = false;
        groupBox5.Text = "Gimmick";
        // 
        // GimmickFileBrowseButton
        // 
        GimmickFileBrowseButton.Location = new Point(143, 22);
        GimmickFileBrowseButton.Name = "GimmickFileBrowseButton";
        GimmickFileBrowseButton.Size = new Size(65, 23);
        GimmickFileBrowseButton.TabIndex = 7;
        GimmickFileBrowseButton.Text = "Change";
        GimmickFileBrowseButton.UseVisualStyleBackColor = true;
        // 
        // GimmickFileNameTextBox
        // 
        GimmickFileNameTextBox.Location = new Point(6, 22);
        GimmickFileNameTextBox.Name = "GimmickFileNameTextBox";
        GimmickFileNameTextBox.ReadOnly = true;
        GimmickFileNameTextBox.Size = new Size(131, 23);
        GimmickFileNameTextBox.TabIndex = 6;
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(301, 301);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(75, 23);
        CancelationButton.TabIndex = 9;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(301, 272);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(75, 23);
        OkButton.TabIndex = 8;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // BattleRoyalForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(388, 336);
        Controls.Add(CancelationButton);
        Controls.Add(OkButton);
        Controls.Add(groupBox4);
        Controls.Add(groupBox5);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(AddButton);
        Controls.Add(RemoveButton);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "BattleRoyalForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Battle Royal";
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private ListBox WrestlersListBox;
    private Button RemoveButton;
    private Button AddButton;
    private GroupBox groupBox2;
    private ListBox ParticipantListBox;
    private GroupBox groupBox3;
    private ComboBox WinnerComboBox;
    private GroupBox groupBox4;
    private ComboBox TitleComboBox;
    private GroupBox groupBox5;
    private Button GimmickFileBrowseButton;
    private TextBox GimmickFileNameTextBox;
    private Button CancelationButton;
    private Button OkButton;
}