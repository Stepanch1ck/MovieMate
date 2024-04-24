namespace MovieMate
{
    partial class BlackListForm
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
            roundedButton1 = new RoundedButton();
            BlackListDataGridView = new DataGridView();
            blackListOpenButton = new RoundedButton();
            deleteFromBlackListButton = new RoundedButton();
            filmName = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            roundedButton4 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(258, 95);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(490, 302);
            roundedButton1.TabIndex = 0;
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // BlackListDataGridView
            // 
            BlackListDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            BlackListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BlackListDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, year, grade });
            BlackListDataGridView.Location = new Point(302, 127);
            BlackListDataGridView.Name = "BlackListDataGridView";
            BlackListDataGridView.RowHeadersWidth = 51;
            BlackListDataGridView.Size = new Size(429, 228);
            BlackListDataGridView.TabIndex = 1;
            // 
            // blackListOpenButton
            // 
            blackListOpenButton.Location = new Point(448, 29);
            blackListOpenButton.Name = "blackListOpenButton";
            blackListOpenButton.Size = new Size(134, 50);
            blackListOpenButton.TabIndex = 2;
            blackListOpenButton.Text = "Открыть";
            blackListOpenButton.UseVisualStyleBackColor = true;
            // 
            // deleteFromBlackListButton
            // 
            deleteFromBlackListButton.Location = new Point(614, 29);
            deleteFromBlackListButton.Name = "deleteFromBlackListButton";
            deleteFromBlackListButton.Size = new Size(134, 50);
            deleteFromBlackListButton.TabIndex = 3;
            deleteFromBlackListButton.Text = "Удалить из чёрного списка";
            deleteFromBlackListButton.UseVisualStyleBackColor = true;
            // 
            // filmName
            // 
            filmName.HeaderText = "Название";
            filmName.MinimumWidth = 6;
            filmName.Name = "filmName";
            filmName.Width = 125;
            // 
            // year
            // 
            year.HeaderText = "Год";
            year.MinimumWidth = 6;
            year.Name = "year";
            year.Width = 125;
            // 
            // grade
            // 
            grade.HeaderText = "Рейтинг";
            grade.MinimumWidth = 6;
            grade.Name = "grade";
            grade.Width = 125;
            // 
            // roundedButton2
            // 
            roundedButton2.Location = new Point(12, 127);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(68, 62);
            roundedButton2.TabIndex = 4;
            roundedButton2.Text = "roundedButton2";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton3
            // 
            roundedButton3.Location = new Point(12, 215);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(68, 62);
            roundedButton3.TabIndex = 5;
            roundedButton3.Text = "roundedButton3";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            roundedButton4.Location = new Point(12, 303);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(68, 62);
            roundedButton4.TabIndex = 6;
            roundedButton4.Text = "roundedButton4";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // BlackListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roundedButton4);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(deleteFromBlackListButton);
            Controls.Add(blackListOpenButton);
            Controls.Add(BlackListDataGridView);
            Controls.Add(roundedButton1);
            Name = "BlackListForm";
            Text = "BlackListForm";
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton roundedButton1;
        private DataGridView BlackListDataGridView;
        private RoundedButton blackListOpenButton;
        private RoundedButton deleteFromBlackListButton;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn grade;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton4;
    }
}