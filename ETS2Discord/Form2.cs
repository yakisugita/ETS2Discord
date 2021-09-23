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

            // カスタムテキスト
            customText.Checked = Settings.custom_enable;
            custom_free_details.Text = Settings.custom_free_details;
            custom_free_state.Text = Settings.custom_free_state;
            custom_job_details.Text = Settings.custom_job_details;
            custom_job_state.Text = Settings.custom_job_state;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            DialogResult ini_result = MessageBox.Show("設定を上書き保存します。再起動なしで反映されます。", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                // カスタムテキスト
                ini.WriteString("custom", "enable", customText.Checked.ToString());
                ini.WriteString("custom", "free_details", custom_free_details.Text);
                ini.WriteString("custom", "free_state", custom_free_state.Text);
                ini.WriteString("custom", "job_details", custom_job_details.Text);
                ini.WriteString("custom", "job_state", custom_job_state.Text);

                // Form1のgetSettings呼び出し
                Form1 form1 = new Form1();
                form1.getSettings();
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
            DialogResult result = MessageBox.Show("TMPにログインした状態で\nhttps://truckersmp.com/profile\nにアクセスしてください。OKを押すとページが開きます", "ヘルプ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://truckersmp.com/profile");
            }
        }

        private void customSelectedIndexChanged(object sender, EventArgs e)
        {
            var customCombo = sender as ComboBox;
            string add_text = "";
            switch (customCombo.Name)
            {
                case "custom_free_top":
                    switch (customCombo.SelectedIndex)  
                    {
                        case 1:
                            add_text = "{truck}";
                            break;
                        case 2:
                            add_text = "{odo}";
                            break;
                        default:
                            break;
                    }
                    custom_free_details.Text += add_text;
                    break;
                case "custom_free_bottom":
                    switch (customCombo.SelectedIndex)
                    {
                        case 1:
                            add_text = "{truck}";
                            break;
                        case 2:
                            add_text = "{odo}";
                            break;
                        default:
                            break;
                    }
                    custom_free_state.Text += add_text;
                    break;
                case "custom_job_top":
                    switch (customCombo.SelectedIndex)
                    {
                        case 1:
                            add_text = "{truck}";
                            break;
                        case 2:
                            add_text = "{odo}";
                            break;
                        case 3:
                            add_text = "{job_full}";
                            break;
                        case 4:
                            add_text = "{job_city}";
                            break;
                        case 5:
                            add_text = "{job_company}";
                            break;
                        case 6:
                            add_text = "{cargo}";
                            break;
                        case 7:
                            add_text = "{mass}";
                            break;
                        case 8:
                            add_text = "{income}";
                            break;
                        default:
                            break;
                    }
                    custom_job_details.Text += add_text;
                    break;
                case "custom_job_bottom":
                    switch (customCombo.SelectedIndex)
                    {
                        case 1:
                            add_text = "{truck}";
                            break;
                        case 2:
                            add_text = "{odo}";
                            break;
                        case 3:
                            add_text = "{job_full}";
                            break;
                        case 4:
                            add_text = "{job_city}";
                            break;
                        case 5:
                            add_text = "{job_company}";
                            break;
                        case 6:
                            add_text = "{cargo}";
                            break;
                        case 7:
                            add_text = "{mass}";
                            break;
                        case 8:
                            add_text = "{income}";
                            break;
                        default:
                            break;
                    }
                    custom_job_state.Text += add_text;
                    break;
                default:
                    break;
            }
            customCombo.SelectedIndex = 0;
        }
    }
}
