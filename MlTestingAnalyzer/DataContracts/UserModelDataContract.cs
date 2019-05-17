using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WindowsFormsMLTest
{
   
    [DataContract]
    public class UserModelDataContract
    {

        [DataMember(Name = "client_CountryOrRegion")]
        public string client_CountryOrRegion { get; set; }

        [DataMember(Name = "client_StateOrProvince")]
        public string client_StateOrProvince { get; set; }

        [DataMember(Name = "client_City")]
        public string client_City { get; set; }

        [DataMember(Name = "client_OS")]
        public string client_OS { get; set; }

        [DataMember(Name = "client_Model")]
        public string client_Model { get; set; }

        [DataMember(Name = "client_Browser")]
        public string client_Browser { get; set; }

        [DataMember(Name = "session_landing_page_vector")]
        public IList<double> session_landing_page_vector { get; set; }

        [DataMember(Name = "session_daytime_vector")]
        public IList<double> session_daytime_vector { get; set; }

        [DataMember(Name = "session_weekend")]
        public int session_weekend { get; set; }

        [DataMember(Name = "n_session")]
        public int n_session { get; set; }

        [DataMember(Name = "session_length_mean")]
        public double session_length_mean { get; set; }

        [DataMember(Name = "session_length_std")]
        public int session_length_std { get; set; }

        [DataMember(Name = "session_length_sum")]
        public double session_length_sum { get; set; }

        [DataMember(Name = "game_category_vector")]
        public IList<double> game_category_vector { get; set; }

        [DataMember(Name = "user_game_vector")]
        public string user_game_vector { get; set; }

        [DataMember(Name = "timestamp")]
        public DateTime timestamp { get; set; }
    }


}