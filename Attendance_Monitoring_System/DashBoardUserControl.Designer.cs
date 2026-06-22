namespace Attendance_Monitoring_System
{
    partial class DashBoardUserControl
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
            panel1 = new Panel();
            TotalClassesLabel = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            TotalStudentsLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            TotalfacultiesLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(188, 208, 192);
            panel1.Controls.Add(TotalClassesLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 200);
            panel1.TabIndex = 0;
            // 
            // TotalClassesLabel
            // 
            TotalClassesLabel.AutoSize = true;
            TotalClassesLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalClassesLabel.Location = new Point(959, 101);
            TotalClassesLabel.Name = "TotalClassesLabel";
            TotalClassesLabel.Size = new Size(57, 38);
            TotalClassesLabel.TabIndex = 4;
            TotalClassesLabel.Text = "{?}";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(730, 101);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 3;
            label1.Text = "Total Classes:";
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 200);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 235, 225);
            panel2.Controls.Add(TotalStudentsLabel);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(1888, 200);
            panel2.TabIndex = 1;
            // 
            // TotalStudentsLabel
            // 
            TotalStudentsLabel.AutoSize = true;
            TotalStudentsLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalStudentsLabel.Location = new Point(959, 91);
            TotalStudentsLabel.Name = "TotalStudentsLabel";
            TotalStudentsLabel.Size = new Size(57, 38);
            TotalStudentsLabel.TabIndex = 5;
            TotalStudentsLabel.Text = "{?}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(716, 91);
            label2.Name = "label2";
            label2.Size = new Size(237, 38);
            label2.TabIndex = 4;
            label2.Text = "Total Students:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(711, 681);
            label3.Name = "label3";
            label3.Size = new Size(242, 38);
            label3.TabIndex = 4;
            label3.Text = "Total Faculties:";
            // 
            // TotalfacultiesLabel
            // 
            TotalfacultiesLabel.AutoSize = true;
            TotalfacultiesLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalfacultiesLabel.Location = new Point(959, 681);
            TotalfacultiesLabel.Name = "TotalfacultiesLabel";
            TotalfacultiesLabel.Size = new Size(57, 38);
            TotalfacultiesLabel.TabIndex = 6;
            TotalfacultiesLabel.Text = "{?}";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1888, 200);
            panel4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(111, 76);
            label5.Name = "label5";
            label5.Size = new Size(244, 47);
            label5.TabIndex = 3;
            label5.Text = "Dashboard:";
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 200);
            panel5.Name = "panel5";
            panel5.Size = new Size(950, 200);
            panel5.TabIndex = 2;
            // 
            // DashBoardUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(panel4);
            Controls.Add(TotalfacultiesLabel);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashBoardUserControl";
            Size = new Size(1888, 800);
            Load += DashBoardUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label TotalClassesLabel;
        private Label label1;
        private Label TotalStudentsLabel;
        private Label label2;
        private Label label3;
        private Label TotalfacultiesLabel;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
    }
}
