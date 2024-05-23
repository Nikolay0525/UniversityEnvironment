namespace UniversityEnvironment.View.Forms
{
    partial class LoginForm
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
            RegisterButton = new Button();
            LoginButton = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            StudentCheck = new RadioButton();
            TeacherCheck = new RadioButton();
            AdminCheck = new RadioButton();
            ForgetButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = SystemColors.ControlLightLight;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.ForeColor = SystemColors.ControlText;
            RegisterButton.Location = new Point(114, 303);
            RegisterButton.Margin = new Padding(4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(177, 52);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ControlLightLight;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.ForeColor = SystemColors.ControlText;
            LoginButton.Location = new Point(114, 223);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(177, 73);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(12, 108);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(280, 27);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 170);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(280, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(110, 147);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(123, 85);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Login";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(StudentCheck);
            groupBox1.Controls.Add(TeacherCheck);
            groupBox1.Controls.Add(AdminCheck);
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(88, 93);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // StudentCheck
            // 
            StudentCheck.AutoSize = true;
            StudentCheck.Checked = true;
            StudentCheck.Location = new Point(0, 68);
            StudentCheck.Name = "StudentCheck";
            StudentCheck.Size = new Size(89, 24);
            StudentCheck.TabIndex = 0;
            StudentCheck.TabStop = true;
            StudentCheck.Text = "Student?";
            StudentCheck.UseVisualStyleBackColor = true;
            // 
            // TeacherCheck
            // 
            TeacherCheck.AutoSize = true;
            TeacherCheck.Location = new Point(0, 40);
            TeacherCheck.Name = "TeacherCheck";
            TeacherCheck.Size = new Size(92, 24);
            TeacherCheck.TabIndex = 0;
            TeacherCheck.TabStop = true;
            TeacherCheck.Text = "Teacher?";
            TeacherCheck.UseVisualStyleBackColor = true;
            // 
            // AdminCheck
            // 
            AdminCheck.Location = new Point(0, 10);
            AdminCheck.Name = "AdminCheck";
            AdminCheck.Size = new Size(107, 30);
            AdminCheck.TabIndex = 0;
            AdminCheck.TabStop = true;
            AdminCheck.Text = "Admin?";
            AdminCheck.UseVisualStyleBackColor = true;
            // 
            // ForgetButton
            // 
            ForgetButton.BackColor = SystemColors.ControlLightLight;
            ForgetButton.FlatStyle = FlatStyle.Flat;
            ForgetButton.Location = new Point(12, 302);
            ForgetButton.Name = "ForgetButton";
            ForgetButton.Size = new Size(93, 53);
            ForgetButton.TabIndex = 12;
            ForgetButton.Text = "Forget Password";
            ForgetButton.UseVisualStyleBackColor = false;
            ForgetButton.Click += ForgetButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(ForgetButton);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Button LoginButton;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton TeacherCheck;
        private RadioButton AdminCheck;
        private Button ForgetButton;
        private RadioButton StudentCheck;
    }
}