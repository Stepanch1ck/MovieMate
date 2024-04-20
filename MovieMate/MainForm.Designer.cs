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
            label1 = new Label();
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
            newUserButton.Click += this.newUserButton_Click;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(552, 308);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(183, 59);
            enterButton.TabIndex = 1;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(486, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 184);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(615, 32);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(enterButton);
            Controls.Add(newUserButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton newUserButton;
        private RoundedButton enterButton;
        private ListBox listBox1;
        private Label label1;
    }
}
