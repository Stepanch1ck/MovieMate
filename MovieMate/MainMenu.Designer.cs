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
            addToFavouritesButton = new RoundedButton();
            openButton = new RoundedButton();
            AddToblackListButton = new RoundedButton();
            roundedButton1 = new RoundedButton();
            upateButton = new RoundedButton();
            secondNicknameLabel = new Label();
            englishButton = new RoundedButton();
            russianButton = new RoundedButton();
            button1 = new Button();
            favoritesButton = new Button();
            button3 = new Button();
            filmsDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addToFavouritesButton
            // 
            resources.ApplyResources(addToFavouritesButton, "addToFavouritesButton");
            addToFavouritesButton.Name = "addToFavouritesButton";
            addToFavouritesButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            resources.ApplyResources(openButton, "openButton");
            openButton.Name = "openButton";
            openButton.UseVisualStyleBackColor = true;
            // 
            // AddToblackListButton
            // 
            resources.ApplyResources(AddToblackListButton, "AddToblackListButton");
            AddToblackListButton.Name = "AddToblackListButton";
            // 
            // roundedButton1
            // 
            resources.ApplyResources(roundedButton1, "roundedButton1");
            roundedButton1.Name = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // upateButton
            // 
            resources.ApplyResources(upateButton, "upateButton");
            upateButton.Name = "upateButton";
            upateButton.UseVisualStyleBackColor = true;
            // 
            // secondNicknameLabel
            // 
            resources.ApplyResources(secondNicknameLabel, "secondNicknameLabel");
            secondNicknameLabel.Name = "secondNicknameLabel";
            // 
            // englishButton
            // 
            resources.ApplyResources(englishButton, "englishButton");
            englishButton.Name = "englishButton";
            englishButton.UseVisualStyleBackColor = true;
            // 
            // russianButton
            // 
            resources.ApplyResources(russianButton, "russianButton");
            russianButton.Name = "russianButton";
            russianButton.UseVisualStyleBackColor = true;
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
            filmsDataGridView.BackgroundColor = SystemColors.Control;
            filmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
            filmsDataGridView.Name = "filmsDataGridView";
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
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(filmsDataGridView);
            Controls.Add(button3);
            Controls.Add(favoritesButton);
            Controls.Add(button1);
            Controls.Add(russianButton);
            Controls.Add(englishButton);
            Controls.Add(secondNicknameLabel);
            Controls.Add(upateButton);
            Controls.Add(roundedButton1);
            Controls.Add(AddToblackListButton);
            Controls.Add(openButton);
            Controls.Add(addToFavouritesButton);
            Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton addToFavouritesButton;
        private RoundedButton openButton;
        private RoundedButton AddToblackListButton;
        private RoundedButton roundedButton1;
        private RoundedButton upateButton;
        private Label secondNicknameLabel;
        private RoundedButton englishButton;
        private RoundedButton russianButton;
        private Button button1;
        private Button favoritesButton;
        private Button button3;
        private DataGridView filmsDataGridView;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
    }
}