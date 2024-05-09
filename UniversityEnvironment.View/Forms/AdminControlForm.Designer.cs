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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            TeacherCheck = new RadioButton();
            AdminCheck = new RadioButton();
            FilterTextBox = new TextBox();
            UsersMessageBox = new Label();
            StudentUsers = new Button();
            TeacherUsers = new Button();
            AdminUsers = new Button();
            ApplyFilterButton = new Button();
            NextButton = new Button();
            PreviousButton = new Button();
            CloseButton = new Button();
            ActualCoursesTable = new DataGridView();
            UsernameColumn = new DataGridViewTextBoxColumn();
            Initials = new DataGridViewTextBoxColumn();
            RoleColumn = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            RequestMessageBox = new Label();
            StudentsRequests = new Button();
            TeachersRequests = new Button();
            PreviousPageRequests = new Button();
            NextPageRequests = new Button();
            AdminsRequests = new Button();
            RequestsTable = new DataGridView();
            FromUsernameColumn = new DataGridViewTextBoxColumn();
            MessageColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            NextPageCourses = new Button();
            PreviousPageCourses = new Button();
            label4 = new Label();
            UnsignButton = new Button();
            CreateButton = new Button();
            AvailableCoursesTable = new DataGridView();
            RowCheck = new DataGridViewCheckBoxColumn();
            CourseColumn = new DataGridViewTextBoxColumn();
            FacultyColumn = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestsTable).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
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
            tabPage1.Controls.Add(UsersMessageBox);
            tabPage1.Controls.Add(StudentUsers);
            tabPage1.Controls.Add(TeacherUsers);
            tabPage1.Controls.Add(AdminUsers);
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
            tabPage1.Text = "Users";
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
            // UsersMessageBox
            // 
            UsersMessageBox.AutoSize = true;
            UsersMessageBox.ForeColor = Color.IndianRed;
            UsersMessageBox.Location = new Point(330, 5);
            UsersMessageBox.Name = "UsersMessageBox";
            UsersMessageBox.Size = new Size(92, 20);
            UsersMessageBox.TabIndex = 5;
            UsersMessageBox.Text = "Choose role";
            // 
            // StudentUsers
            // 
            StudentUsers.FlatStyle = FlatStyle.Flat;
            StudentUsers.Location = new Point(448, 263);
            StudentUsers.Name = "StudentUsers";
            StudentUsers.Size = new Size(138, 35);
            StudentUsers.TabIndex = 4;
            StudentUsers.Text = "Students";
            StudentUsers.UseVisualStyleBackColor = true;
            StudentUsers.Click += StudentUsers_Click;
            // 
            // TeacherUsers
            // 
            TeacherUsers.FlatStyle = FlatStyle.Flat;
            TeacherUsers.Location = new Point(304, 263);
            TeacherUsers.Name = "TeacherUsers";
            TeacherUsers.Size = new Size(138, 35);
            TeacherUsers.TabIndex = 4;
            TeacherUsers.Text = "Teachers";
            TeacherUsers.UseVisualStyleBackColor = true;
            TeacherUsers.Click += TeacherUsers_Click;
            // 
            // AdminUsers
            // 
            AdminUsers.FlatStyle = FlatStyle.Flat;
            AdminUsers.Location = new Point(160, 263);
            AdminUsers.Name = "AdminUsers";
            AdminUsers.Size = new Size(138, 35);
            AdminUsers.TabIndex = 4;
            AdminUsers.Text = "Admins";
            AdminUsers.UseVisualStyleBackColor = true;
            AdminUsers.Click += AdminUsers_Click;
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
            CloseButton.Click += CloseButton_Click;
            // 
            // ActualCoursesTable
            // 
            ActualCoursesTable.AllowUserToAddRows = false;
            ActualCoursesTable.AllowUserToDeleteRows = false;
            ActualCoursesTable.BackgroundColor = SystemColors.Control;
            ActualCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActualCoursesTable.Columns.AddRange(new DataGridViewColumn[] { UsernameColumn, Initials, RoleColumn });
            ActualCoursesTable.Location = new Point(160, 30);
            ActualCoursesTable.Name = "ActualCoursesTable";
            ActualCoursesTable.ReadOnly = true;
            ActualCoursesTable.Size = new Size(425, 227);
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
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLightLight;
            tabPage3.Controls.Add(RequestMessageBox);
            tabPage3.Controls.Add(StudentsRequests);
            tabPage3.Controls.Add(TeachersRequests);
            tabPage3.Controls.Add(PreviousPageRequests);
            tabPage3.Controls.Add(NextPageRequests);
            tabPage3.Controls.Add(AdminsRequests);
            tabPage3.Controls.Add(RequestsTable);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(592, 304);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Requests";
            // 
            // RequestMessageBox
            // 
            RequestMessageBox.AutoSize = true;
            RequestMessageBox.ForeColor = Color.IndianRed;
            RequestMessageBox.Location = new Point(258, 3);
            RequestMessageBox.Name = "RequestMessageBox";
            RequestMessageBox.Size = new Size(92, 20);
            RequestMessageBox.TabIndex = 8;
            RequestMessageBox.Text = "Choose role";
            // 
            // StudentsRequests
            // 
            StudentsRequests.FlatStyle = FlatStyle.Flat;
            StudentsRequests.Location = new Point(398, 266);
            StudentsRequests.Name = "StudentsRequests";
            StudentsRequests.Size = new Size(190, 35);
            StudentsRequests.TabIndex = 5;
            StudentsRequests.Text = "Students";
            StudentsRequests.UseVisualStyleBackColor = true;
            StudentsRequests.Click += StudentsRequests_Click;
            // 
            // TeachersRequests
            // 
            TeachersRequests.FlatStyle = FlatStyle.Flat;
            TeachersRequests.Location = new Point(202, 266);
            TeachersRequests.Name = "TeachersRequests";
            TeachersRequests.Size = new Size(190, 35);
            TeachersRequests.TabIndex = 6;
            TeachersRequests.Text = "Teachers";
            TeachersRequests.UseVisualStyleBackColor = true;
            TeachersRequests.Click += TeachersRequests_Click;
            // 
            // PreviousPageRequests
            // 
            PreviousPageRequests.FlatStyle = FlatStyle.Flat;
            PreviousPageRequests.Location = new Point(8, 29);
            PreviousPageRequests.Name = "PreviousPageRequests";
            PreviousPageRequests.Size = new Size(60, 231);
            PreviousPageRequests.TabIndex = 7;
            PreviousPageRequests.Text = "<=";
            PreviousPageRequests.UseVisualStyleBackColor = true;
            PreviousPageRequests.Click += PreviousPageRequests_Click;
            // 
            // NextPageRequests
            // 
            NextPageRequests.FlatStyle = FlatStyle.Flat;
            NextPageRequests.Location = new Point(524, 29);
            NextPageRequests.Name = "NextPageRequests";
            NextPageRequests.Size = new Size(60, 231);
            NextPageRequests.TabIndex = 7;
            NextPageRequests.Text = "=>";
            NextPageRequests.UseVisualStyleBackColor = true;
            NextPageRequests.Click += NextPageRequests_Click;
            // 
            // AdminsRequests
            // 
            AdminsRequests.FlatStyle = FlatStyle.Flat;
            AdminsRequests.Location = new Point(6, 266);
            AdminsRequests.Name = "AdminsRequests";
            AdminsRequests.Size = new Size(190, 35);
            AdminsRequests.TabIndex = 7;
            AdminsRequests.Text = "Admins";
            AdminsRequests.UseVisualStyleBackColor = true;
            AdminsRequests.Click += AdminsRequests_Click;
            // 
            // RequestsTable
            // 
            RequestsTable.AllowUserToAddRows = false;
            RequestsTable.AllowUserToDeleteRows = false;
            RequestsTable.BackgroundColor = SystemColors.Control;
            RequestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestsTable.Columns.AddRange(new DataGridViewColumn[] { FromUsernameColumn, MessageColumn, TypeColumn });
            RequestsTable.Location = new Point(73, 29);
            RequestsTable.Name = "RequestsTable";
            RequestsTable.Size = new Size(447, 231);
            RequestsTable.TabIndex = 4;
            RequestsTable.CellContentClick += RequestsTable_CellContentClick;
            // 
            // FromUsernameColumn
            // 
            FromUsernameColumn.HeaderText = "Username";
            FromUsernameColumn.Name = "FromUsernameColumn";
            FromUsernameColumn.Width = 180;
            // 
            // MessageColumn
            // 
            MessageColumn.HeaderText = "Role";
            MessageColumn.Name = "MessageColumn";
            MessageColumn.Width = 80;
            // 
            // TypeColumn
            // 
            TypeColumn.HeaderText = "Type of request";
            TypeColumn.Name = "TypeColumn";
            TypeColumn.Width = 142;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(NextPageCourses);
            tabPage2.Controls.Add(PreviousPageCourses);
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
            // NextPageCourses
            // 
            NextPageCourses.FlatStyle = FlatStyle.Flat;
            NextPageCourses.Location = new Point(8, 28);
            NextPageCourses.Name = "NextPageCourses";
            NextPageCourses.Size = new Size(158, 40);
            NextPageCourses.TabIndex = 11;
            NextPageCourses.Text = "Next page =>";
            NextPageCourses.UseVisualStyleBackColor = true;
            // 
            // PreviousPageCourses
            // 
            PreviousPageCourses.FlatStyle = FlatStyle.Flat;
            PreviousPageCourses.Location = new Point(8, 74);
            PreviousPageCourses.Name = "PreviousPageCourses";
            PreviousPageCourses.Size = new Size(158, 40);
            PreviousPageCourses.TabIndex = 12;
            PreviousPageCourses.Text = "<= Previous page";
            PreviousPageCourses.UseVisualStyleBackColor = true;
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
            UnsignButton.Location = new Point(8, 211);
            UnsignButton.Name = "UnsignButton";
            UnsignButton.Size = new Size(158, 85);
            UnsignButton.TabIndex = 8;
            UnsignButton.Text = "Remove selected course";
            UnsignButton.UseVisualStyleBackColor = false;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = SystemColors.ControlLightLight;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Location = new Point(8, 120);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(158, 85);
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RequestsTable).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Button CloseButton;
        private DataGridView ActualCoursesTable;
        private TabPage tabPage2;
        private Button StudentUsers;
        private Button TeacherUsers;
        private Button AdminUsers;
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
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn Initials;
        private DataGridViewTextBoxColumn RoleColumn;
        private Button StudentsRequests;
        private Button TeachersRequests;
        private Button AdminsRequests;
        private Button NextPageCourses;
        private Button PreviousPageCourses;
        private Label UsersMessageBox;
        private Label RequestMessageBox;
        private Button PreviousPageRequests;
        private Button NextPageRequests;
        private DataGridViewTextBoxColumn FromUsernameColumn;
        private DataGridViewTextBoxColumn MessageColumn;
        private DataGridViewTextBoxColumn TypeColumn;
    }
}