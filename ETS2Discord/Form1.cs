﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;

namespace ETS2Discord
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// バージョンチェック
			Settings.version = "1.0.1";
			VersionCheck(false);

			string fileName = @"./ets2discord.ini";
			var ini = new IniFile(System.IO.Directory.GetCurrentDirectory() + @"\ets2discord.ini");
			if (!System.IO.File.Exists(fileName))
			{
				// iniファイルが無かったら作成
				DialogResult ini_result = MessageBox.Show("設定ファイルが見つかりません。\n新しく作成します。", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (ini_result == DialogResult.OK)
				{
					System.IO.File.Create("./ets2discord.ini");
				}
				else if (ini_result == DialogResult.Cancel)
				{
					// 終了する
					Settings.X_button_move = "exit";
					this.Close();
				}
			}

			Settings.Telemetry_url = ini.GetString("ets2discord", "api_url", "http://192.168.56.1:25555/api/ets2/telemetry");// API URLを取得 (取得できなければ初期設定のURL)
			Settings.X_button_move = ini.GetString("ets2discord", "x_button_move", "minimum"); // xボタンを押したときの動作
			// DiscordRPCの表示設定
			Settings.free_details = ini.GetString("ets2discord", "free_details", "0");
			Settings.free_state = ini.GetString("ets2discord", "free_state", "0");
			Settings.job_details = ini.GetString("ets2discord", "job_details", "0");
			Settings.job_state = ini.GetString("ets2discord", "job_state", "0");
			Settings.tmp_mode = ini.GetString("ets2discord", "tmp_mode", "false");
			Settings.tmp_id = ini.GetString("ets2discord", "tmp_id", "0");
			Settings.is_login = false;
			Settings.game = "ETS2";

			Settings.timestamp = new Timestamps() { Start = DateTime.UtcNow };
			timer1.Enabled = true; // タイマーを有効化
			mptimer.Enabled = true;
			Initialize(); // 最初にこれを入れないとETS2起動中に実行したときにエラーでる
		}

		public DiscordRpcClient client;
		bool discordrpc = true; // DiscordRPCが有効かどうか

		//Called when your application first starts.
		//For example, just before your main loop, on OnEnable for unity.
		void Initialize()
		{
			/*
			Create a Discord client
			NOTE: 	If you are using Unity3D, you must use the full constructor and define
					 the pipe connection.
			*/
			if (Settings.game == "ATS")
            {
				client = new DiscordRpcClient("872733914622459964");
			}
			else
            {
				client = new DiscordRpcClient("826286647859347497");
			}

			//Set the logger
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			//Subscribe to events
			client.OnReady += (sender, e) =>
			{
				Console.WriteLine("Received Ready from user {0}", e.User.Username);
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				Console.WriteLine("Received Update! {0}", e.Presence);
			};

			//Connect to the RPC
			client.Initialize();

			//Set the rich presence
			//Call this as many times as you want and anywhere in your code.
			client.SetPresence(new RichPresence()
			{
				Details = "ETS2DRP起動中...",
				State = "",
				Assets = new Assets()
				{
					LargeImageKey = "image_large",
					LargeImageText = "Lachee's Discord IPC Library",
					SmallImageKey = "image_small"
				}
			});
		}

		//The main loop of your application, or some sort of timer. Literally the Update function in Unity3D
		void Update()
		{
			//Invoke all the events, such as OnPresenceUpdate
			client.Invoke();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				// 最小化の操作をしたらフォームを最小サイズにする
				this.WindowState = FormWindowState.Minimized;
				// タスクバーから消し去る
				this.ShowInTaskbar = false;
			}
		}

		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
		}


		void Deinitialize()
		{
			client.Dispose();
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			// フォームを通常サイズで表示
			this.WindowState = FormWindowState.Normal;

			// ウィンドウを手前に持ってくる
			this.TopMost = true;
			this.TopMost = false;

			// タスクバーに表示
			this.ShowInTaskbar = true;
		}

		private async void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				using (var httpclient = new HttpClient())
				{
					var response = await httpclient.GetAsync(Settings.Telemetry_url); // GET
					JObject response_json = JObject.Parse(response.Content.ReadAsStringAsync().Result); // 取得した情報をjsonオブジェクトに変換
																										//MessageBox.Show(response_json["game"]["connected"].ToString(), "確認");

					// ETS2/ATS
					if (response_json["game"]["gameName"].ToString() == "ATS")
                    {
						if(Settings.game == "ETS2")
                        {
							Settings.game = "ATS";
							Deinitialize();
							Initialize();
						}
                    } else
                    {
						if(Settings.game == "ATS")
                        {
							Settings.game = "ETS2";
							Deinitialize();
							Initialize();
						}
                    }

					if ((bool)response_json["game"]["connected"])
					{
						status_label.Text = "ゲーム：実行中";
						if (!discordrpc)
						{
							Initialize();
							discordrpc = true;
							Settings.timestamp = new Timestamps() { Start = DateTime.UtcNow };
						}
						// DiscordRPCの表示を更新
						string rpc_details;
						string rpc_state;
						int cargo_tons;
						// フリー走行中か判断 報酬が1未満かどうかで判断
						if (int.Parse(response_json["job"]["income"].ToString()) < 1)
						{
                            // フリー走行中
                            switch (Settings.free_details)
                            {
								case "0":
									rpc_details = "フリー走行中 - " + response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
								case "1":
									rpc_details = "フリー走行中";
									break;
								case "2":
									rpc_details = response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
                                default:
									rpc_details = "フリー走行中 - " + response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
                            }
							// string -> float -> 切り捨て -> int
							rpc_state = "総走行距離 : " + (int)Math.Floor(float.Parse(response_json["truck"]["odometer"].ToString())) + "km";

                            switch (Settings.free_state)
                            {
								case "0":
									// string -> float -> 切り捨て -> int
									rpc_state = "総走行距離 : " + (int)Math.Floor(float.Parse(response_json["truck"]["odometer"].ToString())) + "km";
									break;
								default:
									rpc_state = "";
                                    break;
                            }
                        }
						else
						{
							// 配送中
							// jsonから荷物の重さを取り出してfloatにしてkg->tして切り捨ててintにする
							cargo_tons = (int)Math.Floor(float.Parse(response_json["cargo"]["mass"].ToString()) / 1000);

                            switch (Settings.job_details)
                            {
								case "0":
									// 報酬(response_json["job"]["income"])はゲーム設定を変えても常にユーロ
									rpc_details = "配送中 - " + response_json["cargo"]["cargo"] + " " + cargo_tons + "t 報酬:€" + response_json["job"]["income"];
									rpc_details += " " + response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
								case "1":
									rpc_details = "配送中 - " + response_json["cargo"]["cargo"] + " " + cargo_tons + "t 報酬:€" + response_json["job"]["income"];
									break;
								case "2":
									rpc_details = "配送中 - " + response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
								case "3":
									rpc_details = response_json["cargo"]["cargo"] + " " + cargo_tons + "t 報酬:€" + response_json["job"]["income"];
									rpc_details += " " + response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
								case "4":
									rpc_details = "配送中";
									break;
								case "5":
									rpc_details = response_json["cargo"]["cargo"] + " " + cargo_tons + "t 報酬:€" + response_json["job"]["income"];
									break;
								case "6":
									rpc_details = response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
								default:
									rpc_details = "配送中 - " + response_json["cargo"]["cargo"] + " " + cargo_tons + "t 報酬:€" + response_json["job"]["income"];
									rpc_details += " " + response_json["truck"]["make"].ToString() + " " + response_json["truck"]["model"].ToString();
									break;
                            }

                            switch (Settings.job_state)
                            {
								case "0":
									rpc_state = response_json["job"]["sourceCity"] + " " + response_json["job"]["sourceCompany"] + " -> ";
									rpc_state += response_json["job"]["destinationCity"] + " " + response_json["job"]["destinationCompany"];
									break;
								case "1":
									rpc_state = response_json["job"]["sourceCity"] + " -> " + response_json["job"]["destinationCity"];
									break;
								case "2":
									rpc_state = response_json["job"]["sourceCompany"] + " -> " + response_json["job"]["destinationCompany"];
									break;
								default:
									rpc_state = response_json["job"]["sourceCity"] + " " + response_json["job"]["sourceCompany"] + " -> ";
									rpc_state += response_json["job"]["destinationCity"] + " " + response_json["job"]["destinationCompany"];
									break;
                            }
						}
						if (Settings.is_login && Settings.tmp_mode == "True")
                        {
							client.SetPresence(new RichPresence()
							{
								Details = Settings.tmp_details,
								State = rpc_details,
								Timestamps = Settings.timestamp,
								Assets = new Assets()
								{
									LargeImageKey = "ets2",
									LargeImageText = "Euro Truck Simulator 2",
									SmallImageKey = "image_small"
								}
							});
						} else
                        {
							client.SetPresence(new RichPresence()
							{
								Details = rpc_details,
								State = rpc_state,
								Timestamps = Settings.timestamp,
								Assets = new Assets()
								{
									LargeImageKey = "ets2",
									LargeImageText = "Euro Truck Simulator 2",
									SmallImageKey = "image_small"
								}
							});
						}
					}
					else
					{
						status_label.Text = "ゲーム：停止";
						if (discordrpc)
						{
							//Deinitialize();
							discordrpc = false;
						}
						Deinitialize();
					}
				}
			}
			catch (Exception)
			{
				status_label.Text = "データを取得できません 以下を確認してください\n\n・TelemetryServerは起動しているか\n・Telemetry API URLは正しく入力できているか";
				if (discordrpc)
				{
					Deinitialize();
					discordrpc = false;
				}
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// 終了する
			Settings.X_button_move = "exit";
			Deinitialize();
			this.Close();
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (Settings.X_button_move == "minimum")
            {
				// フォームを最小サイズにする
				this.WindowState = FormWindowState.Minimized;
				// タスクバーから消し去る
				this.ShowInTaskbar = false;

				// 終了を回避
				e.Cancel = true;
			} else
            {
				// DiscordRPCの終了処理
				Deinitialize();
			}
        }

		private async void VersionCheck(bool click_btn)
        {
            try
            {
				using (var httpclient = new HttpClient())
				{
					var response = await httpclient.GetAsync("https://yakijake.net/version/ETS2DRP"); // GET
					if (response.Content.ReadAsStringAsync().Result != Settings.version)
					{
						string title = "現在のバージョン:" + Settings.version;
						DialogResult result = MessageBox.Show("新しいバージョンが見つかりました : v" + response.Content.ReadAsStringAsync().Result + "\nダウンロードしますか?(ブラウザが開きます)", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
						if (result == DialogResult.OK)
                        {
							var response2 = await httpclient.GetAsync("https://yakijake.net/versions/ETS2DRP/ETS2DiscordRichPresence_v" + response.Content.ReadAsStringAsync().Result + ".zip");
							if (response.StatusCode != HttpStatusCode.OK)
							{
								//200 OK意外
								MessageBox.Show("ファイルが無いようです。\nhttps://yakijake.net/versions/ETS2DRP/ \nで手動でダウンロードできます。", "エラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
							} else
                            {
								// ブラウザで開く
								System.Diagnostics.Process.Start("https://yakijake.net/versions/ETS2DRP/ETS2DiscordRichPresence_v" + response.Content.ReadAsStringAsync().Result + ".zip");
							}
						} else
                        {
							MessageBox.Show("https://yakijake.net/versions/ETS2DRP/ \nここでダウンロードできます", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					} else if (click_btn)
                    {
						// 手動の更新確認
						MessageBox.Show("新しいバージョンは見つかりませんでした。", "新バージョン", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
            catch (Exception)
            {
				if (click_btn)
                {
					MessageBox.Show("何らかの原因で確認/ダウンロードに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void VersionCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
			VersionCheck(true);
        }

        private async void mptimer_Tick(object sender, EventArgs e)
        {
			try
			{
                if (discordrpc)
                {
					using (var httpclient = new HttpClient())
					{
						var response = await httpclient.GetAsync("https://api.truckyapp.com/v3/map/online?playerID=" + Settings.tmp_id); // GET
						JObject response_json = JObject.Parse(response.Content.ReadAsStringAsync().Result); // 取得した情報をjsonオブジェクトに変換

						if ((bool)response_json["response"]["online"])
						{
							Settings.is_login = true;
							string servername = response_json["response"]["serverDetails"]["name"].ToString();
							string id = response_json["response"]["p_id"].ToString();
							string location;
							if (response_json["response"]["location"]["poi"]["type"].ToString() == "city")
							{
								location = response_json["response"]["location"]["poi"]["realName"].ToString() + "市内";
							}
							else if ((bool)response_json["response"]["location"]["area"])
                            {
								location = response_json["response"]["location"]["poi"]["realName"].ToString() + "を走行中";
							}
							else
							{
								location = response_json["response"]["location"]["poi"]["realName"].ToString() + "付近";

							}
							Settings.tmp_details = "鯖:" + servername + " | ID:" + id + " | " + location;
						}
						else
						{
							Settings.is_login = false;
						}
					}
				}
			}
			catch (Exception)
			{
			}
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

    public class Settings
	{
		// 設定ファイルの読み込みなど
		public static string version { get; set; }
		public static Timestamps timestamp { get; set; }

		public static string X_button_move { get; set; }
		public static string Telemetry_url { get; set; }
		
		public static string free_details { get; set; }
		public static string free_state { get; set; }
		public static string job_details { get; set; }
		public static string job_state { get; set; }
		public static string tmp_mode { get; set; }
		public static string tmp_id { get; set; }
		public static string tmp_details { get; set; }
		public static bool is_login { get; set; }
		public static string game { get; set; }
	}
}

