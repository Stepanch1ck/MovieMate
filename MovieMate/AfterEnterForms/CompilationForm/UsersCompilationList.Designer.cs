namespace MovieMate.AfterEnterForms
{
    partial class UsersCompilationList
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
            UserListBox = new ListBox();
            AddUserButton = new Button();
            deleteUserButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            menuLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuLabel.BackColor = Color.Black;
            menuLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.White;
            menuLabel.ImeMode = ImeMode.NoControl;
            menuLabel.Location = new Point(0, -3);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(261, 49);
            menuLabel.TabIndex = 32;
            menuLabel.Text = "Список пользователей";
            menuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserListBox
            // 
            UserListBox.FormattingEnabled = true;
            UserListBox.ItemHeight = 15;
            UserListBox.Location = new Point(12, 49);
            UserListBox.Name = "UserListBox";
            UserListBox.Size = new Size(236, 139);
            UserListBox.TabIndex = 33;
            UserListBox.SelectedIndexChanged += UserListBox_SelectedIndexChanged;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(24, 196);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(107, 53);
            AddUserButton.TabIndex = 34;
            AddUserButton.Text = "Добавить новых пользователей";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(139, 196);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(97, 53);
            deleteUserButton.TabIndex = 35;
            deleteUserButton.Text = "Удалить из текущих";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // UsersCompilationList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 257);
            Controls.Add(deleteUserButton);
            Controls.Add(AddUserButton);
            Controls.Add(UserListBox);
            Controls.Add(menuLabel);
            Name = "UsersCompilationList";
            Text = "UsersCompilationList";
            ResumeLayout(false);
        }

        #endregion

        private Label menuLabel;
        private ListBox UserListBox;
        private Button AddUserButton;
        private Button deleteUserButton;
    }
}