using System.Windows.Forms;

namespace ETS2Discord
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            versionlabel.Text = "バージョン : v" + Settings.version;
        }

        private void Link_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linklabel = sender as LinkLabel;
            switch (linklabel.Name)
            {
                case "DLlink":
                    System.Diagnostics.Process.Start("https://yakijake.net/versions/ETS2DRP/");
                    break;
                case "Discordlink":
                    System.Diagnostics.Process.Start("https://discord.gg/vebXVYYHVu");
                    break;
                case "GFormlink":
                    System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSeYU7fDX0MqZ0yPzqnkVGmLd_QAtI9rVw5hiHjDc3w84axUtA/viewform");
                    break;
                case "Twitterlink":
                    System.Diagnostics.Process.Start("https://twitter.com/_yakisugita_");
                    break;
                default:
                    break;
            }
        }
    }
}
