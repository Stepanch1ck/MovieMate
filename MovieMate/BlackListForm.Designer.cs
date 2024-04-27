namespace MovieMate
{
    partial class BlackListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackListForm));
            roundedButton1 = new RoundedButton();
            BlackListDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            blackListOpenButton = new RoundedButton();
            deleteFromBlackListButton = new RoundedButton();
            favouritesListButton = new Button();
            button2 = new Button();
            mainMenuButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(258, 95);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(490, 302);
            roundedButton1.TabIndex = 0;
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // BlackListDataGridView
            // 
            BlackListDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            BlackListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BlackListDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, year, grade });
            BlackListDataGridView.Location = new Point(302, 127);
            BlackListDataGridView.Name = "BlackListDataGridView";
            BlackListDataGridView.RowHeadersWidth = 51;
            BlackListDataGridView.Size = new Size(429, 228);
            BlackListDataGridView.TabIndex = 1;
            // 
            // filmName
            // 
            filmName.HeaderText = "Название";
            filmName.MinimumWidth = 6;
            filmName.Name = "filmName";
            filmName.Width = 125;
            // 
            // year
            // 
            year.HeaderText = "Год";
            year.MinimumWidth = 6;
            year.Name = "year";
            year.Width = 125;
            // 
            // grade
            // 
            grade.HeaderText = "Рейтинг";
            grade.MinimumWidth = 6;
            grade.Name = "grade";
            grade.Width = 125;
            // 
            // blackListOpenButton
            // 
            blackListOpenButton.Location = new Point(448, 29);
            blackListOpenButton.Name = "blackListOpenButton";
            blackListOpenButton.Size = new Size(134, 50);
            blackListOpenButton.TabIndex = 2;
            blackListOpenButton.Text = "Открыть";
            blackListOpenButton.UseVisualStyleBackColor = true;
            // 
            // deleteFromBlackListButton
            // 
            deleteFromBlackListButton.Location = new Point(614, 29);
            deleteFromBlackListButton.Name = "deleteFromBlackListButton";
            deleteFromBlackListButton.Size = new Size(134, 50);
            deleteFromBlackListButton.TabIndex = 3;
            deleteFromBlackListButton.Text = "Удалить из чёрного списка";
            deleteFromBlackListButton.UseVisualStyleBackColor = true;
            // 
            // favouritesListButton
            // 
            favouritesListButton.BackgroundImage = (Image)resources.GetObject("favouritesListButton.BackgroundImage");
            favouritesListButton.Location = new Point(12, 148);
            favouritesListButton.Name = "favouritesListButton";
            favouritesListButton.Size = new Size(68, 68);
            favouritesListButton.TabIndex = 4;
            favouritesListButton.UseVisualStyleBackColor = true;
            favouritesListButton.Click += favouritesListButton_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(12, 296);
            button2.Name = "button2";
            button2.Size = new Size(68, 68);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // mainMenuButton
            // 
            mainMenuButton.BackgroundImage = (Image)resources.GetObject("mainMenuButton.BackgroundImage");
            mainMenuButton.Location = new Point(12, 222);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(68, 68);
            mainMenuButton.TabIndex = 6;
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += mainMenuButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 74);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // BlackListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(mainMenuButton);
            Controls.Add(button2);
            Controls.Add(favouritesListButton);
            Controls.Add(deleteFromBlackListButton);
            Controls.Add(blackListOpenButton);
            Controls.Add(BlackListDataGridView);
            Controls.Add(roundedButton1);
            Name = "BlackListForm";
            Text = "BlackListForm";
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton roundedButton1;
        private DataGridView BlackListDataGridView;
        private RoundedButton blackListOpenButton;
        private RoundedButton deleteFromBlackListButton;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn grade;
        private Button favouritesListButton;
        private Button button2;
        private Button mainMenuButton;
        private PictureBox pictureBox1;
    }
}