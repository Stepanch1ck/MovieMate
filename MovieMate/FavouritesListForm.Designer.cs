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
            roundedButton1.Location = new Point(201, 75);
            roundedButton1.Margin = new Padding(3, 2, 3, 2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(471, 226);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // FavouritesDataGridView
            // 
            FavouritesDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            FavouritesDataGridView.Location = new Point(221, 102);
            FavouritesDataGridView.Margin = new Padding(3, 2, 3, 2);
            FavouritesDataGridView.Name = "FavouritesDataGridView";
            FavouritesDataGridView.RowHeadersWidth = 51;
            FavouritesDataGridView.Size = new Size(441, 180);
            FavouritesDataGridView.TabIndex = 1;
            FavouritesDataGridView.CellDoubleClick += filmsDataGridView_CellDoubleClick;
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
            openFavouritesButton.Location = new Point(378, 22);
            openFavouritesButton.Margin = new Padding(3, 2, 3, 2);
            openFavouritesButton.Name = "openFavouritesButton";
            openFavouritesButton.Size = new Size(108, 34);
            openFavouritesButton.TabIndex = 2;
            openFavouritesButton.Text = "Открыть";
            openFavouritesButton.UseVisualStyleBackColor = true;
            openFavouritesButton.Click += openFavouritesButton_Click;
            // 
            // deleteFromFavouritesButton
            // 
            deleteFromFavouritesButton.Location = new Point(530, 22);
            deleteFromFavouritesButton.Margin = new Padding(3, 2, 3, 2);
            deleteFromFavouritesButton.Name = "deleteFromFavouritesButton";
            deleteFromFavouritesButton.Size = new Size(104, 34);
            deleteFromFavouritesButton.TabIndex = 3;
            deleteFromFavouritesButton.Text = "Удалить из избранного";
            deleteFromFavouritesButton.UseVisualStyleBackColor = true;
            deleteFromFavouritesButton.Click += deleteFromFavouritesButton_Click;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackgroundImage = (Image)resources.GetObject("mainMenuButton.BackgroundImage");
            mainMenuButton.Location = new Point(2, 146);
            mainMenuButton.Margin = new Padding(3, 2, 3, 2);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(60, 51);
            mainMenuButton.TabIndex = 4;
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // blackListButton
            // 
            blackListButton.BackgroundImage = (Image)resources.GetObject("blackListButton.BackgroundImage");
            blackListButton.Location = new Point(2, 202);
            blackListButton.Margin = new Padding(3, 2, 3, 2);
            blackListButton.Name = "blackListButton";
            blackListButton.Size = new Size(60, 51);
            blackListButton.TabIndex = 5;
            blackListButton.UseVisualStyleBackColor = true;
            blackListButton.Click += blackListButton_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(2, 91);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(60, 51);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 53);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FavouritesListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(blackListButton);
            Controls.Add(mainMenuButton);
            Controls.Add(deleteFromFavouritesButton);
            Controls.Add(openFavouritesButton);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(roundedButton1);
            Margin = new Padding(3, 2, 3, 2);
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