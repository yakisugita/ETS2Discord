using System;
using System.Windows.Forms;

namespace ETS2Discord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // 増減ボタン非表示
            truckersmpid.Controls[0].Visible = false;

            // カスタムテキスト
            custom_free_top.SelectedIndex = 0;
            custom_free_bottom.SelectedIndex = 0;
            custom_job_top.SelectedIndex = 0;
            custom_job_bottom.SelectedIndex = 0;

            // 設定を読み込む
            api_url.Text = Settings.Telemetry_url;
            truckersmp.Checked = bool.Parse(Settings.tmp_mode);
            truckersmpid.ReadOnly = !truckersmp.Checked;
            truckersmpid.Value = int.Parse(Settings.tmp_id);
            free_details_combo.SelectedIndex = int.Parse(Settings.free_details);
            free_state_combo.SelectedIndex = int.Parse(Settings.free_state);
            job_details_combo.SelectedIndex = int.Parse(Settings.job_details);
            job_state_combo.SelectedIndex = int.Parse(Settings.job_state);
            if (Settings.X_button_move == "minimum")
            {
                min_radioButton.Checked = true;
            } else
            {
                exit_radioButton.Checked = true;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            DialogResult ini_result = MessageBox.Show("設定を上書き保存します。\nその他の設定は次回起動時に適用されます。", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (ini_result == DialogResult.OK)
            {
                // 設定を上書き保存
                var ini = new IniFile(System.IO.Directory.GetCurrentDirectory() + @"\ets2discord.ini");
                ini.WriteString("ets2discord", "api_url", api_url.Text);
                ini.WriteString("ets2discord", "tmp_mode", truckersmp.Checked.ToString());
                ini.WriteString("ets2discord", "tmp_id", truckersmpid.Value.ToString());
                ini.WriteString("ets2discord", "free_details", free_details_combo.SelectedIndex.ToString());
                ini.WriteString("ets2discord", "free_state", free_state_combo.SelectedIndex.ToString());
                ini.WriteString("ets2discord", "job_details", job_details_combo.SelectedIndex.ToString());
                ini.WriteString("ets2discord", "job_state", job_state_combo.SelectedIndex.ToString());
                if (min_radioButton.Checked)
                {
                    ini.WriteString("ets2discord", "x_button_move", "minimum");
                } else
                {
                    ini.WriteString("ets2discord", "x_button_move", "exit");
                }

                // DiscordRPCの表示設定はすぐに反映させる
                Settings.free_details = free_details_combo.SelectedIndex.ToString();
                Settings.free_state = free_state_combo.SelectedIndex.ToString();
                Settings.job_details = job_details_combo.SelectedIndex.ToString();
                Settings.job_state = job_state_combo.SelectedIndex.ToString();

                this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void truckersmp_CheckedChanged(object sender, EventArgs e)
        {
            truckersmpid.ReadOnly = !truckersmp.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("TMPにログインした状態で\nhttps://truckersmp.com/profile\nにアクセスしてください。OKを押すとブラウザで開きます", "ヘルプ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://truckersmp.com/profile");
            }
        }

        private void customTabIndexChanged(object sender, EventArgs e)
        {
            var customCombo = sender as ComboBox;
            switch (customCombo.Name)
            {
                case "custom_free_top":
                    customtext_free_top.Text = customtext_free_top.Text + "{0}"
                    break;
                default:
                    break;
            }
        }
    }
}
