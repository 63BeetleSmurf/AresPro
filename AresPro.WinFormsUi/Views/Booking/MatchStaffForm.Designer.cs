namespace AresPro.WinFormsUi.Views.Booking;

partial class MatchStaffForm
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
        Commentator1ComboBox = new ComboBox();
        Commentator2ComboBox = new ComboBox();
        Commentator3ComboBox = new ComboBox();
        Commentator4ComboBox = new ComboBox();
        groupBox2 = new GroupBox();
        RefereeComboBox = new ComboBox();
        groupBox3 = new GroupBox();
        RingAnnouncerComboBox = new ComboBox();
        OkButton = new Button();
        CancelButton = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(Commentator4ComboBox);
        groupBox1.Controls.Add(Commentator3ComboBox);
        groupBox1.Controls.Add(Commentator2ComboBox);
        groupBox1.Controls.Add(Commentator1ComboBox);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(187, 138);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Commentators";
        // 
        // Commentator1ComboBox
        // 
        Commentator1ComboBox.FormattingEnabled = true;
        Commentator1ComboBox.Location = new Point(6, 22);
        Commentator1ComboBox.Name = "Commentator1ComboBox";
        Commentator1ComboBox.Size = new Size(175, 23);
        Commentator1ComboBox.TabIndex = 0;
        // 
        // Commentator2ComboBox
        // 
        Commentator2ComboBox.FormattingEnabled = true;
        Commentator2ComboBox.Location = new Point(6, 51);
        Commentator2ComboBox.Name = "Commentator2ComboBox";
        Commentator2ComboBox.Size = new Size(175, 23);
        Commentator2ComboBox.TabIndex = 1;
        // 
        // Commentator3ComboBox
        // 
        Commentator3ComboBox.FormattingEnabled = true;
        Commentator3ComboBox.Location = new Point(6, 80);
        Commentator3ComboBox.Name = "Commentator3ComboBox";
        Commentator3ComboBox.Size = new Size(175, 23);
        Commentator3ComboBox.TabIndex = 2;
        // 
        // Commentator4ComboBox
        // 
        Commentator4ComboBox.FormattingEnabled = true;
        Commentator4ComboBox.Location = new Point(6, 109);
        Commentator4ComboBox.Name = "Commentator4ComboBox";
        Commentator4ComboBox.Size = new Size(175, 23);
        Commentator4ComboBox.TabIndex = 3;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(RefereeComboBox);
        groupBox2.Location = new Point(12, 156);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(187, 51);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Referee";
        // 
        // RefereeComboBox
        // 
        RefereeComboBox.FormattingEnabled = true;
        RefereeComboBox.Location = new Point(6, 22);
        RefereeComboBox.Name = "RefereeComboBox";
        RefereeComboBox.Size = new Size(175, 23);
        RefereeComboBox.TabIndex = 4;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(RingAnnouncerComboBox);
        groupBox3.Location = new Point(12, 213);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(187, 51);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Ring Announcer";
        // 
        // RingAnnouncerComboBox
        // 
        RingAnnouncerComboBox.FormattingEnabled = true;
        RingAnnouncerComboBox.Location = new Point(6, 22);
        RingAnnouncerComboBox.Name = "RingAnnouncerComboBox";
        RingAnnouncerComboBox.Size = new Size(175, 23);
        RingAnnouncerComboBox.TabIndex = 5;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(205, 205);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(75, 23);
        OkButton.TabIndex = 6;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(205, 234);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(75, 23);
        CancelButton.TabIndex = 7;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // MatchStaffForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelButton;
        ClientSize = new Size(292, 276);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MatchStaffForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Change Commentators/Referee/Announcer";
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private ComboBox Commentator4ComboBox;
    private ComboBox Commentator3ComboBox;
    private ComboBox Commentator2ComboBox;
    private ComboBox Commentator1ComboBox;
    private GroupBox groupBox2;
    private ComboBox RefereeComboBox;
    private GroupBox groupBox3;
    private ComboBox RingAnnouncerComboBox;
    private Button OkButton;
    private Button CancelButton;
}