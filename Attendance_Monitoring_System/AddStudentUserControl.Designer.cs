namespace Attendance_Monitoring_System
{
    partial class AddStudentUserControl
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
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            tabControl = new TabControl();
            InsertStudentTabPage = new TabPage();
            AddStudentDataGridView = new DataGridView();
            SubmitButton = new Button();
            PasswordTextBox = new TextBox();
            label9 = new Label();
            PhoneTextBox = new TextBox();
            StudentIdTextBox = new TextBox();
            EmailTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            FullNameTextBox = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            UpdateStudentTabPage = new TabPage();
            UpdateStudentDataGridView = new DataGridView();
            UpdateButton = new Button();
            UpdatePasswordTextBox = new TextBox();
            label8 = new Label();
            UpdatePhoneTextBox = new TextBox();
            UpdateStudentIdTextBox = new TextBox();
            UpdateEmailTextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            UpdateFullNameTextBox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            DeleteStudentTabPage = new TabPage();
            DeleteStudentDataGridView = new DataGridView();
            DeleteButton = new Button();
            DeleteStudentIdTextBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            DeleteFullNameTextBox = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            tabControl.SuspendLayout();
            InsertStudentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddStudentDataGridView).BeginInit();
            panel3.SuspendLayout();
            UpdateStudentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateStudentDataGridView).BeginInit();
            panel1.SuspendLayout();
            DeleteStudentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteStudentDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(InsertStudentTabPage);
            tabControl.Controls.Add(UpdateStudentTabPage);
            tabControl.Controls.Add(DeleteStudentTabPage);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1888, 1100);
            tabControl.TabIndex = 0;
            // 
            // InsertStudentTabPage
            // 
            InsertStudentTabPage.Controls.Add(AddStudentDataGridView);
            InsertStudentTabPage.Controls.Add(SubmitButton);
            InsertStudentTabPage.Controls.Add(PasswordTextBox);
            InsertStudentTabPage.Controls.Add(label9);
            InsertStudentTabPage.Controls.Add(PhoneTextBox);
            InsertStudentTabPage.Controls.Add(StudentIdTextBox);
            InsertStudentTabPage.Controls.Add(EmailTextBox);
            InsertStudentTabPage.Controls.Add(label6);
            InsertStudentTabPage.Controls.Add(label7);
            InsertStudentTabPage.Controls.Add(label5);
            InsertStudentTabPage.Controls.Add(label4);
            InsertStudentTabPage.Controls.Add(FullNameTextBox);
            InsertStudentTabPage.Controls.Add(panel3);
            InsertStudentTabPage.Location = new Point(4, 4);
            InsertStudentTabPage.Name = "InsertStudentTabPage";
            InsertStudentTabPage.Padding = new Padding(3);
            InsertStudentTabPage.Size = new Size(1880, 1062);
            InsertStudentTabPage.TabIndex = 0;
            InsertStudentTabPage.Text = "Insert Student";
            InsertStudentTabPage.UseVisualStyleBackColor = true;
            InsertStudentTabPage.Click += InsertStudentTabPage_Click;
            // 
            // AddStudentDataGridView
            // 
            AddStudentDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            AddStudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddStudentDataGridView.Location = new Point(252, 554);
            AddStudentDataGridView.Name = "AddStudentDataGridView";
            AddStudentDataGridView.RowHeadersWidth = 62;
            AddStudentDataGridView.Size = new Size(1315, 364);
            AddStudentDataGridView.TabIndex = 61;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.SteelBlue;
            SubmitButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(746, 427);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(328, 62);
            SubmitButton.TabIndex = 60;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(1222, 326);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(503, 31);
            PasswordTextBox.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(253, 254, 253);
            label9.Font = new Font("Arial Rounded MT Bold", 12F);
            label9.Location = new Point(1080, 326);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 58;
            label9.Text = "Password:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(726, 323);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(329, 31);
            PhoneTextBox.TabIndex = 57;
            // 
            // StudentIdTextBox
            // 
            StudentIdTextBox.Location = new Point(286, 323);
            StudentIdTextBox.Name = "StudentIdTextBox";
            StudentIdTextBox.Size = new Size(271, 31);
            StudentIdTextBox.TabIndex = 56;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(1080, 257);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(645, 31);
            EmailTextBox.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(253, 254, 253);
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(142, 323);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 54;
            label6.Text = "Student Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(253, 254, 253);
            label7.Font = new Font("Arial Rounded MT Bold", 12F);
            label7.Location = new Point(628, 323);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 53;
            label7.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(253, 254, 253);
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(989, 257);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 52;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(253, 254, 253);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(145, 257);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 51;
            label4.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(286, 257);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(591, 31);
            FullNameTextBox.TabIndex = 50;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1874, 178);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 62);
            label3.Name = "label3";
            label3.Size = new Size(265, 43);
            label3.TabIndex = 0;
            label3.Text = "Insert Student:";
            // 
            // UpdateStudentTabPage
            // 
            UpdateStudentTabPage.Controls.Add(UpdateStudentDataGridView);
            UpdateStudentTabPage.Controls.Add(UpdateButton);
            UpdateStudentTabPage.Controls.Add(UpdatePasswordTextBox);
            UpdateStudentTabPage.Controls.Add(label8);
            UpdateStudentTabPage.Controls.Add(UpdatePhoneTextBox);
            UpdateStudentTabPage.Controls.Add(UpdateStudentIdTextBox);
            UpdateStudentTabPage.Controls.Add(UpdateEmailTextBox);
            UpdateStudentTabPage.Controls.Add(label10);
            UpdateStudentTabPage.Controls.Add(label11);
            UpdateStudentTabPage.Controls.Add(label12);
            UpdateStudentTabPage.Controls.Add(label13);
            UpdateStudentTabPage.Controls.Add(UpdateFullNameTextBox);
            UpdateStudentTabPage.Controls.Add(panel1);
            UpdateStudentTabPage.Location = new Point(4, 4);
            UpdateStudentTabPage.Name = "UpdateStudentTabPage";
            UpdateStudentTabPage.Padding = new Padding(3);
            UpdateStudentTabPage.Size = new Size(1880, 1062);
            UpdateStudentTabPage.TabIndex = 1;
            UpdateStudentTabPage.Text = "Update Student";
            UpdateStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateStudentDataGridView
            // 
            UpdateStudentDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            UpdateStudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateStudentDataGridView.GridColor = SystemColors.ButtonHighlight;
            UpdateStudentDataGridView.Location = new Point(293, 527);
            UpdateStudentDataGridView.Name = "UpdateStudentDataGridView";
            UpdateStudentDataGridView.RowHeadersWidth = 62;
            UpdateStudentDataGridView.Size = new Size(1265, 380);
            UpdateStudentDataGridView.TabIndex = 73;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.SteelBlue;
            UpdateButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(753, 415);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(328, 62);
            UpdateButton.TabIndex = 72;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdatePasswordTextBox
            // 
            UpdatePasswordTextBox.Location = new Point(1229, 314);
            UpdatePasswordTextBox.Name = "UpdatePasswordTextBox";
            UpdatePasswordTextBox.Size = new Size(503, 31);
            UpdatePasswordTextBox.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(253, 254, 253);
            label8.Font = new Font("Arial Rounded MT Bold", 12F);
            label8.Location = new Point(1087, 314);
            label8.Name = "label8";
            label8.Size = new Size(136, 28);
            label8.TabIndex = 70;
            label8.Text = "Password:";
            // 
            // UpdatePhoneTextBox
            // 
            UpdatePhoneTextBox.Location = new Point(733, 311);
            UpdatePhoneTextBox.Name = "UpdatePhoneTextBox";
            UpdatePhoneTextBox.Size = new Size(329, 31);
            UpdatePhoneTextBox.TabIndex = 69;
            // 
            // UpdateStudentIdTextBox
            // 
            UpdateStudentIdTextBox.Location = new Point(293, 311);
            UpdateStudentIdTextBox.Name = "UpdateStudentIdTextBox";
            UpdateStudentIdTextBox.Size = new Size(271, 31);
            UpdateStudentIdTextBox.TabIndex = 68;
            // 
            // UpdateEmailTextBox
            // 
            UpdateEmailTextBox.Location = new Point(1087, 245);
            UpdateEmailTextBox.Name = "UpdateEmailTextBox";
            UpdateEmailTextBox.Size = new Size(645, 31);
            UpdateEmailTextBox.TabIndex = 67;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(253, 254, 253);
            label10.Font = new Font("Arial Rounded MT Bold", 12F);
            label10.Location = new Point(149, 311);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 66;
            label10.Text = "Student Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(253, 254, 253);
            label11.Font = new Font("Arial Rounded MT Bold", 12F);
            label11.Location = new Point(635, 311);
            label11.Name = "label11";
            label11.Size = new Size(92, 28);
            label11.TabIndex = 65;
            label11.Text = "Phone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(253, 254, 253);
            label12.Font = new Font("Arial Rounded MT Bold", 12F);
            label12.Location = new Point(996, 245);
            label12.Name = "label12";
            label12.Size = new Size(85, 28);
            label12.TabIndex = 64;
            label12.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(253, 254, 253);
            label13.Font = new Font("Arial Rounded MT Bold", 12F);
            label13.Location = new Point(152, 245);
            label13.Name = "label13";
            label13.Size = new Size(135, 28);
            label13.TabIndex = 63;
            label13.Text = "Full Name:";
            // 
            // UpdateFullNameTextBox
            // 
            UpdateFullNameTextBox.Location = new Point(293, 245);
            UpdateFullNameTextBox.Name = "UpdateFullNameTextBox";
            UpdateFullNameTextBox.Size = new Size(591, 31);
            UpdateFullNameTextBox.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1874, 178);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 62);
            label1.Name = "label1";
            label1.Size = new Size(300, 43);
            label1.TabIndex = 0;
            label1.Text = "Update Student:";
            // 
            // DeleteStudentTabPage
            // 
            DeleteStudentTabPage.Controls.Add(DeleteStudentDataGridView);
            DeleteStudentTabPage.Controls.Add(DeleteButton);
            DeleteStudentTabPage.Controls.Add(DeleteStudentIdTextBox);
            DeleteStudentTabPage.Controls.Add(label14);
            DeleteStudentTabPage.Controls.Add(label15);
            DeleteStudentTabPage.Controls.Add(DeleteFullNameTextBox);
            DeleteStudentTabPage.Controls.Add(panel2);
            DeleteStudentTabPage.Location = new Point(4, 4);
            DeleteStudentTabPage.Name = "DeleteStudentTabPage";
            DeleteStudentTabPage.Padding = new Padding(3);
            DeleteStudentTabPage.Size = new Size(1880, 1062);
            DeleteStudentTabPage.TabIndex = 2;
            DeleteStudentTabPage.Text = "Delete Student";
            DeleteStudentTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteStudentDataGridView
            // 
            DeleteStudentDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            DeleteStudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeleteStudentDataGridView.Location = new Point(279, 600);
            DeleteStudentDataGridView.Name = "DeleteStudentDataGridView";
            DeleteStudentDataGridView.RowHeadersWidth = 62;
            DeleteStudentDataGridView.Size = new Size(1209, 351);
            DeleteStudentDataGridView.TabIndex = 74;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SteelBlue;
            DeleteButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(717, 432);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(328, 62);
            DeleteButton.TabIndex = 73;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteStudentIdTextBox
            // 
            DeleteStudentIdTextBox.Location = new Point(717, 314);
            DeleteStudentIdTextBox.Name = "DeleteStudentIdTextBox";
            DeleteStudentIdTextBox.Size = new Size(271, 31);
            DeleteStudentIdTextBox.TabIndex = 72;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(253, 254, 253);
            label14.Font = new Font("Arial Rounded MT Bold", 12F);
            label14.Location = new Point(573, 314);
            label14.Name = "label14";
            label14.Size = new Size(138, 28);
            label14.TabIndex = 71;
            label14.Text = "Student Id:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(253, 254, 253);
            label15.Font = new Font("Arial Rounded MT Bold", 12F);
            label15.Location = new Point(576, 248);
            label15.Name = "label15";
            label15.Size = new Size(135, 28);
            label15.TabIndex = 70;
            label15.Text = "Full Name:";
            // 
            // DeleteFullNameTextBox
            // 
            DeleteFullNameTextBox.Location = new Point(717, 248);
            DeleteFullNameTextBox.Name = "DeleteFullNameTextBox";
            DeleteFullNameTextBox.Size = new Size(591, 31);
            DeleteFullNameTextBox.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1874, 178);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 62);
            label2.Name = "label2";
            label2.Size = new Size(285, 43);
            label2.TabIndex = 0;
            label2.Text = "Delete Student:";
            // 
            // AddStudentUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl);
            Name = "AddStudentUserControl";
            Size = new Size(1888, 1100);
            tabControl.ResumeLayout(false);
            InsertStudentTabPage.ResumeLayout(false);
            InsertStudentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddStudentDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            UpdateStudentTabPage.ResumeLayout(false);
            UpdateStudentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateStudentDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            DeleteStudentTabPage.ResumeLayout(false);
            DeleteStudentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteStudentDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControl;
        private TabPage InsertStudentTabPage;
        private TabPage UpdateStudentTabPage;
        private TabPage DeleteStudentTabPage;
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button SubmitButton;
        private TextBox PasswordTextBox;
        private Label label9;
        private TextBox PhoneTextBox;
        private TextBox StudentIdTextBox;
        private TextBox EmailTextBox;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox FullNameTextBox;
        private Button UpdateButton;
        private TextBox UpdatePasswordTextBox;
        private Label label8;
        private TextBox UpdatePhoneTextBox;
        private TextBox UpdateStudentIdTextBox;
        private TextBox UpdateEmailTextBox;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox UpdateFullNameTextBox;
        private Button DeleteButton;
        private TextBox DeleteStudentIdTextBox;
        private Label label14;
        private Label label15;
        private TextBox DeleteFullNameTextBox;
        private DataGridView AddStudentDataGridView;
        private DataGridView UpdateStudentDataGridView;
        private DataGridView DeleteStudentDataGridView;
    }
}
