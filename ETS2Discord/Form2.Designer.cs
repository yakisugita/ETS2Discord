
namespace ETS2Discord
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_normal = new System.Windows.Forms.TabPage();
            this.free_state_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.free_details_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_job = new System.Windows.Forms.TabPage();
            this.job_state_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.job_details_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_other = new System.Windows.Forms.TabPage();
            this.truckersmpid = new System.Windows.Forms.NumericUpDown();
            this.truckersmp = new System.Windows.Forms.CheckBox();
            this.exit_radioButton = new System.Windows.Forms.RadioButton();
            this.min_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.api_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_normal.SuspendLayout();
            this.tabPage_job.SuspendLayout();
            this.tabPage_other.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckersmpid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_normal);
            this.tabControl1.Controls.Add(this.tabPage_job);
            this.tabControl1.Controls.Add(this.tabPage_other);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 206);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_normal
            // 
            this.tabPage_normal.Controls.Add(this.free_state_combo);
            this.tabPage_normal.Controls.Add(this.label5);
            this.tabPage_normal.Controls.Add(this.free_details_combo);
            this.tabPage_normal.Controls.Add(this.label1);
            this.tabPage_normal.Location = new System.Drawing.Point(4, 22);
            this.tabPage_normal.Name = "tabPage_normal";
            this.tabPage_normal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_normal.Size = new System.Drawing.Size(339, 180);
            this.tabPage_normal.TabIndex = 0;
            this.tabPage_normal.Text = "表示(通常時)";
            this.tabPage_normal.UseVisualStyleBackColor = true;
            // 
            // free_state_combo
            // 
            this.free_state_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.free_state_combo.FormattingEnabled = true;
            this.free_state_combo.Items.AddRange(new object[] {
            "オドメーター",
            "なし"});
            this.free_state_combo.Location = new System.Drawing.Point(5, 66);
            this.free_state_combo.Name = "free_state_combo";
            this.free_state_combo.Size = new System.Drawing.Size(220, 20);
            this.free_state_combo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "下段";
            // 
            // free_details_combo
            // 
            this.free_details_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.free_details_combo.FormattingEnabled = true;
            this.free_details_combo.Items.AddRange(new object[] {
            "ステータス,トラック",
            "ステータスのみ",
            "トラックのみ"});
            this.free_details_combo.Location = new System.Drawing.Point(5, 21);
            this.free_details_combo.Name = "free_details_combo";
            this.free_details_combo.Size = new System.Drawing.Size(220, 20);
            this.free_details_combo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上段";
            // 
            // tabPage_job
            // 
            this.tabPage_job.Controls.Add(this.job_state_combo);
            this.tabPage_job.Controls.Add(this.label6);
            this.tabPage_job.Controls.Add(this.job_details_combo);
            this.tabPage_job.Controls.Add(this.label2);
            this.tabPage_job.Location = new System.Drawing.Point(4, 22);
            this.tabPage_job.Name = "tabPage_job";
            this.tabPage_job.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_job.Size = new System.Drawing.Size(339, 180);
            this.tabPage_job.TabIndex = 1;
            this.tabPage_job.Text = "表示(配送時)";
            this.tabPage_job.UseVisualStyleBackColor = true;
            // 
            // job_state_combo
            // 
            this.job_state_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.job_state_combo.FormattingEnabled = true;
            this.job_state_combo.Items.AddRange(new object[] {
            "配送元 -> 配送先(地域,会社名)",
            "配送元 -> 配送先(地域)",
            "配送元 -> 配送先(会社名)",
            "なし"});
            this.job_state_combo.Location = new System.Drawing.Point(5, 66);
            this.job_state_combo.Name = "job_state_combo";
            this.job_state_combo.Size = new System.Drawing.Size(220, 20);
            this.job_state_combo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "下段";
            // 
            // job_details_combo
            // 
            this.job_details_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.job_details_combo.FormattingEnabled = true;
            this.job_details_combo.Items.AddRange(new object[] {
            "ステータス,貨物,トラック",
            "ステータス,貨物",
            "ステータス,トラック",
            "貨物,トラック",
            "ステータスのみ",
            "貨物のみ",
            "トラックのみ"});
            this.job_details_combo.Location = new System.Drawing.Point(5, 21);
            this.job_details_combo.Name = "job_details_combo";
            this.job_details_combo.Size = new System.Drawing.Size(220, 20);
            this.job_details_combo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "上段";
            // 
            // tabPage_other
            // 
            this.tabPage_other.Controls.Add(this.button1);
            this.tabPage_other.Controls.Add(this.label7);
            this.tabPage_other.Controls.Add(this.truckersmpid);
            this.tabPage_other.Controls.Add(this.truckersmp);
            this.tabPage_other.Controls.Add(this.exit_radioButton);
            this.tabPage_other.Controls.Add(this.min_radioButton);
            this.tabPage_other.Controls.Add(this.label4);
            this.tabPage_other.Controls.Add(this.api_url);
            this.tabPage_other.Controls.Add(this.label3);
            this.tabPage_other.Location = new System.Drawing.Point(4, 22);
            this.tabPage_other.Name = "tabPage_other";
            this.tabPage_other.Size = new System.Drawing.Size(339, 180);
            this.tabPage_other.TabIndex = 2;
            this.tabPage_other.Text = "その他の設定";
            this.tabPage_other.UseVisualStyleBackColor = true;
            // 
            // truckersmpid
            // 
            this.truckersmpid.Location = new System.Drawing.Point(98, 132);
            this.truckersmpid.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.truckersmpid.Name = "truckersmpid";
            this.truckersmpid.ReadOnly = true;
            this.truckersmpid.Size = new System.Drawing.Size(70, 19);
            this.truckersmpid.TabIndex = 6;
            this.truckersmpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.truckersmpid.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // truckersmp
            // 
            this.truckersmp.AutoSize = true;
            this.truckersmp.Location = new System.Drawing.Point(7, 115);
            this.truckersmp.Name = "truckersmp";
            this.truckersmp.Size = new System.Drawing.Size(193, 16);
            this.truckersmp.TabIndex = 5;
            this.truckersmp.Text = "TruckersMP起動中に表示を変える";
            this.truckersmp.UseVisualStyleBackColor = true;
            this.truckersmp.CheckedChanged += new System.EventHandler(this.truckersmp_CheckedChanged);
            // 
            // exit_radioButton
            // 
            this.exit_radioButton.AutoSize = true;
            this.exit_radioButton.Location = new System.Drawing.Point(7, 85);
            this.exit_radioButton.Name = "exit_radioButton";
            this.exit_radioButton.Size = new System.Drawing.Size(81, 16);
            this.exit_radioButton.TabIndex = 4;
            this.exit_radioButton.Text = "アプリを終了";
            this.exit_radioButton.UseVisualStyleBackColor = true;
            // 
            // min_radioButton
            // 
            this.min_radioButton.AutoSize = true;
            this.min_radioButton.Location = new System.Drawing.Point(7, 66);
            this.min_radioButton.Name = "min_radioButton";
            this.min_radioButton.Size = new System.Drawing.Size(113, 16);
            this.min_radioButton.TabIndex = 3;
            this.min_radioButton.Text = "タスクバーに最小化";
            this.min_radioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "xボタンクリック時の動作";
            // 
            // api_url
            // 
            this.api_url.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.api_url.Location = new System.Drawing.Point(7, 21);
            this.api_url.Name = "api_url";
            this.api_url.Size = new System.Drawing.Size(305, 19);
            this.api_url.TabIndex = 1;
            this.api_url.Text = "http://192.168.56.1:25555/api/ets2/telemetry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "ETS2 Telemetry Server - Telemetry API URL";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(280, 224);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(180, 224);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "TruckersMP ID :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "確認方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 259);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "ETS2DRP - 設定ウィンドウ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_normal.ResumeLayout(false);
            this.tabPage_normal.PerformLayout();
            this.tabPage_job.ResumeLayout(false);
            this.tabPage_job.PerformLayout();
            this.tabPage_other.ResumeLayout(false);
            this.tabPage_other.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckersmpid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_normal;
        private System.Windows.Forms.TabPage tabPage_job;
        private System.Windows.Forms.TabPage tabPage_other;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox api_url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.RadioButton exit_radioButton;
        private System.Windows.Forms.RadioButton min_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox free_details_combo;
        private System.Windows.Forms.ComboBox job_details_combo;
        private System.Windows.Forms.ComboBox free_state_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox job_state_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown truckersmpid;
        private System.Windows.Forms.CheckBox truckersmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}