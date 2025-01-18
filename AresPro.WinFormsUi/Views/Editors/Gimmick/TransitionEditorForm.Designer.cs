namespace AresPro.WinFormsUi.Views.Editors.Gimmick;

partial class TransitionEditorForm
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
        this.TransitionTextField = new System.Windows.Forms.TextBox();
        this.TransitionTextFrame = new System.Windows.Forms.GroupBox();
        this.TransitionTextFrame.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(455, 239);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 19;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(374, 239);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(75, 23);
        this.btnOk.TabIndex = 18;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // TransitionTextField
        // 
        this.TransitionTextField.Location = new System.Drawing.Point(6, 19);
        this.TransitionTextField.Name = "TransitionTextField";
        this.TransitionTextField.Size = new System.Drawing.Size(248, 20);
        this.TransitionTextField.TabIndex = 16;
        // 
        // TransitionTextFrame
        // 
        this.TransitionTextFrame.Controls.Add(this.TransitionTextField);
        this.TransitionTextFrame.Location = new System.Drawing.Point(270, 188);
        this.TransitionTextFrame.Name = "TransitionTextFrame";
        this.TransitionTextFrame.Size = new System.Drawing.Size(260, 45);
        this.TransitionTextFrame.TabIndex = 20;
        this.TransitionTextFrame.TabStop = false;
        this.TransitionTextFrame.Text = "Text";
        // 
        // TransitionEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.TransitionTextFrame);
        this.Name = "TransitionEditorForm";
        this.Text = "TransitionEditorForm";
        this.TransitionTextFrame.ResumeLayout(false);
        this.TransitionTextFrame.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.TextBox TransitionTextField;
    internal System.Windows.Forms.GroupBox TransitionTextFrame;
}
