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
            englishButton = new RoundedButton();
            russianButton = new RoundedButton();
            upateButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // favouritesButton
            // 
            favouritesButton.Location = new Point(419, 61);
            favouritesButton.Name = "favouritesButton";
            favouritesButton.Size = new Size(132, 43);
            favouritesButton.TabIndex = 0;
            favouritesButton.Text = "Добавить в избранное";
            favouritesButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            openButton.Location = new Point(281, 61);
            openButton.Name = "openButton";
            openButton.Size = new Size(132, 43);
            openButton.TabIndex = 1;
            openButton.Text = "Открыть";
            openButton.UseVisualStyleBackColor = true;
            // 
            // blackListButton
            // 
            blackListButton.Location = new Point(557, 61);
            blackListButton.Name = "blackListButton";
            blackListButton.Size = new Size(132, 43);
            blackListButton.TabIndex = 2;
            blackListButton.Text = "Добавить в чёрный список";
            blackListButton.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(172, 121);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(592, 269);
            roundedButton1.TabIndex = 3;
            roundedButton1.Text = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // filmsDataGridView
            // 
            filmsDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            filmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmsDataGridView.Location = new Point(197, 133);
            filmsDataGridView.Name = "filmsDataGridView";
            filmsDataGridView.RowHeadersWidth = 51;
            filmsDataGridView.Size = new Size(537, 240);
            filmsDataGridView.TabIndex = 4;
            // 
            // englishButton
            // 
            englishButton.Location = new Point(670, 396);
            englishButton.Name = "englishButton";
            englishButton.Size = new Size(94, 42);
            englishButton.TabIndex = 5;
            englishButton.Text = "English";
            englishButton.UseVisualStyleBackColor = true;
            // 
            // russianButton
            // 
            russianButton.Location = new Point(570, 396);
            russianButton.Name = "russianButton";
            russianButton.Size = new Size(94, 42);
            russianButton.TabIndex = 6;
            russianButton.Text = "Русский";
            russianButton.UseVisualStyleBackColor = true;
            // 
            // upateButton
            // 
            upateButton.Image = (Image)resources.GetObject("upateButton.Image");
            upateButton.Location = new Point(729, 57);
            upateButton.Name = "upateButton";
            upateButton.Size = new Size(59, 50);
            upateButton.TabIndex = 7;
            upateButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(upateButton);
            Controls.Add(russianButton);
            Controls.Add(englishButton);
            Controls.Add(filmsDataGridView);
            Controls.Add(roundedButton1);
            Controls.Add(blackListButton);
            Controls.Add(openButton);
            Controls.Add(favouritesButton);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)filmsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton favouritesButton;
        private RoundedButton openButton;
        private RoundedButton blackListButton;
        private RoundedButton roundedButton1;
        private DataGridView filmsDataGridView;
        private RoundedButton englishButton;
        private RoundedButton russianButton;
        private RoundedButton upateButton;
    }
}