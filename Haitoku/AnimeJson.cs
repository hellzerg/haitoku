using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haitoku
{
    public class Payload
    {
        public string media_type { get; set; }
        public int start_year { get; set; }
        public string aired { get; set; }
        public string score { get; set; }
        public string status { get; set; }
        public List<string> related_works { get; set; }
        public int? favorites { get; set; }
        public string published { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string thumbnail_url { get; set; }
        public Payload payload { get; set; }
        public double es_score { get; set; }
    }

    public class Category
    {
        public string type { get; set; }
        public List<Item> items { get; set; }
    }

    public class AnimeJson
    {
        public List<Category> categories { get; set; }
    }
}
