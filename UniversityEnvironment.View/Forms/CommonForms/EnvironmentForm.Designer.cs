namespace UniversityEnvironment.View.Forms.CommonForms
{
    partial class EnvironmentForm
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
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            CloseButton = new Button();
            PersonRole = new Label();
            PersonName = new Label();
            ActualCoursesTable = new DataGridView();
            CourseColumn = new DataGridViewTextBoxColumn();
            FacultyColumn = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            UnsignButton = new Button();
            SignButton = new Button();
            AvailableCoursesTable = new DataGridView();
            tabPage3 = new TabPage();
            MessageTable = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            InitialsColumn = new DataGridViewTextBoxColumn();
            FromCourseColumn = new DataGridViewTextBoxColumn();
            MessageColumn = new DataGridViewTextBoxColumn();
            IdCol = new DataGridViewTextBoxColumn();
            RowCheck = new DataGridViewCheckBoxColumn();
            AvailableCourseColumn = new DataGridViewTextBoxColumn();
            AvailableFacultyColumn = new DataGridViewTextBoxColumn();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessageTable).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.Dock = DockStyle.Bottom;
            TabControl.ItemSize = new Size(198, 25);
            TabControl.Location = new Point(0, 63);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(600, 337);
            TabControl.SizeMode = TabSizeMode.FillToRight;
            TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(CloseButton);
            tabPage1.Controls.Add(PersonRole);
            tabPage1.Controls.Add(PersonName);
            tabPage1.Controls.Add(ActualCoursesTable);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(592, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 3);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Your courses";
            // 
            // CloseButton
            // 
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(171, 261);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(413, 37);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Sign out";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // PersonRole
            // 
            PersonRole.BackColor = SystemColors.Control;
            PersonRole.Location = new Point(8, 272);
            PersonRole.Name = "PersonRole";
            PersonRole.Size = new Size(157, 26);
            PersonRole.TabIndex = 3;
            // 
            // PersonName
            // 
            PersonName.BackColor = SystemColors.Control;
            PersonName.Location = new Point(8, 208);
            PersonName.Name = "PersonName";
            PersonName.Size = new Size(157, 26);
            PersonName.TabIndex = 3;
            // 
            // ActualCoursesTable
            // 
            ActualCoursesTable.AllowUserToAddRows = false;
            ActualCoursesTable.AllowUserToDeleteRows = false;
            ActualCoursesTable.BackgroundColor = SystemColors.Control;
            ActualCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActualCoursesTable.Columns.AddRange(new DataGridViewColumn[] { CourseColumn, FacultyColumn });
            ActualCoursesTable.Location = new Point(171, 26);
            ActualCoursesTable.Name = "ActualCoursesTable";
            ActualCoursesTable.ReadOnly = true;
            ActualCoursesTable.RowHeadersWidth = 51;
            ActualCoursesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ActualCoursesTable.Size = new Size(414, 231);
            ActualCoursesTable.TabIndex = 2;
            ActualCoursesTable.CellContentClick += ActualCoursesTable_CellContentClick;
            // 
            // CourseColumn
            // 
            CourseColumn.HeaderText = "Course";
            CourseColumn.MinimumWidth = 6;
            CourseColumn.Name = "CourseColumn";
            CourseColumn.ReadOnly = true;
            CourseColumn.Resizable = DataGridViewTriState.False;
            CourseColumn.Width = 150;
            // 
            // FacultyColumn
            // 
            FacultyColumn.HeaderText = "Faculty";
            FacultyColumn.MinimumWidth = 6;
            FacultyColumn.Name = "FacultyColumn";
            FacultyColumn.ReadOnly = true;
            FacultyColumn.Resizable = DataGridViewTriState.False;
            FacultyColumn.Width = 220;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 246);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 182);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Full name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(8, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(UnsignButton);
            tabPage2.Controls.Add(SignButton);
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
            label4.TabIndex = 6;
            label4.Text = "Available courses";
            // 
            // UnsignButton
            // 
            UnsignButton.BackColor = SystemColors.ControlLightLight;
            UnsignButton.FlatStyle = FlatStyle.Flat;
            UnsignButton.Location = new Point(8, 175);
            UnsignButton.Name = "UnsignButton";
            UnsignButton.Size = new Size(153, 121);
            UnsignButton.TabIndex = 4;
            UnsignButton.Text = "Unsign from courses";
            UnsignButton.UseVisualStyleBackColor = false;
            UnsignButton.Click += UnsignButton_Click;
            // 
            // SignButton
            // 
            SignButton.BackColor = SystemColors.ControlLightLight;
            SignButton.FlatStyle = FlatStyle.Flat;
            SignButton.Location = new Point(8, 28);
            SignButton.Name = "SignButton";
            SignButton.Size = new Size(153, 141);
            SignButton.TabIndex = 4;
            SignButton.Text = "Sign on courses";
            SignButton.UseVisualStyleBackColor = false;
            SignButton.Click += SignButton_Click;
            // 
            // AvailableCoursesTable
            // 
            AvailableCoursesTable.AllowUserToAddRows = false;
            AvailableCoursesTable.AllowUserToDeleteRows = false;
            AvailableCoursesTable.BackgroundColor = SystemColors.Control;
            AvailableCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AvailableCoursesTable.Columns.AddRange(new DataGridViewColumn[] { IdCol, RowCheck, AvailableCourseColumn, AvailableFacultyColumn });
            AvailableCoursesTable.Location = new Point(167, 28);
            AvailableCoursesTable.Name = "AvailableCoursesTable";
            AvailableCoursesTable.RowHeadersWidth = 51;
            AvailableCoursesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AvailableCoursesTable.Size = new Size(419, 268);
            AvailableCoursesTable.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLightLight;
            tabPage3.Controls.Add(MessageTable);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(592, 304);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Notifications";
            // 
            // MessageTable
            // 
            MessageTable.AllowUserToAddRows = false;
            MessageTable.AllowUserToDeleteRows = false;
            MessageTable.BackgroundColor = SystemColors.Control;
            MessageTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MessageTable.Columns.AddRange(new DataGridViewColumn[] { IdColumn, InitialsColumn, FromCourseColumn, MessageColumn });
            MessageTable.Location = new Point(0, 0);
            MessageTable.Name = "MessageTable";
            MessageTable.RowHeadersWidth = 51;
            MessageTable.Size = new Size(592, 304);
            MessageTable.TabIndex = 4;
            MessageTable.CellContentClick += MessageTable_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            IdColumn.Width = 125;
            // 
            // InitialsColumn
            // 
            InitialsColumn.HeaderText = "Initials";
            InitialsColumn.MinimumWidth = 6;
            InitialsColumn.Name = "InitialsColumn";
            InitialsColumn.ReadOnly = true;
            InitialsColumn.Resizable = DataGridViewTriState.False;
            InitialsColumn.Width = 150;
            // 
            // FromCourseColumn
            // 
            FromCourseColumn.HeaderText = "Course";
            FromCourseColumn.MinimumWidth = 6;
            FromCourseColumn.Name = "FromCourseColumn";
            FromCourseColumn.ReadOnly = true;
            FromCourseColumn.Resizable = DataGridViewTriState.False;
            FromCourseColumn.Width = 149;
            // 
            // MessageColumn
            // 
            MessageColumn.HeaderText = "Message";
            MessageColumn.MinimumWidth = 6;
            MessageColumn.Name = "MessageColumn";
            MessageColumn.ReadOnly = true;
            MessageColumn.Resizable = DataGridViewTriState.False;
            MessageColumn.Width = 250;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "Id";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // RowCheck
            // 
            RowCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RowCheck.HeaderText = "";
            RowCheck.MinimumWidth = 6;
            RowCheck.Name = "RowCheck";
            RowCheck.Resizable = DataGridViewTriState.False;
            RowCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            RowCheck.Width = 19;
            // 
            // AvailableCourseColumn
            // 
            AvailableCourseColumn.HeaderText = "Course";
            AvailableCourseColumn.MinimumWidth = 6;
            AvailableCourseColumn.Name = "AvailableCourseColumn";
            AvailableCourseColumn.ReadOnly = true;
            AvailableCourseColumn.Resizable = DataGridViewTriState.False;
            AvailableCourseColumn.Width = 150;
            // 
            // AvailableFacultyColumn
            // 
            AvailableFacultyColumn.HeaderText = "Faculty";
            AvailableFacultyColumn.MinimumWidth = 6;
            AvailableFacultyColumn.Name = "AvailableFacultyColumn";
            AvailableFacultyColumn.ReadOnly = true;
            AvailableFacultyColumn.Resizable = DataGridViewTriState.False;
            AvailableFacultyColumn.Width = 206;
            // 
            // EnvironmentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 400);
            Controls.Add(TabControl);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "EnvironmentForm";
            Sizable = false;
            Text = "Environment";
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MessageTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Label PersonName;
        private DataGridView ActualCoursesTable;
        private Label label1;
        private Button CloseButton;
        private Label PersonRole;
        private Label label2;
        private Button SignButton;
        private DataGridView AvailableCoursesTable;
        private Label label4;
        private Button UnsignButton;
        private TabPage tabPage3;
        private DataGridView MessageTable;
        private Label label3;
        private DataGridViewTextBoxColumn CourseColumn;
        private DataGridViewTextBoxColumn FacultyColumn;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn InitialsColumn;
        private DataGridViewTextBoxColumn FromCourseColumn;
        private DataGridViewTextBoxColumn MessageColumn;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewCheckBoxColumn RowCheck;
        private DataGridViewTextBoxColumn AvailableCourseColumn;
        private DataGridViewTextBoxColumn AvailableFacultyColumn;
    }
}