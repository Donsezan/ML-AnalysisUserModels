namespace WindowsFormsMLTest
{
    public class BlobDataContract
    {
        public string user_anon_id { get; set; }
        public string client_CountryOrRegion { get; set; }
        public string client_StateOrProvince { get; set; }
        public string client_City { get; set; }
        public string client_OS { get; set; }
        public string client_Model { get; set; }
        public string client_Browser { get; set; }
        public string session_landing_page_vector { get; set; }
        public string session_daytime_vector { get; set; }
        public string session_weekend { get; set; }
        public string n_session { get; set; }
        public string session_length_mean { get; set; }
        public string session_length_std { get; set; }
        public string session_length_sum { get; set; }
        public string game_session_daytime_vector { get; set; }
        public string n_game_session { get; set; }
        public string game_session_weekend { get; set; }
        public string game_session_length_mean { get; set; }

        public string game_session_length_std { get; set; }
        public string game_session_length_sum { get; set; }
        public string game_completion_rate { get; set; }
        public string game_category_vector { get; set; }
        public string user_game_vector { get; set; }

    }
}