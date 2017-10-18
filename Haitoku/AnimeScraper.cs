using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haitoku
{
    public class AnimeScraper
    {
        string Anime;
        string AnimeGetBase = "http://www.animeget.io";
        string AnimeGet = "http://www.animeget.io/?s=";

        private string ExtractLink(string text)
        {
            string link = string.Empty;
            Regex urlRx = new Regex(@"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*", RegexOptions.IgnoreCase);
            MatchCollection matches = urlRx.Matches(text);
            link = matches[0].Value;

            return link;
        }

        public AnimeScraper(string anime)
        {
            this.Anime = anime.Replace("-", string.Empty).Replace(":", string.Empty).Trim();
        }

        public string SearchWithAnimeGet()
        {
            string found = string.Empty;
            if (!string.IsNullOrEmpty(this.Anime))
            {
                try
                {
                    if (this.Anime == "Elfen Lied") { this.Anime = "Elfien Lied"; }
                    AnimeGet += this.Anime;

                    WebClient searcher = new WebClient();
                    searcher.Encoding = Encoding.UTF8;
                    string result = searcher.DownloadString(new Uri(AnimeGet));

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(result);

                    var node = doc.DocumentNode.SelectNodes("//div[@class='title']");

                    if (node.Where(x => x.InnerHtml.Contains(this.Anime)).Count() < 1)
                    {
                        MessageBox.Show(string.Format("'{0}' can't be found in animeget.io!", this.Anime));
                    }
                    else if (node.Where(x => x.InnerHtml.Contains(this.Anime)).Count() > 1)
                    {
                        found = AnimeGet;
                    }
                    else
                    {
                        found = AnimeGetBase += node.First().SelectNodes("a[@href]").First().Attributes["href"].Value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR: Searching for anime", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return found;
        }
    }
}
