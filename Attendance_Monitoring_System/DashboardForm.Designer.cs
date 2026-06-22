namespace Attendance_Monitoring_System
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            panel5 = new Panel();
            SliderPanel1 = new Panel();
            panel6 = new Panel();
            AddFacultyButton = new Button();
            AttendanceButton = new Button();
            AddClassButton = new Button();
            AddStudentButton = new Button();
            ReportButton = new Button();
            DashBoardButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            ExpandPanel = new Panel();
            ExitButton = new Button();
            panel4 = new Panel();
            MinimizeButton = new Button();
            LogoutButton = new Button();
            ExpandBox = new PictureBox();
            IdentityLabel = new Label();
            label7 = new Label();
            UserNameLabel = new Label();
            label5 = new Label();
            dashBoardUserControl1 = new DashBoardUserControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addClassUserControl1 = new AddClassUserControl();
            addFacultyUserControl1 = new AddFacultyUserControl();
            addStudentUserControl1 = new AddStudentUserControl();
            attendanceUserControl1 = new AttendanceUserControl();
            reportUserControl1 = new ReportUserControl();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SliderPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ExpandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpandBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1474);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.Controls.Add(SliderPanel1);
            panel5.Controls.Add(AddFacultyButton);
            panel5.Controls.Add(AttendanceButton);
            panel5.Controls.Add(AddClassButton);
            panel5.Controls.Add(AddStudentButton);
            panel5.Controls.Add(ReportButton);
            panel5.Controls.Add(DashBoardButton);
            panel5.Location = new Point(0, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(368, 1371);
            panel5.TabIndex = 2;
            // 
            // SliderPanel1
            // 
            SliderPanel1.BackColor = Color.Black;
            SliderPanel1.Controls.Add(panel6);
            SliderPanel1.Location = new Point(3, 1193);
            SliderPanel1.Name = "SliderPanel1";
            SliderPanel1.Size = new Size(10, 199);
            SliderPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ScrollBar;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 104);
            panel6.TabIndex = 6;
            // 
            // AddFacultyButton
            // 
            AddFacultyButton.BackColor = SystemColors.Menu;
            AddFacultyButton.FlatAppearance.BorderSize = 0;
            AddFacultyButton.FlatStyle = FlatStyle.Flat;
            AddFacultyButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddFacultyButton.Location = new Point(12, 516);
            AddFacultyButton.Name = "AddFacultyButton";
            AddFacultyButton.Size = new Size(356, 98);
            AddFacultyButton.TabIndex = 20;
            AddFacultyButton.Text = "Add Faculty";
            AddFacultyButton.UseVisualStyleBackColor = false;
            AddFacultyButton.Click += AddFacultyButton_Click;
            // 
            // AttendanceButton
            // 
            AttendanceButton.BackColor = SystemColors.Menu;
            AttendanceButton.FlatAppearance.BorderSize = 0;
            AttendanceButton.FlatStyle = FlatStyle.Flat;
            AttendanceButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttendanceButton.Location = new Point(12, 208);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(356, 96);
            AttendanceButton.TabIndex = 19;
            AttendanceButton.Text = "Attendance";
            AttendanceButton.UseVisualStyleBackColor = false;
            AttendanceButton.Click += AttendanceButton_Click;
            // 
            // AddClassButton
            // 
            AddClassButton.BackColor = SystemColors.Menu;
            AddClassButton.FlatAppearance.BorderSize = 0;
            AddClassButton.FlatStyle = FlatStyle.Flat;
            AddClassButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddClassButton.Location = new Point(12, 310);
            AddClassButton.Name = "AddClassButton";
            AddClassButton.Size = new Size(356, 96);
            AddClassButton.TabIndex = 12;
            AddClassButton.Text = "Add Class";
            AddClassButton.UseVisualStyleBackColor = false;
            AddClassButton.Click += AddClassButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.BackColor = SystemColors.Menu;
            AddStudentButton.FlatAppearance.BorderSize = 0;
            AddStudentButton.FlatStyle = FlatStyle.Flat;
            AddStudentButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddStudentButton.Location = new Point(12, 412);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(356, 98);
            AddStudentButton.TabIndex = 15;
            AddStudentButton.Text = "Add Student";
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.BackColor = SystemColors.Menu;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReportButton.Location = new Point(12, 107);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(356, 95);
            ReportButton.TabIndex = 18;
            ReportButton.Text = "Genrate Report";
            ReportButton.UseVisualStyleBackColor = false;
            ReportButton.Click += ReportButton_Click;
            // 
            // DashBoardButton
            // 
            DashBoardButton.BackColor = SystemColors.Menu;
            DashBoardButton.FlatAppearance.BorderSize = 0;
            DashBoardButton.FlatStyle = FlatStyle.Flat;
            DashBoardButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashBoardButton.Location = new Point(12, 3);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(356, 98);
            DashBoardButton.TabIndex = 9;
            DashBoardButton.Text = "Dash Board";
            DashBoardButton.UseVisualStyleBackColor = false;
            DashBoardButton.Click += DashBoardButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 213);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(129, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 25;
            label3.Text = "SYSTEM";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Bauhaus 93", 10F);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(101, 162);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 24;
            label2.Text = "MONITORING";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Bauhaus 93", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(89, 137);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 23;
            label4.Text = "ATTENDANCE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 141);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(ExpandPanel);
            panel3.Controls.Add(ExpandBox);
            panel3.Controls.Add(IdentityLabel);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(UserNameLabel);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(368, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1888, 213);
            panel3.TabIndex = 3;
            // 
            // ExpandPanel
            // 
            ExpandPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExpandPanel.BackColor = Color.FromArgb(224, 224, 224);
            ExpandPanel.BorderStyle = BorderStyle.FixedSingle;
            ExpandPanel.Controls.Add(ExitButton);
            ExpandPanel.Controls.Add(panel4);
            ExpandPanel.Controls.Add(MinimizeButton);
            ExpandPanel.Controls.Add(LogoutButton);
            ExpandPanel.Location = new Point(1593, 0);
            ExpandPanel.Name = "ExpandPanel";
            ExpandPanel.Size = new Size(252, 214);
            ExpandPanel.TabIndex = 4;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Dock = DockStyle.Top;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(0, 139);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(250, 66);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 10);
            panel4.TabIndex = 4;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.White;
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.Dock = DockStyle.Top;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimizeButton.Location = new Point(0, 73);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(250, 66);
            MinimizeButton.TabIndex = 1;
            MinimizeButton.Text = "Minimize";
            MinimizeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.White;
            LogoutButton.Cursor = Cursors.Hand;
            LogoutButton.Dock = DockStyle.Top;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.Location = new Point(0, 0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(250, 73);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "  Log Out";
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // ExpandBox
            // 
            ExpandBox.Cursor = Cursors.Hand;
            ExpandBox.Image = (Image)resources.GetObject("ExpandBox.Image");
            ExpandBox.Location = new Point(1845, 3);
            ExpandBox.Name = "ExpandBox";
            ExpandBox.Size = new Size(40, 36);
            ExpandBox.SizeMode = PictureBoxSizeMode.Zoom;
            ExpandBox.TabIndex = 8;
            ExpandBox.TabStop = false;
            ExpandBox.Click += ExpandBox_Click;
            // 
            // IdentityLabel
            // 
            IdentityLabel.AutoSize = true;
            IdentityLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            IdentityLabel.Location = new Point(140, 124);
            IdentityLabel.Name = "IdentityLabel";
            IdentityLabel.Size = new Size(41, 28);
            IdentityLabel.TabIndex = 7;
            IdentityLabel.Text = "{?}";
            IdentityLabel.Click += IDLabel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(35, 124);
            label7.Name = "label7";
            label7.Size = new Size(112, 28);
            label7.TabIndex = 6;
            label7.Text = "Identity: ";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            UserNameLabel.Location = new Point(155, 74);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(41, 28);
            UserNameLabel.TabIndex = 5;
            UserNameLabel.Text = "{?}";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 46);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 4;
            label5.Text = "Welcome Back.";
            // 
            // dashBoardUserControl1
            // 
            dashBoardUserControl1.BackColor = Color.AliceBlue;
            dashBoardUserControl1.Location = new Point(368, 212);
            dashBoardUserControl1.Name = "dashBoardUserControl1";
            dashBoardUserControl1.Size = new Size(1888, 800);
            dashBoardUserControl1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // addClassUserControl1
            // 
            addClassUserControl1.BackColor = SystemColors.ButtonHighlight;
            addClassUserControl1.Location = new Point(368, 212);
            addClassUserControl1.Name = "addClassUserControl1";
            addClassUserControl1.Size = new Size(2832, 1350);
            addClassUserControl1.TabIndex = 5;
            addClassUserControl1.Visible = false;
            // 
            // addFacultyUserControl1
            // 
            addFacultyUserControl1.BackColor = SystemColors.ButtonHighlight;
            addFacultyUserControl1.Location = new Point(368, 212);
            addFacultyUserControl1.Name = "addFacultyUserControl1";
            addFacultyUserControl1.Size = new Size(2832, 1350);
            addFacultyUserControl1.TabIndex = 6;
            addFacultyUserControl1.Visible = false;
            // 
            // addStudentUserControl1
            // 
            addStudentUserControl1.BackColor = SystemColors.ButtonFace;
            addStudentUserControl1.Location = new Point(368, 212);
            addStudentUserControl1.Name = "addStudentUserControl1";
            addStudentUserControl1.Size = new Size(2832, 1350);
            addStudentUserControl1.TabIndex = 7;
            addStudentUserControl1.Visible = false;
            // 
            // attendanceUserControl1
            // 
            attendanceUserControl1.BackColor = SystemColors.ButtonHighlight;
            attendanceUserControl1.Location = new Point(368, 212);
            attendanceUserControl1.Name = "attendanceUserControl1";
            attendanceUserControl1.Size = new Size(2832, 1350);
            attendanceUserControl1.TabIndex = 8;
            attendanceUserControl1.Visible = false;
            // 
            // reportUserControl1
            // 
            reportUserControl1.BackColor = SystemColors.ButtonHighlight;
            reportUserControl1.Location = new Point(368, 209);
            reportUserControl1.Name = "reportUserControl1";
            reportUserControl1.Size = new Size(2832, 1350);
            reportUserControl1.TabIndex = 21;
            reportUserControl1.Visible = false;
            reportUserControl1.Load += reportUserControl1_Load;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(2256, 1474);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dashBoardUserControl1);
            Controls.Add(reportUserControl1);
            Controls.Add(attendanceUserControl1);
            Controls.Add(addStudentUserControl1);
            Controls.Add(addFacultyUserControl1);
            Controls.Add(addClassUserControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            SliderPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ExpandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExpandBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel3;
        private Label IdentityLabel;
        private Label label7;
        private Label UserNameLabel;
        private Label label5;
        private PictureBox ExpandBox;
        private Panel ExpandPanel;
        private Button LogoutButton;
        private Button MinimizeButton;
        private Panel panel5;
        private Panel SliderPanel1;
        private Button DashBoardButton;
        private Button ReportButton;
        private Button AddStudentButton;
        private Button AddClassButton;
        private Panel panel4;
        private Button ExitButton;
        private Button AttendanceButton;
        private Button AddFacultyButton;
        private DashBoardUserControl dashBoardUserControl1;
        private ContextMenuStrip contextMenuStrip1;
        private AddClassUserControl addClassUserControl1;
        private Panel panel6;
        private AddFacultyUserControl addFacultyUserControl1;
        private AddStudentUserControl addStudentUserControl1;
        private AttendanceUserControl attendanceUserControl1;
        private ReportUserControl reportUserControl1;
    }
}