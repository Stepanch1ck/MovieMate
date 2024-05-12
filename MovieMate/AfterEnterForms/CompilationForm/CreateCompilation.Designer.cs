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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCompilation));
            menuLabel = new Label();
            NameCompTextBox = new TextBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            resources.ApplyResources(menuLabel, "menuLabel");
            menuLabel.BackColor = Color.Black;
            menuLabel.ForeColor = Color.White;
            menuLabel.Name = "menuLabel";
            // 
            // NameCompTextBox
            // 
            resources.ApplyResources(NameCompTextBox, "NameCompTextBox");
            NameCompTextBox.Name = "NameCompTextBox";
            // 
            // CreateButton
            // 
            resources.ApplyResources(CreateButton, "CreateButton");
            CreateButton.Name = "CreateButton";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateCompilation
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateButton);
            Controls.Add(NameCompTextBox);
            Controls.Add(menuLabel);
            Name = "CreateCompilation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuLabel;
        private TextBox NameCompTextBox;
        private Button CreateButton;
    }
}