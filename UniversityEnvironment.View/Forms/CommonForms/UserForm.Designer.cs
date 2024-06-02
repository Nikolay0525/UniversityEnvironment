namespace UniversityEnvironment.View.Forms.CommonForms
{
    partial class UserForm
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
            pictureBox1 = new PictureBox();
            CoursesList = new ListBox();
            NameLabel = new Label();
            SurnameLabel = new Label();
            RoleLabel = new Label();
            NameBox = new Label();
            SurnameBox = new Label();
            RoleBox = new Label();
            ScienceDegreeLabel = new Label();
            ScienceDegreeBox = new Label();
            CloseButton = new Button();
            DeductButton = new Button();
            CoursesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CoursesList
            // 
            CoursesList.FormattingEnabled = true;
            CoursesList.ItemHeight = 20;
            CoursesList.Location = new Point(12, 232);
            CoursesList.Name = "CoursesList";
            CoursesList.Size = new Size(136, 124);
            CoursesList.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = SystemColors.ControlLightLight;
            NameLabel.Location = new Point(199, 78);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(51, 20);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.BackColor = SystemColors.ControlLightLight;
            SurnameLabel.Location = new Point(188, 121);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(72, 20);
            SurnameLabel.TabIndex = 5;
            SurnameLabel.Text = "Surname";
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.BackColor = SystemColors.ControlLightLight;
            RoleLabel.Location = new Point(202, 164);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(40, 20);
            RoleLabel.TabIndex = 5;
            RoleLabel.Text = "Role";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(154, 98);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(138, 23);
            NameBox.TabIndex = 5;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(154, 141);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(138, 23);
            SurnameBox.TabIndex = 5;
            // 
            // RoleBox
            // 
            RoleBox.Location = new Point(154, 184);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(138, 23);
            RoleBox.TabIndex = 5;
            // 
            // ScienceDegreeLabel
            // 
            ScienceDegreeLabel.AutoSize = true;
            ScienceDegreeLabel.BackColor = SystemColors.ControlLightLight;
            ScienceDegreeLabel.Location = new Point(170, 207);
            ScienceDegreeLabel.Name = "ScienceDegreeLabel";
            ScienceDegreeLabel.Size = new Size(111, 20);
            ScienceDegreeLabel.TabIndex = 9;
            ScienceDegreeLabel.Text = "ScienceDegree";
            // 
            // ScienceDegreeBox
            // 
            ScienceDegreeBox.Location = new Point(154, 227);
            ScienceDegreeBox.Name = "ScienceDegreeBox";
            ScienceDegreeBox.Size = new Size(138, 23);
            ScienceDegreeBox.TabIndex = 8;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(154, 316);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(138, 40);
            CloseButton.TabIndex = 10;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // DeductButton
            // 
            DeductButton.BackColor = SystemColors.ControlLightLight;
            DeductButton.FlatStyle = FlatStyle.Flat;
            DeductButton.Location = new Point(154, 260);
            DeductButton.Name = "DeductButton";
            DeductButton.Size = new Size(138, 50);
            DeductButton.TabIndex = 10;
            DeductButton.Text = "Deduct from course";
            DeductButton.UseVisualStyleBackColor = false;
            DeductButton.Click += DeductButton_Click;
            // 
            // CoursesLabel
            // 
            CoursesLabel.AutoSize = true;
            CoursesLabel.BackColor = SystemColors.ControlLightLight;
            CoursesLabel.Location = new Point(48, 209);
            CoursesLabel.Name = "CoursesLabel";
            CoursesLabel.Size = new Size(66, 20);
            CoursesLabel.TabIndex = 9;
            CoursesLabel.Text = "Courses";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(DeductButton);
            Controls.Add(CloseButton);
            Controls.Add(CoursesLabel);
            Controls.Add(ScienceDegreeLabel);
            Controls.Add(ScienceDegreeBox);
            Controls.Add(RoleBox);
            Controls.Add(SurnameBox);
            Controls.Add(NameBox);
            Controls.Add(RoleLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(NameLabel);
            Controls.Add(CoursesList);
            Controls.Add(pictureBox1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UserForm";
            Sizable = false;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected PictureBox pictureBox1;
        protected ListBox CoursesList;
        protected Label NameLabel;
        protected Label SurnameLabel;
        protected Label RoleLabel;
        protected Label NameBox;
        protected Label SurnameBox;
        protected Label RoleBox;
        protected Label ScienceDegreeLabel;
        protected Label ScienceDegreeBox;
        protected Button CloseButton;
        protected Button DeductButton;
        protected Label CoursesLabel;
    }
}