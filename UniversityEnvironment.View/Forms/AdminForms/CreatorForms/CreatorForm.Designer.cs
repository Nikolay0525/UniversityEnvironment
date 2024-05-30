namespace UniversityEnvironment.View.Forms.AdminForms
{
    partial class CreatorForm
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
            CloseButton = new Button();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(12, 307);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(280, 49);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = SystemColors.ControlLightLight;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Location = new Point(12, 253);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(280, 48);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreatorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(CloseButton);
            Controls.Add(CreateButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "CreatorForm";
            Sizable = false;
            Text = "CreatorForm";
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Button CreateButton;
    }
}