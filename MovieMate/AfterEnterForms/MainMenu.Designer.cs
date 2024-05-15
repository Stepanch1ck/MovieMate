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
            components = new System.ComponentModel.Container();
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
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // secondNicknameLabel
            // 
            resources.ApplyResources(secondNicknameLabel, "secondNicknameLabel");
            secondNicknameLabel.Name = "secondNicknameLabel";
            toolTip1.SetToolTip(secondNicknameLabel, resources.GetString("secondNicknameLabel.ToolTip"));
            secondNicknameLabel.Click += secondNicknameLabel_Click;
            secondNicknameLabel.MouseHover += UserInfoMouseHover;
            // 
            // RecomendationButton
            // 
            resources.ApplyResources(RecomendationButton, "RecomendationButton");
            RecomendationButton.Name = "RecomendationButton";
            toolTip1.SetToolTip(RecomendationButton, resources.GetString("RecomendationButton.ToolTip"));
            RecomendationButton.UseVisualStyleBackColor = true;
            RecomendationButton.Click += RecomendationButton_Click;
            RecomendationButton.MouseHover += MainMenuMouseHover;
            // 
            // FavoritesButton
            // 
            resources.ApplyResources(FavoritesButton, "FavoritesButton");
            FavoritesButton.Name = "FavoritesButton";
            toolTip1.SetToolTip(FavoritesButton, resources.GetString("FavoritesButton.ToolTip"));
            FavoritesButton.UseVisualStyleBackColor = true;
            FavoritesButton.Click += favoritesButton_Click;
            FavoritesButton.MouseHover += FavButtonMouseHover;
            // 
            // BlackLIstButton
            // 
            resources.ApplyResources(BlackLIstButton, "BlackLIstButton");
            BlackLIstButton.Name = "BlackLIstButton";
            toolTip1.SetToolTip(BlackLIstButton, resources.GetString("BlackLIstButton.ToolTip"));
            BlackLIstButton.UseVisualStyleBackColor = true;
            BlackLIstButton.Click += BlackListbutton_Click;
            BlackLIstButton.MouseHover += BlackListMouseHover;
            // 
            // filmsDataGridView
            // 
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
            filmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            filmsDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            filmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            filmsDataGridView.Name = "filmsDataGridView";
            toolTip1.SetToolTip(filmsDataGridView, resources.GetString("filmsDataGridView.ToolTip"));
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
            toolTip1.SetToolTip(openButton, resources.GetString("openButton.ToolTip"));
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click_1;
            // 
            // favouritesButton
            // 
            resources.ApplyResources(favouritesButton, "favouritesButton");
            favouritesButton.BackColor = Color.Black;
            favouritesButton.ForeColor = Color.White;
            favouritesButton.Name = "favouritesButton";
            toolTip1.SetToolTip(favouritesButton, resources.GetString("favouritesButton.ToolTip"));
            favouritesButton.UseVisualStyleBackColor = false;
            favouritesButton.Click += favouritesButton_Click;
            // 
            // addBlackListButton
            // 
            resources.ApplyResources(addBlackListButton, "addBlackListButton");
            addBlackListButton.BackColor = Color.Black;
            addBlackListButton.ForeColor = Color.White;
            addBlackListButton.Name = "addBlackListButton";
            toolTip1.SetToolTip(addBlackListButton, resources.GetString("addBlackListButton.ToolTip"));
            addBlackListButton.UseVisualStyleBackColor = false;
            addBlackListButton.Click += addBlackListButton_Click;
            // 
            // MainPictureBox
            // 
            resources.ApplyResources(MainPictureBox, "MainPictureBox");
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.TabStop = false;
            toolTip1.SetToolTip(MainPictureBox, resources.GetString("MainPictureBox.ToolTip"));
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            toolTip1.SetToolTip(menuLabel, resources.GetString("menuLabel.ToolTip"));
            // 
            // CompilationButton
            // 
            resources.ApplyResources(CompilationButton, "CompilationButton");
            CompilationButton.Name = "CompilationButton";
            toolTip1.SetToolTip(CompilationButton, resources.GetString("CompilationButton.ToolTip"));
            CompilationButton.UseVisualStyleBackColor = true;
            CompilationButton.Click += generalCompilationButton_Click;
            CompilationButton.MouseHover += CompilationMouseHover;
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
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private ToolTip toolTip1;
    }
}