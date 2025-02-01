namespace AresPro.WinFormsUi.Views.Booking;

partial class BookACardForm
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
        groupBox1 = new GroupBox();
        EventNameTextBox = new TextBox();
        HTMLFormatRadioButton = new RadioButton();
        PlainTextFormatRadioButton = new RadioButton();
        AvailableSegmentsListBox = new ListBox();
        BookedSegmentsListBox = new ListBox();
        AddButton = new Button();
        MoveUpButton = new Button();
        MoveDownButton = new Button();
        RemoveButton = new Button();
        RunCardButton = new Button();
        CloseButton = new Button();
        SelectedSegmentTextBox = new TextBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(EventNameTextBox);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(420, 51);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Event Name";
        // 
        // EventNameTextBox
        // 
        EventNameTextBox.Location = new Point(6, 22);
        EventNameTextBox.Name = "EventNameTextBox";
        EventNameTextBox.Size = new Size(408, 23);
        EventNameTextBox.TabIndex = 0;
        // 
        // HTMLFormatRadioButton
        // 
        HTMLFormatRadioButton.AutoSize = true;
        HTMLFormatRadioButton.Location = new Point(40, 69);
        HTMLFormatRadioButton.Name = "HTMLFormatRadioButton";
        HTMLFormatRadioButton.Size = new Size(154, 19);
        HTMLFormatRadioButton.TabIndex = 1;
        HTMLFormatRadioButton.TabStop = true;
        HTMLFormatRadioButton.Text = "For the World Wide Web";
        HTMLFormatRadioButton.UseVisualStyleBackColor = true;
        // 
        // PlainTextFormatRadioButton
        // 
        PlainTextFormatRadioButton.AutoSize = true;
        PlainTextFormatRadioButton.Location = new Point(232, 69);
        PlainTextFormatRadioButton.Name = "PlainTextFormatRadioButton";
        PlainTextFormatRadioButton.Size = new Size(172, 19);
        PlainTextFormatRadioButton.TabIndex = 2;
        PlainTextFormatRadioButton.TabStop = true;
        PlainTextFormatRadioButton.Text = "For the Email or Newsgroup";
        PlainTextFormatRadioButton.UseVisualStyleBackColor = true;
        // 
        // AvailableSegmentsListBox
        // 
        AvailableSegmentsListBox.FormattingEnabled = true;
        AvailableSegmentsListBox.ItemHeight = 15;
        AvailableSegmentsListBox.Location = new Point(12, 94);
        AvailableSegmentsListBox.Name = "AvailableSegmentsListBox";
        AvailableSegmentsListBox.Size = new Size(420, 64);
        AvailableSegmentsListBox.TabIndex = 3;
        AvailableSegmentsListBox.SelectedIndexChanged += AvailableSegmentsListBox_SelectedIndexChanged;
        // 
        // BookedSegmentsListBox
        // 
        BookedSegmentsListBox.FormattingEnabled = true;
        BookedSegmentsListBox.ItemHeight = 15;
        BookedSegmentsListBox.Location = new Point(12, 164);
        BookedSegmentsListBox.Name = "BookedSegmentsListBox";
        BookedSegmentsListBox.Size = new Size(332, 169);
        BookedSegmentsListBox.TabIndex = 4;
        BookedSegmentsListBox.SelectedIndexChanged += BookedSegmentsListBox_SelectedIndexChanged;
        // 
        // AddButton
        // 
        AddButton.Location = new Point(350, 164);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(82, 23);
        AddButton.TabIndex = 5;
        AddButton.Text = "&Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // MoveUpButton
        // 
        MoveUpButton.Location = new Point(350, 193);
        MoveUpButton.Name = "MoveUpButton";
        MoveUpButton.Size = new Size(82, 23);
        MoveUpButton.TabIndex = 6;
        MoveUpButton.Text = "Move &Up";
        MoveUpButton.UseVisualStyleBackColor = true;
        MoveUpButton.Click += MoveUpButton_Click;
        // 
        // MoveDownButton
        // 
        MoveDownButton.Location = new Point(350, 222);
        MoveDownButton.Name = "MoveDownButton";
        MoveDownButton.Size = new Size(82, 23);
        MoveDownButton.TabIndex = 7;
        MoveDownButton.Text = "Move &Down";
        MoveDownButton.UseVisualStyleBackColor = true;
        MoveDownButton.Click += MoveDownButton_Click;
        // 
        // RemoveButton
        // 
        RemoveButton.Location = new Point(350, 251);
        RemoveButton.Name = "RemoveButton";
        RemoveButton.Size = new Size(82, 23);
        RemoveButton.TabIndex = 8;
        RemoveButton.Text = "&Remove";
        RemoveButton.UseVisualStyleBackColor = true;
        RemoveButton.Click += RemoveButton_Click;
        // 
        // RunCardButton
        // 
        RunCardButton.Location = new Point(350, 280);
        RunCardButton.Name = "RunCardButton";
        RunCardButton.Size = new Size(82, 23);
        RunCardButton.TabIndex = 9;
        RunCardButton.Text = "R&un Card";
        RunCardButton.UseVisualStyleBackColor = true;
        RunCardButton.Click += RunCardButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.DialogResult = DialogResult.Cancel;
        CloseButton.Location = new Point(350, 309);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(82, 23);
        CloseButton.TabIndex = 10;
        CloseButton.Text = "&Close";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // SelectedSegmentTextBox
        // 
        SelectedSegmentTextBox.Location = new Point(12, 339);
        SelectedSegmentTextBox.Name = "SelectedSegmentTextBox";
        SelectedSegmentTextBox.ReadOnly = true;
        SelectedSegmentTextBox.Size = new Size(420, 23);
        SelectedSegmentTextBox.TabIndex = 11;
        // 
        // BookACardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CloseButton;
        ClientSize = new Size(444, 374);
        Controls.Add(SelectedSegmentTextBox);
        Controls.Add(CloseButton);
        Controls.Add(RunCardButton);
        Controls.Add(RemoveButton);
        Controls.Add(MoveDownButton);
        Controls.Add(MoveUpButton);
        Controls.Add(AddButton);
        Controls.Add(BookedSegmentsListBox);
        Controls.Add(AvailableSegmentsListBox);
        Controls.Add(PlainTextFormatRadioButton);
        Controls.Add(HTMLFormatRadioButton);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "BookACardForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Book a Card";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private TextBox EventNameTextBox;
    private RadioButton HTMLFormatRadioButton;
    private RadioButton PlainTextFormatRadioButton;
    private ListBox AvailableSegmentsListBox;
    private ListBox BookedSegmentsListBox;
    private Button AddButton;
    private Button MoveUpButton;
    private Button MoveDownButton;
    private Button RemoveButton;
    private Button RunCardButton;
    private Button CloseButton;
    private TextBox SelectedSegmentTextBox;
}