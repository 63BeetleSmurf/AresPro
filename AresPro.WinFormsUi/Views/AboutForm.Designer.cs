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
        this.OkCommand = new System.Windows.Forms.Button();
        this.IconPicture = new System.Windows.Forms.PictureBox();
        this.CopyrightLabel = new System.Windows.Forms.Label();
        this.VersionLabel = new System.Windows.Forms.Label();
        this.TitleLabel = new System.Windows.Forms.Label();
        this.AboutFrame = new System.Windows.Forms.GroupBox();
        this.CompanyLabel = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
        this.AboutFrame.SuspendLayout();
        this.SuspendLayout();
        // 
        // OkCommand
        // 
        this.OkCommand.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.OkCommand.Location = new System.Drawing.Point(444, 267);
        this.OkCommand.Name = "OkCommand";
        this.OkCommand.Size = new System.Drawing.Size(75, 23);
        this.OkCommand.TabIndex = 4;
        this.OkCommand.Text = "Ok";
        this.OkCommand.UseVisualStyleBackColor = true;
        // 
        // IconPicture
        // 
        this.IconPicture.Location = new System.Drawing.Point(281, 170);
        this.IconPicture.Name = "IconPicture";
        this.IconPicture.Size = new System.Drawing.Size(32, 32);
        this.IconPicture.TabIndex = 3;
        this.IconPicture.TabStop = false;
        // 
        // CopyrightLabel
        // 
        this.CopyrightLabel.AutoSize = true;
        this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.CopyrightLabel.Location = new System.Drawing.Point(6, 58);
        this.CopyrightLabel.Name = "CopyrightLabel";
        this.CopyrightLabel.Size = new System.Drawing.Size(0, 16);
        this.CopyrightLabel.TabIndex = 2;
        // 
        // VersionLabel
        // 
        this.VersionLabel.AutoSize = true;
        this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.VersionLabel.Location = new System.Drawing.Point(6, 37);
        this.VersionLabel.Name = "VersionLabel";
        this.VersionLabel.Size = new System.Drawing.Size(0, 16);
        this.VersionLabel.TabIndex = 1;
        // 
        // TitleLabel
        // 
        this.TitleLabel.AutoSize = true;
        this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.TitleLabel.Location = new System.Drawing.Point(6, 16);
        this.TitleLabel.Name = "TitleLabel";
        this.TitleLabel.Size = new System.Drawing.Size(0, 16);
        this.TitleLabel.TabIndex = 0;
        // 
        // AboutFrame
        // 
        this.AboutFrame.Controls.Add(this.CompanyLabel);
        this.AboutFrame.Controls.Add(this.CopyrightLabel);
        this.AboutFrame.Controls.Add(this.VersionLabel);
        this.AboutFrame.Controls.Add(this.TitleLabel);
        this.AboutFrame.Location = new System.Drawing.Point(319, 161);
        this.AboutFrame.Name = "AboutFrame";
        this.AboutFrame.Size = new System.Drawing.Size(200, 100);
        this.AboutFrame.TabIndex = 2;
        this.AboutFrame.TabStop = false;
        // 
        // CompanyLabel
        // 
        this.CompanyLabel.AutoSize = true;
        this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.CompanyLabel.Location = new System.Drawing.Point(6, 79);
        this.CompanyLabel.Name = "CompanyLabel";
        this.CompanyLabel.Size = new System.Drawing.Size(0, 16);
        this.CompanyLabel.TabIndex = 3;
        // 
        // AboutForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.OkCommand);
        this.Controls.Add(this.IconPicture);
        this.Controls.Add(this.AboutFrame);
        this.Name = "AboutForm";
        this.Text = "AboutForm";
        ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
        this.AboutFrame.ResumeLayout(false);
        this.AboutFrame.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Button OkCommand;
    internal System.Windows.Forms.PictureBox IconPicture;
    internal System.Windows.Forms.Label CopyrightLabel;
    internal System.Windows.Forms.Label VersionLabel;
    internal System.Windows.Forms.Label TitleLabel;
    internal System.Windows.Forms.GroupBox AboutFrame;
    internal System.Windows.Forms.Label CompanyLabel;
}
