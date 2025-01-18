namespace AresPro.WinFormsUi.Views.Editors;

partial class CommercialEditorForm
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
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.txtEdit = new System.Windows.Forms.TextBox();
        this.lstCommercials = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(521, 310);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(72, 23);
        this.btnCancel.TabIndex = 7;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(443, 310);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(72, 23);
        this.btnOk.TabIndex = 6;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // txtEdit
        // 
        this.txtEdit.Location = new System.Drawing.Point(208, 284);
        this.txtEdit.Name = "txtEdit";
        this.txtEdit.Size = new System.Drawing.Size(385, 20);
        this.txtEdit.TabIndex = 5;
        // 
        // lstCommercials
        // 
        this.lstCommercials.FormattingEnabled = true;
        this.lstCommercials.Location = new System.Drawing.Point(208, 118);
        this.lstCommercials.Name = "lstCommercials";
        this.lstCommercials.Size = new System.Drawing.Size(385, 160);
        this.lstCommercials.TabIndex = 4;
        // 
        // CommercialEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.txtEdit);
        this.Controls.Add(this.lstCommercials);
        this.Name = "CommercialEditorForm";
        this.Text = "CommercialEditorForm";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.TextBox txtEdit;
    internal System.Windows.Forms.ListBox lstCommercials;
}
