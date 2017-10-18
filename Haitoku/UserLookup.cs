using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Haitoku
{
    [XmlRoot(ElementName = "myinfo")]
    public class UserInfo
    {
        [XmlElement(ElementName = "user_id")]
        public string User_id { get; set; }
        [XmlElement(ElementName = "user_name")]
        public string User_name { get; set; }
        [XmlElement(ElementName = "user_watching")]
        public string User_watching { get; set; }
        [XmlElement(ElementName = "user_completed")]
        public string User_completed { get; set; }
        [XmlElement(ElementName = "user_onhold")]
        public string User_onhold { get; set; }
        [XmlElement(ElementName = "user_dropped")]
        public string User_dropped { get; set; }
        [XmlElement(ElementName = "user_plantowatch")]
        public string User_plantowatch { get; set; }
        [XmlElement(ElementName = "user_days_spent_watching")]
        public string User_days_spent_watching { get; set; }
    }

    [XmlRoot(ElementName = "anime")]
    public class Anime
    {
        [XmlElement(ElementName = "series_animedb_id")]
        public string Series_animedb_id { get; set; }
        [XmlElement(ElementName = "series_title")]
        public string Series_title { get; set; }
        [XmlElement(ElementName = "series_synonyms")]
        public string Series_synonyms { get; set; }
        [XmlElement(ElementName = "series_type")]
        public string Series_type { get; set; }
        [XmlElement(ElementName = "series_episodes")]
        public string Series_episodes { get; set; }
        [XmlElement(ElementName = "series_status")]
        public string Series_status { get; set; }
        [XmlElement(ElementName = "series_start")]
        public string Series_start { get; set; }
        [XmlElement(ElementName = "series_end")]
        public string Series_end { get; set; }
        [XmlElement(ElementName = "series_image")]
        public string Series_image { get; set; }
        [XmlElement(ElementName = "my_id")]
        public string My_id { get; set; }
        [XmlElement(ElementName = "my_watched_episodes")]
        public string My_watched_episodes { get; set; }
        [XmlElement(ElementName = "my_start_date")]
        public string My_start_date { get; set; }
        [XmlElement(ElementName = "my_finish_date")]
        public string My_finish_date { get; set; }
        [XmlElement(ElementName = "my_score")]
        public string My_score { get; set; }
        [XmlElement(ElementName = "my_status")]
        public string My_status { get; set; }
        [XmlElement(ElementName = "my_rewatching")]
        public string My_rewatching { get; set; }
        [XmlElement(ElementName = "my_rewatching_ep")]
        public string My_rewatching_ep { get; set; }
        [XmlElement(ElementName = "my_last_updated")]
        public string My_last_updated { get; set; }
        [XmlElement(ElementName = "my_tags")]
        public string My_tags { get; set; }
    }

    [XmlRoot(ElementName = "myanimelist")]
    public class UserLookup
    {
        [XmlElement(ElementName = "myinfo")]
        public UserInfo Myinfo { get; set; }
        [XmlElement(ElementName = "anime")]
        public List<Anime> Anime { get; set; }
    }

}
