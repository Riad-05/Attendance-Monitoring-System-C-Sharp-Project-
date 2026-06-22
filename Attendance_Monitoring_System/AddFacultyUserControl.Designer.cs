namespace Attendance_Monitoring_System
{
    partial class AddFacultyUserControl
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
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            InsertFacultyTabPage = new TabPage();
            FacultyDataGridView = new DataGridView();
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
            panel1 = new Panel();
            label1 = new Label();
            UpdateFacultyTabPage = new TabPage();
            UpdateFacultyDataGridView = new DataGridView();
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
            panel2 = new Panel();
            label2 = new Label();
            DeleteFacultyTabPage = new TabPage();
            DeleteFacultyDataGridView = new DataGridView();
            DeleteButton = new Button();
            DeleteStudentIdTextBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            DeleteFullNameTextBox = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            tabControl1.SuspendLayout();
            InsertFacultyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FacultyDataGridView).BeginInit();
            panel1.SuspendLayout();
            UpdateFacultyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateFacultyDataGridView).BeginInit();
            panel2.SuspendLayout();
            DeleteFacultyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteFacultyDataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(InsertFacultyTabPage);
            tabControl1.Controls.Add(UpdateFacultyTabPage);
            tabControl1.Controls.Add(DeleteFacultyTabPage);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1888, 1100);
            tabControl1.TabIndex = 0;
            // 
            // InsertFacultyTabPage
            // 
            InsertFacultyTabPage.Controls.Add(FacultyDataGridView);
            InsertFacultyTabPage.Controls.Add(SubmitButton);
            InsertFacultyTabPage.Controls.Add(PasswordTextBox);
            InsertFacultyTabPage.Controls.Add(label9);
            InsertFacultyTabPage.Controls.Add(PhoneTextBox);
            InsertFacultyTabPage.Controls.Add(StudentIdTextBox);
            InsertFacultyTabPage.Controls.Add(EmailTextBox);
            InsertFacultyTabPage.Controls.Add(label6);
            InsertFacultyTabPage.Controls.Add(label7);
            InsertFacultyTabPage.Controls.Add(label5);
            InsertFacultyTabPage.Controls.Add(label4);
            InsertFacultyTabPage.Controls.Add(FullNameTextBox);
            InsertFacultyTabPage.Controls.Add(panel1);
            InsertFacultyTabPage.Location = new Point(4, 4);
            InsertFacultyTabPage.Name = "InsertFacultyTabPage";
            InsertFacultyTabPage.Padding = new Padding(3);
            InsertFacultyTabPage.Size = new Size(1880, 1062);
            InsertFacultyTabPage.TabIndex = 0;
            InsertFacultyTabPage.Text = "Insert Faculty";
            InsertFacultyTabPage.UseVisualStyleBackColor = true;
            // 
            // FacultyDataGridView
            // 
            FacultyDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            FacultyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FacultyDataGridView.Location = new Point(293, 616);
            FacultyDataGridView.Name = "FacultyDataGridView";
            FacultyDataGridView.RowHeadersWidth = 62;
            FacultyDataGridView.Size = new Size(1241, 333);
            FacultyDataGridView.TabIndex = 72;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.SteelBlue;
            SubmitButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(753, 485);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(328, 62);
            SubmitButton.TabIndex = 71;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(1229, 384);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(503, 31);
            PasswordTextBox.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(253, 254, 253);
            label9.Font = new Font("Arial Rounded MT Bold", 12F);
            label9.Location = new Point(1087, 384);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 69;
            label9.Text = "Password:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(733, 381);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(329, 31);
            PhoneTextBox.TabIndex = 68;
            // 
            // StudentIdTextBox
            // 
            StudentIdTextBox.Location = new Point(293, 381);
            StudentIdTextBox.Name = "StudentIdTextBox";
            StudentIdTextBox.Size = new Size(271, 31);
            StudentIdTextBox.TabIndex = 67;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(1087, 315);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(645, 31);
            EmailTextBox.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(253, 254, 253);
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(154, 381);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 65;
            label6.Text = "Faculty Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(253, 254, 253);
            label7.Font = new Font("Arial Rounded MT Bold", 12F);
            label7.Location = new Point(635, 381);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 64;
            label7.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(253, 254, 253);
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(996, 315);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 63;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(253, 254, 253);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(152, 315);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 62;
            label4.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(293, 315);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(591, 31);
            FullNameTextBox.TabIndex = 61;
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
            label1.Size = new Size(260, 43);
            label1.TabIndex = 0;
            label1.Text = "Insert Faculty:";
            // 
            // UpdateFacultyTabPage
            // 
            UpdateFacultyTabPage.Controls.Add(UpdateFacultyDataGridView);
            UpdateFacultyTabPage.Controls.Add(UpdateButton);
            UpdateFacultyTabPage.Controls.Add(UpdatePasswordTextBox);
            UpdateFacultyTabPage.Controls.Add(label8);
            UpdateFacultyTabPage.Controls.Add(UpdatePhoneTextBox);
            UpdateFacultyTabPage.Controls.Add(UpdateStudentIdTextBox);
            UpdateFacultyTabPage.Controls.Add(UpdateEmailTextBox);
            UpdateFacultyTabPage.Controls.Add(label10);
            UpdateFacultyTabPage.Controls.Add(label11);
            UpdateFacultyTabPage.Controls.Add(label12);
            UpdateFacultyTabPage.Controls.Add(label13);
            UpdateFacultyTabPage.Controls.Add(UpdateFullNameTextBox);
            UpdateFacultyTabPage.Controls.Add(panel2);
            UpdateFacultyTabPage.Location = new Point(4, 4);
            UpdateFacultyTabPage.Name = "UpdateFacultyTabPage";
            UpdateFacultyTabPage.Padding = new Padding(3);
            UpdateFacultyTabPage.Size = new Size(1880, 1062);
            UpdateFacultyTabPage.TabIndex = 1;
            UpdateFacultyTabPage.Text = "Update Faculty";
            UpdateFacultyTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateFacultyDataGridView
            // 
            UpdateFacultyDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            UpdateFacultyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateFacultyDataGridView.Location = new Point(293, 576);
            UpdateFacultyDataGridView.Name = "UpdateFacultyDataGridView";
            UpdateFacultyDataGridView.RowHeadersWidth = 62;
            UpdateFacultyDataGridView.Size = new Size(1274, 322);
            UpdateFacultyDataGridView.TabIndex = 84;
            UpdateFacultyDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.SteelBlue;
            UpdateButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(753, 449);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(328, 62);
            UpdateButton.TabIndex = 83;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdatePasswordTextBox
            // 
            UpdatePasswordTextBox.Location = new Point(1229, 348);
            UpdatePasswordTextBox.Name = "UpdatePasswordTextBox";
            UpdatePasswordTextBox.Size = new Size(503, 31);
            UpdatePasswordTextBox.TabIndex = 82;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(253, 254, 253);
            label8.Font = new Font("Arial Rounded MT Bold", 12F);
            label8.Location = new Point(1087, 348);
            label8.Name = "label8";
            label8.Size = new Size(136, 28);
            label8.TabIndex = 81;
            label8.Text = "Password:";
            // 
            // UpdatePhoneTextBox
            // 
            UpdatePhoneTextBox.Location = new Point(733, 345);
            UpdatePhoneTextBox.Name = "UpdatePhoneTextBox";
            UpdatePhoneTextBox.Size = new Size(329, 31);
            UpdatePhoneTextBox.TabIndex = 80;
            // 
            // UpdateStudentIdTextBox
            // 
            UpdateStudentIdTextBox.Location = new Point(293, 345);
            UpdateStudentIdTextBox.Name = "UpdateStudentIdTextBox";
            UpdateStudentIdTextBox.Size = new Size(271, 31);
            UpdateStudentIdTextBox.TabIndex = 79;
            // 
            // UpdateEmailTextBox
            // 
            UpdateEmailTextBox.Location = new Point(1087, 279);
            UpdateEmailTextBox.Name = "UpdateEmailTextBox";
            UpdateEmailTextBox.Size = new Size(645, 31);
            UpdateEmailTextBox.TabIndex = 78;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(253, 254, 253);
            label10.Font = new Font("Arial Rounded MT Bold", 12F);
            label10.Location = new Point(154, 345);
            label10.Name = "label10";
            label10.Size = new Size(133, 28);
            label10.TabIndex = 77;
            label10.Text = "Faculty Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(253, 254, 253);
            label11.Font = new Font("Arial Rounded MT Bold", 12F);
            label11.Location = new Point(635, 345);
            label11.Name = "label11";
            label11.Size = new Size(92, 28);
            label11.TabIndex = 76;
            label11.Text = "Phone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(253, 254, 253);
            label12.Font = new Font("Arial Rounded MT Bold", 12F);
            label12.Location = new Point(996, 279);
            label12.Name = "label12";
            label12.Size = new Size(85, 28);
            label12.TabIndex = 75;
            label12.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(253, 254, 253);
            label13.Font = new Font("Arial Rounded MT Bold", 12F);
            label13.Location = new Point(152, 279);
            label13.Name = "label13";
            label13.Size = new Size(135, 28);
            label13.TabIndex = 74;
            label13.Text = "Full Name:";
            // 
            // UpdateFullNameTextBox
            // 
            UpdateFullNameTextBox.Location = new Point(293, 279);
            UpdateFullNameTextBox.Name = "UpdateFullNameTextBox";
            UpdateFullNameTextBox.Size = new Size(591, 31);
            UpdateFullNameTextBox.TabIndex = 73;
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
            label2.Size = new Size(295, 43);
            label2.TabIndex = 0;
            label2.Text = "Update Faculty:";
            // 
            // DeleteFacultyTabPage
            // 
            DeleteFacultyTabPage.Controls.Add(DeleteFacultyDataGridView);
            DeleteFacultyTabPage.Controls.Add(DeleteButton);
            DeleteFacultyTabPage.Controls.Add(DeleteStudentIdTextBox);
            DeleteFacultyTabPage.Controls.Add(label14);
            DeleteFacultyTabPage.Controls.Add(label15);
            DeleteFacultyTabPage.Controls.Add(DeleteFullNameTextBox);
            DeleteFacultyTabPage.Controls.Add(panel3);
            DeleteFacultyTabPage.Location = new Point(4, 4);
            DeleteFacultyTabPage.Name = "DeleteFacultyTabPage";
            DeleteFacultyTabPage.Padding = new Padding(3);
            DeleteFacultyTabPage.Size = new Size(1880, 1062);
            DeleteFacultyTabPage.TabIndex = 2;
            DeleteFacultyTabPage.Text = "Delete Faculty";
            DeleteFacultyTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteFacultyDataGridView
            // 
            DeleteFacultyDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            DeleteFacultyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeleteFacultyDataGridView.Location = new Point(226, 629);
            DeleteFacultyDataGridView.Name = "DeleteFacultyDataGridView";
            DeleteFacultyDataGridView.RowHeadersWidth = 62;
            DeleteFacultyDataGridView.Size = new Size(1322, 273);
            DeleteFacultyDataGridView.TabIndex = 79;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SteelBlue;
            DeleteButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(717, 483);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(328, 62);
            DeleteButton.TabIndex = 78;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteStudentIdTextBox
            // 
            DeleteStudentIdTextBox.Location = new Point(717, 365);
            DeleteStudentIdTextBox.Name = "DeleteStudentIdTextBox";
            DeleteStudentIdTextBox.Size = new Size(271, 31);
            DeleteStudentIdTextBox.TabIndex = 77;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(253, 254, 253);
            label14.Font = new Font("Arial Rounded MT Bold", 12F);
            label14.Location = new Point(578, 365);
            label14.Name = "label14";
            label14.Size = new Size(133, 28);
            label14.TabIndex = 76;
            label14.Text = "Faculty Id:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(253, 254, 253);
            label15.Font = new Font("Arial Rounded MT Bold", 12F);
            label15.Location = new Point(576, 299);
            label15.Name = "label15";
            label15.Size = new Size(135, 28);
            label15.TabIndex = 75;
            label15.Text = "Full Name:";
            // 
            // DeleteFullNameTextBox
            // 
            DeleteFullNameTextBox.Location = new Point(717, 299);
            DeleteFullNameTextBox.Name = "DeleteFullNameTextBox";
            DeleteFullNameTextBox.Size = new Size(591, 31);
            DeleteFullNameTextBox.TabIndex = 74;
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
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 62);
            label3.Name = "label3";
            label3.Size = new Size(280, 43);
            label3.TabIndex = 0;
            label3.Text = "Delete Faculty:";
            // 
            // AddFacultyUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tabControl1);
            Name = "AddFacultyUserControl";
            Size = new Size(1888, 1100);
            tabControl1.ResumeLayout(false);
            InsertFacultyTabPage.ResumeLayout(false);
            InsertFacultyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FacultyDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            UpdateFacultyTabPage.ResumeLayout(false);
            UpdateFacultyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateFacultyDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            DeleteFacultyTabPage.ResumeLayout(false);
            DeleteFacultyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteFacultyDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage InsertFacultyTabPage;
        private TabPage UpdateFacultyTabPage;
        private TabPage DeleteFacultyTabPage;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
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
        private DataGridView FacultyDataGridView;
        private DataGridView UpdateFacultyDataGridView;
        private DataGridView DeleteFacultyDataGridView;
        private Button DeleteButton;
        private TextBox DeleteStudentIdTextBox;
        private Label label14;
        private Label label15;
        private TextBox DeleteFullNameTextBox;
    }
}
