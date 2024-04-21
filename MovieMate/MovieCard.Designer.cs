namespace MovieMate
{
    partial class MovieCard
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
            moviePictureBox = new PictureBox();
            roundedButton1 = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)moviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // moviePictureBox
            // 
            moviePictureBox.BackColor = SystemColors.ActiveBorder;
            moviePictureBox.Location = new Point(25, 31);
            moviePictureBox.Name = "moviePictureBox";
            moviePictureBox.Size = new Size(218, 265);
            moviePictureBox.TabIndex = 0;
            moviePictureBox.TabStop = false;
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(284, 31);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(475, 265);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = " ";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(324, 57);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 2;
            label1.Text = "Жанры:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(324, 121);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 3;
            label2.Text = "Оценка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(416, 179);
            label3.Name = "label3";
            label3.Size = new Size(197, 28);
            label3.TabIndex = 4;
            label3.Text = "Ссылка на трейлер:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 65);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 129);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 231);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roundedButton1);
            Controls.Add(moviePictureBox);
            Name = "MovieCard";
            Text = "MovieCard";
            ((System.ComponentModel.ISupportInitialize)moviePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox moviePictureBox;
        private RoundedButton roundedButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}