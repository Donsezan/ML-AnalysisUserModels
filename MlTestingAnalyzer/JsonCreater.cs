using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest
{
    public static class JsonCreater
    {
        public static List<string> CrreateJson(List<BlobDataContract> blobDataContracts, int limit)
        {
            var jsList = new List<string>();
            var startIteration = 0;
            foreach (var blob in blobDataContracts)
            {
                var js = string.Empty;

                js += "[{";
                js += $"\"user_anon_id\": \"{blob.user_anon_id}\",";
                js += $"\"client_CountryOrRegion\": \"{blob.client_CountryOrRegion}\",";
                js += $"\"client_StateOrProvince\": \"{blob.client_StateOrProvince}\",";
                js += $"\"client_City\": \"{blob.client_City}\",";
                js += $"\"client_OS\": \"{blob.client_OS}\",";
                js += $"\"client_Model\": \"{blob.client_Model}\",";
                js += $"\"client_Browser\": \"{blob.client_Browser}\",";
                js += $"\"session_landing_page_vector\": {blob.session_landing_page_vector},"; // array
                js += $"\"session_daytime_vector\": {blob.session_daytime_vector},"; //array
                js += $"\"session_weekend\": {blob.session_weekend},";
                js += $"\"n_session\": {blob.n_session},";
                js += $"\"session_length_mean\": {blob.session_length_mean},";
                js += $"\"session_length_std\": {blob.session_length_std},";
                js += $"\"session_length_sum\": {blob.session_length_sum},";
                js += $"\"game_session_daytime_vector\": {blob.game_session_daytime_vector},";
                js += $"\"n_game_session\": {blob.n_game_session},";
                js += $"\"game_session_weekend\": {blob.game_session_weekend},";
                js += $"\"game_session_length_mean\": {blob.game_session_length_mean},";
                js += $"\"game_session_length_std\": {blob.game_session_length_std},";
                js += $"\"game_session_length_sum\": {blob.game_session_length_sum},";
                js += $"\"game_completion_rate\": {blob.game_completion_rate},";
                js += $"\"game_category_vector\": {blob.game_category_vector},"; //array
                js += $"\"user_game_vector\": {blob.user_game_vector.Remove(blob.user_game_vector.Length - 1)},"; //array
                js += $"\"timestamp\":\"{DateTime.Now:o}\"";
                js += "}]";
                jsList.Add(js);
                startIteration++;
                if (startIteration > limit)
                {
                    break;
                }
            }

            return jsList;
        }

        public static string CrreateJson(BlobDataContract blob)
        {
            var limit = 0;
            var js = string.Empty;
            js += "[{";
            js += $"\"user_anon_id\": \"{blob.user_anon_id}\",";
            js += $"\"client_CountryOrRegion\": \"{blob.client_CountryOrRegion}\",";
            js += $"\"client_StateOrProvince\": \"{blob.client_StateOrProvince}\",";
            js += $"\"client_City\": \"{blob.client_City}\",";
            js += $"\"client_OS\": \"{blob.client_OS}\",";
            js += $"\"client_Model\": \"{blob.client_Model}\",";
            js += $"\"client_Browser\": \"{blob.client_Browser}\",";
            js += $"\"session_landing_page_vector\": {blob.session_landing_page_vector},"; // array
            js += $"\"session_daytime_vector\": {blob.session_daytime_vector},"; //array
            js += $"\"session_weekend\": {blob.session_weekend},";
            js += $"\"n_session\": {blob.n_session},";
            js += $"\"session_length_mean\": {blob.session_length_mean},";
            js += $"\"session_length_std\": {blob.session_length_std},";
            js += $"\"session_length_sum\": {blob.session_length_sum},";
            js += $"\"game_session_daytime_vector\": {blob.game_session_daytime_vector},";// array
            js += $"\"n_game_session\": {blob.n_game_session},";
            js += $"\"game_session_weekend\": {blob.game_session_weekend},";
            js += $"\"game_session_length_mean\": {blob.game_session_length_mean},";
            js += $"\"game_session_length_std\": {blob.game_session_length_std},";
            js += $"\"game_session_length_sum\": {blob.game_session_length_sum},";
            js += $"\"game_completion_rate\": {blob.game_completion_rate},";
            js += $"\"game_category_vector\": {blob.game_category_vector},"; //array
            js += $"\"user_game_vector\": {blob.user_game_vector.Remove(blob.user_game_vector.Length - 1)},"; //array
            js += $"\"timestamp\":\"{DateTime.Now:o}\"";
            js += "}]";
            limit++;
            return js;
        }
    }
}