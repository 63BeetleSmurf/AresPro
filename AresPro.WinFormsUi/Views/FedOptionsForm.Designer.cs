namespace AresPro.WinFormsUi.Views;

partial class FedOptionsForm
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
        CancelationButton = new Button();
        lblBackgroundColor = new Label();
        BackgroundColorTextBox = new TextBox();
        lblFontColor = new Label();
        FontColorTextBox = new TextBox();
        lblStatMax = new Label();
        StatMaxTextBox = new TextBox();
        IncludeMatchHeadingCheckBox = new CheckBox();
        ShowOnlyEndingsCheckBox = new CheckBox();
        MovesInBlockFormatCheckBox = new CheckBox();
        IncludeCommentaryCheckBox = new CheckBox();
        lblWebsite = new Label();
        WebsiteTextBox = new TextBox();
        lblOwner = new Label();
        OwnerTextBox = new TextBox();
        lblName = new Label();
        NameTextBox = new TextBox();
        SuspendLayout();
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(272, 178);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(78, 27);
        OkButton.TabIndex = 11;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(186, 178);
        CancelationButton.Margin = new Padding(4, 3, 4, 3);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(78, 27);
        CancelationButton.TabIndex = 10;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // lblBackgroundColor
        // 
        lblBackgroundColor.AutoSize = true;
        lblBackgroundColor.Location = new Point(13, 181);
        lblBackgroundColor.Margin = new Padding(4, 0, 4, 0);
        lblBackgroundColor.Name = "lblBackgroundColor";
        lblBackgroundColor.Size = new Size(72, 15);
        lblBackgroundColor.TabIndex = 32;
        lblBackgroundColor.Text = "BGCOLOR =";
        // 
        // BackgroundColorTextBox
        // 
        BackgroundColorTextBox.Location = new Point(93, 178);
        BackgroundColorTextBox.Margin = new Padding(4, 3, 4, 3);
        BackgroundColorTextBox.Name = "BackgroundColorTextBox";
        BackgroundColorTextBox.Size = new Size(83, 23);
        BackgroundColorTextBox.TabIndex = 9;
        // 
        // lblFontColor
        // 
        lblFontColor.AutoSize = true;
        lblFontColor.Location = new Point(184, 152);
        lblFontColor.Margin = new Padding(4, 0, 4, 0);
        lblFontColor.Name = "lblFontColor";
        lblFontColor.Size = new Size(74, 15);
        lblFontColor.TabIndex = 30;
        lblFontColor.Text = "Font Color =";
        // 
        // FontColorTextBox
        // 
        FontColorTextBox.Location = new Point(266, 149);
        FontColorTextBox.Margin = new Padding(4, 3, 4, 3);
        FontColorTextBox.Name = "FontColorTextBox";
        FontColorTextBox.Size = new Size(83, 23);
        FontColorTextBox.TabIndex = 8;
        // 
        // lblStatMax
        // 
        lblStatMax.AutoSize = true;
        lblStatMax.Location = new Point(13, 152);
        lblStatMax.Margin = new Padding(4, 0, 4, 0);
        lblStatMax.Name = "lblStatMax";
        lblStatMax.Size = new Size(68, 15);
        lblStatMax.TabIndex = 28;
        lblStatMax.Text = "STATMAX =";
        // 
        // StatMaxTextBox
        // 
        StatMaxTextBox.Location = new Point(93, 149);
        StatMaxTextBox.Margin = new Padding(4, 3, 4, 3);
        StatMaxTextBox.Name = "StatMaxTextBox";
        StatMaxTextBox.Size = new Size(83, 23);
        StatMaxTextBox.TabIndex = 7;
        // 
        // IncludeMatchHeadingCheckBox
        // 
        IncludeMatchHeadingCheckBox.AutoSize = true;
        IncludeMatchHeadingCheckBox.Location = new Point(178, 124);
        IncludeMatchHeadingCheckBox.Margin = new Padding(4, 3, 4, 3);
        IncludeMatchHeadingCheckBox.Name = "IncludeMatchHeadingCheckBox";
        IncludeMatchHeadingCheckBox.Size = new Size(148, 19);
        IncludeMatchHeadingCheckBox.TabIndex = 6;
        IncludeMatchHeadingCheckBox.Text = "Include match heading";
        IncludeMatchHeadingCheckBox.UseVisualStyleBackColor = true;
        // 
        // ShowOnlyEndingsCheckBox
        // 
        ShowOnlyEndingsCheckBox.AutoSize = true;
        ShowOnlyEndingsCheckBox.Location = new Point(34, 124);
        ShowOnlyEndingsCheckBox.Margin = new Padding(4, 3, 4, 3);
        ShowOnlyEndingsCheckBox.Name = "ShowOnlyEndingsCheckBox";
        ShowOnlyEndingsCheckBox.Size = new Size(126, 19);
        ShowOnlyEndingsCheckBox.TabIndex = 5;
        ShowOnlyEndingsCheckBox.Text = "Show only endings";
        ShowOnlyEndingsCheckBox.UseVisualStyleBackColor = true;
        // 
        // MovesInBlockFormatCheckBox
        // 
        MovesInBlockFormatCheckBox.AutoSize = true;
        MovesInBlockFormatCheckBox.Location = new Point(178, 99);
        MovesInBlockFormatCheckBox.Margin = new Padding(4, 3, 4, 3);
        MovesInBlockFormatCheckBox.Name = "MovesInBlockFormatCheckBox";
        MovesInBlockFormatCheckBox.Size = new Size(145, 19);
        MovesInBlockFormatCheckBox.TabIndex = 4;
        MovesInBlockFormatCheckBox.Text = "Moves in block format";
        MovesInBlockFormatCheckBox.UseVisualStyleBackColor = true;
        // 
        // IncludeCommentaryCheckBox
        // 
        IncludeCommentaryCheckBox.AutoSize = true;
        IncludeCommentaryCheckBox.Location = new Point(34, 99);
        IncludeCommentaryCheckBox.Margin = new Padding(4, 3, 4, 3);
        IncludeCommentaryCheckBox.Name = "IncludeCommentaryCheckBox";
        IncludeCommentaryCheckBox.Size = new Size(136, 19);
        IncludeCommentaryCheckBox.TabIndex = 3;
        IncludeCommentaryCheckBox.Text = "Include commentary";
        IncludeCommentaryCheckBox.UseVisualStyleBackColor = true;
        // 
        // lblWebsite
        // 
        lblWebsite.AutoSize = true;
        lblWebsite.Location = new Point(13, 73);
        lblWebsite.Margin = new Padding(4, 0, 4, 0);
        lblWebsite.Name = "lblWebsite";
        lblWebsite.Size = new Size(49, 15);
        lblWebsite.TabIndex = 22;
        lblWebsite.Text = "Website";
        // 
        // WebsiteTextBox
        // 
        WebsiteTextBox.Location = new Point(82, 70);
        WebsiteTextBox.Margin = new Padding(4, 3, 4, 3);
        WebsiteTextBox.Name = "WebsiteTextBox";
        WebsiteTextBox.Size = new Size(268, 23);
        WebsiteTextBox.TabIndex = 2;
        // 
        // lblOwner
        // 
        lblOwner.AutoSize = true;
        lblOwner.Location = new Point(13, 44);
        lblOwner.Margin = new Padding(4, 0, 4, 0);
        lblOwner.Name = "lblOwner";
        lblOwner.Size = new Size(42, 15);
        lblOwner.TabIndex = 20;
        lblOwner.Text = "Owner";
        // 
        // OwnerTextBox
        // 
        OwnerTextBox.Location = new Point(82, 41);
        OwnerTextBox.Margin = new Padding(4, 3, 4, 3);
        OwnerTextBox.Name = "OwnerTextBox";
        OwnerTextBox.Size = new Size(268, 23);
        OwnerTextBox.TabIndex = 1;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(13, 15);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(61, 15);
        lblName.TabIndex = 18;
        lblName.Text = "Fed Name";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(82, 12);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(268, 23);
        NameTextBox.TabIndex = 0;
        // 
        // FedOptionsForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelationButton;
        ClientSize = new Size(363, 217);
        Controls.Add(OkButton);
        Controls.Add(CancelationButton);
        Controls.Add(lblBackgroundColor);
        Controls.Add(BackgroundColorTextBox);
        Controls.Add(lblFontColor);
        Controls.Add(FontColorTextBox);
        Controls.Add(lblStatMax);
        Controls.Add(StatMaxTextBox);
        Controls.Add(IncludeMatchHeadingCheckBox);
        Controls.Add(ShowOnlyEndingsCheckBox);
        Controls.Add(MovesInBlockFormatCheckBox);
        Controls.Add(IncludeCommentaryCheckBox);
        Controls.Add(lblWebsite);
        Controls.Add(WebsiteTextBox);
        Controls.Add(lblOwner);
        Controls.Add(OwnerTextBox);
        Controls.Add(lblName);
        Controls.Add(NameTextBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FedOptionsForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Federation Options";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.Button CancelationButton;
    internal System.Windows.Forms.Label lblBackgroundColor;
    internal System.Windows.Forms.TextBox BackgroundColorTextBox;
    internal System.Windows.Forms.Label lblFontColor;
    internal System.Windows.Forms.TextBox FontColorTextBox;
    internal System.Windows.Forms.Label lblStatMax;
    internal System.Windows.Forms.TextBox StatMaxTextBox;
    internal System.Windows.Forms.CheckBox IncludeMatchHeadingCheckBox;
    internal System.Windows.Forms.CheckBox ShowOnlyEndingsCheckBox;
    internal System.Windows.Forms.CheckBox MovesInBlockFormatCheckBox;
    internal System.Windows.Forms.CheckBox IncludeCommentaryCheckBox;
    internal System.Windows.Forms.Label lblWebsite;
    internal System.Windows.Forms.TextBox WebsiteTextBox;
    internal System.Windows.Forms.Label lblOwner;
    internal System.Windows.Forms.TextBox OwnerTextBox;
    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.TextBox NameTextBox;
}
