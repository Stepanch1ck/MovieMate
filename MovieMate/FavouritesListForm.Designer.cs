namespace MovieMate
{
    partial class FavouritesListForm
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
            FavouritesDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            openFavouritesButton = new RoundedButton();
            deleteFromFavouritesButton = new RoundedButton();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            roundedButton4 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(230, 100);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(538, 301);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // FavouritesDataGridView
            // 
            FavouritesDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            FavouritesDataGridView.Location = new Point(253, 136);
            FavouritesDataGridView.Name = "FavouritesDataGridView";
            FavouritesDataGridView.RowHeadersWidth = 51;
            FavouritesDataGridView.Size = new Size(504, 240);
            FavouritesDataGridView.TabIndex = 1;
            // 
            // filmName
            // 
            filmName.HeaderText = "Название";
            filmName.MinimumWidth = 6;
            filmName.Name = "filmName";
            filmName.Width = 150;
            // 
            // Year
            // 
            Year.HeaderText = "Год";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Width = 150;
            // 
            // Grade
            // 
            Grade.HeaderText = "Рейтинг";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.Width = 150;
            // 
            // openFavouritesButton
            // 
            openFavouritesButton.Location = new Point(432, 30);
            openFavouritesButton.Name = "openFavouritesButton";
            openFavouritesButton.Size = new Size(123, 46);
            openFavouritesButton.TabIndex = 2;
            openFavouritesButton.Text = "Открыть";
            openFavouritesButton.UseVisualStyleBackColor = true;
            // 
            // deleteFromFavouritesButton
            // 
            deleteFromFavouritesButton.Location = new Point(606, 30);
            deleteFromFavouritesButton.Name = "deleteFromFavouritesButton";
            deleteFromFavouritesButton.Size = new Size(119, 46);
            deleteFromFavouritesButton.TabIndex = 3;
            deleteFromFavouritesButton.Text = "Удалить из избранного";
            deleteFromFavouritesButton.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            roundedButton2.Location = new Point(12, 136);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(68, 62);
            roundedButton2.TabIndex = 4;
            roundedButton2.Text = "roundedButton2";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton3
            // 
            roundedButton3.Location = new Point(12, 230);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(68, 62);
            roundedButton3.TabIndex = 5;
            roundedButton3.Text = "roundedButton3";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            roundedButton4.Location = new Point(12, 325);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(68, 62);
            roundedButton4.TabIndex = 6;
            roundedButton4.Text = "roundedButton4";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // FavouritesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roundedButton4);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(deleteFromFavouritesButton);
            Controls.Add(openFavouritesButton);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(roundedButton1);
            Name = "FavouritesListForm";
            Text = "FavouritesListForm";
            Load += FavouritesListForm_Load;
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton roundedButton1;
        private DataGridView FavouritesDataGridView;
        private RoundedButton openFavouritesButton;
        private RoundedButton deleteFromFavouritesButton;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton4;
    }
}