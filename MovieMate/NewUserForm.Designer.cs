﻿namespace MovieMate
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
            nameLabel = new Label();
            pictureSelectButton = new Button();
            filmSelectLabel = new Label();
            pictureBox2 = new PictureBox();
            loginVKLabel = new Label();
            loginButton = new Button();
            passwordLabel = new Label();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            richTextBox3 = new RichTextBox();
            emailLabel = new Label();
            emailRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // moviesCheckBox1
            // 
            resources.ApplyResources(moviesCheckBox1, "moviesCheckBox1");
            moviesCheckBox1.Name = "moviesCheckBox1";
            moviesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox2
            // 
            resources.ApplyResources(moviesCheckBox2, "moviesCheckBox2");
            moviesCheckBox2.Name = "moviesCheckBox2";
            moviesCheckBox2.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox3
            // 
            resources.ApplyResources(moviesCheckBox3, "moviesCheckBox3");
            moviesCheckBox3.Name = "moviesCheckBox3";
            moviesCheckBox3.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox4
            // 
            resources.ApplyResources(moviesCheckBox4, "moviesCheckBox4");
            moviesCheckBox4.Name = "moviesCheckBox4";
            moviesCheckBox4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.BackColor = SystemColors.ActiveCaptionText;
            nameLabel.ForeColor = Color.White;
            nameLabel.Name = "nameLabel";
            // 
            // pictureSelectButton
            // 
            resources.ApplyResources(pictureSelectButton, "pictureSelectButton");
            pictureSelectButton.BackColor = Color.Black;
            pictureSelectButton.ForeColor = Color.White;
            pictureSelectButton.Name = "pictureSelectButton";
            pictureSelectButton.UseVisualStyleBackColor = false;
            pictureSelectButton.Click += pictureSelectButton_Click;
            // 
            // filmSelectLabel
            // 
            resources.ApplyResources(filmSelectLabel, "filmSelectLabel");
            filmSelectLabel.BackColor = SystemColors.ActiveCaptionText;
            filmSelectLabel.ForeColor = Color.White;
            filmSelectLabel.Name = "filmSelectLabel";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // loginVKLabel
            // 
            resources.ApplyResources(loginVKLabel, "loginVKLabel");
            loginVKLabel.Name = "loginVKLabel";
            loginVKLabel.Click += loginVKLabel_Click;
            // 
            // loginButton
            // 
            resources.ApplyResources(loginButton, "loginButton");
            loginButton.BackColor = Color.Black;
            loginButton.ForeColor = Color.White;
            loginButton.Name = "loginButton";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.BackColor = SystemColors.ActiveCaptionText;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Name = "passwordLabel";
            // 
            // richTextBox2
            // 
            resources.ApplyResources(richTextBox2, "richTextBox2");
            richTextBox2.Name = "richTextBox2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // richTextBox3
            // 
            resources.ApplyResources(richTextBox3, "richTextBox3");
            richTextBox3.Name = "richTextBox3";
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.BackColor = SystemColors.ActiveCaptionText;
            emailLabel.ForeColor = Color.White;
            emailLabel.Name = "emailLabel";
            // 
            // emailRichTextBox
            // 
            resources.ApplyResources(emailRichTextBox, "emailRichTextBox");
            emailRichTextBox.Name = "emailRichTextBox";
            // 
            // NewUserForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(emailRichTextBox);
            Controls.Add(emailLabel);
            Controls.Add(richTextBox3);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(passwordLabel);
            Controls.Add(loginButton);
            Controls.Add(loginVKLabel);
            Controls.Add(pictureBox2);
            Controls.Add(filmSelectLabel);
            Controls.Add(pictureSelectButton);
            Controls.Add(nameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(moviesCheckBox4);
            Controls.Add(moviesCheckBox3);
            Controls.Add(moviesCheckBox2);
            Controls.Add(moviesCheckBox1);
            Name = "NewUserForm";
            Load += NewUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox moviesCheckBox1;
        private CheckBox moviesCheckBox2;
        private CheckBox moviesCheckBox3;
        private CheckBox moviesCheckBox4;
        private RichTextBox richTextBox1;
        private RoundedButton roundedButton2;
        private PictureBox pictureBox1;
        private Label nameLabel;
        private Button pictureSelectButton;
        private Label filmSelectLabel;
        private PictureBox pictureBox2;
        private Label loginVKLabel;
        private Button loginButton;
        private Label passwordLabel;
        private RichTextBox richTextBox2;
        private Label label1;
        private RichTextBox richTextBox3;
        private Label emailLabel;
        private RichTextBox emailRichTextBox;
    }
}