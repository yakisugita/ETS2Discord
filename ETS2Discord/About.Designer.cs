
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
            this.GFormlink = new System.Windows.Forms.LinkLabel();
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
            this.Twitterlink.Location = new System.Drawing.Point(12, 99);
            this.Twitterlink.Name = "Twitterlink";
            this.Twitterlink.Size = new System.Drawing.Size(151, 12);
            this.Twitterlink.TabIndex = 2;
            this.Twitterlink.TabStop = true;
            this.Twitterlink.Text = "制作者Twitter (焼きすぎた鮭)";
            this.Twitterlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Click);
            // 
            // GFormlink
            // 
            this.GFormlink.AutoSize = true;
            this.GFormlink.Location = new System.Drawing.Point(12, 69);
            this.GFormlink.Name = "GFormlink";
            this.GFormlink.Size = new System.Drawing.Size(94, 12);
            this.GFormlink.TabIndex = 3;
            this.GFormlink.TabStop = true;
            this.GFormlink.Text = "不具合の報告など";
            this.GFormlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 121);
            this.Controls.Add(this.GFormlink);
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
        private System.Windows.Forms.LinkLabel GFormlink;
    }
}