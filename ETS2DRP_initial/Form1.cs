using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ETS2DRP_initial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			DialogResult result = MessageBox.Show("ETS2TelemetryServerの導入(Ver4.0以降)は済んでいますか?", "初期設定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				DialogResult result1 = MessageBox.Show("ダウンロードします(ブラウザが開きます)", "初期設定", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (result1 == DialogResult.OK)
				{
					System.Diagnostics.Process.Start("https://github.com/PauloTNCunha/TelemetryServer4/archive/refs/heads/master.zip");
					MessageBox.Show("zipファイルを解凍し、セットアップ用のファイルを起動してください(最新版のもの)", "初期設定", MessageBoxButtons.OK);
					MessageBox.Show("画面の指示にしたがってセットアップを進めてください。", "初期設定", MessageBoxButtons.OK);
					MessageBox.Show("スタートメニューに「Telemetry Server 4.x.x.x」が追加されているので、起動してください。", "初期設定", MessageBoxButtons.OK);
					MessageBox.Show("右下の「Install」をクリックしてください。", "初期設定", MessageBoxButtons.OK);
				}
			}
			MessageBox.Show("Telemetry Serverに表示されているAPI URLを入力してください。", "初期設定", MessageBoxButtons.OK);
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
			MessageBox.Show("初期設定が完了しました。", "初期設定", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
