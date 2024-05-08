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
            pictureBox1.Image = Properties.Resources.VK_LOGO;
            pictureBox1.Location = new Point(125, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.Black;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(65, 240);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(254, 32);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Enter the password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.BackColor = Color.Black;
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(65, 149);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(254, 32);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Enter the phone number:";
            phoneNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(140, 334);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // VKLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(phoneNumberLabel);
            Controls.Add(passwordLabel);
            Controls.Add(pictureBox1);
            Name = "VKLoginForm";
            Text = "VKLoginForm";
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