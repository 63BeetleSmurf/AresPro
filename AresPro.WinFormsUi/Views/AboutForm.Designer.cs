namespace AresPro.WinFormsUi.Views;

partial class AboutForm
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
        IconPictureBox = new PictureBox();
        CopyrightLabel = new Label();
        VersionLabel = new Label();
        TitleLabel = new Label();
        AboutFrame = new GroupBox();
        CompanyLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)IconPictureBox).BeginInit();
        AboutFrame.SuspendLayout();
        SuspendLayout();
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(203, 133);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(88, 27);
        OkButton.TabIndex = 4;
        OkButton.Text = "Ok";
        OkButton.UseVisualStyleBackColor = true;
        OkButton.Click += OkButton_Click;
        // 
        // IconPictureBox
        // 
        IconPictureBox.Location = new Point(13, 30);
        IconPictureBox.Margin = new Padding(4, 3, 4, 3);
        IconPictureBox.Name = "IconPictureBox";
        IconPictureBox.Size = new Size(37, 37);
        IconPictureBox.TabIndex = 3;
        IconPictureBox.TabStop = false;
        // 
        // CopyrightLabel
        // 
        CopyrightLabel.AutoSize = true;
        CopyrightLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        CopyrightLabel.Location = new Point(7, 67);
        CopyrightLabel.Margin = new Padding(4, 0, 4, 0);
        CopyrightLabel.Name = "CopyrightLabel";
        CopyrightLabel.Size = new Size(131, 16);
        CopyrightLabel.TabIndex = 2;
        CopyrightLabel.Text = "Copyright (c) 2025";
        // 
        // VersionLabel
        // 
        VersionLabel.AutoSize = true;
        VersionLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        VersionLabel.Location = new Point(7, 43);
        VersionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionLabel.Name = "VersionLabel";
        VersionLabel.Size = new Size(64, 16);
        VersionLabel.TabIndex = 1;
        VersionLabel.Text = "Version ";
        // 
        // TitleLabel
        // 
        TitleLabel.AutoSize = true;
        TitleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        TitleLabel.Location = new Point(7, 18);
        TitleLabel.Margin = new Padding(4, 0, 4, 0);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new Size(67, 16);
        TitleLabel.TabIndex = 0;
        TitleLabel.Text = "Ares Pro";
        // 
        // AboutFrame
        // 
        AboutFrame.Controls.Add(CompanyLabel);
        AboutFrame.Controls.Add(CopyrightLabel);
        AboutFrame.Controls.Add(VersionLabel);
        AboutFrame.Controls.Add(TitleLabel);
        AboutFrame.Location = new Point(58, 12);
        AboutFrame.Margin = new Padding(4, 3, 4, 3);
        AboutFrame.Name = "AboutFrame";
        AboutFrame.Padding = new Padding(4, 3, 4, 3);
        AboutFrame.Size = new Size(233, 115);
        AboutFrame.TabIndex = 2;
        AboutFrame.TabStop = false;
        // 
        // CompanyLabel
        // 
        CompanyLabel.AutoSize = true;
        CompanyLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        CompanyLabel.Location = new Point(7, 91);
        CompanyLabel.Margin = new Padding(4, 0, 4, 0);
        CompanyLabel.Name = "CompanyLabel";
        CompanyLabel.Size = new Size(94, 16);
        CompanyLabel.TabIndex = 3;
        CompanyLabel.Text = "Geeksoft.net";
        // 
        // AboutForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(304, 172);
        Controls.Add(OkButton);
        Controls.Add(IconPictureBox);
        Controls.Add(AboutFrame);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AboutForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "About...";
        ((System.ComponentModel.ISupportInitialize)IconPictureBox).EndInit();
        AboutFrame.ResumeLayout(false);
        AboutFrame.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.PictureBox IconPictureBox;
    internal System.Windows.Forms.Label CopyrightLabel;
    internal System.Windows.Forms.Label VersionLabel;
    internal System.Windows.Forms.Label TitleLabel;
    internal System.Windows.Forms.GroupBox AboutFrame;
    internal System.Windows.Forms.Label CompanyLabel;
}
