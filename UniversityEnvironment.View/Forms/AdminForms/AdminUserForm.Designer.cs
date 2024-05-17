namespace UniversityEnvironment.View.Forms.AdminForms
{
    partial class AdminUserForm
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
            DeleteButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ControlLightLight;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(156, 362);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(136, 76);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete user";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(12, 362);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(138, 76);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // AdminUserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(CloseButton);
            Controls.Add(DeleteButton);
            Name = "AdminUserForm";
            Text = "AdminUserForm";
            Controls.SetChildIndex(ScienceDegreeLabel, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(CoursesList, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(NameLabel, 0);
            Controls.SetChildIndex(SurnameLabel, 0);
            Controls.SetChildIndex(RoleLabel, 0);
            Controls.SetChildIndex(DeleteButton, 0);
            Controls.SetChildIndex(CloseButton, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteButton;
        private Button CloseButton;
    }
}