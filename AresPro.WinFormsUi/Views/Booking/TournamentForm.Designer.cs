namespace AresPro.WinFormsUi.Views.Booking;

partial class TournamentForm
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
        Participant1ComboBox = new ComboBox();
        Participant2ComboBox = new ComboBox();
        Participant3ComboBox = new ComboBox();
        Participant4ComboBox = new ComboBox();
        Participant5ComboBox = new ComboBox();
        Participant6ComboBox = new ComboBox();
        Participant7ComboBox = new ComboBox();
        Participant8ComboBox = new ComboBox();
        CancelButton = new Button();
        OkButton = new Button();
        groupBox3 = new GroupBox();
        WinnerComboBox = new ComboBox();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // Participant1ComboBox
        // 
        Participant1ComboBox.FormattingEnabled = true;
        Participant1ComboBox.Location = new Point(12, 12);
        Participant1ComboBox.Name = "Participant1ComboBox";
        Participant1ComboBox.Size = new Size(182, 23);
        Participant1ComboBox.TabIndex = 0;
        // 
        // Participant2ComboBox
        // 
        Participant2ComboBox.FormattingEnabled = true;
        Participant2ComboBox.Location = new Point(12, 41);
        Participant2ComboBox.Name = "Participant2ComboBox";
        Participant2ComboBox.Size = new Size(182, 23);
        Participant2ComboBox.TabIndex = 1;
        // 
        // Participant3ComboBox
        // 
        Participant3ComboBox.FormattingEnabled = true;
        Participant3ComboBox.Location = new Point(12, 70);
        Participant3ComboBox.Name = "Participant3ComboBox";
        Participant3ComboBox.Size = new Size(182, 23);
        Participant3ComboBox.TabIndex = 2;
        // 
        // Participant4ComboBox
        // 
        Participant4ComboBox.FormattingEnabled = true;
        Participant4ComboBox.Location = new Point(12, 99);
        Participant4ComboBox.Name = "Participant4ComboBox";
        Participant4ComboBox.Size = new Size(182, 23);
        Participant4ComboBox.TabIndex = 3;
        // 
        // Participant5ComboBox
        // 
        Participant5ComboBox.FormattingEnabled = true;
        Participant5ComboBox.Location = new Point(12, 128);
        Participant5ComboBox.Name = "Participant5ComboBox";
        Participant5ComboBox.Size = new Size(182, 23);
        Participant5ComboBox.TabIndex = 4;
        // 
        // Participant6ComboBox
        // 
        Participant6ComboBox.FormattingEnabled = true;
        Participant6ComboBox.Location = new Point(12, 157);
        Participant6ComboBox.Name = "Participant6ComboBox";
        Participant6ComboBox.Size = new Size(182, 23);
        Participant6ComboBox.TabIndex = 5;
        // 
        // Participant7ComboBox
        // 
        Participant7ComboBox.FormattingEnabled = true;
        Participant7ComboBox.Location = new Point(12, 186);
        Participant7ComboBox.Name = "Participant7ComboBox";
        Participant7ComboBox.Size = new Size(182, 23);
        Participant7ComboBox.TabIndex = 6;
        // 
        // Participant8ComboBox
        // 
        Participant8ComboBox.FormattingEnabled = true;
        Participant8ComboBox.Location = new Point(12, 215);
        Participant8ComboBox.Name = "Participant8ComboBox";
        Participant8ComboBox.Size = new Size(182, 23);
        Participant8ComboBox.TabIndex = 7;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(206, 272);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(75, 23);
        CancelButton.TabIndex = 12;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(287, 272);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(75, 23);
        OkButton.TabIndex = 11;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(WinnerComboBox);
        groupBox3.Location = new Point(12, 244);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(188, 51);
        groupBox3.TabIndex = 10;
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
        // TournamentForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(374, 307);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        Controls.Add(groupBox3);
        Controls.Add(Participant8ComboBox);
        Controls.Add(Participant7ComboBox);
        Controls.Add(Participant6ComboBox);
        Controls.Add(Participant5ComboBox);
        Controls.Add(Participant4ComboBox);
        Controls.Add(Participant3ComboBox);
        Controls.Add(Participant2ComboBox);
        Controls.Add(Participant1ComboBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TournamentForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Zeus Tournament";
        groupBox3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ComboBox Participant1ComboBox;
    private ComboBox Participant2ComboBox;
    private ComboBox Participant3ComboBox;
    private ComboBox Participant4ComboBox;
    private ComboBox Participant5ComboBox;
    private ComboBox Participant6ComboBox;
    private ComboBox Participant7ComboBox;
    private ComboBox Participant8ComboBox;
    private Button CancelButton;
    private Button OkButton;
    private GroupBox groupBox3;
    private ComboBox WinnerComboBox;
}