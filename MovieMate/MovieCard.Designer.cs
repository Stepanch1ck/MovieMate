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
            roundedButton1.Location = new Point(323, 31);
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
            label1.Location = new Point(350, 58);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 2;
            label1.Text = "Жанры:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(350, 119);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
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
    }
}