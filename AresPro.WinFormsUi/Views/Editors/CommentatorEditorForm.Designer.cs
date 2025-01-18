namespace AresPro.WinFormsUi.Views.Editors;

partial class CommentatorEditorForm
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
        this.grpFile = new System.Windows.Forms.GroupBox();
        this.btnFileBrowse = new System.Windows.Forms.Button();
        this.txtFile = new System.Windows.Forms.TextBox();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.cboAffliliation = new System.Windows.Forms.ComboBox();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.grpFile.SuspendLayout();
        this.SuspendLayout();
        // 
        // grpFile
        // 
        this.grpFile.Controls.Add(this.btnFileBrowse);
        this.grpFile.Controls.Add(this.txtFile);
        this.grpFile.Location = new System.Drawing.Point(268, 200);
        this.grpFile.Name = "grpFile";
        this.grpFile.Size = new System.Drawing.Size(268, 48);
        this.grpFile.TabIndex = 8;
        this.grpFile.TabStop = false;
        this.grpFile.Text = "Commentary File";
        // 
        // btnFileBrowse
        // 
        this.btnFileBrowse.Location = new System.Drawing.Point(187, 19);
        this.btnFileBrowse.Name = "btnFileBrowse";
        this.btnFileBrowse.Size = new System.Drawing.Size(75, 23);
        this.btnFileBrowse.TabIndex = 1;
        this.btnFileBrowse.Text = "C&hange";
        this.btnFileBrowse.UseVisualStyleBackColor = true;
        // 
        // txtFile
        // 
        this.txtFile.Location = new System.Drawing.Point(6, 21);
        this.txtFile.Name = "txtFile";
        this.txtFile.ReadOnly = true;
        this.txtFile.Size = new System.Drawing.Size(175, 20);
        this.txtFile.TabIndex = 0;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(478, 254);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(58, 23);
        this.btnCancel.TabIndex = 11;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(414, 254);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(58, 23);
        this.btnOk.TabIndex = 10;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // cboAffliliation
        // 
        this.cboAffliliation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboAffliliation.FormattingEnabled = true;
        this.cboAffliliation.Items.AddRange(new object[] {
        "Face",
        "Neutral",
        "Heel"});
        this.cboAffliliation.Location = new System.Drawing.Point(268, 254);
        this.cboAffliliation.Name = "cboAffliliation";
        this.cboAffliliation.Size = new System.Drawing.Size(140, 21);
        this.cboAffliliation.TabIndex = 9;
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(306, 174);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(230, 20);
        this.txtName.TabIndex = 7;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(265, 177);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(35, 13);
        this.lblName.TabIndex = 6;
        this.lblName.Text = "Name";
        // 
        // CommentatorEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.grpFile);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.cboAffliliation);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblName);
        this.Name = "CommentatorEditorForm";
        this.Text = "CommentatorEditorForm";
        this.grpFile.ResumeLayout(false);
        this.grpFile.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.GroupBox grpFile;
    internal System.Windows.Forms.Button btnFileBrowse;
    internal System.Windows.Forms.TextBox txtFile;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.ComboBox cboAffliliation;
    internal System.Windows.Forms.TextBox txtName;
    internal System.Windows.Forms.Label lblName;
}
