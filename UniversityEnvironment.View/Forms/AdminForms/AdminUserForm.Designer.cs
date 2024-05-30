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
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ControlLightLight;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(12, 363);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(280, 76);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete user";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AdminUserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 451);
            Controls.Add(DeleteButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "AdminUserForm";
            Sizable = false;
            Text = "Profile";
            ResumeLayout(false);
        }

        #endregion
        private Button DeleteButton;
    }
}