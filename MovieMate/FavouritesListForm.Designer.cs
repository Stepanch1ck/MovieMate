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
            openFavouritesButton = new RoundedButton();
            deleteFromFavouritesButton = new RoundedButton();
            mainMenuButton = new Button();
            blackListButton = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            resources.ApplyResources(roundedButton1, "roundedButton1");
            roundedButton1.Name = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // FavouritesDataGridView
            // 
            resources.ApplyResources(FavouritesDataGridView, "FavouritesDataGridView");
            FavouritesDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            FavouritesDataGridView.Name = "FavouritesDataGridView";
            FavouritesDataGridView.CellDoubleClick += filmsDataGridView_CellDoubleClick;
            // 
            // openFavouritesButton
            // 
            resources.ApplyResources(openFavouritesButton, "openFavouritesButton");
            openFavouritesButton.Name = "openFavouritesButton";
            openFavouritesButton.UseVisualStyleBackColor = true;
            openFavouritesButton.Click += openFavouritesButton_Click;
            // 
            // deleteFromFavouritesButton
            // 
            resources.ApplyResources(deleteFromFavouritesButton, "deleteFromFavouritesButton");
            deleteFromFavouritesButton.Name = "deleteFromFavouritesButton";
            deleteFromFavouritesButton.UseVisualStyleBackColor = true;
            deleteFromFavouritesButton.Click += deleteFromFavouritesButton_Click;
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
            // FavouritesListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(blackListButton);
            Controls.Add(mainMenuButton);
            Controls.Add(deleteFromFavouritesButton);
            Controls.Add(openFavouritesButton);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(roundedButton1);
            Name = "FavouritesListForm";
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
        private Button mainMenuButton;
        private Button blackListButton;
        private Button button3;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
    }
}