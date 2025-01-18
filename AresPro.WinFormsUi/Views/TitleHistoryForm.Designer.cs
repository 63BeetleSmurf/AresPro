namespace AresPro.WinFormsUi.Views;

partial class TitleHistoryForm
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
        this.btnClose = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnReset = new System.Windows.Forms.Button();
        this.btnHTML = new System.Windows.Forms.Button();
        this.lstTitleHistory = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // btnClose
        // 
        this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnClose.Location = new System.Drawing.Point(543, 323);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(75, 23);
        this.btnClose.TabIndex = 9;
        this.btnClose.Text = "&Close";
        this.btnClose.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        this.btnDelete.Location = new System.Drawing.Point(462, 323);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(75, 23);
        this.btnDelete.TabIndex = 8;
        this.btnDelete.Text = "&Delete";
        this.btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnReset
        // 
        this.btnReset.Location = new System.Drawing.Point(381, 323);
        this.btnReset.Name = "btnReset";
        this.btnReset.Size = new System.Drawing.Size(75, 23);
        this.btnReset.TabIndex = 7;
        this.btnReset.Text = "&Reset";
        this.btnReset.UseVisualStyleBackColor = true;
        // 
        // btnHTML
        // 
        this.btnHTML.Location = new System.Drawing.Point(183, 323);
        this.btnHTML.Name = "btnHTML";
        this.btnHTML.Size = new System.Drawing.Size(75, 23);
        this.btnHTML.TabIndex = 6;
        this.btnHTML.Text = "&HTML";
        this.btnHTML.UseVisualStyleBackColor = true;
        // 
        // lstTitleHistory
        // 
        this.lstTitleHistory.FormattingEnabled = true;
        this.lstTitleHistory.Location = new System.Drawing.Point(183, 105);
        this.lstTitleHistory.Name = "lstTitleHistory";
        this.lstTitleHistory.Size = new System.Drawing.Size(435, 212);
        this.lstTitleHistory.TabIndex = 5;
        // 
        // TitleHistoryForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.btnHTML);
        this.Controls.Add(this.lstTitleHistory);
        this.Name = "TitleHistoryForm";
        this.Text = "TitleHistoryForm";
        this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Button btnClose;
    internal System.Windows.Forms.Button btnDelete;
    internal System.Windows.Forms.Button btnReset;
    internal System.Windows.Forms.Button btnHTML;
    internal System.Windows.Forms.ListBox lstTitleHistory;
}
