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
            favouritesButton = new RoundedButton();
            openButton = new RoundedButton();
            blackListButton = new RoundedButton();
            roundedButton1 = new RoundedButton();
            filmsDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            upateButton = new RoundedButton();
            secondNicknameLabel = new Label();
            englishButton = new RoundedButton();
            russianButton = new RoundedButton();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            roundedButton4 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // favouritesButton
            // 
            resources.ApplyResources(favouritesButton, "favouritesButton");
            favouritesButton.Name = "favouritesButton";
            favouritesButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            resources.ApplyResources(openButton, "openButton");
            openButton.Name = "openButton";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // blackListButton
            // 
            resources.ApplyResources(blackListButton, "blackListButton");
            blackListButton.Name = "blackListButton";
            // 
            // roundedButton1
            // 
            resources.ApplyResources(roundedButton1, "roundedButton1");
            roundedButton1.Name = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // filmsDataGridView
            // 
            filmsDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            filmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, Year, Grade });
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
            filmsDataGridView.Name = "filmsDataGridView";
            filmsDataGridView.CellContentClick += filmsDataGridView_CellContentClick;
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
            // roundedButton2
            // 
            resources.ApplyResources(roundedButton2, "roundedButton2");
            roundedButton2.Name = "roundedButton2";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton3
            // 
            resources.ApplyResources(roundedButton3, "roundedButton3");
            roundedButton3.Name = "roundedButton3";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            resources.ApplyResources(roundedButton4, "roundedButton4");
            roundedButton4.Name = "roundedButton4";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedButton4);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(russianButton);
            Controls.Add(englishButton);
            Controls.Add(secondNicknameLabel);
            Controls.Add(upateButton);
            Controls.Add(filmsDataGridView);
            Controls.Add(roundedButton1);
            Controls.Add(blackListButton);
            Controls.Add(openButton);
            Controls.Add(favouritesButton);
            Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton favouritesButton;
        private RoundedButton openButton;
        private RoundedButton blackListButton;
        private RoundedButton roundedButton1;
        private DataGridView filmsDataGridView;
        private RoundedButton upateButton;
        private Label secondNicknameLabel;
        private RoundedButton englishButton;
        private RoundedButton russianButton;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton4;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
    }
}