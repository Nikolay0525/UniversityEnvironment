namespace UniversityEnvironment.View.Forms
{
    partial class AdminRequestForm
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
            DeclineButton = new Button();
            AcceptButton = new Button();
            label1 = new Label();
            label2 = new Label();
            UsernameText = new Label();
            FullNameText = new Label();
            RoleText = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(12, 333);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(280, 30);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // DeclineButton
            // 
            DeclineButton.BackColor = SystemColors.ControlLightLight;
            DeclineButton.FlatStyle = FlatStyle.Flat;
            DeclineButton.Location = new Point(12, 292);
            DeclineButton.Name = "DeclineButton";
            DeclineButton.Size = new Size(280, 35);
            DeclineButton.TabIndex = 0;
            DeclineButton.Text = "Decline request";
            DeclineButton.UseVisualStyleBackColor = false;
            DeclineButton.Click += DeclineButton_Click;
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = SystemColors.ControlLightLight;
            AcceptButton.FlatStyle = FlatStyle.Flat;
            AcceptButton.Location = new Point(12, 251);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(280, 35);
            AcceptButton.TabIndex = 0;
            AcceptButton.Text = "Accept request";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(47, 95);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(114, 168);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Full name";
            // 
            // UsernameText
            // 
            UsernameText.BackColor = SystemColors.Control;
            UsernameText.Location = new Point(29, 125);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(116, 24);
            UsernameText.TabIndex = 4;
            // 
            // FullNameText
            // 
            FullNameText.BackColor = SystemColors.Control;
            FullNameText.Location = new Point(29, 199);
            FullNameText.Name = "FullNameText";
            FullNameText.Size = new Size(247, 24);
            FullNameText.TabIndex = 4;
            // 
            // RoleText
            // 
            RoleText.BackColor = SystemColors.Control;
            RoleText.Location = new Point(163, 125);
            RoleText.Name = "RoleText";
            RoleText.Size = new Size(113, 24);
            RoleText.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Location = new Point(200, 95);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 1;
            label9.Text = "Role";
            // 
            // AdminRequestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(FullNameText);
            Controls.Add(RoleText);
            Controls.Add(UsernameText);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AcceptButton);
            Controls.Add(DeclineButton);
            Controls.Add(CloseButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AdminRequestForm";
            Text = "Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Button DeclineButton;
        private new Button AcceptButton;
        private Label label1;
        private Label label2;
        private Label UsernameText;
        private Label FullNameText;
        private Label RoleText;
        private Label label9;
    }
}