using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDirector;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WindowsFormsMLTest
{
    public partial class Form1 : Form
    {
        private List<string> JsList = new List<string>();
        private List<BlobDataContract> CsvData = new List<BlobDataContract>();
        private int Index = 0;
        private static ArenaApiDataContract arenaApiData = null;
        private Dictionary<int, GameCategoriesModel> MlVectors = new Dictionary<int, GameCategoriesModel>();

        public Form1()
        {
            InitializeComponent();
            ProgramEnvironment.MlServiceLink = "http://recsys.arkadium-inhabit.com/score";
        }

        private async void CheckButton_Click(object sender, EventArgs e)
        {
            var model = await GetMlmodel(InputTextBox.Text);
            var categotyVector = await GetGameVector(model);
            createChart(pictureBox2, categotyVector);
            DrawVectors(categotyVector);
            if (!MlVectors.ContainsKey(Index))
            {
                MlVectors.Add(Index, categotyVector);
            }
            else
            {
                MlVectors[Index] = categotyVector;
            }
        }


        private void DrawVectors(GameCategoriesModel gameCategoriesModel)
        {
            textBox15.Text = gameCategoriesModel.Action.ToString();
            textBox14.Text = gameCategoriesModel.Arcade.ToString();
            textBox13.Text = gameCategoriesModel.BrainGames.ToString();
            textBox12.Text = gameCategoriesModel.Card.ToString();
            textBox11.Text = gameCategoriesModel.Casino.ToString();
            textBox10.Text = gameCategoriesModel.Crossword.ToString();
            textBox9.Text = gameCategoriesModel.Matching.ToString();
            textBox9.Text = gameCategoriesModel.Matching.ToString();

            textBox3.Text = gameCategoriesModel.MeTVGames.ToString();
            textBox2.Text = gameCategoriesModel.Puzzle.ToString();
            textBox4.Text = gameCategoriesModel.Puzzles.ToString();
            textBox5.Text = gameCategoriesModel.Quizzes.ToString();
            textBox6.Text = gameCategoriesModel.Solitaire.ToString();
            textBox7.Text = gameCategoriesModel.Strategy.ToString();
            textBox8.Text = gameCategoriesModel.Word.ToString();

            if (textBox5.Text != "0")
            {
                //textBox5.BackColor = Color.Red;
            }
        }

        private async  Task<string[]> GetMlmodel(string newModel = "")
        {
            OutputTextBox.Text = string.Empty;
            var input = JsList[Index];
            if (newModel != "")
            {
                input = newModel;
            }

            var result = await SendPost(input);

            var results = JsonConvert.DeserializeObject<List<ResponseDataContract>>(result)[0];
            var log = new StringBuilder();

            var games = "";
            var similarities = "";
            var gameArray = new string[int.Parse(textBox1.Text)];
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                gameArray[i] = results.games[i];
                games += results.games[i] + ", ";
                similarities += results.similarities[i] + ", ";
            }

            log.AppendLine("games");
            log.AppendLine(games);
            log.AppendLine();
            log.AppendLine("similarities");
            log.AppendLine(similarities);
            log.AppendLine();
            OutputTextBox.Text = log.ToString();
            return gameArray;
        }
        
        private async Task<string> SendPost(string json)
        {
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {
                response = await client.PostAsync(
                    ProgramEnvironment.MlServiceLink,
                    new StringContent(json, Encoding.UTF8, "application/json"));
            }
            return await response.Content.ReadAsStringAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProgramEnvironment.ListOfRule == null)
            {
                CsvData = FileHelper.ReadCsv(PathTextBox.Text);
            }
            else if (ProgramEnvironment.ListOfRule.Count == 0)
            {
                CsvData = FileHelper.ReadCsv(PathTextBox.Text);
            }
            else
            {
                foreach (var func in ProgramEnvironment.ListOfRule)
                {
                    CsvData = func(CsvData);
                }
            }
            JsList = JsonCreater.CrreateJson(CsvData);

            listBox1.Items.Clear();
            //listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            //listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.BeginUpdate();
            var i = 0;
            foreach (var js in JsList)
            {
                listBox1.Items.Add(i);
                i++;
            }
            listBox1.EndUpdate();
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curItem = listBox1.SelectedItem.ToString();
            InputTextBox.Text = JsList[Index];

            var element = InputTextBox.Text.Split(new[] { "game_category_vector" }, StringSplitOptions.None)[1].Split(new[] { "user_game_vector" }, StringSplitOptions.None)[0].Substring(4); ;

            var vectors = element.Remove(element.Length - 3).Split(',');
            // Find the string in ListBox2.
            Index = listBox1.FindString(curItem);
            if (Index != -1)
            {
                //    var log = new StringBuilder();
                //    var element = CsvData[Index];
                //    log.AppendLine($"client_CountryOrRegion: {element.client_CountryOrRegion}");
                //    log.AppendLine($"client_StateOrProvince: {element.client_StateOrProvince}");
                //    log.AppendLine($"client_City: {element.client_City}");
                //    log.AppendLine($"client_OS: {element.client_OS}");
                //    log.AppendLine($"client_Model: {element.client_Model}");
                //    log.AppendLine($"client_Browser: {element.client_Browser}");
                //    log.AppendLine($"session_landing_page_vector: {element.session_landing_page_vector}");
                //    log.AppendLine($"session_daytime_vector: {element.session_daytime_vector}");
                //    log.AppendLine($"session_weekend: {element.session_weekend}");
                //    log.AppendLine($"n_session: {element.n_session}");
                //    log.AppendLine($"session_length_mean: {element.session_length_mean}");
                //    log.AppendLine($"session_length_std: {element.session_length_std}");
                //    log.AppendLine($"session_length_sum: {element.session_length_sum}");
                //    log.AppendLine($"game_category_vector: {element.game_category_vector}");
                //    log.AppendLine($"user_game_vector: {element.user_game_vector}");
                //    InputTextBox.Text = log.ToString();
                //    var vectors = element.game_category_vector.Split(',');
                //    ActionTextBox.Text = vectors[0].Substring(1);
                //    ArcadeTextBox.Text = vectors[1];
                //    BrainTextBox.Text = vectors[2];
                //    CardTextBox.Text = vectors[3];
                //    CasinotextBox3.Text = vectors[4];
                //    CrosswordtextBox4.Text = vectors[5];
                //    MatchingtextBox5.Text = vectors[6];
                //    MeTVtextBox11.Text = vectors[7];
                //    PuzzletextBox12.Text = vectors[8];
                //    PuzzlestextBox10.Text = vectors[9];
                //    QuizzestextBox9.Text = vectors[10];
                //    SolitairetextBox8.Text = vectors[11];
                //    StrategytextBox7.Text = vectors[12];
                //    WordtextBox6.Text = vectors[13].Remove(vectors[13].Length - 1);
            //    var vectors = new string[element.Length];
            //for (int i = 0; i < element.Length; i++)
            //{
            //    vectors[i] = element[i].ToString();
            //}

            ActionTextBox.Text = vectors[0];
            ArcadeTextBox.Text = vectors[1];
            BrainTextBox.Text = vectors[2];
            CardTextBox.Text = vectors[3];
            CasinotextBox3.Text = vectors[4];
            CrosswordtextBox4.Text = vectors[5];
            MatchingtextBox5.Text = vectors[6];
            MeTVtextBox11.Text = vectors[7];
            PuzzletextBox12.Text = vectors[8];
            PuzzlestextBox10.Text = vectors[9];
            QuizzestextBox9.Text = vectors[10];
            SolitairetextBox8.Text = vectors[11];
            StrategytextBox7.Text = vectors[12];
            WordtextBox6.Text = vectors[13];


            var categoryVectors = new GameCategoriesModel
                {
                    Action = Convert.ToDouble(vectors[0]),
                    Arcade = Convert.ToDouble(vectors[1]),
                    BrainGames = Convert.ToDouble(vectors[2]),
                    Card = Convert.ToDouble(vectors[3]),
                    Casino = Convert.ToDouble(vectors[4]),
                    Crossword = Convert.ToDouble(vectors[5]),
                    Matching = Convert.ToDouble(vectors[6]),
                    MeTVGames = Convert.ToDouble(vectors[7]),
                    Puzzle = Convert.ToDouble(vectors[8]),
                    Puzzles = Convert.ToDouble(vectors[9]),
                    Quizzes = Convert.ToDouble(vectors[10]),
                    Solitaire = Convert.ToDouble(vectors[11]),
                    Strategy = Convert.ToDouble(vectors[12]),
                    Word = Convert.ToDouble(vectors[13]),
                };
                createChart(pictureBox1, categoryVectors);
                if (!MlVectors.ContainsKey(Index))
                {
                    MlVectors.Add(Index, categoryVectors);
                }

                if (checkBox1.Checked)
                {
                    var model = await GetMlmodel(InputTextBox.Text);
                    var gamevectors = await GetGameVector(model);
                    createChart(pictureBox2, gamevectors);
                    DrawVectors(gamevectors);
                }
            }
        }


        public void createChart(WinChartViewer viewer, GameCategoriesModel vModel)
        {
            // The data for the chart
            double[] data = {
                vModel.Card,
                vModel.Arcade,
                vModel.Matching,
                vModel.Action,
                vModel.Strategy,
                vModel.Word,
                vModel.Puzzles,
                vModel.Crossword,
                vModel.MeTVGames,
                vModel.Quizzes,
                vModel.Casino,
                vModel.BrainGames,
                vModel.Puzzle,
                vModel.Solitaire };

            // The labels for the chart
            string[] labels = { "Card", "Arcade", "Matching", "Action", "Strategy", "Word", "Puzzles", "Crossword", "MeTVGames", "Quizzes", "Casino", "BrainGames", "Puzzle", "Solitaire" };

            // Create a PolarChart object of size 450 x 350 pixels
            PolarChart c = new PolarChart(347, 238);

            // Set center of plot area at (225, 185) with radius 150 pixels
            c.setPlotArea(173, 115, 80);

            // Add an area layer to the polar chart
            c.addAreaLayer(data, 0x9999ff);

            // Set the labels to the angular axis as spokes
            c.angularAxis().setLabels(labels);

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "", "title='{label}: score = {value}'");
        }
        public static async Task<GameCategoriesModel> GetGameVector(string[] games)
        {
            if (arenaApiData == null)
            {
                arenaApiData = await DownloadAsync();
            }

            var categoryVector = new GameCategoriesModel();
            var gameList = games.ToList();
            var weight = 1.0 / games.Length;
            foreach (var game in arenaApiData.games)
            {
                if (gameList.Contains(game.key))
                {
                    foreach (var category in game.categories)
                    {
                        switch (category)
                        {
                            case "Card":
                                categoryVector.Card += weight;
                                break;
                            case "Arcade":
                                categoryVector.Arcade += weight;
                                break;
                            case "Matching":
                                categoryVector.Matching += weight;
                                break;
                            case "Action":
                                categoryVector.Action += weight;
                                break;
                            case "Strategy":
                                categoryVector.Strategy += weight;
                                break;
                            case "Word":
                                categoryVector.Word += weight;
                                break;
                            case "Puzzles":
                                categoryVector.Puzzles += weight;
                                break;
                            case "Crossword":
                                categoryVector.Crossword += weight;
                                break;
                            case "MeTV Games":
                                categoryVector.MeTVGames += weight;
                                break;
                            case "Quizzes":
                                categoryVector.Quizzes += weight;
                                break;
                            case "Casino":
                                categoryVector.Casino += weight;
                                break;
                            case "Brain Games":
                                categoryVector.BrainGames += weight;
                                break;
                            case "Puzzle":
                                categoryVector.Puzzle += weight;
                                break;
                            case "Solitaire":
                                categoryVector.Solitaire += weight;
                                break;
                        }
                    }
                    gameList.Remove(game.key);
                }
                if (gameList.Count == 0)
                {
                    break; ;
                }
            }
            return categoryVector;
        }

        public static async Task<ArenaApiDataContract> DownloadAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync("https://games.metv.com/arenaapi/json");
                var symdication = JsonConvert.DeserializeObject<ArenaApiDataContract>(json);
                return symdication;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var option = new Options();
            option.Show();
        }
    }
}