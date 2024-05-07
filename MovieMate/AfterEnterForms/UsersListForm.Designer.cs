namespace MovieMate
{
    partial class UsersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListForm));
            button1 = new Button();
            FavouritesDataGridView = new DataGridView();
            menuLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // FavouritesDataGridView
            // 
            resources.ApplyResources(FavouritesDataGridView, "FavouritesDataGridView");
            FavouritesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FavouritesDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            FavouritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesDataGridView.Name = "FavouritesDataGridView";
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // UsersListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(menuLabel);
            Controls.Add(FavouritesDataGridView);
            Controls.Add(button1);
            Name = "UsersListForm";
            ((System.ComponentModel.ISupportInitialize)FavouritesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView FavouritesDataGridView;
        private Label menuLabel;
    }
}