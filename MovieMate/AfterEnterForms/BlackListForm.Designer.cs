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
            BlackListDataGridView = new DataGridView();
            filmName = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            RecomendationButton = new Button();
            BlackListButton = new Button();
            FavoriteListButton = new Button();
            pictureBox1 = new PictureBox();
            deleteBlackList = new Button();
            openButton = new Button();
            blacklistLabel = new Label();
            CompilationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BlackListDataGridView
            // 
            resources.ApplyResources(BlackListDataGridView, "BlackListDataGridView");
            BlackListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BlackListDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            BlackListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BlackListDataGridView.Columns.AddRange(new DataGridViewColumn[] { filmName, year, grade });
            BlackListDataGridView.Name = "BlackListDataGridView";
            BlackListDataGridView.CellDoubleClick += filmsDataGridView_CellDoubleClick;
            // 
            // filmName
            // 
            resources.ApplyResources(filmName, "filmName");
            filmName.Name = "filmName";
            // 
            // year
            // 
            resources.ApplyResources(year, "year");
            year.Name = "year";
            // 
            // grade
            // 
            resources.ApplyResources(grade, "grade");
            grade.Name = "grade";
            // 
            // RecomendationButton
            // 
            resources.ApplyResources(RecomendationButton, "RecomendationButton");
            RecomendationButton.Name = "RecomendationButton";
            RecomendationButton.UseVisualStyleBackColor = true;
            RecomendationButton.Click += button1_Click;
            // 
            // BlackListButton
            // 
            resources.ApplyResources(BlackListButton, "BlackListButton");
            BlackListButton.Name = "BlackListButton";
            BlackListButton.UseVisualStyleBackColor = true;
            // 
            // FavoriteListButton
            // 
            resources.ApplyResources(FavoriteListButton, "FavoriteListButton");
            FavoriteListButton.Name = "FavoriteListButton";
            FavoriteListButton.UseVisualStyleBackColor = true;
            FavoriteListButton.Click += button3_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // deleteBlackList
            // 
            resources.ApplyResources(deleteBlackList, "deleteBlackList");
            deleteBlackList.BackColor = Color.Black;
            deleteBlackList.ForeColor = Color.White;
            deleteBlackList.Name = "deleteBlackList";
            deleteBlackList.UseVisualStyleBackColor = false;
            deleteBlackList.Click += deleteBlackList_Click;
            // 
            // openButton
            // 
            resources.ApplyResources(openButton, "openButton");
            openButton.BackColor = Color.Black;
            openButton.ForeColor = Color.White;
            openButton.Name = "openButton";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // blacklistLabel
            // 
            resources.ApplyResources(blacklistLabel, "blacklistLabel");
            blacklistLabel.BackColor = Color.Black;
            blacklistLabel.ForeColor = Color.White;
            blacklistLabel.Name = "blacklistLabel";
            // 
            // CompilationButton
            // 
            resources.ApplyResources(CompilationButton, "CompilationButton");
            CompilationButton.Name = "CompilationButton";
            CompilationButton.UseVisualStyleBackColor = true;
            CompilationButton.Click += generalCompilationButton_Click;
            // 
            // BlackListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CompilationButton);
            Controls.Add(blacklistLabel);
            Controls.Add(openButton);
            Controls.Add(deleteBlackList);
            Controls.Add(pictureBox1);
            Controls.Add(FavoriteListButton);
            Controls.Add(BlackListButton);
            Controls.Add(RecomendationButton);
            Controls.Add(BlackListDataGridView);
            Name = "BlackListForm";
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView BlackListDataGridView;
        private Button RecomendationButton;
        private Button BlackListButton;
        private Button FavoriteListButton;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn filmName;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn grade;
        private Button deleteBlackList;
        private Button openButton;
        private Label blacklistLabel;
        private Button CompilationButton;
    }
}