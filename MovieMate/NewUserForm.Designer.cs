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
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            roundedButton3 = new RoundedButton();
            roundedButton4 = new RoundedButton();
            pictureButton = new RoundedButton();
            secondEnterButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // moviesCheckBox1
            // 
            moviesCheckBox1.AutoSize = true;
            moviesCheckBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox1.Location = new Point(41, 316);
            moviesCheckBox1.Name = "moviesCheckBox1";
            moviesCheckBox1.Size = new Size(155, 29);
            moviesCheckBox1.TabIndex = 1;
            moviesCheckBox1.Text = "Кунг-фу панда";
            moviesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox2
            // 
            moviesCheckBox2.AutoSize = true;
            moviesCheckBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox2.Location = new Point(41, 351);
            moviesCheckBox2.Name = "moviesCheckBox2";
            moviesCheckBox2.Size = new Size(73, 29);
            moviesCheckBox2.TabIndex = 2;
            moviesCheckBox2.Text = "Ёлки";
            moviesCheckBox2.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox3
            // 
            moviesCheckBox3.AutoSize = true;
            moviesCheckBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox3.Location = new Point(41, 386);
            moviesCheckBox3.Name = "moviesCheckBox3";
            moviesCheckBox3.Size = new Size(101, 29);
            moviesCheckBox3.TabIndex = 3;
            moviesCheckBox3.Text = "Форсаж";
            moviesCheckBox3.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox4
            // 
            moviesCheckBox4.AutoSize = true;
            moviesCheckBox4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox4.Location = new Point(41, 421);
            moviesCheckBox4.Name = "moviesCheckBox4";
            moviesCheckBox4.Size = new Size(117, 29);
            moviesCheckBox4.TabIndex = 4;
            moviesCheckBox4.Text = "Мстители";
            moviesCheckBox4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 103);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(382, 39);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(12, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // roundedButton3
            // 
            roundedButton3.Location = new Point(0, 26);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(382, 71);
            roundedButton3.TabIndex = 9;
            roundedButton3.Text = "Введите имя пользователя:";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            roundedButton4.Location = new Point(0, 255);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(382, 55);
            roundedButton4.TabIndex = 10;
            roundedButton4.Text = "Выберите фильмы, которые вам нравятся";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // pictureButton
            // 
            pictureButton.Location = new Point(138, 192);
            pictureButton.Name = "pictureButton";
            pictureButton.Size = new Size(244, 57);
            pictureButton.TabIndex = 11;
            pictureButton.Text = "Выбрать картинку профиля";
            pictureButton.UseVisualStyleBackColor = true;
            pictureButton.Click += pictureButton_Click_1;
            // 
            // secondEnterButton
            // 
            secondEnterButton.Location = new Point(91, 456);
            secondEnterButton.Name = "secondEnterButton";
            secondEnterButton.Size = new Size(196, 59);
            secondEnterButton.TabIndex = 12;
            secondEnterButton.Text = "Войти";
            secondEnterButton.UseVisualStyleBackColor = true;
            secondEnterButton.Click += secondEnterButton_Click_1;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 527);
            Controls.Add(secondEnterButton);
            Controls.Add(pictureButton);
            Controls.Add(roundedButton4);
            Controls.Add(roundedButton3);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(moviesCheckBox4);
            Controls.Add(moviesCheckBox3);
            Controls.Add(moviesCheckBox2);
            Controls.Add(moviesCheckBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewUserForm";
            Text = "MovieMate";
            Load += NewUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton secondEnterButton;
        private CheckBox moviesCheckBox1;
        private CheckBox moviesCheckBox2;
        private CheckBox moviesCheckBox3;
        private CheckBox moviesCheckBox4;
        private RichTextBox richTextBox1;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private PictureBox pictureBox1;
        private RoundedButton pictureButton;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton4;
        
    }
}