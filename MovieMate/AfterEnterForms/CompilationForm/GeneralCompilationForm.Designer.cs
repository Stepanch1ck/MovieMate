namespace MovieMate
{
    partial class GeneralCompilationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralCompilationForm));
            pictureBox1 = new PictureBox();
            favoritesButton = new Button();
            mainMenuButton = new Button();
            blackListButton = new Button();
            generalCompilationButton = new Button();
            filmsDataGridView = new DataGridView();
            openCompButton = new Button();
            MovieListCompilation = new Button();
            menuLabel = new Label();
            createCompilationButton = new Button();
            SendEmailButton = new Button();
            UserListButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // favoritesButton
            // 
            favoritesButton.BackgroundImage = Properties.Resources.free_icon_bookmarks_1174410;
            resources.ApplyResources(favoritesButton, "favoritesButton");
            favoritesButton.Name = "favoritesButton";
            favoritesButton.UseVisualStyleBackColor = true;
            favoritesButton.Click += favoritesButton_Click;
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
            // generalCompilationButton
            // 
            resources.ApplyResources(generalCompilationButton, "generalCompilationButton");
            generalCompilationButton.Name = "generalCompilationButton";
            generalCompilationButton.UseVisualStyleBackColor = true;
            // 
            // filmsDataGridView
            // 
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
            filmsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            filmsDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            filmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsDataGridView.Name = "filmsDataGridView";
            filmsDataGridView.CellDoubleClick += filmsDataGridView_CellDoubleClick;
            // 
            // openCompButton
            // 
            resources.ApplyResources(openCompButton, "openCompButton");
            openCompButton.BackColor = Color.Black;
            openCompButton.ForeColor = Color.White;
            openCompButton.Name = "openCompButton";
            openCompButton.UseVisualStyleBackColor = false;
            openCompButton.Click += openFavButton_Click;
            // 
            // MovieListCompilation
            // 
            resources.ApplyResources(MovieListCompilation, "MovieListCompilation");
            MovieListCompilation.BackColor = Color.Black;
            MovieListCompilation.ForeColor = Color.White;
            MovieListCompilation.Name = "MovieListCompilation";
            MovieListCompilation.UseVisualStyleBackColor = false;
            MovieListCompilation.Click += MovListCompilation_Click;
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // createCompilationButton
            // 
            resources.ApplyResources(createCompilationButton, "createCompilationButton");
            createCompilationButton.BackColor = Color.Black;
            createCompilationButton.ForeColor = Color.White;
            createCompilationButton.Name = "createCompilationButton";
            createCompilationButton.UseVisualStyleBackColor = false;
            createCompilationButton.Click += createCompilationButton_Click;
            // 
            // SendEmailButton
            // 
            resources.ApplyResources(SendEmailButton, "SendEmailButton");
            SendEmailButton.BackColor = Color.Black;
            SendEmailButton.ForeColor = Color.White;
            SendEmailButton.Name = "SendEmailButton";
            SendEmailButton.UseVisualStyleBackColor = false;
            SendEmailButton.Click += SendEmailButton_Click;
            // 
            // UserListButton
            // 
            resources.ApplyResources(UserListButton, "UserListButton");
            UserListButton.BackColor = Color.Black;
            UserListButton.ForeColor = Color.White;
            UserListButton.Name = "UserListButton";
            UserListButton.UseVisualStyleBackColor = false;
            UserListButton.Click += UserListButton_Click;
            // 
            // GeneralCompilationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(UserListButton);
            Controls.Add(SendEmailButton);
            Controls.Add(createCompilationButton);
            Controls.Add(menuLabel);
            Controls.Add(MovieListCompilation);
            Controls.Add(openCompButton);
            Controls.Add(filmsDataGridView);
            Controls.Add(generalCompilationButton);
            Controls.Add(blackListButton);
            Controls.Add(mainMenuButton);
            Controls.Add(favoritesButton);
            Controls.Add(pictureBox1);
            Name = "GeneralCompilationForm";
            Load += GeneralCompilationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button favoritesButton;
        private Button mainMenuButton;
        private Button blackListButton;
        private Button generalCompilationButton;
        private DataGridView filmsDataGridView;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private Button openCompButton;
        private Button MovieListCompilation;
        private Label menuLabel;
        private Button createCompilationButton;
        private Button SendEmailButton;
        private Button UserListButton;
    }
}