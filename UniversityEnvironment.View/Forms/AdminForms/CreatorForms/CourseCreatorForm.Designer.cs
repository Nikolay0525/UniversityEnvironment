namespace UniversityEnvironment.View.Forms.AdminForms
{
    partial class CourseCreatorForm
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
            CourseNameBox = new TextBox();
            FacultyNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CourseNameBox
            // 
            CourseNameBox.Location = new Point(12, 116);
            CourseNameBox.Name = "CourseNameBox";
            CourseNameBox.Size = new Size(280, 27);
            CourseNameBox.TabIndex = 2;
            // 
            // FacultyNameBox
            // 
            FacultyNameBox.Location = new Point(12, 187);
            FacultyNameBox.Name = "FacultyNameBox";
            FacultyNameBox.Size = new Size(280, 27);
            FacultyNameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 164);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Faculty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 93);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // CourseCreatorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(304, 368);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FacultyNameBox);
            Controls.Add(CourseNameBox);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "CourseCreatorForm";
            Text = "Course creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox CourseNameBox;
        private TextBox FacultyNameBox;
        private Label label1;
        private Label label2;
    }
}