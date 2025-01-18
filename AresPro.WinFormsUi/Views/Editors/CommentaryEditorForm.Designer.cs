namespace AresPro.WinFormsUi.Views.Editors;

partial class CommentaryEditorForm
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
        this.grpUsedWhen = new System.Windows.Forms.GroupBox();
        this.cboUsedWhen = new System.Windows.Forms.ComboBox();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.txtEdit = new System.Windows.Forms.TextBox();
        this.lstTexts = new System.Windows.Forms.ListBox();
        this.grpUsedWhen.SuspendLayout();
        this.SuspendLayout();
        // 
        // grpUsedWhen
        // 
        this.grpUsedWhen.Controls.Add(this.cboUsedWhen);
        this.grpUsedWhen.Location = new System.Drawing.Point(208, 111);
        this.grpUsedWhen.Name = "grpUsedWhen";
        this.grpUsedWhen.Size = new System.Drawing.Size(385, 46);
        this.grpUsedWhen.TabIndex = 5;
        this.grpUsedWhen.TabStop = false;
        this.grpUsedWhen.Text = "Used When";
        // 
        // cboUsedWhen
        // 
        this.cboUsedWhen.FormattingEnabled = true;
        this.cboUsedWhen.Items.AddRange(new object[] {
        "Match moves where pins count",
        "Match moves where pins do not count",
        "Match moves where submissions count",
        "Match moves where submissions do not count",
        "Match moves to count-out area",
        "Match moves to weapons",
        "Match moves away from weapons",
        "#ATT# uses a weak pin/submission",
        "#REC# escapes a pin/submission",
        "#ATT# almost gets the win",
        "#ATT# wins the match",
        "#ATT# uses a strong move",
        "#ATT# uses a normal move",
        "#ATT# uses a high risk move",
        "#ATT# uses an illegal move",
        "#ATT# uses a weapon",
        "There is blood in the current location",
        "The ref is counting them out",
        "#REC# is being double teamed",
        "#REC# is eliminated from match",
        "Question requiring yes answer",
        "Question requiring no answer",
        "Yes response",
        "No response",
        "Random comment"});
        this.cboUsedWhen.Location = new System.Drawing.Point(6, 19);
        this.cboUsedWhen.Name = "cboUsedWhen";
        this.cboUsedWhen.Size = new System.Drawing.Size(373, 21);
        this.cboUsedWhen.TabIndex = 0;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(521, 316);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(72, 23);
        this.btnCancel.TabIndex = 9;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(443, 316);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(72, 23);
        this.btnOk.TabIndex = 8;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // txtEdit
        // 
        this.txtEdit.Location = new System.Drawing.Point(208, 290);
        this.txtEdit.Name = "txtEdit";
        this.txtEdit.Size = new System.Drawing.Size(385, 20);
        this.txtEdit.TabIndex = 7;
        // 
        // lstTexts
        // 
        this.lstTexts.FormattingEnabled = true;
        this.lstTexts.Location = new System.Drawing.Point(208, 163);
        this.lstTexts.Name = "lstTexts";
        this.lstTexts.Size = new System.Drawing.Size(385, 121);
        this.lstTexts.TabIndex = 6;
        // 
        // CommentaryEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.grpUsedWhen);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.txtEdit);
        this.Controls.Add(this.lstTexts);
        this.Name = "CommentaryEditorForm";
        this.Text = "CommentaryEditorForm";
        this.grpUsedWhen.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.GroupBox grpUsedWhen;
    internal System.Windows.Forms.ComboBox cboUsedWhen;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.TextBox txtEdit;
    internal System.Windows.Forms.ListBox lstTexts;
}
