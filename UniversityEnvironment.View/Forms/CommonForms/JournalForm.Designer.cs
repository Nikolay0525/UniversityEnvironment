namespace UniversityEnvironment.View.Forms
{
    partial class JournalForm
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
            JournalTable = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            ApplyButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)JournalTable).BeginInit();
            SuspendLayout();
            // 
            // JournalTable
            // 
            JournalTable.AllowUserToAddRows = false;
            JournalTable.AllowUserToDeleteRows = false;
            JournalTable.BackgroundColor = SystemColors.Control;
            JournalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JournalTable.Columns.AddRange(new DataGridViewColumn[] { StudentName });
            JournalTable.Location = new Point(-1, 64);
            JournalTable.Name = "JournalTable";
            JournalTable.ReadOnly = true;
            JournalTable.Size = new Size(601, 294);
            JournalTable.TabIndex = 0;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // ApplyButton
            // 
            ApplyButton.BackColor = SystemColors.ControlLightLight;
            ApplyButton.FlatStyle = FlatStyle.Flat;
            ApplyButton.Location = new Point(12, 364);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(281, 31);
            ApplyButton.TabIndex = 1;
            ApplyButton.Text = "Apply changes";
            ApplyButton.UseVisualStyleBackColor = false;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ControlLightLight;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(299, 364);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(289, 31);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Go back";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // JournalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(CloseButton);
            Controls.Add(ApplyButton);
            Controls.Add(JournalTable);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "JournalForm";
            ((System.ComponentModel.ISupportInitialize)JournalTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView JournalTable;
        private DataGridViewTextBoxColumn StudentName;
        private Button ApplyButton;
        private Button CloseButton;
    }
}