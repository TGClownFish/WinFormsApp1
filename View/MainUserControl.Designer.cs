namespace WinFormsApp1.View
{
    partial class MainUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainUserControlListBox = new ListBox();
            mainUserControlDeleteElementButton = new Button();
            mainUserControlAddNewElementButton = new Button();
            mainUserControlNameTextBox = new TextBox();
            mainUserControlLinkTextBox = new TextBox();
            mainUserControlPhoneNumberTextBox = new TextBox();
            mainUserControllDateTimePicker = new DateTimePicker();
            mainUserControlEditElementButton = new Button();
            mainUserControlSaveElementButton = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            errorLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainUserControlListBox
            // 
            mainUserControlListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mainUserControlListBox.FormattingEnabled = true;
            mainUserControlListBox.ItemHeight = 15;
            mainUserControlListBox.Location = new Point(21, 25);
            mainUserControlListBox.Name = "mainUserControlListBox";
            mainUserControlListBox.Size = new Size(132, 199);
            mainUserControlListBox.TabIndex = 0;
            mainUserControlListBox.SelectedIndexChanged += mainUserControlListBox_SelectedIndexChanged;
            // 
            // mainUserControlDeleteElementButton
            // 
            mainUserControlDeleteElementButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mainUserControlDeleteElementButton.Location = new Point(113, 241);
            mainUserControlDeleteElementButton.Name = "mainUserControlDeleteElementButton";
            mainUserControlDeleteElementButton.Size = new Size(40, 35);
            mainUserControlDeleteElementButton.TabIndex = 2;
            mainUserControlDeleteElementButton.Text = "Del";
            mainUserControlDeleteElementButton.UseVisualStyleBackColor = true;
            mainUserControlDeleteElementButton.Click += mainUserControlDeleteElementButton_Click;
            // 
            // mainUserControlAddNewElementButton
            // 
            mainUserControlAddNewElementButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mainUserControlAddNewElementButton.Location = new Point(23, 241);
            mainUserControlAddNewElementButton.Name = "mainUserControlAddNewElementButton";
            mainUserControlAddNewElementButton.Size = new Size(40, 35);
            mainUserControlAddNewElementButton.TabIndex = 3;
            mainUserControlAddNewElementButton.Text = "Add";
            mainUserControlAddNewElementButton.UseVisualStyleBackColor = true;
            mainUserControlAddNewElementButton.Click += mainUserControlAddNewElementButton_Click;
            // 
            // mainUserControlNameTextBox
            // 
            mainUserControlNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainUserControlNameTextBox.Location = new Point(103, 22);
            mainUserControlNameTextBox.Name = "mainUserControlNameTextBox";
            mainUserControlNameTextBox.ReadOnly = true;
            mainUserControlNameTextBox.Size = new Size(208, 23);
            mainUserControlNameTextBox.TabIndex = 5;
            mainUserControlNameTextBox.TextChanged += mainUserControlNameTextBox_TextChanged;
            // 
            // mainUserControlLinkTextBox
            // 
            mainUserControlLinkTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainUserControlLinkTextBox.Location = new Point(103, 166);
            mainUserControlLinkTextBox.Name = "mainUserControlLinkTextBox";
            mainUserControlLinkTextBox.ReadOnly = true;
            mainUserControlLinkTextBox.Size = new Size(208, 23);
            mainUserControlLinkTextBox.TabIndex = 6;
            mainUserControlLinkTextBox.TextChanged += mainUserControlLinkTextBox_TextChanged;
            // 
            // mainUserControlPhoneNumberTextBox
            // 
            mainUserControlPhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainUserControlPhoneNumberTextBox.Location = new Point(103, 116);
            mainUserControlPhoneNumberTextBox.Name = "mainUserControlPhoneNumberTextBox";
            mainUserControlPhoneNumberTextBox.ReadOnly = true;
            mainUserControlPhoneNumberTextBox.Size = new Size(208, 23);
            mainUserControlPhoneNumberTextBox.TabIndex = 7;
            mainUserControlPhoneNumberTextBox.TextChanged += mainUserControlPhoneNumberTextBox_TextChanged;
            // 
            // mainUserControllDateTimePicker
            // 
            mainUserControllDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainUserControllDateTimePicker.Enabled = false;
            mainUserControllDateTimePicker.Location = new Point(103, 68);
            mainUserControllDateTimePicker.Name = "mainUserControllDateTimePicker";
            mainUserControllDateTimePicker.Size = new Size(208, 23);
            mainUserControllDateTimePicker.TabIndex = 8;
            mainUserControllDateTimePicker.ValueChanged += mainUserControllDateTimePicker_ValueChanged;
            // 
            // mainUserControlEditElementButton
            // 
            mainUserControlEditElementButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mainUserControlEditElementButton.Location = new Point(382, 241);
            mainUserControlEditElementButton.Name = "mainUserControlEditElementButton";
            mainUserControlEditElementButton.Size = new Size(40, 35);
            mainUserControlEditElementButton.TabIndex = 9;
            mainUserControlEditElementButton.Text = "Edit";
            mainUserControlEditElementButton.UseVisualStyleBackColor = true;
            mainUserControlEditElementButton.Click += mainUserControlEditElementButton_Click;
            // 
            // mainUserControlSaveElementButton
            // 
            mainUserControlSaveElementButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mainUserControlSaveElementButton.Enabled = false;
            mainUserControlSaveElementButton.Location = new Point(442, 241);
            mainUserControlSaveElementButton.Name = "mainUserControlSaveElementButton";
            mainUserControlSaveElementButton.Size = new Size(40, 35);
            mainUserControlSaveElementButton.TabIndex = 10;
            mainUserControlSaveElementButton.Text = "Save";
            mainUserControlSaveElementButton.UseVisualStyleBackColor = true;
            mainUserControlSaveElementButton.Click += mainUserControlSaveElementButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 7);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "Contacts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 25);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 12;
            label2.Text = "Full Name:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(mainUserControlNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mainUserControlLinkTextBox);
            groupBox1.Controls.Add(mainUserControllDateTimePicker);
            groupBox1.Controls.Add(mainUserControlPhoneNumberTextBox);
            groupBox1.Location = new Point(171, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 199);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 169);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 15;
            label5.Text = "vk.com:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 14;
            label4.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 74);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 13;
            label3.Text = "Date of Birth:";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(228, 241);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(10, 15);
            errorLabel.TabIndex = 16;
            errorLabel.Text = " ";
            // 
            // MainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(errorLabel);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(mainUserControlSaveElementButton);
            Controls.Add(mainUserControlEditElementButton);
            Controls.Add(mainUserControlAddNewElementButton);
            Controls.Add(mainUserControlListBox);
            Controls.Add(mainUserControlDeleteElementButton);
            Name = "MainUserControl";
            Size = new Size(504, 307);
            Load += MainUserControl_Load;
            HandleDestroyed += MainUserControl_HandleDestroyed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox mainUserControlListBox;
        private Button mainUserControlDeleteElementButton;
        private Button mainUserControlAddNewElementButton;
        private DateTimePicker mainUserControllDateTimePicker;
        private TextBox mainUserControlPhoneNumberTextBox;
        private TextBox mainUserControlLinkTextBox;
        private TextBox mainUserControlNameTextBox;
        private Button mainUserControlEditElementButton;
        private Button mainUserControlSaveElementButton;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label errorLabel;
    }
}
