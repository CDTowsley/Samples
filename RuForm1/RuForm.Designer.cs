using System;

namespace RuForm1
{
    partial class RuForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuForm1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewImageToolStripMenuItem,
            this.deleteImageToolStripMenuItem,
            this.removeImageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewImageToolStripMenuItem
            // 
            this.addNewImageToolStripMenuItem.Name = "addNewImageToolStripMenuItem";
            this.addNewImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewImageToolStripMenuItem.Text = "&New Deck";
            this.addNewImageToolStripMenuItem.Click += new System.EventHandler(this.addNewImageToolStripMenuItem_Click);
            // 
            // deleteImageToolStripMenuItem
            // 
            this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
            this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteImageToolStripMenuItem.Text = "&Sort";
            this.deleteImageToolStripMenuItem.Click += new System.EventHandler(this.deleteImageToolStripMenuItem_Click);
            // 
            // removeImageToolStripMenuItem
            // 
            this.removeImageToolStripMenuItem.Name = "removeImageToolStripMenuItem";
            this.removeImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeImageToolStripMenuItem.Text = "S&huffle";
            this.removeImageToolStripMenuItem.Click += new System.EventHandler(this.removeImageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Location = new System.Drawing.Point(12, 45);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(211, 433);
            this.lstCards.TabIndex = 1;
            // 
            // RuForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 490);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuForm1";
            this.Text = "Deck of Cards";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.ListBox lstCards;
    }
}

