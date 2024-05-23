namespace UniversityEnvironment.View.Forms.AdminForms
{
    partial class TestCreatorForm
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
            TestNameBox = new TextBox();
            DescriptionBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
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
            // 
            // TestNameBox
            // 
            TestNameBox.Location = new Point(12, 107);
            TestNameBox.Name = "TestNameBox";
            TestNameBox.Size = new Size(280, 27);
            TestNameBox.TabIndex = 4;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(12, 185);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(280, 27);
            DescriptionBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(118, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(104, 162);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // TestCreatorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescriptionBox);
            Controls.Add(TestNameBox);
            Controls.Add(CloseButton);
            Controls.Add(CreateButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TestCreatorForm";
            Text = "Test creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Button CreateButton;
        private TextBox TestNameBox;
        private TextBox DescriptionBox;
        private Label label1;
        private Label label2;
    }
}