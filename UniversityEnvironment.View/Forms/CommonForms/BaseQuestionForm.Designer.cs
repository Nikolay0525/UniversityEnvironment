namespace UniversityEnvironment.View.Forms.CommonForms
{
    partial class BaseQuestionForm
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
            dataGridView1 = new DataGridView();
            CloseButton = new Button();
            QuestionLabel = new Label();
            AnswerColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AnswerColumn });
            dataGridView1.Location = new Point(12, 116);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(575, 228);
            dataGridView1.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(12, 351);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(575, 37);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.BackColor = SystemColors.ControlLightLight;
            QuestionLabel.Location = new Point(299, 81);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(0, 20);
            QuestionLabel.TabIndex = 2;
            // 
            // AnswerColumn
            // 
            AnswerColumn.HeaderText = "Answer";
            AnswerColumn.Name = "AnswerColumn";
            AnswerColumn.ReadOnly = true;
            AnswerColumn.Width = 529;
            // 
            // BaseQuestionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(QuestionLabel);
            Controls.Add(CloseButton);
            Controls.Add(dataGridView1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BaseQuestionForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button CloseButton;
        private Label QuestionLabel;
        private DataGridViewTextBoxColumn AnswerColumn;
    }
}