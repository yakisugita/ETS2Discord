
namespace ETS2Discord
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openmanualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status_label = new System.Windows.Forms.Label();
            this.mptimer = new System.Windows.Forms.Timer(this.components);
            this.update_notice = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ETS2DRP";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowToolStripMenuItem.Image")));
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ShowToolStripMenuItem.Text = "表示";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ExitToolStripMenuItem.Text = "終了";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.redisplayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(242, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.SettingsToolStripMenuItem.Text = "設定";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionCheckToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.openmanualToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.infoToolStripMenuItem.Text = "インフォ";
            // 
            // VersionCheckToolStripMenuItem
            // 
            this.VersionCheckToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("VersionCheckToolStripMenuItem.Image")));
            this.VersionCheckToolStripMenuItem.Name = "VersionCheckToolStripMenuItem";
            this.VersionCheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VersionCheckToolStripMenuItem.Text = "更新の確認";
            this.VersionCheckToolStripMenuItem.Click += new System.EventHandler(this.VersionCheckToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "このツールについて";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openmanualToolStripMenuItem
            // 
            this.openmanualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openmanualToolStripMenuItem.Image")));
            this.openmanualToolStripMenuItem.Name = "openmanualToolStripMenuItem";
            this.openmanualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openmanualToolStripMenuItem.Text = "オンラインマニュアル";
            this.openmanualToolStripMenuItem.Click += new System.EventHandler(this.openmanualToolStripMenuItem_Click);
            // 
            // redisplayToolStripMenuItem
            // 
            this.redisplayToolStripMenuItem.Name = "redisplayToolStripMenuItem";
            this.redisplayToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.redisplayToolStripMenuItem.Text = "再表示";
            this.redisplayToolStripMenuItem.Click += new System.EventHandler(this.redisplayToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(12, 25);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(50, 12);
            this.status_label.TabIndex = 2;
            this.status_label.Text = "ステータス";
            // 
            // mptimer
            // 
            this.mptimer.Interval = 10000;
            this.mptimer.Tick += new System.EventHandler(this.mptimer_Tick);
            // 
            // update_notice
            // 
            this.update_notice.AutoSize = true;
            this.update_notice.ForeColor = System.Drawing.Color.Black;
            this.update_notice.Location = new System.Drawing.Point(12, 90);
            this.update_notice.Name = "update_notice";
            this.update_notice.Size = new System.Drawing.Size(179, 12);
            this.update_notice.TabIndex = 3;
            this.update_notice.Text = "更新がある場合はここに表示されます";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 111);
            this.Controls.Add(this.update_notice);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ETS2DiscordRichPresence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Timer mptimer;
        private System.Windows.Forms.ToolStripMenuItem VersionCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redisplayToolStripMenuItem;
        private System.Windows.Forms.Label update_notice;
        private System.Windows.Forms.ToolStripMenuItem openmanualToolStripMenuItem;
    }
}

