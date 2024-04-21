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
            upateButton = new RoundedButton();
            secondNicknameLabel = new Label();
            languageComboBox = new ComboBox();
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
            resources.ApplyResources(filmsDataGridView, "filmsDataGridView");
            filmsDataGridView.Name = "filmsDataGridView";
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
            // languageComboBox
            // 
            languageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            languageComboBox.FormattingEnabled = true;
            resources.ApplyResources(languageComboBox, "languageComboBox");
            languageComboBox.Name = "languageComboBox";
            languageComboBox.SelectedIndexChanged += languageComboBox_SelectedIndexChanged;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(languageComboBox);
            Controls.Add(secondNicknameLabel);
            Controls.Add(upateButton);
            Controls.Add(filmsDataGridView);
            Controls.Add(roundedButton1);
            Controls.Add(blackListButton);
            Controls.Add(openButton);
            Controls.Add(favouritesButton);
            Name = "MainMenu";
            Load += MainMenu_Load;
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
        private ComboBox languageComboBox;
    }
}