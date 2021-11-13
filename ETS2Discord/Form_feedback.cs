using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;

namespace ETS2Discord
{
    public partial class Form_feedback : Form
    {
        public Form_feedback()
        {
            InitializeComponent();
        }

        private async void sendbutton_Click(object sender, EventArgs e)
        {
			if (feedback_text.Text.Replace("\r\n", "").Length > 0)
            {
				try
				{
					var url = "https://docs.google.com/forms/d/e/1FAIpQLSeYU7fDX0MqZ0yPzqnkVGmLd_QAtI9rVw5hiHjDc3w84axUtA/formResponse?usp=pp_url&entry.169504070=__other_option__&entry.169504070.other_option_response=ETS2DRP:Feedback";
					url += "&entry.2087193578=version:" + Application.ProductVersion + "\n" + Uri.EscapeDataString(feedback_text.Text);
					url += "&entry.1026792646=" + Uri.EscapeDataString(address_text.Text);

					if (System.IO.File.Exists(Settings.current_dir + "/error.log"))
                    {
						url += "&entry.1692366863=" + System.IO.File.ReadAllText(Settings.current_dir + "/error.log");
					}else
                    {
						url += "&entry.1692366863=FileNotFound";
					}
					using (var httpclient = new HttpClient())
					{
						var response = await httpclient.GetAsync(url);
						if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
							MessageBox.Show("正常に送信されました。\n意見を送っていただきありがとうございます!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
						} else
                        {
							DialogResult msg_result = MessageBox.Show("送信時にエラーが発生しました。\n「OK」を押すと配布ページが開きます。\nGoogleフォームへのリンクから手動で送信できます。", "エラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
							if (msg_result == DialogResult.OK)
							{
								Form1 form1 = new Form1();
								form1.openbrowser("https://yakijake.net/versions/ETS2DRP/");
							}
						}
					}
				}
				catch (Exception err)
				{
					DialogResult msg_result = MessageBox.Show("送信時にエラーが発生しました。\n「OK」を押すと配布ページが開きます。\nGoogleフォームへのリンクから手動で送信できます。", "エラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
					if (msg_result == DialogResult.OK)
					{
						Form1 form1 = new Form1();
						form1.openbrowser("https://yakijake.net/versions/ETS2DRP/");
					}

					// 時刻
					DateTime dt = DateTime.Now;
					// エラーが起きてる行
					StackTrace stacktrace = new StackTrace(1, true);
					int errline = stacktrace.GetFrame(0).GetFileLineNumber();
					System.IO.File.WriteAllText(Settings.current_dir + "/error.log", $"{dt.ToString("[MPCheckERR] yyyy/MM/dd HH:mm:ss:")}\nMPTimer error\n{err.Message}\nFile: {stacktrace.GetFrame(0).GetFileName()}, row : {errline}"); // 上書き
				}
			} else
            {
				MessageBox.Show("テキストを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
    }
}
