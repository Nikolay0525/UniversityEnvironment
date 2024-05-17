namespace UniversityEnvironment.View.Forms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameLabel = new Label();
            SurnameLabel = new Label();
            RoleLabel = new Label();
            label4 = new Label();
            ScienceDegreeLabel = new Label();
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
            CoursesList.Location = new Point(12, 212);
            CoursesList.Name = "CoursesList";
            CoursesList.Size = new Size(136, 144);
            CoursesList.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(199, 78);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(187, 147);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(204, 216);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(154, 104);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(138, 23);
            NameLabel.TabIndex = 5;
            // 
            // SurnameLabel
            // 
            SurnameLabel.Location = new Point(154, 177);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(138, 23);
            SurnameLabel.TabIndex = 5;
            // 
            // RoleLabel
            // 
            RoleLabel.Location = new Point(154, 245);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(138, 23);
            RoleLabel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(171, 287);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 9;
            label4.Text = "ScienceDegree";
            // 
            // ScienceDegreeLabel
            // 
            ScienceDegreeLabel.Location = new Point(154, 322);
            ScienceDegreeLabel.Name = "ScienceDegreeLabel";
            ScienceDegreeLabel.Size = new Size(138, 23);
            ScienceDegreeLabel.TabIndex = 8;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(label4);
            Controls.Add(ScienceDegreeLabel);
            Controls.Add(RoleLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(NameLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CoursesList);
            Controls.Add(pictureBox1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected PictureBox pictureBox1;
        protected ListBox CoursesList;
        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label NameLabel;
        protected Label SurnameLabel;
        protected Label RoleLabel;
        protected Label label4;
        protected Label ScienceDegreeLabel;
    }
}