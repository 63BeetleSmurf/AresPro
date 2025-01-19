namespace AresPro.WinFormsUi.Views;

partial class RankingsForm
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
        CancelButton = new Button();
        CreateButton = new Button();
        ByPushRadioButton = new RadioButton();
        ByNameRadioButton = new RadioButton();
        ByWinLossRatioRadioButton = new RadioButton();
        ByLosesRadioButton = new RadioButton();
        ByWinsRadioButton = new RadioButton();
        SuspendLayout();
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(45, 170);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(88, 27);
        CancelButton.TabIndex = 6;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // CreateButton
        // 
        CreateButton.Location = new Point(45, 137);
        CreateButton.Margin = new Padding(4, 3, 4, 3);
        CreateButton.Name = "CreateButton";
        CreateButton.Size = new Size(88, 27);
        CreateButton.TabIndex = 5;
        CreateButton.Text = "Create";
        CreateButton.UseVisualStyleBackColor = true;
        // 
        // ByPushRadioButton
        // 
        ByPushRadioButton.AutoSize = true;
        ByPushRadioButton.Location = new Point(13, 112);
        ByPushRadioButton.Margin = new Padding(4, 3, 4, 3);
        ByPushRadioButton.Name = "ByPushRadioButton";
        ByPushRadioButton.Size = new Size(67, 19);
        ByPushRadioButton.TabIndex = 4;
        ByPushRadioButton.TabStop = true;
        ByPushRadioButton.Text = "By Push";
        ByPushRadioButton.UseVisualStyleBackColor = true;
        // 
        // ByNameRadioButton
        // 
        ByNameRadioButton.AutoSize = true;
        ByNameRadioButton.Location = new Point(13, 87);
        ByNameRadioButton.Margin = new Padding(4, 3, 4, 3);
        ByNameRadioButton.Name = "ByNameRadioButton";
        ByNameRadioButton.Size = new Size(73, 19);
        ByNameRadioButton.TabIndex = 3;
        ByNameRadioButton.TabStop = true;
        ByNameRadioButton.Text = "By Name";
        ByNameRadioButton.UseVisualStyleBackColor = true;
        // 
        // ByWinLossRatioRadioButton
        // 
        ByWinLossRatioRadioButton.AutoSize = true;
        ByWinLossRatioRadioButton.Location = new Point(13, 62);
        ByWinLossRatioRadioButton.Margin = new Padding(4, 3, 4, 3);
        ByWinLossRatioRadioButton.Name = "ByWinLossRatioRadioButton";
        ByWinLossRatioRadioButton.Size = new Size(120, 19);
        ByWinLossRatioRadioButton.TabIndex = 2;
        ByWinLossRatioRadioButton.TabStop = true;
        ByWinLossRatioRadioButton.Text = "By Win/Loss Ratio";
        ByWinLossRatioRadioButton.UseVisualStyleBackColor = true;
        // 
        // ByLosesRadioButton
        // 
        ByLosesRadioButton.AutoSize = true;
        ByLosesRadioButton.Location = new Point(13, 37);
        ByLosesRadioButton.Margin = new Padding(4, 3, 4, 3);
        ByLosesRadioButton.Name = "ByLosesRadioButton";
        ByLosesRadioButton.Size = new Size(70, 19);
        ByLosesRadioButton.TabIndex = 1;
        ByLosesRadioButton.TabStop = true;
        ByLosesRadioButton.Text = "By Loses";
        ByLosesRadioButton.UseVisualStyleBackColor = true;
        // 
        // ByWinsRadioButton
        // 
        ByWinsRadioButton.AutoSize = true;
        ByWinsRadioButton.Location = new Point(13, 12);
        ByWinsRadioButton.Margin = new Padding(4, 3, 4, 3);
        ByWinsRadioButton.Name = "ByWinsRadioButton";
        ByWinsRadioButton.Size = new Size(67, 19);
        ByWinsRadioButton.TabIndex = 0;
        ByWinsRadioButton.TabStop = true;
        ByWinsRadioButton.Text = "By Wins";
        ByWinsRadioButton.UseVisualStyleBackColor = true;
        // 
        // RankingsForm
        // 
        AcceptButton = CreateButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelButton;
        ClientSize = new Size(146, 209);
        Controls.Add(CancelButton);
        Controls.Add(CreateButton);
        Controls.Add(ByPushRadioButton);
        Controls.Add(ByNameRadioButton);
        Controls.Add(ByWinLossRatioRadioButton);
        Controls.Add(ByLosesRadioButton);
        Controls.Add(ByWinsRadioButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RankingsForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Zeus Rankings";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.Button CreateButton;
    internal System.Windows.Forms.RadioButton ByPushRadioButton;
    internal System.Windows.Forms.RadioButton ByNameRadioButton;
    internal System.Windows.Forms.RadioButton ByWinLossRatioRadioButton;
    internal System.Windows.Forms.RadioButton ByLosesRadioButton;
    internal System.Windows.Forms.RadioButton ByWinsRadioButton;
}
