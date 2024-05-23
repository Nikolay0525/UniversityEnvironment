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
            UsernameLabel = new Label();
            FullNameLabel = new Label();
            UsernameBox = new Label();
            FullNameBox = new Label();
            RoleBox = new Label();
            RoleLabel = new Label();
            ScienceDegreeBox = new Label();
            ScienceDegreeLabel = new Label();
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
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = SystemColors.ControlLightLight;
            UsernameLabel.Location = new Point(47, 77);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(80, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.BackColor = SystemColors.ControlLightLight;
            FullNameLabel.Location = new Point(114, 139);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(79, 20);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "Full name";
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = SystemColors.Control;
            UsernameBox.Location = new Point(29, 97);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(116, 24);
            UsernameBox.TabIndex = 4;
            // 
            // FullNameBox
            // 
            FullNameBox.BackColor = SystemColors.Control;
            FullNameBox.Location = new Point(29, 159);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(247, 24);
            FullNameBox.TabIndex = 4;
            // 
            // RoleBox
            // 
            RoleBox.BackColor = SystemColors.Control;
            RoleBox.Location = new Point(163, 97);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(113, 24);
            RoleBox.TabIndex = 4;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.BackColor = SystemColors.ControlLightLight;
            RoleLabel.Location = new Point(200, 77);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(40, 20);
            RoleLabel.TabIndex = 1;
            RoleLabel.Text = "Role";
            // 
            // ScienceDegreeBox
            // 
            ScienceDegreeBox.BackColor = SystemColors.Control;
            ScienceDegreeBox.Location = new Point(29, 214);
            ScienceDegreeBox.Name = "ScienceDegreeBox";
            ScienceDegreeBox.Size = new Size(247, 24);
            ScienceDegreeBox.TabIndex = 4;
            // 
            // ScienceDegreeLabel
            // 
            ScienceDegreeLabel.AutoSize = true;
            ScienceDegreeLabel.BackColor = SystemColors.ControlLightLight;
            ScienceDegreeLabel.Location = new Point(99, 194);
            ScienceDegreeLabel.Name = "ScienceDegreeLabel";
            ScienceDegreeLabel.Size = new Size(114, 20);
            ScienceDegreeLabel.TabIndex = 2;
            ScienceDegreeLabel.Text = "Science degree";
            // 
            // AdminRequestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(ScienceDegreeBox);
            Controls.Add(FullNameBox);
            Controls.Add(RoleBox);
            Controls.Add(UsernameBox);
            Controls.Add(RoleLabel);
            Controls.Add(ScienceDegreeLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(UsernameLabel);
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
        private Label UsernameLabel;
        private Label FullNameLabel;
        private Label UsernameBox;
        private Label FullNameBox;
        private Label RoleBox;
        private Label RoleLabel;
        private Label ScienceDegreeBox;
        private Label ScienceDegreeLabel;
    }
}