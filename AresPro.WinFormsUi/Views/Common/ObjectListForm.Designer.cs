namespace AresPro.WinFormsUi.Views.Common;

partial class ObjectListForm
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
        this.btnOk = new System.Windows.Forms.Button();
        this.btnButton3 = new System.Windows.Forms.Button();
        this.btnButton2 = new System.Windows.Forms.Button();
        this.btnButton1 = new System.Windows.Forms.Button();
        this.lstObjects = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(458, 328);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(60, 23);
        this.btnOk.TabIndex = 9;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // btnButton3
        // 
        this.btnButton3.Location = new System.Drawing.Point(458, 158);
        this.btnButton3.Name = "btnButton3";
        this.btnButton3.Size = new System.Drawing.Size(60, 23);
        this.btnButton3.TabIndex = 8;
        this.btnButton3.UseVisualStyleBackColor = true;
        // 
        // btnButton2
        // 
        this.btnButton2.Location = new System.Drawing.Point(458, 129);
        this.btnButton2.Name = "btnButton2";
        this.btnButton2.Size = new System.Drawing.Size(60, 23);
        this.btnButton2.TabIndex = 7;
        this.btnButton2.UseVisualStyleBackColor = true;
        // 
        // btnButton1
        // 
        this.btnButton1.Location = new System.Drawing.Point(458, 100);
        this.btnButton1.Name = "btnButton1";
        this.btnButton1.Size = new System.Drawing.Size(60, 23);
        this.btnButton1.TabIndex = 6;
        this.btnButton1.UseVisualStyleBackColor = true;
        // 
        // lstObjects
        // 
        this.lstObjects.DisplayMember = "Value";
        this.lstObjects.FormattingEnabled = true;
        this.lstObjects.Location = new System.Drawing.Point(282, 100);
        this.lstObjects.Name = "lstObjects";
        this.lstObjects.Size = new System.Drawing.Size(170, 251);
        this.lstObjects.Sorted = true;
        this.lstObjects.TabIndex = 5;
        this.lstObjects.ValueMember = "Key";
        // 
        // ObjectListForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.btnButton3);
        this.Controls.Add(this.btnButton2);
        this.Controls.Add(this.btnButton1);
        this.Controls.Add(this.lstObjects);
        this.Name = "ObjectListForm";
        this.Text = "ObjectListForm";
        this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.Button btnButton3;
    internal System.Windows.Forms.Button btnButton2;
    internal System.Windows.Forms.Button btnButton1;
    internal System.Windows.Forms.ListBox lstObjects;
}
