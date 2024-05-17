namespace UniversityEnvironment.View.Forms
{
    partial class BaseCourseForm
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
            CheckColumn = new DataGridViewCheckBoxColumn();
            TestColumn = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
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
            TestsTable.BackgroundColor = SystemColors.Control;
            TestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TestsTable.Columns.AddRange(new DataGridViewColumn[] { CheckColumn, TestColumn, Description });
            TestsTable.Location = new Point(12, 70);
            TestsTable.Name = "TestsTable";
            TestsTable.Size = new Size(377, 318);
            TestsTable.TabIndex = 2;
            TestsTable.CellContentClick += TestsTable_CellContentClick;
            // 
            // CheckColumn
            // 
            CheckColumn.HeaderText = "";
            CheckColumn.Name = "CheckColumn";
            CheckColumn.ReadOnly = true;
            CheckColumn.Width = 20;
            // 
            // TestColumn
            // 
            TestColumn.HeaderText = "Test";
            TestColumn.Name = "TestColumn";
            TestColumn.Width = 103;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 210;
            // 
            // BaseCourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(TestsTable);
            Controls.Add(JournalButton);
            Controls.Add(CloseButton);
            Controls.Add(TeacherTable);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "BaseCourseForm";
            ((System.ComponentModel.ISupportInitialize)TeacherTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)TestsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TeacherTable;
        private Button CloseButton;
        private Button JournalButton;
        private DataGridViewTextBoxColumn UserName;
        private DataGridView TestsTable;
        private DataGridViewCheckBoxColumn CheckColumn;
        private DataGridViewTextBoxColumn TestColumn;
        private DataGridViewTextBoxColumn Description;
    }
}