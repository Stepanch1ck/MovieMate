namespace MovieMate
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
            secondEnterButton = new RoundedButton();
            moviesCheckBox1 = new CheckBox();
            moviesCheckBox2 = new CheckBox();
            moviesCheckBox3 = new CheckBox();
            moviesCheckBox4 = new CheckBox();
            roundedRichTextBox1 = new RoundedRichTextBox();
            SuspendLayout();
            // 
            // secondEnterButton
            // 
            secondEnterButton.Location = new Point(107, 414);
            secondEnterButton.Name = "secondEnterButton";
            secondEnterButton.Size = new Size(183, 59);
            secondEnterButton.TabIndex = 0;
            secondEnterButton.Text = "Войти";
            secondEnterButton.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox1
            // 
            moviesCheckBox1.AutoSize = true;
            moviesCheckBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox1.Location = new Point(41, 272);
            moviesCheckBox1.Name = "moviesCheckBox1";
            moviesCheckBox1.Size = new Size(155, 29);
            moviesCheckBox1.TabIndex = 1;
            moviesCheckBox1.Text = "Кунг-фу панда";
            moviesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox2
            // 
            moviesCheckBox2.AutoSize = true;
            moviesCheckBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox2.Location = new Point(41, 302);
            moviesCheckBox2.Name = "moviesCheckBox2";
            moviesCheckBox2.Size = new Size(73, 29);
            moviesCheckBox2.TabIndex = 2;
            moviesCheckBox2.Text = "Ёлки";
            moviesCheckBox2.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox3
            // 
            moviesCheckBox3.AutoSize = true;
            moviesCheckBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox3.Location = new Point(41, 332);
            moviesCheckBox3.Name = "moviesCheckBox3";
            moviesCheckBox3.Size = new Size(101, 29);
            moviesCheckBox3.TabIndex = 3;
            moviesCheckBox3.Text = "Форсаж";
            moviesCheckBox3.UseVisualStyleBackColor = true;
            // 
            // moviesCheckBox4
            // 
            moviesCheckBox4.AutoSize = true;
            moviesCheckBox4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moviesCheckBox4.Location = new Point(41, 362);
            moviesCheckBox4.Name = "moviesCheckBox4";
            moviesCheckBox4.Size = new Size(117, 29);
            moviesCheckBox4.TabIndex = 4;
            moviesCheckBox4.Text = "Мстители";
            moviesCheckBox4.UseVisualStyleBackColor = true;
            // 
            // roundedRichTextBox1
            // 
            roundedRichTextBox1.Location = new Point(12, 86);
            roundedRichTextBox1.Name = "roundedRichTextBox1";
            roundedRichTextBox1.Size = new Size(361, 48);
            roundedRichTextBox1.TabIndex = 5;
            roundedRichTextBox1.Text = "";
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 474);
            Controls.Add(roundedRichTextBox1);
            Controls.Add(moviesCheckBox4);
            Controls.Add(moviesCheckBox3);
            Controls.Add(moviesCheckBox2);
            Controls.Add(moviesCheckBox1);
            Controls.Add(secondEnterButton);
            Name = "NewUserForm";
            Text = "NewUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton secondEnterButton;
        private CheckBox moviesCheckBox1;
        private CheckBox moviesCheckBox2;
        private CheckBox moviesCheckBox3;
        private CheckBox moviesCheckBox4;
        private RoundedRichTextBox roundedRichTextBox1;
    }
}