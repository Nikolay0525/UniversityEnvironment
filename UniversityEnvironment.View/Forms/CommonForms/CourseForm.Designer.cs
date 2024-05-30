namespace UniversityEnvironment.View.Forms.CommonForms
{
    partial class CourseForm
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
            TeacherTable = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            CloseButton = new Button();
            JournalButton = new Button();
            TestsTable = new DataGridView();
            DeleteTestButton = new Button();
            CreateTestButton = new Button();
            IdColumn = new DataGridViewTextBoxColumn();
            CheckColumn = new DataGridViewCheckBoxColumn();
            TestName = new DataGridViewTextBoxColumn();
            TestDescription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TeacherTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TestsTable).BeginInit();
            SuspendLayout();
            // 
            // TeacherTable
            // 
            TeacherTable.AllowUserToAddRows = false;
            TeacherTable.AllowUserToDeleteRows = false;
            TeacherTable.BackgroundColor = SystemColors.Control;
            TeacherTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherTable.Columns.AddRange(new DataGridViewColumn[] { UserName });
            TeacherTable.Location = new Point(395, 70);
            TeacherTable.Name = "TeacherTable";
            TeacherTable.ReadOnly = true;
            TeacherTable.Size = new Size(193, 236);
            TeacherTable.TabIndex = 0;
            TeacherTable.CellContentClick += TeacherTable_CellContentClick;
            // 
            // UserName
            // 
            UserName.HeaderText = "Course teachers";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 150;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(395, 353);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(193, 35);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // JournalButton
            // 
            JournalButton.BackColor = SystemColors.ControlLightLight;
            JournalButton.FlatStyle = FlatStyle.Flat;
            JournalButton.Location = new Point(395, 312);
            JournalButton.Name = "JournalButton";
            JournalButton.Size = new Size(193, 35);
            JournalButton.TabIndex = 1;
            JournalButton.Text = "Journal";
            JournalButton.UseVisualStyleBackColor = false;
            JournalButton.Click += JournalButton_Click;
            // 
            // TestsTable
            // 
            TestsTable.AllowUserToAddRows = false;
            TestsTable.AllowUserToDeleteRows = false;
            TestsTable.BackgroundColor = SystemColors.Control;
            TestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TestsTable.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CheckColumn, TestName, TestDescription });
            TestsTable.Location = new Point(12, 70);
            TestsTable.Name = "TestsTable";
            TestsTable.Size = new Size(377, 318);
            TestsTable.TabIndex = 2;
            TestsTable.CellContentClick += TestsTable_CellContentClick;
            // 
            // DeleteTestButton
            // 
            DeleteTestButton.BackColor = SystemColors.ControlLightLight;
            DeleteTestButton.FlatStyle = FlatStyle.Flat;
            DeleteTestButton.Location = new Point(316, 394);
            DeleteTestButton.Name = "DeleteTestButton";
            DeleteTestButton.Size = new Size(272, 35);
            DeleteTestButton.TabIndex = 4;
            DeleteTestButton.Text = "Delete test";
            DeleteTestButton.UseVisualStyleBackColor = false;
            DeleteTestButton.Click += DeleteTestButton_Click;
            // 
            // CreateTestButton
            // 
            CreateTestButton.BackColor = SystemColors.ControlLightLight;
            CreateTestButton.FlatStyle = FlatStyle.Flat;
            CreateTestButton.Location = new Point(11, 394);
            CreateTestButton.Name = "CreateTestButton";
            CreateTestButton.Size = new Size(299, 35);
            CreateTestButton.TabIndex = 5;
            CreateTestButton.Text = "Create test";
            CreateTestButton.UseVisualStyleBackColor = false;
            CreateTestButton.Click += CreateButton_Click;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Resizable = DataGridViewTriState.False;
            IdColumn.Visible = false;
            // 
            // CheckColumn
            // 
            CheckColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CheckColumn.HeaderText = "";
            CheckColumn.MinimumWidth = 21;
            CheckColumn.Name = "CheckColumn";
            CheckColumn.Resizable = DataGridViewTriState.False;
            CheckColumn.Width = 21;
            // 
            // TestName
            // 
            TestName.HeaderText = "Test";
            TestName.Name = "TestName";
            TestName.ReadOnly = true;
            TestName.Resizable = DataGridViewTriState.False;
            // 
            // TestDescription
            // 
            TestDescription.HeaderText = "Description";
            TestDescription.Name = "TestDescription";
            TestDescription.ReadOnly = true;
            TestDescription.Resizable = DataGridViewTriState.False;
            TestDescription.Width = 213;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 435);
            Controls.Add(DeleteTestButton);
            Controls.Add(CreateTestButton);
            Controls.Add(TestsTable);
            Controls.Add(JournalButton);
            Controls.Add(CloseButton);
            Controls.Add(TeacherTable);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "CourseForm";
            Sizable = false;
            ((System.ComponentModel.ISupportInitialize)TeacherTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)TestsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TeacherTable;
        private Button CloseButton;
        private Button JournalButton;
        private DataGridView TestsTable;
        private Button DeleteTestButton;
        private Button CreateTestButton;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewCheckBoxColumn CheckColumn;
        private DataGridViewTextBoxColumn TestName;
        private DataGridViewTextBoxColumn TestDescription;
    }
}