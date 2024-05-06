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
            button1 = new Button();
            favoritesButton = new Button();
            button3 = new Button();
            filmsDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            openButton = new Button();
            favouritesButton = new Button();
            addBlackListButton = new Button();
            pictureBox1 = new PictureBox();
            menuLabel = new Label();
            generalCompilationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // secondNicknameLabel
            // 
            resources.ApplyResources(secondNicknameLabel, "secondNicknameLabel");
            secondNicknameLabel.Name = "secondNicknameLabel";
            secondNicknameLabel.Click += secondNicknameLabel_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // favoritesButton
            // 
            resources.ApplyResources(favoritesButton, "favoritesButton");
            favoritesButton.Name = "favoritesButton";
            favoritesButton.UseVisualStyleBackColor = true;
            favoritesButton.Click += favoritesButton_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // filmsDataGridView
            // 
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
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
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // generalCompilationButton
            // 
            resources.ApplyResources(generalCompilationButton, "generalCompilationButton");
            generalCompilationButton.Name = "generalCompilationButton";
            generalCompilationButton.UseVisualStyleBackColor = true;
            generalCompilationButton.Click += generalCompilationButton_Click;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(generalCompilationButton);
            Controls.Add(menuLabel);
            Controls.Add(pictureBox1);
            Controls.Add(addBlackListButton);
            Controls.Add(favouritesButton);
            Controls.Add(openButton);
            Controls.Add(filmsDataGridView);
            Controls.Add(button3);
            Controls.Add(favoritesButton);
            Controls.Add(button1);
            Controls.Add(secondNicknameLabel);
            ForeColor = Color.Black;
            Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label secondNicknameLabel;
        private Button button1;
        private Button favoritesButton;
        private Button button3;
        private DataGridView filmsDataGridView;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private Button openButton;
        private Button favouritesButton;
        private Button addBlackListButton;
        private PictureBox pictureBox1;
        private Label menuLabel;
        private Button generalCompilationButton;
    }
}