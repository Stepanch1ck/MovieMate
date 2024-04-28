namespace MovieMate
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newUserButton = new RoundedButton();
            enterButton = new RoundedButton();
            listBox1 = new ListBox();
            nickNameLabel = new Label();
            roundedButton1 = new RoundedButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // newUserButton
            // 
            newUserButton.Location = new Point(322, 322);
            newUserButton.Margin = new Padding(3, 2, 3, 2);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(160, 44);
            newUserButton.TabIndex = 0;
            newUserButton.Text = "Новый пользователь";
            newUserButton.UseVisualStyleBackColor = true;
            newUserButton.Click += newUserButton_Click;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(322, 274);
            enterButton.Margin = new Padding(3, 2, 3, 2);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(160, 44);
            enterButton.TabIndex = 1;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(322, 104);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 139);
            listBox1.TabIndex = 2;
            // 
            // nickNameLabel
            // 
            nickNameLabel.AutoSize = true;
            nickNameLabel.BackColor = SystemColors.ActiveCaptionText;
            nickNameLabel.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nickNameLabel.ForeColor = SystemColors.ButtonHighlight;
            nickNameLabel.Location = new Point(228, 30);
            nickNameLabel.Name = "nickNameLabel";
            nickNameLabel.Size = new Size(178, 47);
            nickNameLabel.TabIndex = 3;
            nickNameLabel.Text = "Nickname";
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(190, 30);
            roundedButton1.Margin = new Padding(3, 2, 3, 2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(260, 62);
            roundedButton1.TabIndex = 4;
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 411);
            Controls.Add(nickNameLabel);
            Controls.Add(roundedButton1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(enterButton);
            Controls.Add(newUserButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton newUserButton;
        private RoundedButton enterButton;
        private ListBox listBox1;
        private Label nickNameLabel;
        private RoundedButton roundedButton1;
        private PictureBox pictureBox1;
    }
}
