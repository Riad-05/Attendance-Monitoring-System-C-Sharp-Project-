namespace Attendance_Monitoring_System
{
    partial class ReportUserControl
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
            StudentIDTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            FullNameTextBox = new TextBox();
            SearchButton = new Button();
            GenerateReportDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GenerateReportDataGridView).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 62);
            label1.Name = "label1";
            label1.Size = new Size(321, 43);
            label1.TabIndex = 0;
            label1.Text = "Generate Report:";
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.Location = new Point(1102, 269);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(645, 31);
            StudentIDTextBox.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(253, 254, 253);
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(915, 266);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 87;
            label5.Text = "Student ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(253, 254, 253);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(167, 266);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 86;
            label4.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(308, 266);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(544, 31);
            FullNameTextBox.TabIndex = 85;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.DarkSlateGray;
            SearchButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(768, 364);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(328, 62);
            SearchButton.TabIndex = 89;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // GenerateReportDataGridView
            // 
            GenerateReportDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            GenerateReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GenerateReportDataGridView.Location = new Point(167, 499);
            GenerateReportDataGridView.Name = "GenerateReportDataGridView";
            GenerateReportDataGridView.RowHeadersWidth = 62;
            GenerateReportDataGridView.Size = new Size(1580, 549);
            GenerateReportDataGridView.TabIndex = 90;
            // 
            // ReportUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(GenerateReportDataGridView);
            Controls.Add(SearchButton);
            Controls.Add(StudentIDTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(FullNameTextBox);
            Controls.Add(panel1);
            Name = "ReportUserControl";
            Size = new Size(1888, 1100);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GenerateReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox StudentIDTextBox;
        private Label label5;
        private Label label4;
        private TextBox FullNameTextBox;
        private Button SearchButton;
        private DataGridView GenerateReportDataGridView;
    }
}
