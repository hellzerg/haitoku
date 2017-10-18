using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using System.Text.RegularExpressions;

namespace Haitoku
{
    public partial class AnimeForm : Form
    {
        string term = string.Empty;
        string AnimeURL = string.Empty;

        Anime anime;
        AnimeJson json;
        AnimeScraper scraper;

        private void GetAnimeInfo()
        {
            pictureBox1.ImageLocation = anime.Series_image;
            this.Text = anime.Series_title;
            lblAnimeTitle.Text = anime.Series_title;
            term = anime.Series_title;

            try
            {
                AnimeURL = string.Format("https://myanimelist.net/search/prefix.json?type=anime&keyword={0}&v=1", term);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                client.DownloadStringAsync(new Uri(AnimeURL));
                client.DownloadStringCompleted += Client_DownloadStringCompleted;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR: Fetching anime info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FetchAnimeInfo()
        {
            string url = json.categories[0].items[0].url;

            try
            {
                lblLoading.Visible = true;
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                wc.DownloadStringAsync(new Uri(url));
                wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: Fetching anime synopsis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string year = json.categories[0].items[0].payload.start_year.ToString();
            string aired = json.categories[0].items[0].payload.aired;
            string finished = anime.Series_end;
            string score = json.categories[0].items[0].payload.score;
            string status = json.categories[0].items[0].payload.status;
            string episodes = anime.Series_episodes;
            //string synonyms = anime.Series_synonyms;

            if (finished.Equals("0000-00-00"))
            {
                finished = "-";
            }

            lblEpisodes.Text = "Episodes: " + episodes;
            lblYear.Text = "Year: " + year;
            lblAired.Text = "Aired: " + aired;
            lblFinished.Text = "Finished: " + finished;
            lblStatus.Text = "Status: " + status;
            lblScore.Text = "Score: " + score;
            //lblSynonyms.Text = "Synonyms: " + synonyms; 
        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(e.Result);

                var node = doc.DocumentNode.SelectSingleNode("//span[@itemprop='description']");
                txtSynopsis.Text = WebUtility.HtmlDecode(node.InnerText);
            }
            catch (Exception ex)
            {
                txtSynopsis.Text = "Error while fetching anime synopsis:\n\n" + ex.Message;
            }
            lblLoading.Visible = false;
        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            json = JsonConvert.DeserializeObject<AnimeJson>(e.Result);

            FetchAnimeInfo();
        }

        public AnimeForm(Anime a)
        {
            InitializeComponent();
            Options.ApplyTheme(this);
            anime = a;
            scraper = new AnimeScraper(anime.Series_title);
        }

        private void AnimeForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            GetAnimeInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = scraper.SearchWithAnimeGet();
            if (!string.IsNullOrEmpty(r))
            {
                Process.Start(r);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(json.categories[0].items[0].url);
        }
    }
}
