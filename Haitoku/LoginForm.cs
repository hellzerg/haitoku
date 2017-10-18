using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Haitoku
{
    public partial class LoginForm : Form
    {
        internal static readonly string VerifyCredentialsURL = @"https://myanimelist.net/api/account/verify_credentials.xml";

        private void LoadSettings()
        {
            if (File.Exists(Options.SettingsFile))
            {
                if (!string.IsNullOrEmpty(Options.CurrentOptions.Username) && !string.IsNullOrEmpty(Options.CurrentOptions.Password))
                {
                    txtPassword.Text = CryLain.Base64Decode(Options.CurrentOptions.Password);
                    Authenticate(Options.CurrentOptions.Username, CryLain.Base64Decode(Options.CurrentOptions.Password));
                }
                txtUsername.Text = Options.CurrentOptions.Username;
                checkBox1.Checked = Options.CurrentOptions.RememberMe;
            }
        }

        private void Authenticate(string username, string password)
        {
            button1.Enabled = txtUsername.Enabled = txtPassword.Enabled = false;
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                client.Credentials = new NetworkCredential(username, password);
                client.DownloadStringAsync(new Uri(VerifyCredentialsURL));
                client.DownloadStringCompleted += Client_DownloadStringCompleted;
            }
            catch //(Exception error)
            {
                MessageBox.Show("Your username and/or password is invalid!", "ERROR: Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            button1.Enabled = txtUsername.Enabled = txtPassword.Enabled = true;
            try
            {
                if (e.Result.ToLowerInvariant().Contains(txtUsername.Text.ToLowerInvariant().Trim()))
                {
                    if (Options.CurrentOptions.RememberMe)
                    {
                        Options.CurrentOptions.Username = txtUsername.Text.ToLowerInvariant().Trim();
                        Options.CurrentOptions.Password = CryLain.Base64Encode(txtPassword.Text);
                        Options.SaveSettings(); 
                    }

                    Program.SetMainForm(new ProfileForm(txtUsername.Text));
                    txtUsername.Clear();
                    txtPassword.Clear();
                    this.Close();
                    Program.ShowMainForm();
                }
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Your username and/or password is invalid!", "ERROR: Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Options.SaveSettings();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtUsername.Text)) && (!string.IsNullOrEmpty(txtPassword.Text)))
            {
                Authenticate(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("Username and/or password is missing!", "ERROR: Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
            LoadSettings();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.RememberMe = checkBox1.Checked;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            Options.SaveSettings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm(this);
            f.ShowDialog();
        }
    }
}
