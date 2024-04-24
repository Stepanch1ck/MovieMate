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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            roundedButton2 = new RoundedButton();
            label8 = new Label();
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
            roundedButton1.Location = new Point(282, 107);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(479, 189);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = " ";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(417, 212);
            label3.Name = "label3";
            label3.Size = new Size(197, 28);
            label3.TabIndex = 4;
            label3.Text = "Ссылка на трейлер:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(324, 135);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(324, 184);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(491, 255);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // roundedButton2
            // 
            roundedButton2.Location = new Point(282, 31);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(479, 70);
            roundedButton2.TabIndex = 8;
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(324, 42);
            label8.Name = "label8";
            label8.Size = new Size(91, 38);
            label8.TabIndex = 10;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(label8);
            Controls.Add(roundedButton2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(roundedButton1);
            Controls.Add(moviePictureBox);
            Name = "MovieCard";
            Text = "MovieCard";
            Load += MovieCard_Load;
            ((System.ComponentModel.ISupportInitialize)moviePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox moviePictureBox;
        private RoundedButton roundedButton1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RoundedButton roundedButton2;
        private Label label8;
    }
}