namespace MovieMate.AfterEnterForms
{
    partial class CreateCompilation
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
            menuLabel = new Label();
            NameCompTextBox = new TextBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            menuLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuLabel.BackColor = Color.Black;
            menuLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.White;
            menuLabel.ImeMode = ImeMode.NoControl;
            menuLabel.Location = new Point(-3, -1);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(225, 49);
            menuLabel.TabIndex = 30;
            menuLabel.Text = "Создание подборки";
            menuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameCompTextBox
            // 
            NameCompTextBox.Location = new Point(12, 71);
            NameCompTextBox.Name = "NameCompTextBox";
            NameCompTextBox.Size = new Size(193, 23);
            NameCompTextBox.TabIndex = 31;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(69, 113);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 34;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateCompilation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 168);
            Controls.Add(CreateButton);
            Controls.Add(NameCompTextBox);
            Controls.Add(menuLabel);
            Name = "CreateCompilation";
            Text = "CreateCompilation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuLabel;
        private TextBox NameCompTextBox;
        private Button CreateButton;
    }
}