using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DiscordRPC;
using DiscordRPC.Logging;

namespace SandboxRPC
{
    public partial class SandboxRPC : Form
    {

        public SandboxRPC()
        {
            InitializeComponent();
            Initialize();
        }

        public DiscordRpcClient client;

        private void update_button_Click(object sender, EventArgs e)
        {
            client.SetPresence(new RichPresence()
            {
                Details = statetext_text.Text,
                Assets = new Assets()
                {
                    LargeImageKey = "sandbox-logo-large",
                    LargeImageText = "discord.gg/sbox",
                    SmallImageKey = stateicon_list.SelectedItem.ToString(),
                    SmallImageText = statetext_text.Text
                }
            });
        }

        void Initialize()
        {

            client = new DiscordRpcClient("1133287332951367710");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };
            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "In editor",
                //State = "",
                Assets = new Assets()
                {
                    LargeImageKey = "sandbox-logo-large",
                    LargeImageText = "discord.gg/sbox",
                    SmallImageKey = "sandbox-dev-logo",
                    SmallImageText = "In editor"
                }
            });
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            trayIcon.Visible = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            trayIcon.Visible = false;
        }
    }
}
