using System.ComponentModel;

namespace shar_kurs_work.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyLevelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardLevelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentWord = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.translateList = new System.Windows.Forms.ListBox();
            this.translateLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.ToolStripMenuItem, this.resultsToolStripMenuItem, this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.easyLevelToolStripMenuItem1, this.mediumLevelToolStripMenuItem, this.hardLevelToolStripMenuItem1
            });
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ToolStripMenuItem.Text = "New game";
            // 
            // easyLevelToolStripMenuItem1
            // 
            this.easyLevelToolStripMenuItem1.Name = "easyLevelToolStripMenuItem1";
            this.easyLevelToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.easyLevelToolStripMenuItem1.Text = "Easy level";
            this.easyLevelToolStripMenuItem1.Click += new System.EventHandler(this.easyLevelToolStripMenuItem1_Click);
            // 
            // mediumLevelToolStripMenuItem
            // 
            this.mediumLevelToolStripMenuItem.Name = "mediumLevelToolStripMenuItem";
            this.mediumLevelToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.mediumLevelToolStripMenuItem.Text = "Medium level";
            this.mediumLevelToolStripMenuItem.Click += new System.EventHandler(this.mediumLevelToolStripMenuItem_Click);
            // 
            // hardLevelToolStripMenuItem1
            // 
            this.hardLevelToolStripMenuItem1.Name = "hardLevelToolStripMenuItem1";
            this.hardLevelToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.hardLevelToolStripMenuItem1.Text = "Hard level";
            this.hardLevelToolStripMenuItem1.Click += new System.EventHandler(this.hardLevelToolStripMenuItem1_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.viewResultsToolStripMenuItem, this.clearResultsToolStripMenuItem});
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.resultsToolStripMenuItem.Text = "Results";
            // 
            // viewResultsToolStripMenuItem
            // 
            this.viewResultsToolStripMenuItem.Name = "viewResultsToolStripMenuItem";
            this.viewResultsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.viewResultsToolStripMenuItem.Text = "View results";
            this.viewResultsToolStripMenuItem.Click += new System.EventHandler(this.viewResultsToolStripMenuItem_Click);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.clearResultsToolStripMenuItem.Text = "Clear results";
            this.clearResultsToolStripMenuItem.Click +=
                new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // easyLevelToolStripMenuItem
            // 
            this.easyLevelToolStripMenuItem.Name = "easyLevelToolStripMenuItem";
            this.easyLevelToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.easyLevelToolStripMenuItem.Text = "Easy level";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.mediumToolStripMenuItem.Text = "Medium level";
            // 
            // hardLevelToolStripMenuItem
            // 
            this.hardLevelToolStripMenuItem.Name = "hardLevelToolStripMenuItem";
            this.hardLevelToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.hardLevelToolStripMenuItem.Text = "Hard level";
            // 
            // currentWord
            // 
            this.currentWord.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.currentWord.Location = new System.Drawing.Point(12, 44);
            this.currentWord.Name = "currentWord";
            this.currentWord.Size = new System.Drawing.Size(315, 61);
            this.currentWord.TabIndex = 2;
            this.currentWord.Text = "Word";
            this.currentWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.enterButton.Location = new System.Drawing.Point(12, 396);
            this.enterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(315, 56);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Next";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // translateList
            // 
            this.translateList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.translateList.FormattingEnabled = true;
            this.translateList.ItemHeight = 28;
            this.translateList.Location = new System.Drawing.Point(12, 108);
            this.translateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translateList.Name = "translateList";
            this.translateList.Size = new System.Drawing.Size(315, 284);
            this.translateList.TabIndex = 5;
            this.translateList.Visible = false;
            this.translateList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.translateList_KeyUp);
            // 
            // translateLabel
            // 
            this.translateLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.translateLabel.Location = new System.Drawing.Point(12, 108);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(315, 284);
            this.translateLabel.TabIndex = 6;
            this.translateLabel.Text = "WordTranslate";
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 462);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.translateList);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.currentWord);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(19, 19);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Learning Eng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.Label currentWord;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ListBox translateList;
        private System.Windows.Forms.ToolStripMenuItem easyLevelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediumLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardLevelToolStripMenuItem1;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}