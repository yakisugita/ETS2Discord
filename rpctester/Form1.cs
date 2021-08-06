using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpctester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			Initialize();
		}

        public DiscordRpcClient client;

		void Initialize()
		{
			client = new DiscordRpcClient("826286647859347497");
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

			client.SetPresence(new RichPresence()
			{
				Details = "テスターが起動中",
				State = "",
				Timestamps = new Timestamps() { Start = DateTime.UtcNow },
				Assets = new Assets()
				{
					LargeImageKey = "ets2",
					LargeImageText = "ETS2_TEST",
					SmallImageKey = "image_small"
				}
			});
		}

		void Deinitialize()
		{
			client.Dispose();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			Deinitialize();
        }
    }
}
