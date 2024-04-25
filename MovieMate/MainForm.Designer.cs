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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            newUserButton = new RoundedButton();
            enterButton = new RoundedButton();
            listBox1 = new ListBox();
            nickNameLabel = new Label();
            roundedButton1 = new RoundedButton();
            SuspendLayout();
            // 
            // newUserButton
            // 
            newUserButton.Location = new Point(552, 379);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(183, 59);
            newUserButton.TabIndex = 0;
            newUserButton.Text = "Новый пользователь";
            newUserButton.UseVisualStyleBackColor = true;
            newUserButton.Click += newUserButton_Click;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(552, 308);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(183, 59);
            enterButton.TabIndex = 1;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(486, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 184);
            listBox1.TabIndex = 2;
            // 
            // nickNameLabel
            // 
            nickNameLabel.AutoSize = true;
            nickNameLabel.BackColor = SystemColors.ActiveCaptionText;
            nickNameLabel.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nickNameLabel.ForeColor = SystemColors.ButtonHighlight;
            nickNameLabel.Location = new Point(475, 23);
            nickNameLabel.Name = "nickNameLabel";
            nickNameLabel.Size = new Size(226, 60);
            nickNameLabel.TabIndex = 3;
            nickNameLabel.Text = "Nickname";
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(438, 12);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(297, 83);
            roundedButton1.TabIndex = 4;
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nickNameLabel);
            Controls.Add(roundedButton1);
            Controls.Add(listBox1);
            Controls.Add(enterButton);
            Controls.Add(newUserButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MovieMate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton newUserButton;
        private RoundedButton enterButton;
        private ListBox listBox1;
        private Label nickNameLabel;
        private RoundedButton roundedButton1;
    }
}
