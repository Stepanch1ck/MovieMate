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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            resources.ApplyResources(roundedButton1, "roundedButton1");
            roundedButton1.Name = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // BlackListDataGridView
            // 
            resources.ApplyResources(BlackListDataGridView, "BlackListDataGridView");
            BlackListDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
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
            // blackListOpenButton
            // 
            resources.ApplyResources(blackListOpenButton, "blackListOpenButton");
            blackListOpenButton.Name = "blackListOpenButton";
            blackListOpenButton.UseVisualStyleBackColor = true;
            blackListOpenButton.Click += blackListOpenButton_Click;
            // 
            // deleteFromBlackListButton
            // 
            resources.ApplyResources(deleteFromBlackListButton, "deleteFromBlackListButton");
            deleteFromBlackListButton.Name = "deleteFromBlackListButton";
            deleteFromBlackListButton.UseVisualStyleBackColor = true;
            deleteFromBlackListButton.Click += deleteFromBlackListButton_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // BlackListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deleteFromBlackListButton);
            Controls.Add(blackListOpenButton);
            Controls.Add(BlackListDataGridView);
            Controls.Add(roundedButton1);
            Name = "BlackListForm";
            Load += BlackListForm_Load_1;
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
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}