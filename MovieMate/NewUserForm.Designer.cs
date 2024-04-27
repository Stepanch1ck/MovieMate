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
            secondEnterButton = new RoundedButton();
            moviesCheckBox1 = new CheckBox();
            moviesCheckBox2 = new CheckBox();
            moviesCheckBox3 = new CheckBox();
            moviesCheckBox4 = new CheckBox();
            richTextBox1 = new RichTextBox();
            roundedButton1 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            pictureBox1 = new PictureBox();
            pictureButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // secondEnterButton
            // 
            secondEnterButton.Location = new Point(100, 456);
            secondEnterButton.Name = "secondEnterButton";
            secondEnterButton.Size = new Size(183, 59);
            secondEnterButton.TabIndex = 0;
            secondEnterButton.Text = "Войти";
            secondEnterButton.UseVisualStyleBackColor = true;
            secondEnterButton.Click += secondEnterButton_Click;
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
            //richTextBox1
            //
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 103);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(382, 39);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // roundedButton1
            // 
            roundedButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(0, 32);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(382, 55);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "Введите имя пользователя:";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            roundedButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roundedButton2.Location = new Point(0, 255);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(382, 55);
            roundedButton2.TabIndex = 7;
            roundedButton2.Text = "  Выберите фильмы, \r\nкоторые вам нравятся";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(12, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 101);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureButton
            // 
            pictureButton.Location = new Point(156, 195);
            pictureButton.Name = "pictureButton";
            pictureButton.Size = new Size(217, 54);
            pictureButton.TabIndex = 9;
            pictureButton.Text = "Выбрать \r\nкартинку профиля";
            pictureButton.UseVisualStyleBackColor = true;
            pictureButton.Click += pictureButton_Click;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 527);
            Controls.Add(pictureButton);
            Controls.Add(pictureBox1);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(richTextBox1);
            Controls.Add(moviesCheckBox4);
            Controls.Add(moviesCheckBox3);
            Controls.Add(moviesCheckBox2);
            Controls.Add(moviesCheckBox1);
            Controls.Add(secondEnterButton);
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
    }
}