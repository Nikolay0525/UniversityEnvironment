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
            QuestionTable = new DataGridView();
            SendAnswersButton = new Button();
            CreateQuestionButton = new Button();
            DeleteQuestionButton = new Button();
            IdColumn = new DataGridViewTextBoxColumn();
            RowCheck = new DataGridViewCheckBoxColumn();
            QuestionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)QuestionTable).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(12, 327);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(129, 35);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // QuestionTable
            // 
            QuestionTable.AllowUserToAddRows = false;
            QuestionTable.AllowUserToDeleteRows = false;
            QuestionTable.BackgroundColor = SystemColors.Control;
            QuestionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionTable.Columns.AddRange(new DataGridViewColumn[] { IdColumn, RowCheck, QuestionColumn });
            QuestionTable.Location = new Point(12, 75);
            QuestionTable.Name = "QuestionTable";
            QuestionTable.ReadOnly = true;
            QuestionTable.Size = new Size(280, 246);
            QuestionTable.TabIndex = 1;
            QuestionTable.CellContentClick += QuestionTable_CellContentClick;
            // 
            // SendAnswersButton
            // 
            SendAnswersButton.BackColor = SystemColors.ControlLightLight;
            SendAnswersButton.FlatStyle = FlatStyle.Flat;
            SendAnswersButton.Location = new Point(147, 327);
            SendAnswersButton.Name = "SendAnswersButton";
            SendAnswersButton.Size = new Size(145, 35);
            SendAnswersButton.TabIndex = 2;
            SendAnswersButton.Text = "Send answers";
            SendAnswersButton.UseVisualStyleBackColor = false;
            // 
            // CreateQuestionButton
            // 
            CreateQuestionButton.BackColor = SystemColors.ControlLightLight;
            CreateQuestionButton.FlatStyle = FlatStyle.Flat;
            CreateQuestionButton.Location = new Point(12, 369);
            CreateQuestionButton.Name = "CreateQuestionButton";
            CreateQuestionButton.Size = new Size(129, 35);
            CreateQuestionButton.TabIndex = 3;
            CreateQuestionButton.Text = "Create";
            CreateQuestionButton.UseVisualStyleBackColor = false;
            CreateQuestionButton.Click += CreateQuestionButton_Click;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.BackColor = SystemColors.ControlLightLight;
            DeleteQuestionButton.FlatStyle = FlatStyle.Flat;
            DeleteQuestionButton.Location = new Point(147, 368);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(145, 35);
            DeleteQuestionButton.TabIndex = 3;
            DeleteQuestionButton.Text = "Delete";
            DeleteQuestionButton.UseVisualStyleBackColor = false;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            IdColumn.Width = 30;
            // 
            // RowCheck
            // 
            RowCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowCheck.HeaderText = "";
            RowCheck.MinimumWidth = 21;
            RowCheck.Name = "RowCheck";
            RowCheck.ReadOnly = true;
            RowCheck.Width = 21;
            // 
            // QuestionColumn
            // 
            QuestionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuestionColumn.HeaderText = "Question";
            QuestionColumn.Name = "QuestionColumn";
            QuestionColumn.ReadOnly = true;
            // 
            // BaseTestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 416);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(CreateQuestionButton);
            Controls.Add(SendAnswersButton);
            Controls.Add(QuestionTable);
            Controls.Add(CloseButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "BaseTestForm";
            Text = "BaseTestForm";
            ((System.ComponentModel.ISupportInitialize)QuestionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private DataGridView QuestionTable;
        private Button SendAnswersButton;
        private Button CreateQuestionButton;
        private Button DeleteQuestionButton;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewCheckBoxColumn RowCheck;
        private DataGridViewTextBoxColumn QuestionColumn;
    }
}