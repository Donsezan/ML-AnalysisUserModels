using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WindowsFormsMLTest
{

    [DataContract]
    public class Image
    {

        [DataMember(Name = "width")]
        public string width { get; set; }

        [DataMember(Name = "height")]
        public string height { get; set; }

        [DataMember(Name = "url")]
        public string url { get; set; }

        [DataMember(Name = "key")]
        public string key { get; set; }
    }

    [DataContract]
    public class Screenshot
    {

        [DataMember(Name = "width")]
        public string width { get; set; }

        [DataMember(Name = "height")]
        public string height { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "url")]
        public string url { get; set; }
    }

    [DataContract]
    public class PersonalizationRank
    {

        [DataMember(Name = "platform")]
        public string platform { get; set; }

        [DataMember(Name = "rank")]
        public string rank { get; set; }
    }

    [DataContract]
    public class Technology
    {

        [DataMember(Name = "width")]
        public string width { get; set; }

        [DataMember(Name = "height")]
        public string height { get; set; }

        [DataMember(Name = "programmingTechnology")]
        public string programmingTechnology { get; set; }

        [DataMember(Name = "url")]
        public string url { get; set; }

        [DataMember(Name = "arenaUrl")]
        public string arenaUrl { get; set; }
    }

    [DataContract]
    public class Game
    {

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "key")]
        public string key { get; set; }

        [DataMember(Name = "images")]
        public IList<Image> images { get; set; }

        [DataMember(Name = "screenshots")]
        public IList<Screenshot> screenshots { get; set; }

        [DataMember(Name = "shortDescription")]
        public string shortDescription { get; set; }

        [DataMember(Name = "longDescription")]
        public string longDescription { get; set; }

        [DataMember(Name = "personalization-ranks")]
        public IList<PersonalizationRank> personalizationRanks { get; set; }

        [DataMember(Name = "platform")]
        public string platform { get; set; }

        [DataMember(Name = "contentType")]
        public string contentType { get; set; }

        [DataMember(Name = "categories")]
        public IList<string> categories { get; set; }

        [DataMember(Name = "technologies")]
        public IList<Technology> technologies { get; set; }
    }

    [DataContract]
    public class ArenaApiDataContract
    {

        [DataMember(Name = "games")]
        public IList<Game> games { get; set; }
    }
}