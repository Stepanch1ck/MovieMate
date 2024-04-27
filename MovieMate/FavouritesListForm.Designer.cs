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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouritesListForm));
            roundedButton1 = new RoundedButton();
            FavouritesDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            openFavouritesButton = new RoundedButton();
            deleteFromFavouritesButton = new RoundedButton();
            mainMenuButton = new Button();
            blackListButton = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            deleteFromFavouritesButton.Click += deleteFromFavouritesButton_Click;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackgroundImage = (Image)resources.GetObject("mainMenuButton.BackgroundImage");
            mainMenuButton.Location = new Point(2, 195);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(68, 68);
            mainMenuButton.TabIndex = 4;
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // blackListButton
            // 
            blackListButton.BackgroundImage = (Image)resources.GetObject("blackListButton.BackgroundImage");
            blackListButton.Location = new Point(2, 269);
            blackListButton.Name = "blackListButton";
            blackListButton.Size = new Size(68, 68);
            blackListButton.TabIndex = 5;
            blackListButton.UseVisualStyleBackColor = true;
            blackListButton.Click += blackListButton_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(2, 121);
            button3.Name = "button3";
            button3.Size = new Size(68, 68);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 71);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FavouritesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(blackListButton);
            Controls.Add(mainMenuButton);
            Controls.Add(deleteFromFavouritesButton);
            Controls.Add(openFavouritesButton);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(roundedButton1);
            Name = "FavouritesListForm";
            Text = "FavouritesListForm";
            Load += FavouritesListForm_Load;
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button mainMenuButton;
        private Button blackListButton;
        private Button button3;
        private PictureBox pictureBox1;
    }
}