namespace Attendance_Monitoring_System
{
    partial class AddClassUserControl
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
            InsertClassTabPage = new TabPage();
            SectionTextBox = new TextBox();
            ClassNameTextBox = new TextBox();
            InsertClassDataGridView = new DataGridView();
            SubmitButton = new Button();
            TotalStudentTextBox = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            DepartmentTextBox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            DeleteClassTabPage = new TabPage();
            DeleteClassDataGridView = new DataGridView();
            DeleteButton = new Button();
            DeleteSectionTextBox = new TextBox();
            DeleteClassNameTextBox = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            DeleteDepartmentTextBox = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            SearchClassTabPage = new TabPage();
            SearchClassDataGridView = new DataGridView();
            SearchButton = new Button();
            SearchSectionTextBox = new TextBox();
            SearchClassNameTextBox = new TextBox();
            label7 = new Label();
            label12 = new Label();
            label13 = new Label();
            SearchDepartmentTextBox = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            tabControl.SuspendLayout();
            InsertClassTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InsertClassDataGridView).BeginInit();
            panel1.SuspendLayout();
            DeleteClassTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteClassDataGridView).BeginInit();
            panel2.SuspendLayout();
            SearchClassTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchClassDataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(InsertClassTabPage);
            tabControl.Controls.Add(DeleteClassTabPage);
            tabControl.Controls.Add(SearchClassTabPage);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1888, 1100);
            tabControl.TabIndex = 0;
            // 
            // InsertClassTabPage
            // 
            InsertClassTabPage.Controls.Add(SectionTextBox);
            InsertClassTabPage.Controls.Add(ClassNameTextBox);
            InsertClassTabPage.Controls.Add(InsertClassDataGridView);
            InsertClassTabPage.Controls.Add(SubmitButton);
            InsertClassTabPage.Controls.Add(TotalStudentTextBox);
            InsertClassTabPage.Controls.Add(label9);
            InsertClassTabPage.Controls.Add(label6);
            InsertClassTabPage.Controls.Add(label5);
            InsertClassTabPage.Controls.Add(label4);
            InsertClassTabPage.Controls.Add(DepartmentTextBox);
            InsertClassTabPage.Controls.Add(panel1);
            InsertClassTabPage.Location = new Point(4, 4);
            InsertClassTabPage.Name = "InsertClassTabPage";
            InsertClassTabPage.Padding = new Padding(3);
            InsertClassTabPage.Size = new Size(1880, 1062);
            InsertClassTabPage.TabIndex = 0;
            InsertClassTabPage.Text = "Insert Class";
            InsertClassTabPage.UseVisualStyleBackColor = true;
            // 
            // SectionTextBox
            // 
            SectionTextBox.Location = new Point(291, 343);
            SectionTextBox.Name = "SectionTextBox";
            SectionTextBox.Size = new Size(591, 31);
            SectionTextBox.TabIndex = 85;
            // 
            // ClassNameTextBox
            // 
            ClassNameTextBox.Location = new Point(1085, 277);
            ClassNameTextBox.Name = "ClassNameTextBox";
            ClassNameTextBox.Size = new Size(645, 31);
            ClassNameTextBox.TabIndex = 84;
            // 
            // InsertClassDataGridView
            // 
            InsertClassDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            InsertClassDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InsertClassDataGridView.Location = new Point(291, 580);
            InsertClassDataGridView.Name = "InsertClassDataGridView";
            InsertClassDataGridView.RowHeadersWidth = 62;
            InsertClassDataGridView.Size = new Size(1242, 324);
            InsertClassDataGridView.TabIndex = 83;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.SteelBlue;
            SubmitButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(751, 444);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(328, 62);
            SubmitButton.TabIndex = 82;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // TotalStudentTextBox
            // 
            TotalStudentTextBox.Location = new Point(1085, 343);
            TotalStudentTextBox.Name = "TotalStudentTextBox";
            TotalStudentTextBox.Size = new Size(645, 31);
            TotalStudentTextBox.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(253, 254, 253);
            label9.Font = new Font("Arial Rounded MT Bold", 12F);
            label9.Location = new Point(906, 343);
            label9.Name = "label9";
            label9.Size = new Size(173, 28);
            label9.TabIndex = 80;
            label9.Text = "Total Student:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(253, 254, 253);
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(178, 343);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 76;
            label6.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(253, 254, 253);
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(898, 274);
            label5.Name = "label5";
            label5.Size = new Size(181, 28);
            label5.TabIndex = 74;
            label5.Text = "Subject Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(253, 254, 253);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(128, 277);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 73;
            label4.Text = "Department:";
            // 
            // DepartmentTextBox
            // 
            DepartmentTextBox.Location = new Point(291, 274);
            DepartmentTextBox.Name = "DepartmentTextBox";
            DepartmentTextBox.Size = new Size(591, 31);
            DepartmentTextBox.TabIndex = 72;
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 62);
            label1.Name = "label1";
            label1.Size = new Size(226, 43);
            label1.TabIndex = 0;
            label1.Text = "Insert Class:";
            label1.Click += label1_Click;
            // 
            // DeleteClassTabPage
            // 
            DeleteClassTabPage.Controls.Add(DeleteClassDataGridView);
            DeleteClassTabPage.Controls.Add(DeleteButton);
            DeleteClassTabPage.Controls.Add(DeleteSectionTextBox);
            DeleteClassTabPage.Controls.Add(DeleteClassNameTextBox);
            DeleteClassTabPage.Controls.Add(label8);
            DeleteClassTabPage.Controls.Add(label10);
            DeleteClassTabPage.Controls.Add(label11);
            DeleteClassTabPage.Controls.Add(DeleteDepartmentTextBox);
            DeleteClassTabPage.Controls.Add(panel2);
            DeleteClassTabPage.Location = new Point(4, 4);
            DeleteClassTabPage.Name = "DeleteClassTabPage";
            DeleteClassTabPage.Padding = new Padding(3);
            DeleteClassTabPage.Size = new Size(1880, 1062);
            DeleteClassTabPage.TabIndex = 1;
            DeleteClassTabPage.Text = "Delete Class";
            DeleteClassTabPage.UseVisualStyleBackColor = true;
            DeleteClassTabPage.Click += tabPage2_Click;
            // 
            // DeleteClassDataGridView
            // 
            DeleteClassDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            DeleteClassDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeleteClassDataGridView.Location = new Point(303, 595);
            DeleteClassDataGridView.Name = "DeleteClassDataGridView";
            DeleteClassDataGridView.RowHeadersWidth = 62;
            DeleteClassDataGridView.Size = new Size(1274, 316);
            DeleteClassDataGridView.TabIndex = 92;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SteelBlue;
            DeleteButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(763, 447);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(328, 62);
            DeleteButton.TabIndex = 91;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteSectionTextBox
            // 
            DeleteSectionTextBox.Location = new Point(303, 346);
            DeleteSectionTextBox.Name = "DeleteSectionTextBox";
            DeleteSectionTextBox.Size = new Size(591, 31);
            DeleteSectionTextBox.TabIndex = 88;
            // 
            // DeleteClassNameTextBox
            // 
            DeleteClassNameTextBox.Location = new Point(1097, 277);
            DeleteClassNameTextBox.Name = "DeleteClassNameTextBox";
            DeleteClassNameTextBox.Size = new Size(645, 31);
            DeleteClassNameTextBox.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(253, 254, 253);
            label8.Font = new Font("Arial Rounded MT Bold", 12F);
            label8.Location = new Point(190, 346);
            label8.Name = "label8";
            label8.Size = new Size(107, 28);
            label8.TabIndex = 86;
            label8.Text = "Section:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(253, 254, 253);
            label10.Font = new Font("Arial Rounded MT Bold", 12F);
            label10.Location = new Point(910, 277);
            label10.Name = "label10";
            label10.Size = new Size(181, 28);
            label10.TabIndex = 85;
            label10.Text = "Subject Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(253, 254, 253);
            label11.Font = new Font("Arial Rounded MT Bold", 12F);
            label11.Location = new Point(140, 280);
            label11.Name = "label11";
            label11.Size = new Size(157, 28);
            label11.TabIndex = 84;
            label11.Text = "Department:";
            // 
            // DeleteDepartmentTextBox
            // 
            DeleteDepartmentTextBox.Location = new Point(303, 277);
            DeleteDepartmentTextBox.Name = "DeleteDepartmentTextBox";
            DeleteDepartmentTextBox.Size = new Size(591, 31);
            DeleteDepartmentTextBox.TabIndex = 83;
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
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 62);
            label2.Name = "label2";
            label2.Size = new Size(246, 43);
            label2.TabIndex = 0;
            label2.Text = "Delete Class:";
            // 
            // SearchClassTabPage
            // 
            SearchClassTabPage.Controls.Add(SearchClassDataGridView);
            SearchClassTabPage.Controls.Add(SearchButton);
            SearchClassTabPage.Controls.Add(SearchSectionTextBox);
            SearchClassTabPage.Controls.Add(SearchClassNameTextBox);
            SearchClassTabPage.Controls.Add(label7);
            SearchClassTabPage.Controls.Add(label12);
            SearchClassTabPage.Controls.Add(label13);
            SearchClassTabPage.Controls.Add(SearchDepartmentTextBox);
            SearchClassTabPage.Controls.Add(panel3);
            SearchClassTabPage.Location = new Point(4, 4);
            SearchClassTabPage.Name = "SearchClassTabPage";
            SearchClassTabPage.Padding = new Padding(3);
            SearchClassTabPage.Size = new Size(1880, 1062);
            SearchClassTabPage.TabIndex = 2;
            SearchClassTabPage.Text = "Search Class";
            SearchClassTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchClassDataGridView
            // 
            SearchClassDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            SearchClassDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchClassDataGridView.Location = new Point(309, 587);
            SearchClassDataGridView.Name = "SearchClassDataGridView";
            SearchClassDataGridView.RowHeadersWidth = 62;
            SearchClassDataGridView.Size = new Size(1254, 314);
            SearchClassDataGridView.TabIndex = 99;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.SteelBlue;
            SearchButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(769, 459);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(328, 62);
            SearchButton.TabIndex = 98;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchSectionTextBox
            // 
            SearchSectionTextBox.Location = new Point(309, 358);
            SearchSectionTextBox.Name = "SearchSectionTextBox";
            SearchSectionTextBox.Size = new Size(591, 31);
            SearchSectionTextBox.TabIndex = 97;
            // 
            // SearchClassNameTextBox
            // 
            SearchClassNameTextBox.Location = new Point(1103, 289);
            SearchClassNameTextBox.Name = "SearchClassNameTextBox";
            SearchClassNameTextBox.Size = new Size(645, 31);
            SearchClassNameTextBox.TabIndex = 96;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(253, 254, 253);
            label7.Font = new Font("Arial Rounded MT Bold", 12F);
            label7.Location = new Point(196, 358);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 95;
            label7.Text = "Section:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(253, 254, 253);
            label12.Font = new Font("Arial Rounded MT Bold", 12F);
            label12.Location = new Point(916, 289);
            label12.Name = "label12";
            label12.Size = new Size(181, 28);
            label12.TabIndex = 94;
            label12.Text = "Subject Name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(253, 254, 253);
            label13.Font = new Font("Arial Rounded MT Bold", 12F);
            label13.Location = new Point(146, 292);
            label13.Name = "label13";
            label13.Size = new Size(157, 28);
            label13.TabIndex = 93;
            label13.Text = "Department:";
            // 
            // SearchDepartmentTextBox
            // 
            SearchDepartmentTextBox.Location = new Point(309, 289);
            SearchDepartmentTextBox.Name = "SearchDepartmentTextBox";
            SearchDepartmentTextBox.Size = new Size(591, 31);
            SearchDepartmentTextBox.TabIndex = 92;
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
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 62);
            label3.Name = "label3";
            label3.Size = new Size(255, 43);
            label3.TabIndex = 0;
            label3.Text = "Search Class:";
            // 
            // AddClassUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tabControl);
            Name = "AddClassUserControl";
            Size = new Size(1888, 1100);
            tabControl.ResumeLayout(false);
            InsertClassTabPage.ResumeLayout(false);
            InsertClassTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InsertClassDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            DeleteClassTabPage.ResumeLayout(false);
            DeleteClassTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteClassDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            SearchClassTabPage.ResumeLayout(false);
            SearchClassTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchClassDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControl;
        private TabPage InsertClassTabPage;
        private TabPage DeleteClassTabPage;
        private TabPage SearchClassTabPage;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Button SubmitButton;
        private TextBox TotalStudentTextBox;
        private Label label9;
        private TextBox PhoneTextBox;
        private TextBox StudentIdTextBox;
        private TextBox EmailTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox DepartmentTextBox;
        private Button DeleteButton;
        private TextBox DeleteSectionTextBox;
        private TextBox DeleteClassNameTextBox;
        private Label label8;
        private Label label10;
        private Label label11;
        private TextBox DeleteDepartmentTextBox;
        private Button SearchButton;
        private TextBox SearchSectionTextBox;
        private TextBox SearchClassNameTextBox;
        private Label label7;
        private Label label12;
        private Label label13;
        private TextBox SearchDepartmentTextBox;
        private DataGridView InsertClassDataGridView;
        private TextBox SectionTextBox;
        private TextBox ClassNameTextBox;
        private DataGridView DeleteClassDataGridView;
        private DataGridView SearchClassDataGridView;
    }
}
