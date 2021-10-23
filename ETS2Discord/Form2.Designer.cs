
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.truckersmpid = new System.Windows.Forms.NumericUpDown();
            this.truckersmp = new System.Windows.Forms.CheckBox();
            this.exit_radioButton = new System.Windows.Forms.RadioButton();
            this.min_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.api_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.advanced = new System.Windows.Forms.TabPage();
            this.custom_job_bottom = new System.Windows.Forms.ComboBox();
            this.custom_job_top = new System.Windows.Forms.ComboBox();
            this.custom_free_bottom = new System.Windows.Forms.ComboBox();
            this.custom_free_top = new System.Windows.Forms.ComboBox();
            this.custom_job_state = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.custom_job_details = new System.Windows.Forms.TextBox();
            this.custom_free_state = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.custom_free_details = new System.Windows.Forms.TextBox();
            this.customText = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.startupbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage_normal.SuspendLayout();
            this.tabPage_job.SuspendLayout();
            this.tabPage_other.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckersmpid)).BeginInit();
            this.advanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_normal);
            this.tabControl1.Controls.Add(this.tabPage_job);
            this.tabControl1.Controls.Add(this.tabPage_other);
            this.tabControl1.Controls.Add(this.advanced);
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
            this.tabPage_other.Controls.Add(this.startupbutton);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "確認方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "TruckersMP ID :";
            // 
            // truckersmpid
            // 
            this.truckersmpid.Location = new System.Drawing.Point(98, 113);
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
            this.truckersmp.Location = new System.Drawing.Point(7, 96);
            this.truckersmp.Name = "truckersmp";
            this.truckersmp.Size = new System.Drawing.Size(299, 16);
            this.truckersmp.TabIndex = 5;
            this.truckersmp.Text = "TruckersMP起動中に表示を変える ※Trucky APIを使用";
            this.truckersmp.UseVisualStyleBackColor = true;
            this.truckersmp.CheckedChanged += new System.EventHandler(this.truckersmp_CheckedChanged);
            // 
            // exit_radioButton
            // 
            this.exit_radioButton.AutoSize = true;
            this.exit_radioButton.Location = new System.Drawing.Point(126, 66);
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
            // advanced
            // 
            this.advanced.Controls.Add(this.custom_job_bottom);
            this.advanced.Controls.Add(this.custom_job_top);
            this.advanced.Controls.Add(this.custom_free_bottom);
            this.advanced.Controls.Add(this.custom_free_top);
            this.advanced.Controls.Add(this.custom_job_state);
            this.advanced.Controls.Add(this.label9);
            this.advanced.Controls.Add(this.custom_job_details);
            this.advanced.Controls.Add(this.custom_free_state);
            this.advanced.Controls.Add(this.label8);
            this.advanced.Controls.Add(this.custom_free_details);
            this.advanced.Controls.Add(this.customText);
            this.advanced.Location = new System.Drawing.Point(4, 22);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(339, 180);
            this.advanced.TabIndex = 3;
            this.advanced.Text = "高度な設定";
            this.advanced.UseVisualStyleBackColor = true;
            // 
            // custom_job_bottom
            // 
            this.custom_job_bottom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custom_job_bottom.FormattingEnabled = true;
            this.custom_job_bottom.Items.AddRange(new object[] {
            "アイテムを追加",
            "トラック・メーカー",
            "走行距離",
            "配送[フル]",
            "配送[地域]",
            "配送[会社]",
            "荷物の名前",
            "荷物の重量[t]",
            "報酬[€]"});
            this.custom_job_bottom.Location = new System.Drawing.Point(231, 143);
            this.custom_job_bottom.Name = "custom_job_bottom";
            this.custom_job_bottom.Size = new System.Drawing.Size(100, 20);
            this.custom_job_bottom.TabIndex = 10;
            this.custom_job_bottom.SelectedIndexChanged += new System.EventHandler(this.customSelectedIndexChanged);
            // 
            // custom_job_top
            // 
            this.custom_job_top.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custom_job_top.FormattingEnabled = true;
            this.custom_job_top.Items.AddRange(new object[] {
            "アイテムを追加",
            "トラック・メーカー",
            "走行距離",
            "配送[フル]",
            "配送[地域]",
            "配送[会社]",
            "荷物の名前",
            "荷物の重量[t]",
            "報酬[€]"});
            this.custom_job_top.Location = new System.Drawing.Point(231, 118);
            this.custom_job_top.Name = "custom_job_top";
            this.custom_job_top.Size = new System.Drawing.Size(100, 20);
            this.custom_job_top.TabIndex = 9;
            this.custom_job_top.SelectedIndexChanged += new System.EventHandler(this.customSelectedIndexChanged);
            // 
            // custom_free_bottom
            // 
            this.custom_free_bottom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custom_free_bottom.FormattingEnabled = true;
            this.custom_free_bottom.Items.AddRange(new object[] {
            "アイテムを追加",
            "トラック・メーカー",
            "走行距離(km表記)"});
            this.custom_free_bottom.Location = new System.Drawing.Point(231, 69);
            this.custom_free_bottom.Name = "custom_free_bottom";
            this.custom_free_bottom.Size = new System.Drawing.Size(100, 20);
            this.custom_free_bottom.TabIndex = 8;
            this.custom_free_bottom.SelectedIndexChanged += new System.EventHandler(this.customSelectedIndexChanged);
            // 
            // custom_free_top
            // 
            this.custom_free_top.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custom_free_top.FormattingEnabled = true;
            this.custom_free_top.Items.AddRange(new object[] {
            "アイテムを追加",
            "トラック・メーカー",
            "走行距離(km表記)"});
            this.custom_free_top.Location = new System.Drawing.Point(231, 44);
            this.custom_free_top.Name = "custom_free_top";
            this.custom_free_top.Size = new System.Drawing.Size(100, 20);
            this.custom_free_top.TabIndex = 7;
            this.custom_free_top.SelectedIndexChanged += new System.EventHandler(this.customSelectedIndexChanged);
            // 
            // custom_job_state
            // 
            this.custom_job_state.Location = new System.Drawing.Point(5, 144);
            this.custom_job_state.Name = "custom_job_state";
            this.custom_job_state.Size = new System.Drawing.Size(220, 19);
            this.custom_job_state.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "配送時";
            // 
            // custom_job_details
            // 
            this.custom_job_details.Location = new System.Drawing.Point(5, 119);
            this.custom_job_details.Name = "custom_job_details";
            this.custom_job_details.Size = new System.Drawing.Size(220, 19);
            this.custom_job_details.TabIndex = 4;
            // 
            // custom_free_state
            // 
            this.custom_free_state.Location = new System.Drawing.Point(5, 70);
            this.custom_free_state.Name = "custom_free_state";
            this.custom_free_state.Size = new System.Drawing.Size(220, 19);
            this.custom_free_state.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "フリー走行時";
            // 
            // custom_free_details
            // 
            this.custom_free_details.Location = new System.Drawing.Point(5, 45);
            this.custom_free_details.Name = "custom_free_details";
            this.custom_free_details.Size = new System.Drawing.Size(220, 19);
            this.custom_free_details.TabIndex = 1;
            // 
            // customText
            // 
            this.customText.AutoSize = true;
            this.customText.Location = new System.Drawing.Point(5, 6);
            this.customText.Name = "customText";
            this.customText.Size = new System.Drawing.Size(126, 16);
            this.customText.TabIndex = 0;
            this.customText.Text = "カスタムテキスト[beta]";
            this.customText.UseVisualStyleBackColor = true;
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
            // startupbutton
            // 
            this.startupbutton.Location = new System.Drawing.Point(7, 145);
            this.startupbutton.Name = "startupbutton";
            this.startupbutton.Size = new System.Drawing.Size(100, 23);
            this.startupbutton.TabIndex = 10;
            this.startupbutton.Text = "スタートアップ設定";
            this.startupbutton.UseVisualStyleBackColor = true;
            this.startupbutton.Click += new System.EventHandler(this.startupbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Ets2Telemetry.exe";
            this.openFileDialog1.Title = "実行ファイルを選択 デフォ:Telemetry Serverフォルダ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 259);
            this.ControlBox = false;
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
            this.advanced.ResumeLayout(false);
            this.advanced.PerformLayout();
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
        private System.Windows.Forms.TabPage advanced;
        private System.Windows.Forms.CheckBox customText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox custom_free_details;
        private System.Windows.Forms.TextBox custom_job_state;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox custom_job_details;
        private System.Windows.Forms.TextBox custom_free_state;
        private System.Windows.Forms.ComboBox custom_job_bottom;
        private System.Windows.Forms.ComboBox custom_job_top;
        private System.Windows.Forms.ComboBox custom_free_bottom;
        private System.Windows.Forms.ComboBox custom_free_top;
        private System.Windows.Forms.Button startupbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}