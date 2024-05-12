namespace MovieMate.AfterEnterForms
{
    partial class addUser
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
            UserListBox = new ListBox();
            menuLabel = new Label();
            userAddButton = new Button();
            SuspendLayout();
            // 
            // UserListBox
            // 
            UserListBox.FormattingEnabled = true;
            UserListBox.ItemHeight = 15;
            UserListBox.Location = new Point(12, 57);
            UserListBox.Name = "UserListBox";
            UserListBox.Size = new Size(248, 124);
            UserListBox.TabIndex = 0;
            UserListBox.SelectedIndexChanged += UserListBox_SelectedIndexChanged;
            // 
            // menuLabel
            // 
            menuLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuLabel.BackColor = Color.Black;
            menuLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.White;
            menuLabel.ImeMode = ImeMode.NoControl;
            menuLabel.Location = new Point(-2, -4);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(276, 49);
            menuLabel.TabIndex = 31;
            menuLabel.Text = "Добавление пользователя";
            menuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userAddButton
            // 
            userAddButton.Location = new Point(95, 208);
            userAddButton.Name = "userAddButton";
            userAddButton.Size = new Size(75, 23);
            userAddButton.TabIndex = 32;
            userAddButton.Text = "Добавить";
            userAddButton.UseVisualStyleBackColor = true;
            userAddButton.Click += userAddButton_Click;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 269);
            Controls.Add(userAddButton);
            Controls.Add(menuLabel);
            Controls.Add(UserListBox);
            Name = "addUser";
            Text = "addUser";
            ResumeLayout(false);
        }

        #endregion

        private ListBox UserListBox;
        private Label menuLabel;
        private Button userAddButton;
    }
}