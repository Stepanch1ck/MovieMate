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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.VK_LOGO;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.BackColor = Color.Black;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Name = "passwordLabel";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(phoneNumberLabel, "phoneNumberLabel");
            phoneNumberLabel.BackColor = Color.Black;
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // VKLoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}