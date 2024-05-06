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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieCard));
            moviePictureBox = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)moviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // moviePictureBox
            // 
            resources.ApplyResources(moviePictureBox, "moviePictureBox");
            moviePictureBox.BackColor = SystemColors.ActiveBorder;
            moviePictureBox.Name = "moviePictureBox";
            moviePictureBox.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.White;
            label8.ForeColor = Color.Black;
            label8.Name = "label8";
            // 
            // MovieCard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(moviePictureBox);
            Name = "MovieCard";
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