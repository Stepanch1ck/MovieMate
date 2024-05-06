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
            listBox1 = new ListBox();
            nickNameLabel = new Label();
            pictureBox1 = new PictureBox();
            newUserButton = new Button();
            enterUserButton = new Button();
            russianButton = new Button();
            englishButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
            // 
            // nickNameLabel
            // 
            resources.ApplyResources(nickNameLabel, "nickNameLabel");
            nickNameLabel.BackColor = Color.White;
            nickNameLabel.ForeColor = Color.Black;
            nickNameLabel.Name = "nickNameLabel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // newUserButton
            // 
            resources.ApplyResources(newUserButton, "newUserButton");
            newUserButton.BackColor = SystemColors.ActiveCaptionText;
            newUserButton.ForeColor = SystemColors.ButtonHighlight;
            newUserButton.Name = "newUserButton";
            newUserButton.UseVisualStyleBackColor = false;
            newUserButton.Click += newUserButton_Click;
            // 
            // enterUserButton
            // 
            resources.ApplyResources(enterUserButton, "enterUserButton");
            enterUserButton.BackColor = SystemColors.ActiveCaptionText;
            enterUserButton.ForeColor = SystemColors.ButtonHighlight;
            enterUserButton.Name = "enterUserButton";
            enterUserButton.UseVisualStyleBackColor = false;
            enterUserButton.Click += enterUserButton_Click;
            // 
            // russianButton
            // 
            resources.ApplyResources(russianButton, "russianButton");
            russianButton.BackColor = Color.Black;
            russianButton.ForeColor = Color.White;
            russianButton.Name = "russianButton";
            russianButton.UseVisualStyleBackColor = false;
            russianButton.Click += RussianButton_Click;
            // 
            // englishButton
            // 
            resources.ApplyResources(englishButton, "englishButton");
            englishButton.BackColor = Color.Black;
            englishButton.ForeColor = Color.White;
            englishButton.Name = "englishButton";
            englishButton.UseVisualStyleBackColor = false;
            englishButton.Click += EnglishButton_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(englishButton);
            Controls.Add(russianButton);
            Controls.Add(enterUserButton);
            Controls.Add(newUserButton);
            Controls.Add(nickNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
        }

        private void RussianButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
        }

        #endregion

        private ListBox listBox1;
        private Label nickNameLabel;
        private PictureBox pictureBox1;
        private Button button1;
        private Button enterUserButton;
        private Button newUserButton;
        private Button russianButton;
        private Button englishButton;
    }
}
