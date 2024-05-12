namespace MovieMate
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            userImage = new PictureBox();
            nameLabel = new Label();
            label2 = new Label();
            accountTypeLabel = new Label();
            UserNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.BackColor = Color.DarkGray;
            resources.ApplyResources(userImage, "userImage");
            userImage.Name = "userImage";
            userImage.TabStop = false;
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // accountTypeLabel
            // 
            resources.ApplyResources(accountTypeLabel, "accountTypeLabel");
            accountTypeLabel.Name = "accountTypeLabel";
            // 
            // UserNameTextBox
            // 
            resources.ApplyResources(UserNameTextBox, "UserNameTextBox");
            UserNameTextBox.Name = "UserNameTextBox";
            // 
            // EmailTextBox
            // 
            resources.ApplyResources(EmailTextBox, "EmailTextBox");
            EmailTextBox.Name = "EmailTextBox";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // UserInfo
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(EmailTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(accountTypeLabel);
            Controls.Add(label2);
            Controls.Add(nameLabel);
            Controls.Add(userImage);
            Name = "UserInfo";
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userImage;
        private Label nameLabel;
        private Label label2;
        private Label accountTypeLabel;
        private TextBox UserNameTextBox;
        private TextBox EmailTextBox;
        private TextBox textBox3;
        private PictureBox pictureBox1;
    }
}