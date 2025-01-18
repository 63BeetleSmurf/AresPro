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
        this.OkCommand = new System.Windows.Forms.Button();
        this.CancelCommand = new System.Windows.Forms.Button();
        this.lblBackgroundColor = new System.Windows.Forms.Label();
        this.BackgroundColorField = new System.Windows.Forms.TextBox();
        this.lblFontColor = new System.Windows.Forms.Label();
        this.FontColorField = new System.Windows.Forms.TextBox();
        this.lblStatMax = new System.Windows.Forms.Label();
        this.StatMaxField = new System.Windows.Forms.TextBox();
        this.MatchHeadingCheckBox = new System.Windows.Forms.CheckBox();
        this.OnlyEndingsCheckBox = new System.Windows.Forms.CheckBox();
        this.BlockFormatMovesCheckBox = new System.Windows.Forms.CheckBox();
        this.CommentaryCheckBox = new System.Windows.Forms.CheckBox();
        this.lblWebsite = new System.Windows.Forms.Label();
        this.WebsiteField = new System.Windows.Forms.TextBox();
        this.lblOwner = new System.Windows.Forms.Label();
        this.OwnerField = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.NameField = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // OkCommand
        // 
        this.OkCommand.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.OkCommand.Location = new System.Drawing.Point(471, 289);
        this.OkCommand.Name = "OkCommand";
        this.OkCommand.Size = new System.Drawing.Size(75, 23);
        this.OkCommand.TabIndex = 35;
        this.OkCommand.Text = "&Ok";
        this.OkCommand.UseVisualStyleBackColor = true;
        // 
        // CancelCommand
        // 
        this.CancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.CancelCommand.Location = new System.Drawing.Point(390, 289);
        this.CancelCommand.Name = "CancelCommand";
        this.CancelCommand.Size = new System.Drawing.Size(75, 23);
        this.CancelCommand.TabIndex = 34;
        this.CancelCommand.Text = "&Cancel";
        this.CancelCommand.UseVisualStyleBackColor = true;
        // 
        // lblBackgroundColor
        // 
        this.lblBackgroundColor.AutoSize = true;
        this.lblBackgroundColor.Location = new System.Drawing.Point(254, 292);
        this.lblBackgroundColor.Name = "lblBackgroundColor";
        this.lblBackgroundColor.Size = new System.Drawing.Size(49, 13);
        this.lblBackgroundColor.TabIndex = 32;
        this.lblBackgroundColor.Text = "BG Color";
        // 
        // BackgroundColorField
        // 
        this.BackgroundColorField.Location = new System.Drawing.Point(309, 289);
        this.BackgroundColorField.Name = "BackgroundColorField";
        this.BackgroundColorField.Size = new System.Drawing.Size(72, 20);
        this.BackgroundColorField.TabIndex = 33;
        // 
        // lblFontColor
        // 
        this.lblFontColor.AutoSize = true;
        this.lblFontColor.Location = new System.Drawing.Point(393, 266);
        this.lblFontColor.Name = "lblFontColor";
        this.lblFontColor.Size = new System.Drawing.Size(55, 13);
        this.lblFontColor.TabIndex = 30;
        this.lblFontColor.Text = "Font Color";
        // 
        // FontColorField
        // 
        this.FontColorField.Location = new System.Drawing.Point(454, 263);
        this.FontColorField.Name = "FontColorField";
        this.FontColorField.Size = new System.Drawing.Size(72, 20);
        this.FontColorField.TabIndex = 31;
        // 
        // lblStatMax
        // 
        this.lblStatMax.AutoSize = true;
        this.lblStatMax.Location = new System.Drawing.Point(254, 266);
        this.lblStatMax.Name = "lblStatMax";
        this.lblStatMax.Size = new System.Drawing.Size(49, 13);
        this.lblStatMax.TabIndex = 28;
        this.lblStatMax.Text = "Stat Max";
        // 
        // StatMaxField
        // 
        this.StatMaxField.Location = new System.Drawing.Point(309, 263);
        this.StatMaxField.Name = "StatMaxField";
        this.StatMaxField.Size = new System.Drawing.Size(72, 20);
        this.StatMaxField.TabIndex = 29;
        // 
        // MatchHeadingCheckBox
        // 
        this.MatchHeadingCheckBox.AutoSize = true;
        this.MatchHeadingCheckBox.Location = new System.Drawing.Point(396, 240);
        this.MatchHeadingCheckBox.Name = "MatchHeadingCheckBox";
        this.MatchHeadingCheckBox.Size = new System.Drawing.Size(134, 17);
        this.MatchHeadingCheckBox.TabIndex = 27;
        this.MatchHeadingCheckBox.Text = "Include match heading";
        this.MatchHeadingCheckBox.UseVisualStyleBackColor = true;
        // 
        // OnlyEndingsCheckBox
        // 
        this.OnlyEndingsCheckBox.AutoSize = true;
        this.OnlyEndingsCheckBox.Location = new System.Drawing.Point(257, 240);
        this.OnlyEndingsCheckBox.Name = "OnlyEndingsCheckBox";
        this.OnlyEndingsCheckBox.Size = new System.Drawing.Size(115, 17);
        this.OnlyEndingsCheckBox.TabIndex = 26;
        this.OnlyEndingsCheckBox.Text = "Show only endings";
        this.OnlyEndingsCheckBox.UseVisualStyleBackColor = true;
        // 
        // BlockFormatMovesCheckBox
        // 
        this.BlockFormatMovesCheckBox.AutoSize = true;
        this.BlockFormatMovesCheckBox.Location = new System.Drawing.Point(396, 217);
        this.BlockFormatMovesCheckBox.Name = "BlockFormatMovesCheckBox";
        this.BlockFormatMovesCheckBox.Size = new System.Drawing.Size(130, 17);
        this.BlockFormatMovesCheckBox.TabIndex = 25;
        this.BlockFormatMovesCheckBox.Text = "Moves in block format";
        this.BlockFormatMovesCheckBox.UseVisualStyleBackColor = true;
        // 
        // CommentaryCheckBox
        // 
        this.CommentaryCheckBox.AutoSize = true;
        this.CommentaryCheckBox.Location = new System.Drawing.Point(257, 217);
        this.CommentaryCheckBox.Name = "CommentaryCheckBox";
        this.CommentaryCheckBox.Size = new System.Drawing.Size(121, 17);
        this.CommentaryCheckBox.TabIndex = 24;
        this.CommentaryCheckBox.Text = "Include commentary";
        this.CommentaryCheckBox.UseVisualStyleBackColor = true;
        // 
        // lblWebsite
        // 
        this.lblWebsite.AutoSize = true;
        this.lblWebsite.Location = new System.Drawing.Point(254, 194);
        this.lblWebsite.Name = "lblWebsite";
        this.lblWebsite.Size = new System.Drawing.Size(46, 13);
        this.lblWebsite.TabIndex = 22;
        this.lblWebsite.Text = "Website";
        // 
        // WebsiteField
        // 
        this.WebsiteField.Location = new System.Drawing.Point(316, 191);
        this.WebsiteField.Name = "WebsiteField";
        this.WebsiteField.Size = new System.Drawing.Size(230, 20);
        this.WebsiteField.TabIndex = 23;
        // 
        // lblOwner
        // 
        this.lblOwner.AutoSize = true;
        this.lblOwner.Location = new System.Drawing.Point(254, 168);
        this.lblOwner.Name = "lblOwner";
        this.lblOwner.Size = new System.Drawing.Size(38, 13);
        this.lblOwner.TabIndex = 20;
        this.lblOwner.Text = "Owner";
        // 
        // OwnerField
        // 
        this.OwnerField.Location = new System.Drawing.Point(316, 165);
        this.OwnerField.Name = "OwnerField";
        this.OwnerField.Size = new System.Drawing.Size(230, 20);
        this.OwnerField.TabIndex = 21;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(254, 142);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(56, 13);
        this.lblName.TabIndex = 18;
        this.lblName.Text = "Fed Name";
        // 
        // NameField
        // 
        this.NameField.Location = new System.Drawing.Point(316, 139);
        this.NameField.Name = "NameField";
        this.NameField.Size = new System.Drawing.Size(230, 20);
        this.NameField.TabIndex = 19;
        // 
        // FedOptionsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.OkCommand);
        this.Controls.Add(this.CancelCommand);
        this.Controls.Add(this.lblBackgroundColor);
        this.Controls.Add(this.BackgroundColorField);
        this.Controls.Add(this.lblFontColor);
        this.Controls.Add(this.FontColorField);
        this.Controls.Add(this.lblStatMax);
        this.Controls.Add(this.StatMaxField);
        this.Controls.Add(this.MatchHeadingCheckBox);
        this.Controls.Add(this.OnlyEndingsCheckBox);
        this.Controls.Add(this.BlockFormatMovesCheckBox);
        this.Controls.Add(this.CommentaryCheckBox);
        this.Controls.Add(this.lblWebsite);
        this.Controls.Add(this.WebsiteField);
        this.Controls.Add(this.lblOwner);
        this.Controls.Add(this.OwnerField);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.NameField);
        this.Name = "FedOptionsForm";
        this.Text = "FedOptionsForm";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button OkCommand;
    internal System.Windows.Forms.Button CancelCommand;
    internal System.Windows.Forms.Label lblBackgroundColor;
    internal System.Windows.Forms.TextBox BackgroundColorField;
    internal System.Windows.Forms.Label lblFontColor;
    internal System.Windows.Forms.TextBox FontColorField;
    internal System.Windows.Forms.Label lblStatMax;
    internal System.Windows.Forms.TextBox StatMaxField;
    internal System.Windows.Forms.CheckBox MatchHeadingCheckBox;
    internal System.Windows.Forms.CheckBox OnlyEndingsCheckBox;
    internal System.Windows.Forms.CheckBox BlockFormatMovesCheckBox;
    internal System.Windows.Forms.CheckBox CommentaryCheckBox;
    internal System.Windows.Forms.Label lblWebsite;
    internal System.Windows.Forms.TextBox WebsiteField;
    internal System.Windows.Forms.Label lblOwner;
    internal System.Windows.Forms.TextBox OwnerField;
    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.TextBox NameField;
}
