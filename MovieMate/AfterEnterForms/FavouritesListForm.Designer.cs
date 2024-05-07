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
            FavouritesDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            mainMenuButton = new Button();
            blackListButton = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            openFavButton = new Button();
            deleteFavButton = new Button();
            favoriteLabel = new Label();
            generalCompilationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FavouritesDataGridView
            // 
            resources.ApplyResources(FavouritesDataGridView, "FavouritesDataGridView");
            FavouritesDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            FavouritesDataGridView.Name = "FavouritesDataGridView";
            FavouritesDataGridView.CellDoubleClick += filmsDataGridView_CellDoubleClick;
            // 
            // filmName
            // 
            resources.ApplyResources(filmName, "filmName");
            filmName.Name = "filmName";
            // 
            // Year
            // 
            resources.ApplyResources(Year, "Year");
            Year.Name = "Year";
            // 
            // Grade
            // 
            resources.ApplyResources(Grade, "Grade");
            Grade.Name = "Grade";
            // 
            // mainMenuButton
            // 
            resources.ApplyResources(mainMenuButton, "mainMenuButton");
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // blackListButton
            // 
            resources.ApplyResources(blackListButton, "blackListButton");
            blackListButton.Name = "blackListButton";
            blackListButton.UseVisualStyleBackColor = true;
            blackListButton.Click += blackListButton_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // openFavButton
            // 
            resources.ApplyResources(openFavButton, "openFavButton");
            openFavButton.BackColor = Color.Black;
            openFavButton.ForeColor = Color.White;
            openFavButton.Name = "openFavButton";
            openFavButton.UseVisualStyleBackColor = false;
            openFavButton.Click += openFavButton_Click;
            // 
            // deleteFavButton
            // 
            resources.ApplyResources(deleteFavButton, "deleteFavButton");
            deleteFavButton.BackColor = Color.Black;
            deleteFavButton.ForeColor = Color.White;
            deleteFavButton.Name = "deleteFavButton";
            deleteFavButton.UseVisualStyleBackColor = false;
            deleteFavButton.Click += deleteFavButton_Click;
            // 
            // favoriteLabel
            // 
            resources.ApplyResources(favoriteLabel, "favoriteLabel");
            favoriteLabel.BackColor = Color.Black;
            favoriteLabel.ForeColor = Color.White;
            favoriteLabel.Name = "favoriteLabel";
            // 
            // generalCompilationButton
            // 
            resources.ApplyResources(generalCompilationButton, "generalCompilationButton");
            generalCompilationButton.Name = "generalCompilationButton";
            generalCompilationButton.UseVisualStyleBackColor = true;
            generalCompilationButton.Click += button1_Click;
            // 
            // FavouritesListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(generalCompilationButton);
            Controls.Add(favoriteLabel);
            Controls.Add(deleteFavButton);
            Controls.Add(openFavButton);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(blackListButton);
            Controls.Add(mainMenuButton);
            Controls.Add(FavouritesDataGridView);
            Name = "FavouritesListForm";
            Load += FavouritesListForm_Load;
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView FavouritesDataGridView;
        private Button mainMenuButton;
        private Button blackListButton;
        private Button button3;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private Button openFavButton;
        private Button deleteFavButton;
        private Label favoriteLabel;
        private Button generalCompilationButton;
    }
}