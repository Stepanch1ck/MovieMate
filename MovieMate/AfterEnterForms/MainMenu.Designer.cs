namespace MovieMate
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            secondNicknameLabel = new Label();
            RecomendationButton = new Button();
            FavoritesButton = new Button();
            BlackLIstButton = new Button();
            filmsDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            openButton = new Button();
            favouritesButton = new Button();
            addBlackListButton = new Button();
            MainPictureBox = new PictureBox();
            menuLabel = new Label();
            CompilationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // secondNicknameLabel
            // 
            resources.ApplyResources(secondNicknameLabel, "secondNicknameLabel");
            secondNicknameLabel.Name = "secondNicknameLabel";
            secondNicknameLabel.Click += secondNicknameLabel_Click;
            // 
            // RecomendationButton
            // 
            resources.ApplyResources(RecomendationButton, "RecomendationButton");
            RecomendationButton.Name = "RecomendationButton";
            RecomendationButton.UseVisualStyleBackColor = true;
            RecomendationButton.Click += RecomendationButton_Click;
            // 
            // FavoritesButton
            // 
            resources.ApplyResources(FavoritesButton, "FavoritesButton");
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.UseVisualStyleBackColor = true;
            FavoritesButton.Click += favoritesButton_Click;
            // 
            // BlackLIstButton
            // 
            resources.ApplyResources(BlackLIstButton, "BlackLIstButton");
            BlackLIstButton.Name = "BlackLIstButton";
            BlackLIstButton.UseVisualStyleBackColor = true;
            BlackLIstButton.Click += button3_Click;
            // 
            // filmsDataGridView
            // 
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
            filmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            filmsDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            filmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            filmsDataGridView.Name = "filmsDataGridView";
            filmsDataGridView.CellDoubleClick += filmsDataGridView_CellDoubleClick;
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
            // openButton
            // 
            resources.ApplyResources(openButton, "openButton");
            openButton.BackColor = Color.Black;
            openButton.ForeColor = Color.White;
            openButton.Name = "openButton";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click_1;
            // 
            // favouritesButton
            // 
            resources.ApplyResources(favouritesButton, "favouritesButton");
            favouritesButton.BackColor = Color.Black;
            favouritesButton.ForeColor = Color.White;
            favouritesButton.Name = "favouritesButton";
            favouritesButton.UseVisualStyleBackColor = false;
            favouritesButton.Click += favouritesButton_Click;
            // 
            // addBlackListButton
            // 
            resources.ApplyResources(addBlackListButton, "addBlackListButton");
            addBlackListButton.BackColor = Color.Black;
            addBlackListButton.ForeColor = Color.White;
            addBlackListButton.Name = "addBlackListButton";
            addBlackListButton.UseVisualStyleBackColor = false;
            addBlackListButton.Click += addBlackListButton_Click;
            // 
            // MainPictureBox
            // 
            resources.ApplyResources(MainPictureBox, "MainPictureBox");
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.TabStop = false;
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // CompilationButton
            // 
            resources.ApplyResources(CompilationButton, "CompilationButton");
            CompilationButton.Name = "CompilationButton";
            CompilationButton.UseVisualStyleBackColor = true;
            CompilationButton.Click += generalCompilationButton_Click;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CompilationButton);
            Controls.Add(menuLabel);
            Controls.Add(MainPictureBox);
            Controls.Add(addBlackListButton);
            Controls.Add(favouritesButton);
            Controls.Add(openButton);
            Controls.Add(filmsDataGridView);
            Controls.Add(BlackLIstButton);
            Controls.Add(FavoritesButton);
            Controls.Add(RecomendationButton);
            Controls.Add(secondNicknameLabel);
            ForeColor = Color.Black;
            Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label secondNicknameLabel;
        private Button RecomendationButton;
        private Button FavoritesButton;
        private Button BlackLIstButton;
        private DataGridView filmsDataGridView;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private Button openButton;
        private Button favouritesButton;
        private Button addBlackListButton;
        private PictureBox MainPictureBox;
        private Label menuLabel;
        private Button CompilationButton;
    }
}