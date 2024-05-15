namespace MovieMate
{
    partial class VKLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VKLoginForm));
            pictureBox1 = new PictureBox();
            passwordLabel = new Label();
            phoneNumberLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            VKLoginbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.VK_LOGO;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.Black;
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Name = "passwordLabel";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.BackColor = Color.Black;
            resources.ApplyResources(phoneNumberLabel, "phoneNumberLabel");
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // LoginTextBox
            // 
            resources.ApplyResources(LoginTextBox, "LoginTextBox");
            LoginTextBox.Name = "LoginTextBox";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.Name = "PasswordTextBox";
            // 
            // VKLoginbutton
            // 
            VKLoginbutton.BackColor = Color.Black;
            VKLoginbutton.ForeColor = Color.White;
            resources.ApplyResources(VKLoginbutton, "VKLoginbutton");
            VKLoginbutton.Name = "VKLoginbutton";
            VKLoginbutton.UseVisualStyleBackColor = false;
            VKLoginbutton.Click += VKLoginbutton_Click;
            // 
            // VKLoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(VKLoginbutton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(passwordLabel);
            Controls.Add(pictureBox1);
            Name = "VKLoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label passwordLabel;
        private Label phoneNumberLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button VKLoginbutton;
    }
}