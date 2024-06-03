namespace UniversityEnvironment.View.Forms.AdminForms.CreatorForms
{
    partial class QuestionCreatorForm
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
            label2 = new Label();
            QuestionTextBox = new TextBox();
            ManyAnswersButton = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(113, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Question";
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Location = new Point(12, 124);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(280, 27);
            QuestionTextBox.TabIndex = 4;
            // 
            // ManyAnswersButton
            // 
            ManyAnswersButton.AutoSize = true;
            ManyAnswersButton.BackColor = SystemColors.ControlLightLight;
            ManyAnswersButton.Location = new Point(79, 182);
            ManyAnswersButton.Name = "ManyAnswersButton";
            ManyAnswersButton.Size = new Size(148, 24);
            ManyAnswersButton.TabIndex = 6;
            ManyAnswersButton.Text = "Multiple answers";
            ManyAnswersButton.UseVisualStyleBackColor = false;
            // 
            // QuestionCreatorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(ManyAnswersButton);
            Controls.Add(label2);
            Controls.Add(QuestionTextBox);
            Name = "QuestionCreatorForm";
            Text = "Question creator";
            Controls.SetChildIndex(QuestionTextBox, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(ManyAnswersButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox QuestionTextBox;
        private CheckBox ManyAnswersButton;
    }
}