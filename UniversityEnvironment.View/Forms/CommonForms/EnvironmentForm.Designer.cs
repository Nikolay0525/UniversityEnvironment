﻿namespace UniversityEnvironment.View.Forms
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
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
            RowCheck = new DataGridViewCheckBoxColumn();
            AvailableCourseColumn = new DataGridViewTextBoxColumn();
            AvailableFacultyColumn = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            InitialsColumn = new DataGridViewTextBoxColumn();
            FromCourseColumn = new DataGridViewTextBoxColumn();
            MessageColumn = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
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
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(486, 263);
            button2.Name = "button2";
            button2.Size = new Size(99, 35);
            button2.TabIndex = 7;
            button2.Text = "=>";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(171, 261);
            button1.Name = "button1";
            button1.Size = new Size(116, 37);
            button1.TabIndex = 6;
            button1.Text = "<=";
            button1.UseVisualStyleBackColor = true;
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
            CloseButton.Location = new Point(293, 261);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(187, 37);
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
            ActualCoursesTable.Size = new Size(414, 231);
            ActualCoursesTable.TabIndex = 2;
            ActualCoursesTable.CellContentClick += ActualCoursesTable_CellContentClick;
            // 
            // CourseColumn
            // 
            CourseColumn.HeaderText = "Course";
            CourseColumn.Name = "CourseColumn";
            CourseColumn.ReadOnly = true;
            CourseColumn.Width = 150;
            // 
            // FacultyColumn
            // 
            FacultyColumn.HeaderText = "Faculty";
            FacultyColumn.Name = "FacultyColumn";
            FacultyColumn.ReadOnly = true;
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
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
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
            UnsignButton.Location = new Point(8, 132);
            UnsignButton.Name = "UnsignButton";
            UnsignButton.Size = new Size(158, 106);
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
            SignButton.Size = new Size(158, 98);
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
            AvailableCoursesTable.Columns.AddRange(new DataGridViewColumn[] { RowCheck, AvailableCourseColumn, AvailableFacultyColumn });
            AvailableCoursesTable.Location = new Point(172, 28);
            AvailableCoursesTable.Name = "AvailableCoursesTable";
            AvailableCoursesTable.Size = new Size(414, 268);
            AvailableCoursesTable.TabIndex = 3;
            // 
            // RowCheck
            // 
            RowCheck.HeaderText = "";
            RowCheck.Name = "RowCheck";
            RowCheck.Resizable = DataGridViewTriState.True;
            RowCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            RowCheck.Width = 20;
            // 
            // AvailableCourseColumn
            // 
            AvailableCourseColumn.HeaderText = "Course";
            AvailableCourseColumn.Name = "AvailableCourseColumn";
            AvailableCourseColumn.Width = 150;
            // 
            // AvailableFacultyColumn
            // 
            AvailableFacultyColumn.HeaderText = "Faculty";
            AvailableFacultyColumn.Name = "AvailableFacultyColumn";
            AvailableFacultyColumn.Width = 200;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLightLight;
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(592, 304);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Notifications";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { InitialsColumn, FromCourseColumn, MessageColumn });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(592, 304);
            dataGridView1.TabIndex = 4;
            // 
            // InitialsColumn
            // 
            InitialsColumn.HeaderText = "Initials";
            InitialsColumn.Name = "InitialsColumn";
            InitialsColumn.Width = 200;
            // 
            // FromCourseColumn
            // 
            FromCourseColumn.HeaderText = "Course";
            FromCourseColumn.Name = "FromCourseColumn";
            FromCourseColumn.Width = 149;
            // 
            // MessageColumn
            // 
            MessageColumn.HeaderText = "Message";
            MessageColumn.Name = "MessageColumn";
            MessageColumn.Width = 200;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(8, 244);
            button3.Name = "button3";
            button3.Size = new Size(76, 49);
            button3.TabIndex = 7;
            button3.Text = "<=";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(90, 244);
            button4.Name = "button4";
            button4.Size = new Size(76, 50);
            button4.TabIndex = 8;
            button4.Text = "=>";
            button4.UseVisualStyleBackColor = true;
            // 
            // EnvironmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(tabControl1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "EnvironmentForm";
            Text = "Environment";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn InitialsColumn;
        private DataGridViewTextBoxColumn FromCourseColumn;
        private DataGridViewTextBoxColumn MessageColumn;
        private Label label3;
        private DataGridViewTextBoxColumn CourseColumn;
        private DataGridViewTextBoxColumn FacultyColumn;
        private DataGridViewCheckBoxColumn RowCheck;
        private DataGridViewTextBoxColumn AvailableCourseColumn;
        private DataGridViewTextBoxColumn AvailableFacultyColumn;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}