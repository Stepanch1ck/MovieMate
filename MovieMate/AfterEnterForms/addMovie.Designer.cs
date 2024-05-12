namespace MovieMate.AfterEnterForms
{
    partial class addMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMovie));
            menuLabel = new Label();
            MovieListBox = new ListBox();
            movieAddButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // MovieListBox
            // 
            resources.ApplyResources(MovieListBox, "MovieListBox");
            MovieListBox.FormattingEnabled = true;
            MovieListBox.Name = "MovieListBox";
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // movieAddButton
            // 
            resources.ApplyResources(movieAddButton, "movieAddButton");
            movieAddButton.Name = "movieAddButton";
            movieAddButton.UseVisualStyleBackColor = true;
            movieAddButton.Click += movieAddButton_Click;
            // 
            // addMovie
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(movieAddButton);
            Controls.Add(MovieListBox);
            Controls.Add(menuLabel);
            Name = "addMovie";
            ResumeLayout(false);
        }

        #endregion

        private Label menuLabel;
        private ListBox MovieListBox;
        private Button movieAddButton;
    }
}