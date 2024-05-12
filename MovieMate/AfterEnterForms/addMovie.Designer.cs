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
            menuLabel = new Label();
            MovieListBox = new ListBox();
            movieAddButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            menuLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuLabel.BackColor = Color.Black;
            menuLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.White;
            menuLabel.ImeMode = ImeMode.NoControl;
            menuLabel.Location = new Point(-2, -6);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(267, 49);
            menuLabel.TabIndex = 32;
            menuLabel.Text = "Добавление фильма";
            menuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Location = new Point(12, 56);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(239, 124);
            MovieListBox.TabIndex = 33;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // movieAddButton
            // 
            movieAddButton.Location = new Point(92, 218);
            movieAddButton.Name = "movieAddButton";
            movieAddButton.Size = new Size(75, 23);
            movieAddButton.TabIndex = 34;
            movieAddButton.Text = "Добавить";
            movieAddButton.UseVisualStyleBackColor = true;
            movieAddButton.Click += movieAddButton_Click;
            // 
            // addMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 274);
            Controls.Add(movieAddButton);
            Controls.Add(MovieListBox);
            Controls.Add(menuLabel);
            Name = "addMovie";
            Text = "addMovie";
            ResumeLayout(false);
        }

        #endregion

        private Label menuLabel;
        private ListBox MovieListBox;
        private Button movieAddButton;
    }
}