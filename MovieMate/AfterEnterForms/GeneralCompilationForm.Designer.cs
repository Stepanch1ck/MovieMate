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
            button3 = new Button();
            mainMenuButton = new Button();
            blackListButton = new Button();
            generalCompilationButton = new Button();
            FavouritesDataGridView = new DataGridView();
            openFavButton = new Button();
            addFilmToCompilation = new Button();
            button2 = new Button();
            menuLabel = new Label();
            selectCompilationButton = new Button();
            createCompilationButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // mainMenuButton
            // 
            resources.ApplyResources(mainMenuButton, "mainMenuButton");
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.UseVisualStyleBackColor = true;
            // 
            // blackListButton
            // 
            resources.ApplyResources(blackListButton, "blackListButton");
            blackListButton.Name = "blackListButton";
            blackListButton.UseVisualStyleBackColor = true;
            // 
            // generalCompilationButton
            // 
            resources.ApplyResources(generalCompilationButton, "generalCompilationButton");
            generalCompilationButton.Name = "generalCompilationButton";
            generalCompilationButton.UseVisualStyleBackColor = true;
            // 
            // FavouritesDataGridView
            // 
            resources.ApplyResources(FavouritesDataGridView, "FavouritesDataGridView");
            FavouritesDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Name = "FavouritesDataGridView";
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
            // addFilmToCompilation
            // 
            resources.ApplyResources(addFilmToCompilation, "addFilmToCompilation");
            addFilmToCompilation.BackColor = Color.Black;
            addFilmToCompilation.ForeColor = Color.White;
            addFilmToCompilation.Name = "addFilmToCompilation";
            addFilmToCompilation.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // selectCompilationButton
            // 
            resources.ApplyResources(selectCompilationButton, "selectCompilationButton");
            selectCompilationButton.BackColor = Color.Black;
            selectCompilationButton.ForeColor = Color.White;
            selectCompilationButton.Name = "selectCompilationButton";
            selectCompilationButton.UseVisualStyleBackColor = false;
            // 
            // createCompilationButton
            // 
            resources.ApplyResources(createCompilationButton, "createCompilationButton");
            createCompilationButton.BackColor = Color.Black;
            createCompilationButton.ForeColor = Color.White;
            createCompilationButton.Name = "createCompilationButton";
            createCompilationButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // GeneralCompilationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(createCompilationButton);
            Controls.Add(selectCompilationButton);
            Controls.Add(menuLabel);
            Controls.Add(button2);
            Controls.Add(addFilmToCompilation);
            Controls.Add(openFavButton);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(generalCompilationButton);
            Controls.Add(blackListButton);
            Controls.Add(mainMenuButton);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Name = "GeneralCompilationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button3;
        private Button mainMenuButton;
        private Button blackListButton;
        private Button generalCompilationButton;
        private DataGridView FavouritesDataGridView;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private Button openFavButton;
        private Button addFilmToCompilation;
        private Button button2;
        private Label menuLabel;
        private Button selectCompilationButton;
        private Button createCompilationButton;
        private Button button1;
    }
}