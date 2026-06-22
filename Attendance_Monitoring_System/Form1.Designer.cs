namespace Attendance_Monitoring_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            RegisterLabel = new Label();
            ForgetLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label8 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            LoginButton = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ExitBox = new PictureBox();
            ExitButton = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.BackColor = Color.White;
            RegisterLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            RegisterLabel.ForeColor = Color.FromArgb(0, 64, 64);
            RegisterLabel.Location = new Point(499, 816);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(81, 25);
            RegisterLabel.TabIndex = 31;
            RegisterLabel.Text = "Register";
            RegisterLabel.Click += RegisterLabel_Click;
            // 
            // ForgetLabel
            // 
            ForgetLabel.AutoSize = true;
            ForgetLabel.BackColor = SystemColors.ButtonHighlight;
            ForgetLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ForgetLabel.ForeColor = Color.FromArgb(0, 64, 64);
            ForgetLabel.Location = new Point(595, 679);
            ForgetLabel.Name = "ForgetLabel";
            ForgetLabel.Size = new Size(158, 25);
            ForgetLabel.TabIndex = 29;
            ForgetLabel.Text = "Forget Password?";
            ForgetLabel.Click += ForgetLabel_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = SystemColors.ButtonHighlight;
            UserNameTextBox.BorderStyle = BorderStyle.None;
            UserNameTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(208, 398);
            UserNameTextBox.Multiline = true;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(545, 38);
            UserNameTextBox.TabIndex = 34;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.ButtonHighlight;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(208, 544);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(545, 30);
            PasswordTextBox.TabIndex = 33;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 64, 64);
            label8.Location = new Point(155, 302);
            label8.Name = "label8";
            label8.Size = new Size(310, 30);
            label8.TabIndex = 32;
            label8.Text = "Please enter your details:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI Semibold", 9F);
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(290, 816);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 30;
            label6.Text = "Don't have an account?";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 64, 64);
            panel4.Location = new Point(155, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(598, 4);
            panel4.TabIndex = 28;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(155, 530);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(155, 388);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Teal;
            LoginButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(155, 707);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(598, 62);
            LoginButton.TabIndex = 25;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 64);
            panel3.Location = new Point(155, 445);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 4);
            panel3.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(852, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 488);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(1169, 730);
            label3.Name = "label3";
            label3.Size = new Size(126, 39);
            label3.TabIndex = 22;
            label3.Text = "SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Bauhaus 93", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(1108, 685);
            label2.Name = "label2";
            label2.Size = new Size(256, 45);
            label2.TabIndex = 21;
            label2.Text = "MONITORING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Bauhaus 93", 21F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(1097, 637);
            label1.Name = "label1";
            label1.Size = new Size(277, 48);
            label1.TabIndex = 20;
            label1.Text = "ATTENDANCE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1038, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(82, 58);
            label4.Name = "label4";
            label4.Size = new Size(296, 56);
            label4.TabIndex = 4;
            label4.Text = "Log-in Form";
            // 
            // ExitBox
            // 
            ExitBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitBox.Image = (Image)resources.GetObject("ExitBox.Image");
            ExitBox.Location = new Point(2943, 12);
            ExitBox.Name = "ExitBox";
            ExitBox.Size = new Size(45, 39);
            ExitBox.SizeMode = PictureBoxSizeMode.Zoom;
            ExitBox.TabIndex = 5;
            ExitBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.Location = new Point(1552, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(45, 39);
            ExitButton.SizeMode = PictureBoxSizeMode.Zoom;
            ExitButton.TabIndex = 6;
            ExitButton.TabStop = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(ExitBox);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Teal;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 173);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1600, 900);
            Controls.Add(RegisterLabel);
            Controls.Add(ForgetLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(LoginButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RegisterLabel;
        private Label ForgetLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Label label8;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button LoginButton;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox ExitBox;
        private PictureBox ExitButton;
        private Panel panel1;
    }
}
