using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS2DRP_initial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			DialogResult result = MessageBox.Show("ETS2TelemetryServerの導入は済んでいますか?", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				DialogResult result1 = MessageBox.Show("ダウンロードします(ブラウザが開きます)", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (result1 == DialogResult.OK)
				{
					System.Diagnostics.Process.Start("https://github.com/mike-koch/ets2-telemetry-server/archive/refs/heads/master.zip");
					MessageBox.Show("zipファイルを解凍し、serverフォルダにあるexeファイルを起動してください。(緑のアイコン)", "メッセージ", MessageBoxButtons.OK);
					MessageBox.Show("「install」をクリックしてインストールしてください。完了したらOKを押してください。\nボタンが無い場合はこの手順をスキップしてください。", "メッセージ", MessageBoxButtons.OK);
				}
			}
			MessageBox.Show("Telemetry API URLを入力してください。", "メッセージ", MessageBoxButtons.OK);
			InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			string fileName = @"./ets2discord.ini";
			if (!System.IO.File.Exists(fileName))
			{
				System.IO.File.Create("./ets2discord.ini");
			}
			var ini = new IniFile(System.IO.Directory.GetCurrentDirectory() + @"\ets2discord.ini");
			ini.GetString("ets2discord", "api_url", "");
			ini.WriteString("ets2discord", "api_url", api_url.Text);
			MessageBox.Show("初期設定が完了しました。", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
    }

    public class IniFile
	{
		[DllImport("kernel32.dll")]
		private static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

		[DllImport("kernel32.dll")]
		private static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

		/// Ini ファイルのファイルパス
		public string FilePath { get; set; }

		/// インスタンスの初期化
		public IniFile(string filePath)
		{
			FilePath = filePath;
		}
		/// Ini ファイルから文字列を取得
		public string GetString(string section, string key, string defaultValue = "")
		{
			var sb = new StringBuilder(1024);
			var r = GetPrivateProfileString(section, key, defaultValue, sb, (uint)sb.Capacity, FilePath);
			return sb.ToString();
		}
		/// Ini ファイルに文字列を書き込み
		public bool WriteString(string section, string key, string value)
		{
			return WritePrivateProfileString(section, key, value, FilePath);
		}
	}
}
