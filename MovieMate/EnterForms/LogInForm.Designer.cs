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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            roundedButton = new RoundedButton();
            NickNameLabel = new Label();
            PasswordRounded = new RoundedButton();
            PasswordTextBox = new TextBox();
            EnterButton = new RoundedButton();
            SuspendLayout();
            // 
            // roundedButton
            // 
            resources.ApplyResources(roundedButton, "roundedButton");
            roundedButton.Name = "roundedButton";
            roundedButton.UseVisualStyleBackColor = true;
            // 
            // NickNameLabel
            // 
            resources.ApplyResources(NickNameLabel, "NickNameLabel");
            NickNameLabel.BackColor = SystemColors.ActiveCaptionText;
            NickNameLabel.ForeColor = SystemColors.ButtonHighlight;
            NickNameLabel.Name = "NickNameLabel";
            // 
            // PasswordRounded
            // 
            resources.ApplyResources(PasswordRounded, "PasswordRounded");
            PasswordRounded.Name = "PasswordRounded";
            PasswordRounded.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.Name = "PasswordTextBox";
            // 
            // EnterButton
            // 
            resources.ApplyResources(EnterButton, "EnterButton");
            EnterButton.Name = "EnterButton";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // LogInForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordRounded);
            Controls.Add(NickNameLabel);
            Controls.Add(roundedButton);
            Name = "LogInForm";
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