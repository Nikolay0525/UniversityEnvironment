namespace UniversityEnvironment.View.Forms
{
    partial class AdminControlForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            TeacherCheck = new RadioButton();
            AdminCheck = new RadioButton();
            FilterTextBox = new TextBox();
            label3 = new Label();
            StudentsButton = new Button();
            TeachersButton = new Button();
            AdminsButton = new Button();
            ApplyFilterButton = new Button();
            NextButton = new Button();
            PreviousButton = new Button();
            CloseButton = new Button();
            ActualCoursesTable = new DataGridView();
            UsernameColumn = new DataGridViewTextBoxColumn();
            Initials = new DataGridViewTextBoxColumn();
            RoleColumn = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            label4 = new Label();
            UnsignButton = new Button();
            CreateButton = new Button();
            AvailableCoursesTable = new DataGridView();
            RowCheck = new DataGridViewCheckBoxColumn();
            CourseColumn = new DataGridViewTextBoxColumn();
            FacultyColumn = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            RequestsTable = new DataGridView();
            FromUsernameColumn = new DataGridViewTextBoxColumn();
            InitialsColumn = new DataGridViewTextBoxColumn();
            MessageColumn = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestsTable).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.ItemSize = new Size(198, 25);
            tabControl1.Location = new Point(0, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 337);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(FilterTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(StudentsButton);
            tabPage1.Controls.Add(TeachersButton);
            tabPage1.Controls.Add(AdminsButton);
            tabPage1.Controls.Add(ApplyFilterButton);
            tabPage1.Controls.Add(NextButton);
            tabPage1.Controls.Add(PreviousButton);
            tabPage1.Controls.Add(CloseButton);
            tabPage1.Controls.Add(ActualCoursesTable);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(592, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(TeacherCheck);
            groupBox1.Controls.Add(AdminCheck);
            groupBox1.Location = new Point(8, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 60);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // TeacherCheck
            // 
            TeacherCheck.Location = new Point(0, 36);
            TeacherCheck.Name = "TeacherCheck";
            TeacherCheck.Size = new Size(120, 24);
            TeacherCheck.TabIndex = 0;
            TeacherCheck.TabStop = true;
            TeacherCheck.Text = "By initials";
            TeacherCheck.UseVisualStyleBackColor = true;
            // 
            // AdminCheck
            // 
            AdminCheck.Location = new Point(0, 7);
            AdminCheck.Name = "AdminCheck";
            AdminCheck.Size = new Size(120, 28);
            AdminCheck.TabIndex = 0;
            AdminCheck.TabStop = true;
            AdminCheck.Text = "By username";
            AdminCheck.UseVisualStyleBackColor = true;
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(8, 92);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(146, 27);
            FilterTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 3);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Users";
            // 
            // StudentsButton
            // 
            StudentsButton.FlatStyle = FlatStyle.Flat;
            StudentsButton.Location = new Point(448, 263);
            StudentsButton.Name = "StudentsButton";
            StudentsButton.Size = new Size(138, 35);
            StudentsButton.TabIndex = 4;
            StudentsButton.Text = "Students";
            StudentsButton.UseVisualStyleBackColor = true;
            // 
            // TeachersButton
            // 
            TeachersButton.FlatStyle = FlatStyle.Flat;
            TeachersButton.Location = new Point(304, 263);
            TeachersButton.Name = "TeachersButton";
            TeachersButton.Size = new Size(138, 35);
            TeachersButton.TabIndex = 4;
            TeachersButton.Text = "Teachers";
            TeachersButton.UseVisualStyleBackColor = true;
            // 
            // AdminsButton
            // 
            AdminsButton.FlatStyle = FlatStyle.Flat;
            AdminsButton.Location = new Point(160, 263);
            AdminsButton.Name = "AdminsButton";
            AdminsButton.Size = new Size(138, 35);
            AdminsButton.TabIndex = 4;
            AdminsButton.Text = "Admins";
            AdminsButton.UseVisualStyleBackColor = true;
            // 
            // ApplyFilterButton
            // 
            ApplyFilterButton.FlatStyle = FlatStyle.Flat;
            ApplyFilterButton.Location = new Point(8, 125);
            ApplyFilterButton.Name = "ApplyFilterButton";
            ApplyFilterButton.Size = new Size(146, 40);
            ApplyFilterButton.TabIndex = 4;
            ApplyFilterButton.Text = "Apply filter";
            ApplyFilterButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Location = new Point(8, 171);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(146, 40);
            NextButton.TabIndex = 4;
            NextButton.Text = "Next page =>";
            NextButton.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            PreviousButton.FlatStyle = FlatStyle.Flat;
            PreviousButton.Location = new Point(8, 217);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(146, 40);
            PreviousButton.TabIndex = 4;
            PreviousButton.Text = "<= Previous page";
            PreviousButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(8, 263);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(146, 35);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Sign out";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // ActualCoursesTable
            // 
            ActualCoursesTable.AllowUserToAddRows = false;
            ActualCoursesTable.AllowUserToDeleteRows = false;
            ActualCoursesTable.BackgroundColor = SystemColors.Control;
            ActualCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActualCoursesTable.Columns.AddRange(new DataGridViewColumn[] { UsernameColumn, Initials, RoleColumn });
            ActualCoursesTable.Location = new Point(160, 26);
            ActualCoursesTable.Name = "ActualCoursesTable";
            ActualCoursesTable.ReadOnly = true;
            ActualCoursesTable.Size = new Size(425, 231);
            ActualCoursesTable.TabIndex = 2;
            // 
            // UsernameColumn
            // 
            UsernameColumn.HeaderText = "Username";
            UsernameColumn.Name = "UsernameColumn";
            UsernameColumn.ReadOnly = true;
            UsernameColumn.Width = 130;
            // 
            // Initials
            // 
            Initials.HeaderText = "Initials";
            Initials.Name = "Initials";
            Initials.ReadOnly = true;
            Initials.Width = 180;
            // 
            // RoleColumn
            // 
            RoleColumn.HeaderText = "Role";
            RoleColumn.Name = "RoleColumn";
            RoleColumn.ReadOnly = true;
            RoleColumn.Width = 72;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(UnsignButton);
            tabPage2.Controls.Add(CreateButton);
            tabPage2.Controls.Add(AvailableCoursesTable);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(592, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Courses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 5);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 10;
            label4.Text = "Available courses";
            // 
            // UnsignButton
            // 
            UnsignButton.BackColor = SystemColors.ControlLightLight;
            UnsignButton.FlatStyle = FlatStyle.Flat;
            UnsignButton.Location = new Point(8, 190);
            UnsignButton.Name = "UnsignButton";
            UnsignButton.Size = new Size(158, 106);
            UnsignButton.TabIndex = 8;
            UnsignButton.Text = "Remove selected course";
            UnsignButton.UseVisualStyleBackColor = false;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = SystemColors.ControlLightLight;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Location = new Point(8, 28);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(158, 156);
            CreateButton.TabIndex = 9;
            CreateButton.Text = "Create new course";
            CreateButton.UseVisualStyleBackColor = false;
            // 
            // AvailableCoursesTable
            // 
            AvailableCoursesTable.AllowUserToAddRows = false;
            AvailableCoursesTable.AllowUserToDeleteRows = false;
            AvailableCoursesTable.BackgroundColor = SystemColors.Control;
            AvailableCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AvailableCoursesTable.Columns.AddRange(new DataGridViewColumn[] { RowCheck, CourseColumn, FacultyColumn });
            AvailableCoursesTable.Location = new Point(172, 28);
            AvailableCoursesTable.Name = "AvailableCoursesTable";
            AvailableCoursesTable.Size = new Size(414, 268);
            AvailableCoursesTable.TabIndex = 7;
            // 
            // RowCheck
            // 
            RowCheck.HeaderText = "";
            RowCheck.Name = "RowCheck";
            RowCheck.Resizable = DataGridViewTriState.True;
            RowCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            RowCheck.Width = 20;
            // 
            // CourseColumn
            // 
            CourseColumn.HeaderText = "Course";
            CourseColumn.Name = "CourseColumn";
            CourseColumn.Width = 150;
            // 
            // FacultyColumn
            // 
            FacultyColumn.HeaderText = "Faculty";
            FacultyColumn.Name = "FacultyColumn";
            FacultyColumn.Width = 200;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLightLight;
            tabPage3.Controls.Add(RequestsTable);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(592, 304);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Requests";
            // 
            // RequestsTable
            // 
            RequestsTable.AllowUserToAddRows = false;
            RequestsTable.AllowUserToDeleteRows = false;
            RequestsTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RequestsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RequestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestsTable.Columns.AddRange(new DataGridViewColumn[] { FromUsernameColumn, InitialsColumn, MessageColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            RequestsTable.DefaultCellStyle = dataGridViewCellStyle2;
            RequestsTable.Location = new Point(0, 0);
            RequestsTable.Name = "RequestsTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RequestsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RequestsTable.Size = new Size(592, 304);
            RequestsTable.TabIndex = 4;
            RequestsTable.CellContentClick += RequestsTable_CellContentClick;
            // 
            // FromUsernameColumn
            // 
            FromUsernameColumn.HeaderText = "Username";
            FromUsernameColumn.Name = "FromUsernameColumn";
            FromUsernameColumn.Width = 160;
            // 
            // InitialsColumn
            // 
            InitialsColumn.HeaderText = "Initials";
            InitialsColumn.Name = "InitialsColumn";
            InitialsColumn.Width = 240;
            // 
            // MessageColumn
            // 
            MessageColumn.HeaderText = "Role";
            MessageColumn.Name = "MessageColumn";
            MessageColumn.Width = 149;
            // 
            // AdminControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(tabControl1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AdminControlForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RequestsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Button CloseButton;
        private DataGridView ActualCoursesTable;
        private TabPage tabPage2;
        private Button StudentsButton;
        private Button TeachersButton;
        private Button AdminsButton;
        private Label label4;
        private Button UnsignButton;
        private Button CreateButton;
        private DataGridView AvailableCoursesTable;
        private DataGridViewCheckBoxColumn RowCheck;
        private DataGridViewTextBoxColumn CourseColumn;
        private DataGridViewTextBoxColumn FacultyColumn;
        private TextBox FilterTextBox;
        private Button NextButton;
        private Button PreviousButton;
        private Button ApplyFilterButton;
        private GroupBox groupBox1;
        private RadioButton TeacherCheck;
        private RadioButton AdminCheck;
        private TabPage tabPage3;
        private DataGridView RequestsTable;
        private DataGridViewTextBoxColumn FromUsernameColumn;
        private DataGridViewTextBoxColumn InitialsColumn;
        private DataGridViewTextBoxColumn MessageColumn;
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn Initials;
        private DataGridViewTextBoxColumn RoleColumn;
    }
}