using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haitoku
{
    public partial class OptionsForm : Form
    {
        Form _form;

        public OptionsForm(Form form)
        {
            InitializeComponent();
            _form = form;

            LoadSettings();
            Options.ApplyTheme(this);

            CheckForIllegalCrossThreadCalls = false;
            t1.Interval = 50;
            t2.Interval = 50;

            t1.Start();
        }

        private void LoadSettings()
        {
            switch (Options.CurrentOptions.Color)
            {
                case Theme.Caramel:
                    carameltheme.Checked = true;
                    break;
                case Theme.Lime:
                    limetheme.Checked = true;
                    break;
                case Theme.Magma:
                    magmatheme.Checked = true;
                    break;
                case Theme.Minimal:
                    minimaltheme.Checked = true;
                    break;
                case Theme.Ocean:
                    oceantheme.Checked = true;
                    break;
                case Theme.Zerg:
                    zergtheme.Checked = true;
                    break;
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "d";
            string s2 = "de";
            string s3 = "dea";
            string s4 = "dead";
            string s5 = "deadm";
            string s6 = "deadmo";
            string s7 = "deadmoo";
            string s8 = "deadmoon";
            string s9 = "deadmoon © ";
            string s10 = "deadmoon © 2";
            string s11 = "deadmoon © 20";
            string s12 = "deadmoon © 201";
            string s13 = "deadmoon © 2017";

            switch (l2.Text)
            {
                case "":
                    l2.Text = s1;
                    break;
                case "d":
                    l2.Text = s2;
                    break;
                case "de":
                    l2.Text = s3;
                    break;
                case "dea":
                    l2.Text = s4;
                    break;
                case "dead":
                    l2.Text = s5;
                    break;
                case "deadm":
                    l2.Text = s6;
                    break;
                case "deadmo":
                    l2.Text = s7;
                    break;
                case "deadmoo":
                    l2.Text = s8;
                    break;
                case "deadmoon":
                    l2.Text = s9;
                    break;
                case "deadmoon © ":
                    l2.Text = s10;
                    break;
                case "deadmoon © 2":
                    l2.Text = s11;
                    break;
                case "deadmoon © 20":
                    l2.Text = s12;
                    break;
                case "deadmoon © 201":
                    l2.Text = s13;
                    t2.Stop();
                    //t1.Start();
                    break;
                case "deadmoon © 2017":
                    l2.Text = s0;
                    break;
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://5.249.159.211/deadmoon");
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            const string s0 = "";
            const string s1 = "H";
            const string s2 = "Ha";
            const string s3 = "Hai";
            const string s4 = "Hait";
            const string s5 = "Haito";
            const string s6 = "Haitok";
            const string s7 = "Haitoku";

            switch (l1.Text)
            {
                case s0:
                    l1.Text = s1;
                    break;
                case s1:
                    l1.Text = s2;
                    break;
                case s2:
                    l1.Text = s3;
                    break;
                case s3:
                    l1.Text = s4;
                    break;
                case s4:
                    l1.Text = s5;
                    break;
                case s5:
                    l1.Text = s6;
                    break;
                case s6:
                    l1.Text = s7;
                    t1.Stop();
                    t2.Start();
                    break;
                case s7:
                    l1.Text = s0;
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Options.SettingsFile))
                {
                    File.Delete(Options.SettingsFile);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("No account is saved!\nLogin and check 'Remember me'.", "Haitoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void oceantheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Ocean;
            Options.ApplyTheme(this);
            Options.ApplyTheme(_form);
        }

        private void magmatheme_CheckedChanged(object sender, EventArgs e)
        {

            Options.CurrentOptions.Color = Theme.Magma;
            Options.ApplyTheme(this);
            Options.ApplyTheme(_form);
        }

        private void zergtheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Zerg;
            Options.ApplyTheme(this);
            Options.ApplyTheme(_form);
        }

        private void carameltheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Caramel;
            Options.ApplyTheme(this);
            Options.ApplyTheme(_form);
        }

        private void limetheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Lime;
            Options.ApplyTheme(this);
            Options.ApplyTheme(_form);
        }

        private void minimaltheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Minimal;
            Options.ApplyTheme(this);
            Options.ApplyTheme(_form);
        }
    }
}
