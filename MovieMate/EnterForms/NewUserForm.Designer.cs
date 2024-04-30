namespace MovieMate
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            moviesCheckBox1 = new CheckBox();
            moviesCheckBox2 = new CheckBox();
            moviesCheckBox3 = new CheckBox();
            moviesCheckBox4 = new CheckBox();
            pictureBox1 = new PictureBox();
            NameRounded = new RoundedButton();
            roundedButton4 = new RoundedButton();
            pictureButton = new RoundedButton();
            secondEnterButton = new RoundedButton();
            MovieMatePictureBox = new PictureBox();
            PasswordRounded = new RoundedButton();
            NameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordRepeatRounded = new RoundedButton();
            PasswordRepeatTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovieMatePictureBox).BeginInit();
            SuspendLayout();
            // 
            // moviesCheckBox1
            // 
            moviesCheckBox1.AutoSize = true;
            moviesCheckBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox1.Location = new Point(95, 394);
            moviesCheckBox1.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox1.Name = "moviesCheckBox1";
            moviesCheckBox1.Size = new Size(131, 24);
            moviesCheckBox1.TabIndex = 1;
            moviesCheckBox1.Text = "Кунг-фу панда";
            moviesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox2
            // 
            moviesCheckBox2.AutoSize = true;
            moviesCheckBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox2.Location = new Point(281, 394);
            moviesCheckBox2.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox2.Name = "moviesCheckBox2";
            moviesCheckBox2.Size = new Size(61, 24);
            moviesCheckBox2.TabIndex = 2;
            moviesCheckBox2.Text = "Ёлки";
            moviesCheckBox2.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox3
            // 
            moviesCheckBox3.AutoSize = true;
            moviesCheckBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox3.Location = new Point(95, 422);
            moviesCheckBox3.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox3.Name = "moviesCheckBox3";
            moviesCheckBox3.Size = new Size(85, 24);
            moviesCheckBox3.TabIndex = 3;
            moviesCheckBox3.Text = "Форсаж";
            moviesCheckBox3.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox4
            // 
            moviesCheckBox4.AutoSize = true;
            moviesCheckBox4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox4.Location = new Point(281, 422);
            moviesCheckBox4.Margin = new Padding(3, 2, 3, 2);
            moviesCheckBox4.Name = "moviesCheckBox4";
            moviesCheckBox4.Size = new Size(95, 24);
            moviesCheckBox4.TabIndex = 4;
            moviesCheckBox4.Text = "Мстители";
            moviesCheckBox4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(312, 238);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // NameRounded
            // 
            NameRounded.Location = new Point(1, 96);
            NameRounded.Margin = new Padding(3, 2, 3, 2);
            NameRounded.Name = "NameRounded";
            NameRounded.Size = new Size(225, 28);
            NameRounded.TabIndex = 9;
            NameRounded.Text = "Введите имя пользователя:";
            NameRounded.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            roundedButton4.Location = new Point(75, 351);
            roundedButton4.Margin = new Padding(3, 2, 3, 2);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(334, 30);
            roundedButton4.TabIndex = 10;
            roundedButton4.Text = "Выберите фильмы, которые вам нравятся";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // pictureButton
            // 
            pictureButton.Location = new Point(50, 270);
            pictureButton.Margin = new Padding(3, 2, 3, 2);
            pictureButton.Name = "pictureButton";
            pictureButton.Size = new Size(214, 44);
            pictureButton.TabIndex = 11;
            pictureButton.Text = "Выбрать картинку профиля";
            pictureButton.UseVisualStyleBackColor = true;
            pictureButton.Click += pictureButton_Click_1;
            // 
            // secondEnterButton
            // 
            secondEnterButton.Location = new Point(153, 475);
            secondEnterButton.Margin = new Padding(3, 2, 3, 2);
            secondEnterButton.Name = "secondEnterButton";
            secondEnterButton.Size = new Size(172, 29);
            secondEnterButton.TabIndex = 12;
            secondEnterButton.Text = "Войти";
            secondEnterButton.UseVisualStyleBackColor = true;
            secondEnterButton.Click += secondEnterButton_Click_1;
            // 
            // MovieMatePictureBox
            // 
            MovieMatePictureBox.BackgroundImage = (Image)resources.GetObject("MovieMatePictureBox.BackgroundImage");
            MovieMatePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            MovieMatePictureBox.Location = new Point(173, 4);
            MovieMatePictureBox.Name = "MovieMatePictureBox";
            MovieMatePictureBox.Size = new Size(152, 87);
            MovieMatePictureBox.TabIndex = 13;
            MovieMatePictureBox.TabStop = false;
            // 
            // PasswordRounded
            // 
            PasswordRounded.Location = new Point(268, 96);
            PasswordRounded.Margin = new Padding(3, 2, 3, 2);
            PasswordRounded.Name = "PasswordRounded";
            PasswordRounded.Size = new Size(223, 28);
            PasswordRounded.TabIndex = 14;
            PasswordRounded.Text = "Введите имя пользователя:";
            PasswordRounded.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(22, 129);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(191, 23);
            NameTextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(281, 129);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(201, 23);
            PasswordTextBox.TabIndex = 16;
            // 
            // PasswordRepeatRounded
            // 
            PasswordRepeatRounded.Location = new Point(268, 157);
            PasswordRepeatRounded.Margin = new Padding(3, 2, 3, 2);
            PasswordRepeatRounded.Name = "PasswordRepeatRounded";
            PasswordRepeatRounded.Size = new Size(223, 28);
            PasswordRepeatRounded.TabIndex = 17;
            PasswordRepeatRounded.Text = "Введите имя пользователя:";
            PasswordRepeatRounded.UseVisualStyleBackColor = true;
            // 
            // PasswordRepeatTextBox
            // 
            PasswordRepeatTextBox.Location = new Point(281, 190);
            PasswordRepeatTextBox.Name = "PasswordRepeatTextBox";
            PasswordRepeatTextBox.Size = new Size(201, 23);
            PasswordRepeatTextBox.TabIndex = 18;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 519);
            Controls.Add(PasswordRepeatTextBox);
            Controls.Add(PasswordRepeatRounded);
            Controls.Add(PasswordTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(PasswordRounded);
            Controls.Add(MovieMatePictureBox);
            Controls.Add(secondEnterButton);
            Controls.Add(pictureButton);
            Controls.Add(roundedButton4);
            Controls.Add(NameRounded);
            Controls.Add(pictureBox1);
            Controls.Add(moviesCheckBox4);
            Controls.Add(moviesCheckBox3);
            Controls.Add(moviesCheckBox2);
            Controls.Add(moviesCheckBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewUserForm";
            Text = "MovieMate";
            Load += NewUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovieMatePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton secondEnterButton;
        private CheckBox moviesCheckBox1;
        private CheckBox moviesCheckBox2;
        private CheckBox moviesCheckBox3;
        private CheckBox moviesCheckBox4;
        private RoundedButton PasswordRounded;
        private RoundedButton PasswordRepeatRounded;
        private PictureBox pictureBox1;
        private RoundedButton pictureButton;
        private RoundedButton NameRounded;
        private RoundedButton roundedButton4;
        private PictureBox MovieMatePictureBox;
        private TextBox NameTextBox;
        private TextBox PasswordTextBox;
        private TextBox PasswordRepeatTextBox;
    }
}