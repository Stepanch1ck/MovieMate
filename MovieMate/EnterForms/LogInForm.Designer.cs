namespace MovieMate.EnterForms
{
    partial class LogInForm
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
            roundedButton = new RoundedButton();
            NickNameLabel = new Label();
            PasswordRounded = new RoundedButton();
            PasswordTextBox = new TextBox();
            EnterButton = new RoundedButton();
            SuspendLayout();
            // 
            // roundedButton
            // 
            roundedButton.Location = new Point(12, 11);
            roundedButton.Margin = new Padding(3, 2, 3, 2);
            roundedButton.Name = "roundedButton";
            roundedButton.Size = new Size(260, 62);
            roundedButton.TabIndex = 5;
            roundedButton.UseVisualStyleBackColor = true;
            // 
            // NickNameLabel
            // 
            NickNameLabel.AutoSize = true;
            NickNameLabel.BackColor = SystemColors.ActiveCaptionText;
            NickNameLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NickNameLabel.ForeColor = SystemColors.ButtonHighlight;
            NickNameLabel.Location = new Point(85, 23);
            NickNameLabel.Name = "NickNameLabel";
            NickNameLabel.Size = new Size(110, 30);
            NickNameLabel.TabIndex = 6;
            NickNameLabel.Text = "NickName";
            // 
            // PasswordRounded
            // 
            PasswordRounded.Location = new Point(29, 91);
            PasswordRounded.Margin = new Padding(3, 2, 3, 2);
            PasswordRounded.Name = "PasswordRounded";
            PasswordRounded.Size = new Size(223, 28);
            PasswordRounded.TabIndex = 15;
            PasswordRounded.Text = "Введите пароль:";
            PasswordRounded.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(29, 146);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(223, 23);
            PasswordTextBox.TabIndex = 17;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(54, 198);
            EnterButton.Margin = new Padding(3, 2, 3, 2);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(172, 29);
            EnterButton.TabIndex = 18;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 283);
            Controls.Add(EnterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordRounded);
            Controls.Add(NickNameLabel);
            Controls.Add(roundedButton);
            Name = "LogInForm";
            Text = "LogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton roundedButton;
        private Label NickNameLabel;
        private RoundedButton PasswordRounded;
        private TextBox PasswordTextBox;
        private RoundedButton EnterButton;
    }
}