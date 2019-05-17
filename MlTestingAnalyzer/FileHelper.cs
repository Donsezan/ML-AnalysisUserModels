using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsMLTest
{
    public static class FileHelper
    {
        public static List<BlobDataContract> ReadCsv(string path)
        {
            if (path == "Path to Csv DataBase")
            {
                path = @"D:\users_2019-04-23.csv";
            }
            var csvList = new List<BlobDataContract>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);
                    var blobElement = new BlobDataContract
                    {
                        user_anon_id = values[0].Replace("\"\"", "").Replace("\"", ""),
                        client_CountryOrRegion = values[1],
                        client_StateOrProvince = values[2],
                        client_City = values[3],
                        client_OS = values[4],
                        client_Model = values[5],
                        client_Browser = values[6],
                        session_landing_page_vector = values[7],
                        session_daytime_vector = values[8],
                        session_weekend = values[9],
                        n_session = values[10],
                        session_length_mean = values[11],
                        session_length_std = values[12],
                        session_length_sum = values[13],
                        game_session_daytime_vector = values[14],
                        user_game_vector = values[22].Replace("\"\"", "\""),
                        n_game_session = values[15],
                        game_session_weekend = values[16],
                        game_session_length_mean = values[17],
                        game_session_length_std = values[18],
                        game_session_length_sum = values[19],
                        game_completion_rate = values[20],
                        game_category_vector = values[21],

                    };
                    if (blobElement.n_session == "n_session")
                    {
                        continue;
                    }
                    csvList.Add(blobElement);
                }
            }

            return csvList;
        }
    }
}