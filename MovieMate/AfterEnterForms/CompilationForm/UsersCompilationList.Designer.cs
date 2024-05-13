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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersCompilationList));
            menuLabel = new Label();
            UserListBox = new ListBox();
            AddUserButton = new Button();
            deleteUserButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // UserListBox
            // 
            resources.ApplyResources(UserListBox, "UserListBox");
            UserListBox.FormattingEnabled = true;
            UserListBox.Name = "UserListBox";
            UserListBox.SelectedIndexChanged += UserListBox_SelectedIndexChanged;
            // 
            // AddUserButton
            // 
            resources.ApplyResources(AddUserButton, "AddUserButton");
            AddUserButton.Name = "AddUserButton";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // deleteUserButton
            // 
            resources.ApplyResources(deleteUserButton, "deleteUserButton");
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // UsersCompilationList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteUserButton);
            Controls.Add(AddUserButton);
            Controls.Add(UserListBox);
            Controls.Add(menuLabel);
            Name = "UsersCompilationList";
            ResumeLayout(false);
        }

        #endregion

        private Label menuLabel;
        private ListBox UserListBox;
        private Button AddUserButton;
        private Button deleteUserButton;
    }
}