using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using HtmlAgilityPack;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Haitoku
{
    public partial class ProfileForm : Form
    {
        string ConnectedUser;
        string ConnectedUserLookUpURL = @"https://myanimelist.net/malappinfo.php?status=all&type=anime&u=";
        string ConnectedUserProfileURL = @"https://myanimelist.net/profile/";
        string ConnectedUserImageURL;

        List<ListViewItem> AnimeList = new List<ListViewItem>();
        List<Anime> Animes = new List<Anime>();
        UserLookup userLookup;

        ListViewItem item;
        List<ListViewItem> items;
        ImageList images;

        private void LoadingStatus(bool flag)
        {
            animeListView.Visible = !flag;
            avatar.Visible = !flag;
            lblAvatar.Visible = flag;
            lblView.Visible = flag;
            txtSearch.Enabled = !flag;
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim().ToLower()))
            {
                animeListView.Clear();
                animeListView.Items.AddRange(AnimeList.ToArray());
            }
            else
            {
                animeListView.Clear();
                foreach (ListViewItem i in AnimeList)
                {
                    if (i.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                    {
                        animeListView.Items.Add(i);
                    }
                }
            }
        }

        private void FetchProfileInfo()
        {
            lblAll.Text = string.Format("All anime: {0}", userLookup.Anime.Count);
            lblWatching.Text = string.Format("Watching: {0}", userLookup.Myinfo.User_watching);
            lblCompleted.Text = string.Format("Completed: {0}", userLookup.Myinfo.User_completed);
            lblOnHold.Text = string.Format("On hold: {0}", userLookup.Myinfo.User_onhold);
            lblDropped.Text = string.Format("Dropped: {0}", userLookup.Myinfo.User_dropped);
            lblPlanToWatch.Text = string.Format("Planned to watch: {0}", userLookup.Myinfo.User_plantowatch);
            lblStats.Text = string.Format("Days spent watching: {0}", userLookup.Myinfo.User_days_spent_watching);

            items = new List<ListViewItem>();
            images = new ImageList();
            images.ImageSize = new Size(96, 128);
            int count = 0;
            animeListView.LargeImageList = images;

            foreach (Anime a in userLookup.Anime)
            {
                images.Images.Add(GetImageFromUrl(a.Series_image));
                item = new ListViewItem();
                item.Text = a.Series_title;
                item.ImageIndex = count++;
                items.Add(item);
                Animes.Add(a);
            }

            animeListView.Items.AddRange(items.ToArray());
            animeListView.Sort();
            
            foreach (ListViewItem i in animeListView.Items)
            {
                AnimeList.Add(i);
               
            }

            LoadingStatus(false);
        }

        private Bitmap GetImageFromUrl(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse resp = request.GetResponse();
            Stream respStream = resp.GetResponseStream();
            Bitmap bmp = new Bitmap(respStream);
            respStream.Dispose();
            return bmp;
        }

        private void GetUserImage()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.DownloadStringAsync(new Uri(ConnectedUserProfileURL + ConnectedUser));
            client.DownloadStringCompleted += Client_DownloadStringCompleted1;
        }

        private void Client_DownloadStringCompleted1(object sender, DownloadStringCompletedEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(e.Result);
            var node = doc.DocumentNode.SelectSingleNode("//div[@class='user-image mb8']");
            ConnectedUserImageURL = node.InnerHtml.Replace("<img src=\"", string.Empty).Replace("\">", string.Empty).Trim();

            avatar.ImageLocation = ConnectedUserImageURL;
        }

        private void GetUserInfo()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.DownloadStringAsync(new Uri(ConnectedUserLookUpURL + ConnectedUser));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserLookup));

                using (TextReader reader = new StringReader(e.Result))
                {
                    userLookup = (UserLookup)serializer.Deserialize(reader);
                    userLookup.Anime = userLookup.Anime.OrderBy(o => o.Series_title).ToList();
                }

                LoadingStatus(true);
                Task t = new Task(() => FetchProfileInfo());
                t.Start();
            }
            catch
            {
                MessageBox.Show("User info can't get fetched!");
            }
        }

        public ProfileForm(string user)
        {
            InitializeComponent();
            Options.ApplyTheme(this);
            ConnectedUser = user;
            lblUser.Text = ConnectedUser;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.Text += Program.GetCurrentVersionToString();

            GetUserImage();
            GetUserInfo();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void animeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (animeListView.SelectedIndices.Count > 0)
            {
                int i = AnimeList.FindIndex(x => x.Text.Equals(animeListView.SelectedItems[0].Text));
                AnimeForm f = new AnimeForm(Animes[i]);
                f.Show();
            }
        }

        private void animeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(ConnectedUserProfileURL + ConnectedUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm(this);
            f.ShowDialog();
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options.SaveSettings();
        }
    }
}
