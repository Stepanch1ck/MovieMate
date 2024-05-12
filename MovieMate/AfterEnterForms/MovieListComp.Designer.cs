namespace MovieMate.AfterEnterForms
{
    partial class MovieListComp
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
            menuLabel = new Label();
            MovieListBox = new ListBox();
            AddMovieButton = new Button();
            deleteMovieButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            menuLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuLabel.BackColor = Color.Black;
            menuLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.White;
            menuLabel.ImeMode = ImeMode.NoControl;
            menuLabel.Location = new Point(-1, -2);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(287, 49);
            menuLabel.TabIndex = 33;
            menuLabel.Text = "Список фильмов";
            menuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Location = new Point(12, 50);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(261, 139);
            MovieListBox.TabIndex = 34;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // AddMovieButton
            // 
            AddMovieButton.Location = new Point(24, 205);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(107, 53);
            AddMovieButton.TabIndex = 35;
            AddMovieButton.Text = "Добавить новый фильм";
            AddMovieButton.UseVisualStyleBackColor = true;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // deleteMovieButton
            // 
            deleteMovieButton.Location = new Point(157, 205);
            deleteMovieButton.Name = "deleteMovieButton";
            deleteMovieButton.Size = new Size(97, 53);
            deleteMovieButton.TabIndex = 36;
            deleteMovieButton.Text = "Удалить из текущих";
            deleteMovieButton.UseVisualStyleBackColor = true;
            deleteMovieButton.Click += deleteMovieButton_Click;
            // 
            // MovieListComp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 279);
            Controls.Add(deleteMovieButton);
            Controls.Add(AddMovieButton);
            Controls.Add(MovieListBox);
            Controls.Add(menuLabel);
            Name = "MovieListComp";
            Text = "MovieListComp";
            ResumeLayout(false);
        }

        #endregion

        private Label menuLabel;
        private ListBox MovieListBox;
        private Button AddMovieButton;
        private Button deleteMovieButton;
    }
}