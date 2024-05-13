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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            UserListBox = new ListBox();
            menuLabel = new Label();
            userAddButton = new Button();
            SuspendLayout();
            // 
            // UserListBox
            // 
            resources.ApplyResources(UserListBox, "UserListBox");
            UserListBox.FormattingEnabled = true;
            UserListBox.Name = "UserListBox";
            UserListBox.SelectedIndexChanged += UserListBox_SelectedIndexChanged;
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // userAddButton
            // 
            resources.ApplyResources(userAddButton, "userAddButton");
            userAddButton.Name = "userAddButton";
            userAddButton.UseVisualStyleBackColor = true;
            userAddButton.Click += userAddButton_Click;
            // 
            // addUser
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userAddButton);
            Controls.Add(menuLabel);
            Controls.Add(UserListBox);
            Name = "addUser";
            ResumeLayout(false);
        }

        #endregion

        private ListBox UserListBox;
        private Label menuLabel;
        private Button userAddButton;
    }
}