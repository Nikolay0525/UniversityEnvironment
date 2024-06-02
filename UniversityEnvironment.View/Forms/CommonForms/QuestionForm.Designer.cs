namespace UniversityEnvironment.View.Forms.CommonForms
{
    partial class QuestionForm
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
            CheckColumn = new DataGridViewCheckBoxColumn();
            AnswerColumn = new DataGridViewTextBoxColumn();
            CloseButton = new Button();
            QuestionLabel = new Label();
            CreateAnswerButton = new Button();
            DeleteAnswerButton = new Button();
            SendAnswersButton = new Button();
            StudentAnswerTable = new DataGridView();
            StudentNameColumn = new DataGridViewTextBoxColumn();
            GuideLineAnswer = new Label();
            ((System.ComponentModel.ISupportInitialize)AnswerTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentAnswerTable).BeginInit();
            SuspendLayout();
            // 
            // AnswerTable
            // 
            AnswerTable.AllowUserToAddRows = false;
            AnswerTable.AllowUserToDeleteRows = false;
            AnswerTable.BackgroundColor = SystemColors.Control;
            AnswerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnswerTable.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CheckColumn, AnswerColumn });
            AnswerTable.Location = new Point(11, 114);
            AnswerTable.Margin = new Padding(4);
            AnswerTable.Name = "AnswerTable";
            AnswerTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AnswerTable.Size = new Size(280, 233);
            AnswerTable.TabIndex = 0;
            AnswerTable.CellContentClick += AnswerTable_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Resizable = DataGridViewTriState.False;
            IdColumn.Visible = false;
            IdColumn.Width = 21;
            // 
            // CheckColumn
            // 
            CheckColumn.HeaderText = "";
            CheckColumn.Name = "CheckColumn";
            CheckColumn.Resizable = DataGridViewTriState.True;
            CheckColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            CheckColumn.Width = 19;
            // 
            // AnswerColumn
            // 
            AnswerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AnswerColumn.HeaderText = "Answer";
            AnswerColumn.Name = "AnswerColumn";
            AnswerColumn.ReadOnly = true;
            AnswerColumn.Resizable = DataGridViewTriState.False;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(11, 354);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(142, 37);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // QuestionLabel
            // 
            QuestionLabel.BackColor = SystemColors.ControlLightLight;
            QuestionLabel.Location = new Point(11, 90);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(280, 20);
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
            DeleteAnswerButton.Click += DeleteAnswerButton_Click;
            // 
            // SendAnswersButton
            // 
            SendAnswersButton.BackColor = SystemColors.ControlLightLight;
            SendAnswersButton.FlatStyle = FlatStyle.Flat;
            SendAnswersButton.Location = new Point(159, 354);
            SendAnswersButton.Name = "SendAnswersButton";
            SendAnswersButton.Size = new Size(132, 37);
            SendAnswersButton.TabIndex = 1;
            SendAnswersButton.Text = "Answer";
            SendAnswersButton.UseVisualStyleBackColor = false;
            SendAnswersButton.Click += SendAnswersButton_Click;
            // 
            // StudentAnswerTable
            // 
            StudentAnswerTable.AllowUserToAddRows = false;
            StudentAnswerTable.AllowUserToDeleteRows = false;
            StudentAnswerTable.BackgroundColor = SystemColors.Control;
            StudentAnswerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentAnswerTable.Columns.AddRange(new DataGridViewColumn[] { StudentNameColumn });
            StudentAnswerTable.Location = new Point(296, 114);
            StudentAnswerTable.Name = "StudentAnswerTable";
            StudentAnswerTable.ReadOnly = true;
            StudentAnswerTable.Size = new Size(200, 322);
            StudentAnswerTable.TabIndex = 6;
            // 
            // StudentNameColumn
            // 
            StudentNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentNameColumn.HeaderText = "Student";
            StudentNameColumn.Name = "StudentNameColumn";
            StudentNameColumn.ReadOnly = true;
            // 
            // GuideLineAnswer
            // 
            GuideLineAnswer.BackColor = SystemColors.ControlLightLight;
            GuideLineAnswer.ForeColor = Color.Black;
            GuideLineAnswer.Location = new Point(296, 64);
            GuideLineAnswer.Name = "GuideLineAnswer";
            GuideLineAnswer.Size = new Size(200, 46);
            GuideLineAnswer.TabIndex = 2;
            GuideLineAnswer.Text = "Choose any answer, to see student answers";
            GuideLineAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 435);
            Controls.Add(StudentAnswerTable);
            Controls.Add(DeleteAnswerButton);
            Controls.Add(CreateAnswerButton);
            Controls.Add(GuideLineAnswer);
            Controls.Add(QuestionLabel);
            Controls.Add(SendAnswersButton);
            Controls.Add(CloseButton);
            Controls.Add(AnswerTable);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "QuestionForm";
            Sizable = false;
            ((System.ComponentModel.ISupportInitialize)AnswerTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentAnswerTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AnswerTable;
        private Button CloseButton;
        private Label QuestionLabel;
        private Button CreateAnswerButton;
        private Button DeleteAnswerButton;
        private Button SendAnswersButton;
        private DataGridView StudentAnswerTable;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewCheckBoxColumn CheckColumn;
        private DataGridViewTextBoxColumn AnswerColumn;
        private DataGridViewTextBoxColumn StudentNameColumn;
        private Label GuideLineAnswer;
    }
}