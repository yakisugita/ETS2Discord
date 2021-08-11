
namespace ETS2Discord
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.versionlabel = new System.Windows.Forms.Label();
            this.DLlink = new System.Windows.Forms.LinkLabel();
            this.Twitterlink = new System.Windows.Forms.LinkLabel();
            this.Discordlink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.Location = new System.Drawing.Point(12, 9);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(56, 12);
            this.versionlabel.TabIndex = 0;
            this.versionlabel.Text = "バージョン :";
            // 
            // DLlink
            // 
            this.DLlink.AutoSize = true;
            this.DLlink.Location = new System.Drawing.Point(12, 39);
            this.DLlink.Name = "DLlink";
            this.DLlink.Size = new System.Drawing.Size(59, 12);
            this.DLlink.TabIndex = 1;
            this.DLlink.TabStop = true;
            this.DLlink.Text = "配布ページ";
            this.DLlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Click);
            // 
            // Twitterlink
            // 
            this.Twitterlink.AutoSize = true;
            this.Twitterlink.Location = new System.Drawing.Point(12, 115);
            this.Twitterlink.Name = "Twitterlink";
            this.Twitterlink.Size = new System.Drawing.Size(77, 12);
            this.Twitterlink.TabIndex = 2;
            this.Twitterlink.TabStop = true;
            this.Twitterlink.Text = "制作者Twitter";
            this.Twitterlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Click);
            // 
            // Discordlink
            // 
            this.Discordlink.AutoSize = true;
            this.Discordlink.Location = new System.Drawing.Point(12, 69);
            this.Discordlink.Name = "Discordlink";
            this.Discordlink.Size = new System.Drawing.Size(44, 12);
            this.Discordlink.TabIndex = 3;
            this.Discordlink.TabStop = true;
            this.Discordlink.Text = "Discord";
            this.Discordlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "最新版をより早く試せます";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Discordlink);
            this.Controls.Add(this.Twitterlink);
            this.Controls.Add(this.DLlink);
            this.Controls.Add(this.versionlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.LinkLabel DLlink;
        private System.Windows.Forms.LinkLabel Twitterlink;
        private System.Windows.Forms.LinkLabel Discordlink;
        private System.Windows.Forms.Label label1;
    }
}