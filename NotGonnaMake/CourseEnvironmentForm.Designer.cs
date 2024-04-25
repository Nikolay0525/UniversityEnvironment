﻿namespace UniversityEnvironment.View.Forms
{
    partial class CourseEnvironmentForm
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
            ((System.ComponentModel.ISupportInitialize)TeacherTable).BeginInit();
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
            // CourseEnvironmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(JournalButton);
            Controls.Add(CloseButton);
            Controls.Add(TeacherTable);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "CourseEnvironmentForm";
            Text = "CourseEnvironmentForm";
            ((System.ComponentModel.ISupportInitialize)TeacherTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TeacherTable;
        private Button CloseButton;
        private Button JournalButton;
        private DataGridViewTextBoxColumn UserName;
    }
}