namespace MovieMate.EnterForms
{
    partial class VKLogFilmsChoice
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
            filmSelectLabel = new Label();
            moviesCheckBox1 = new CheckBox();
            moviesCheckBox3 = new CheckBox();
            moviesCheckBox2 = new CheckBox();
            moviesCheckBox4 = new CheckBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // filmSelectLabel
            // 
            filmSelectLabel.BackColor = SystemColors.ActiveCaptionText;
            filmSelectLabel.ForeColor = Color.White;
            filmSelectLabel.ImeMode = ImeMode.NoControl;
            filmSelectLabel.Location = new Point(1, -2);
            filmSelectLabel.Name = "filmSelectLabel";
            filmSelectLabel.Size = new Size(305, 31);
            filmSelectLabel.TabIndex = 16;
            filmSelectLabel.Text = "Выберите фильмы, которые вам нравятся:";
            filmSelectLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moviesCheckBox1
            // 
            moviesCheckBox1.AutoSize = true;
            moviesCheckBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            moviesCheckBox1.ImeMode = ImeMode.NoControl;
            moviesCheckBox1.Location = new Point(12, 43);
            moviesCheckBox1.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox1.Name = "moviesCheckBox1";
            moviesCheckBox1.Size = new Size(131, 24);
            moviesCheckBox1.TabIndex = 17;
            moviesCheckBox1.Text = "Кунг-фу панда";
            moviesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox3
            // 
            moviesCheckBox3.AutoSize = true;
            moviesCheckBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            moviesCheckBox3.ImeMode = ImeMode.NoControl;
            moviesCheckBox3.Location = new Point(178, 43);
            moviesCheckBox3.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox3.Name = "moviesCheckBox3";
            moviesCheckBox3.Size = new Size(85, 24);
            moviesCheckBox3.TabIndex = 18;
            moviesCheckBox3.Text = "Форсаж";
            moviesCheckBox3.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox2
            // 
            moviesCheckBox2.AutoSize = true;
            moviesCheckBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            moviesCheckBox2.ImeMode = ImeMode.NoControl;
            moviesCheckBox2.Location = new Point(12, 71);
            moviesCheckBox2.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox2.Name = "moviesCheckBox2";
            moviesCheckBox2.Size = new Size(61, 24);
            moviesCheckBox2.TabIndex = 19;
            moviesCheckBox2.Text = "Ёлки";
            moviesCheckBox2.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox4
            // 
            moviesCheckBox4.AutoSize = true;
            moviesCheckBox4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            moviesCheckBox4.ImeMode = ImeMode.NoControl;
            moviesCheckBox4.Location = new Point(178, 71);
            moviesCheckBox4.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox4.Name = "moviesCheckBox4";
            moviesCheckBox4.Size = new Size(95, 24);
            moviesCheckBox4.TabIndex = 20;
            moviesCheckBox4.Text = "Мстители";
            moviesCheckBox4.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.Black;
            loginButton.ForeColor = Color.White;
            loginButton.ImeMode = ImeMode.NoControl;
            loginButton.Location = new Point(86, 115);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(119, 38);
            loginButton.TabIndex = 21;
            loginButton.Text = "Продолжить";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // VKLogFilmsChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 164);
            Controls.Add(loginButton);
            Controls.Add(moviesCheckBox4);
            Controls.Add(moviesCheckBox2);
            Controls.Add(moviesCheckBox3);
            Controls.Add(moviesCheckBox1);
            Controls.Add(filmSelectLabel);
            Name = "VKLogFilmsChoice";
            Text = "VKLogFilmsChoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label filmSelectLabel;
        private CheckBox moviesCheckBox1;
        private CheckBox moviesCheckBox3;
        private CheckBox moviesCheckBox2;
        private CheckBox moviesCheckBox4;
        private Button loginButton;
    }
}