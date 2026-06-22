namespace Attendance_Monitoring_System
{
    partial class AttendanceUserControl
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
            panel1 = new Panel();
            label1 = new Label();
            SubjectNameTextBox = new TextBox();
            label4 = new Label();
            SectionTextBox = new TextBox();
            label2 = new Label();
            AttendanceDatePicker = new DateTimePicker();
            label3 = new Label();
            SubmitButton = new Button();
            SaveAttancanceButton = new Button();
            AttendnceDataGridView = new DataGridView();
            Present = new DataGridViewCheckBoxColumn();
            label5 = new Label();
            DepartmentTextBox = new TextBox();
            ViewAttendanceButton = new Button();
            DeleteAttendanceButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendnceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 178);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 62);
            label1.Name = "label1";
            label1.Size = new Size(332, 43);
            label1.TabIndex = 0;
            label1.Text = "Take Attendance:";
            // 
            // SubjectNameTextBox
            // 
            SubjectNameTextBox.Location = new Point(1198, 293);
            SubjectNameTextBox.Name = "SubjectNameTextBox";
            SubjectNameTextBox.Size = new Size(519, 31);
            SubjectNameTextBox.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(253, 254, 253);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(1011, 293);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 74;
            label4.Text = "Subject Name:";
            // 
            // SectionTextBox
            // 
            SectionTextBox.Location = new Point(317, 389);
            SectionTextBox.Name = "SectionTextBox";
            SectionTextBox.Size = new Size(519, 31);
            SectionTextBox.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(253, 254, 253);
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(204, 389);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 76;
            label2.Text = "Section:";
            // 
            // AttendanceDatePicker
            // 
            AttendanceDatePicker.Location = new Point(1198, 386);
            AttendanceDatePicker.Name = "AttendanceDatePicker";
            AttendanceDatePicker.Size = new Size(300, 31);
            AttendanceDatePicker.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(253, 254, 253);
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(1118, 386);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 78;
            label3.Text = "Date:";
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.DarkSlateGray;
            SubmitButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(233, 519);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(328, 62);
            SubmitButton.TabIndex = 83;
            SubmitButton.Text = "Search";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // SaveAttancanceButton
            // 
            SaveAttancanceButton.BackColor = Color.DarkSlateGray;
            SaveAttancanceButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveAttancanceButton.ForeColor = Color.White;
            SaveAttancanceButton.Location = new Point(622, 519);
            SaveAttancanceButton.Name = "SaveAttancanceButton";
            SaveAttancanceButton.Size = new Size(328, 62);
            SaveAttancanceButton.TabIndex = 84;
            SaveAttancanceButton.Text = "Save Attendance";
            SaveAttancanceButton.UseVisualStyleBackColor = false;
            SaveAttancanceButton.Click += SaveAttancanceButton_Click;
            // 
            // AttendnceDataGridView
            // 
            AttendnceDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            AttendnceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendnceDataGridView.Columns.AddRange(new DataGridViewColumn[] { Present });
            AttendnceDataGridView.GridColor = SystemColors.ButtonShadow;
            AttendnceDataGridView.Location = new Point(233, 681);
            AttendnceDataGridView.Name = "AttendnceDataGridView";
            AttendnceDataGridView.RowHeadersWidth = 62;
            AttendnceDataGridView.Size = new Size(1484, 336);
            AttendnceDataGridView.TabIndex = 85;
            // 
            // Present
            // 
            Present.HeaderText = "isPresent?";
            Present.MinimumWidth = 8;
            Present.Name = "Present";
            Present.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(253, 254, 253);
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(154, 293);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 86;
            label5.Text = "Department:";
            // 
            // DepartmentTextBox
            // 
            DepartmentTextBox.Location = new Point(317, 296);
            DepartmentTextBox.Name = "DepartmentTextBox";
            DepartmentTextBox.Size = new Size(519, 31);
            DepartmentTextBox.TabIndex = 87;
            // 
            // ViewAttendanceButton
            // 
            ViewAttendanceButton.BackColor = Color.DarkSlateGray;
            ViewAttendanceButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewAttendanceButton.ForeColor = Color.White;
            ViewAttendanceButton.Location = new Point(1011, 519);
            ViewAttendanceButton.Name = "ViewAttendanceButton";
            ViewAttendanceButton.Size = new Size(328, 62);
            ViewAttendanceButton.TabIndex = 88;
            ViewAttendanceButton.Text = "View Attendance";
            ViewAttendanceButton.UseVisualStyleBackColor = false;
            ViewAttendanceButton.Click += ViewAttendanceButton_Click;
            // 
            // DeleteAttendanceButton
            // 
            DeleteAttendanceButton.BackColor = Color.DarkSlateGray;
            DeleteAttendanceButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteAttendanceButton.ForeColor = Color.White;
            DeleteAttendanceButton.Location = new Point(1389, 519);
            DeleteAttendanceButton.Name = "DeleteAttendanceButton";
            DeleteAttendanceButton.Size = new Size(328, 62);
            DeleteAttendanceButton.TabIndex = 89;
            DeleteAttendanceButton.Text = "Delete Attendance";
            DeleteAttendanceButton.UseVisualStyleBackColor = false;
            DeleteAttendanceButton.Click += DeleteAttendanceButton_Click;
            // 
            // AttendanceUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(DeleteAttendanceButton);
            Controls.Add(ViewAttendanceButton);
            Controls.Add(DepartmentTextBox);
            Controls.Add(label5);
            Controls.Add(AttendnceDataGridView);
            Controls.Add(SaveAttancanceButton);
            Controls.Add(SubmitButton);
            Controls.Add(label3);
            Controls.Add(AttendanceDatePicker);
            Controls.Add(label2);
            Controls.Add(SectionTextBox);
            Controls.Add(label4);
            Controls.Add(SubjectNameTextBox);
            Controls.Add(panel1);
            Name = "AttendanceUserControl";
            Size = new Size(1888, 1100);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttendnceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox SubjectNameTextBox;
        private Label label4;
        private TextBox SectionTextBox;
        private Label label2;
        private DateTimePicker AttendanceDatePicker;
        private Label label3;
        private Button SubmitButton;
        private Button SaveAttancanceButton;
        private DataGridView AttendnceDataGridView;
        private Label label5;
        private TextBox DepartmentTextBox;
        private Button ViewAttendanceButton;
        private DataGridViewCheckBoxColumn Present;
        private Button DeleteAttendanceButton;
    }
}
