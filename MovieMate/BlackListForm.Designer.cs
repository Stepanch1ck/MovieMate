namespace MovieMate
{
    partial class BlackListForm
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
            roundedButton1 = new RoundedButton();
            BlackListDataGridView = new DataGridView();
            blackListOpenButton = new RoundedButton();
            deleteFromBlackListButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(258, 95);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(490, 302);
            roundedButton1.TabIndex = 0;
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // BlackListDataGridView
            // 
            BlackListDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            BlackListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BlackListDataGridView.Location = new Point(302, 127);
            BlackListDataGridView.Name = "BlackListDataGridView";
            BlackListDataGridView.RowHeadersWidth = 51;
            BlackListDataGridView.Size = new Size(403, 228);
            BlackListDataGridView.TabIndex = 1;
            // 
            // blackListOpenButton
            // 
            blackListOpenButton.Location = new Point(448, 29);
            blackListOpenButton.Name = "blackListOpenButton";
            blackListOpenButton.Size = new Size(134, 50);
            blackListOpenButton.TabIndex = 2;
            blackListOpenButton.Text = "Открыть";
            blackListOpenButton.UseVisualStyleBackColor = true;
            // 
            // deleteFromBlackListButton
            // 
            deleteFromBlackListButton.Location = new Point(614, 29);
            deleteFromBlackListButton.Name = "deleteFromBlackListButton";
            deleteFromBlackListButton.Size = new Size(134, 50);
            deleteFromBlackListButton.TabIndex = 3;
            deleteFromBlackListButton.Text = "Удалить из чёрного списка";
            deleteFromBlackListButton.UseVisualStyleBackColor = true;
            // 
            // BlackListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteFromBlackListButton);
            Controls.Add(blackListOpenButton);
            Controls.Add(BlackListDataGridView);
            Controls.Add(roundedButton1);
            Name = "BlackListForm";
            Text = "BlackListForm";
            ((System.ComponentModel.ISupportInitialize)BlackListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton roundedButton1;
        private DataGridView BlackListDataGridView;
        private RoundedButton blackListOpenButton;
        private RoundedButton deleteFromBlackListButton;
    }
}