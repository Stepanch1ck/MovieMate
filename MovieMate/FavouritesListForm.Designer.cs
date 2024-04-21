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
            openFavouritesButton = new RoundedButton();
            deleteFromFavouritesButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(250, 100);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(518, 301);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // FavouritesDataGridView
            // 
            FavouritesDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Location = new Point(285, 132);
            FavouritesDataGridView.Name = "FavouritesDataGridView";
            FavouritesDataGridView.RowHeadersWidth = 51;
            FavouritesDataGridView.Size = new Size(440, 240);
            FavouritesDataGridView.TabIndex = 1;
            // 
            // openFavouritesButton
            // 
            openFavouritesButton.Location = new Point(433, 30);
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
            // FavouritesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteFromFavouritesButton);
            Controls.Add(openFavouritesButton);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(roundedButton1);
            Name = "FavouritesListForm";
            Text = "FavouritesListForm";
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton roundedButton1;
        private DataGridView FavouritesDataGridView;
        private RoundedButton openFavouritesButton;
        private RoundedButton deleteFromFavouritesButton;
    }
}