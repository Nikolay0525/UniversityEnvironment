namespace UniversityEnvironment.View.Forms
{
    partial class BaseTestForm
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
            dataGridView1 = new DataGridView();
            SendAnswersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(12, 327);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(129, 31);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(280, 246);
            dataGridView1.TabIndex = 1;
            // 
            // SendAnswersButton
            // 
            SendAnswersButton.BackColor = SystemColors.ControlLightLight;
            SendAnswersButton.FlatStyle = FlatStyle.Flat;
            SendAnswersButton.Location = new Point(147, 327);
            SendAnswersButton.Name = "SendAnswersButton";
            SendAnswersButton.Size = new Size(145, 31);
            SendAnswersButton.TabIndex = 2;
            SendAnswersButton.Text = "Send answers";
            SendAnswersButton.UseVisualStyleBackColor = false;
            // 
            // BaseTestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(SendAnswersButton);
            Controls.Add(dataGridView1);
            Controls.Add(CloseButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "BaseTestForm";
            Text = "BaseTestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private DataGridView dataGridView1;
        private Button SendAnswersButton;
    }
}