namespace UniversityEnvironment.View.Forms
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
            AnswerTable = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            RowCheck = new DataGridViewCheckBoxColumn();
            AnswerColumn = new DataGridViewTextBoxColumn();
            CloseButton = new Button();
            QuestionLabel = new Label();
            CreateAnswerButton = new Button();
            DeleteAnswerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AnswerTable).BeginInit();
            SuspendLayout();
            // 
            // AnswerTable
            // 
            AnswerTable.AllowUserToAddRows = false;
            AnswerTable.AllowUserToDeleteRows = false;
            AnswerTable.BackgroundColor = SystemColors.Control;
            AnswerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnswerTable.Columns.AddRange(new DataGridViewColumn[] { IdColumn, RowCheck, AnswerColumn });
            AnswerTable.Location = new Point(11, 114);
            AnswerTable.Margin = new Padding(4);
            AnswerTable.Name = "AnswerTable";
            AnswerTable.Size = new Size(280, 233);
            AnswerTable.TabIndex = 0;
            AnswerTable.CellContentClick += AnswerTable_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.Name = "IdColumn";
            IdColumn.Visible = false;
            IdColumn.Width = 21;
            // 
            // RowCheck
            // 
            RowCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowCheck.HeaderText = "";
            RowCheck.Name = "RowCheck";
            RowCheck.Resizable = DataGridViewTriState.True;
            RowCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            RowCheck.Width = 19;
            // 
            // AnswerColumn
            // 
            AnswerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AnswerColumn.HeaderText = "Answer";
            AnswerColumn.Name = "AnswerColumn";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(11, 354);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(280, 37);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.BackColor = SystemColors.ControlLightLight;
            QuestionLabel.Location = new Point(153, 84);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(0, 20);
            QuestionLabel.TabIndex = 2;
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateAnswerButton
            // 
            CreateAnswerButton.BackColor = SystemColors.ControlLightLight;
            CreateAnswerButton.FlatStyle = FlatStyle.Flat;
            CreateAnswerButton.Location = new Point(11, 397);
            CreateAnswerButton.Name = "CreateAnswerButton";
            CreateAnswerButton.Size = new Size(142, 35);
            CreateAnswerButton.TabIndex = 4;
            CreateAnswerButton.Text = "Create";
            CreateAnswerButton.UseVisualStyleBackColor = false;
            CreateAnswerButton.Click += CreateAnswerButton_Click;
            // 
            // DeleteAnswerButton
            // 
            DeleteAnswerButton.BackColor = SystemColors.ControlLightLight;
            DeleteAnswerButton.FlatStyle = FlatStyle.Flat;
            DeleteAnswerButton.Location = new Point(159, 397);
            DeleteAnswerButton.Name = "DeleteAnswerButton";
            DeleteAnswerButton.Size = new Size(132, 35);
            DeleteAnswerButton.TabIndex = 5;
            DeleteAnswerButton.Text = "Delete";
            DeleteAnswerButton.UseVisualStyleBackColor = false;
            // 
            // BaseQuestionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 440);
            Controls.Add(DeleteAnswerButton);
            Controls.Add(CreateAnswerButton);
            Controls.Add(QuestionLabel);
            Controls.Add(CloseButton);
            Controls.Add(AnswerTable);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "BaseQuestionForm";
            ((System.ComponentModel.ISupportInitialize)AnswerTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AnswerTable;
        private Button CloseButton;
        private Label QuestionLabel;
        private Button CreateAnswerButton;
        private Button DeleteAnswerButton;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewCheckBoxColumn RowCheck;
        private DataGridViewTextBoxColumn AnswerColumn;
    }
}