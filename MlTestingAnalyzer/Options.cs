using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsMLTest.Rules;

namespace WindowsFormsMLTest
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            LicnkTextBox.Text = ProgramEnvironment.MlServiceLink;
            if (ProgramEnvironment.FiltrState == null)
            {
                ProgramEnvironment.FiltrState = new BlobDataContract();
                ProgramEnvironment.FilterBoolState = new bool[22];
            }
            else
            {
                textBox1.Text = ProgramEnvironment.FiltrState.client_CountryOrRegion;
                checkBox1.Checked = ProgramEnvironment.FilterBoolState[0];
                textBox2.Text = ProgramEnvironment.FiltrState.client_StateOrProvince;
                checkBox2.Checked = ProgramEnvironment.FilterBoolState[1];
                textBox3.Text = ProgramEnvironment.FiltrState.client_City;
                checkBox3.Checked = ProgramEnvironment.FilterBoolState[2];
                textBox4.Text = ProgramEnvironment.FiltrState.client_OS;
                checkBox4.Checked = ProgramEnvironment.FilterBoolState[3];
                textBox5.Text = ProgramEnvironment.FiltrState.client_Model;
                checkBox5.Checked = ProgramEnvironment.FilterBoolState[4];
                textBox6.Text = ProgramEnvironment.FiltrState.client_Browser;
                checkBox6.Checked = ProgramEnvironment.FilterBoolState[5];
                textBox7.Text = ProgramEnvironment.FiltrState.session_landing_page_vector;
                checkBox7.Checked = ProgramEnvironment.FilterBoolState[6];
                textBox8.Text = ProgramEnvironment.FiltrState.session_daytime_vector;
                checkBox8.Checked = ProgramEnvironment.FilterBoolState[7];
                textBox9.Text = ProgramEnvironment.FiltrState.session_weekend;
                checkBox9.Checked = ProgramEnvironment.FilterBoolState[8];
                textBox13.Text = ProgramEnvironment.FiltrState.n_session;
                checkBox15.Checked = ProgramEnvironment.FilterBoolState[9];
                textBox10.Text = ProgramEnvironment.FiltrState.session_length_mean;
                checkBox10.Checked = ProgramEnvironment.FilterBoolState[10];
                textBox11.Text = ProgramEnvironment.FiltrState.session_length_std;
                checkBox11.Checked = ProgramEnvironment.FilterBoolState[11];
                textBox12.Text = ProgramEnvironment.FiltrState.session_length_sum;
                checkBox12.Checked = ProgramEnvironment.FilterBoolState[12];
                textBox14.Text = ProgramEnvironment.FiltrState.game_category_vector;
                checkBox13.Checked = ProgramEnvironment.FilterBoolState[13];
                textBox15.Text = ProgramEnvironment.FiltrState.user_game_vector;
                checkBox14.Checked = ProgramEnvironment.FilterBoolState[14];


                textBox16.Text = ProgramEnvironment.FiltrState.n_game_session;
                checkBox16.Checked = ProgramEnvironment.FilterBoolState[15];

                textBox17.Text = ProgramEnvironment.FiltrState.game_session_weekend;
                checkBox17.Checked = ProgramEnvironment.FilterBoolState[16];

                textBox18.Text = ProgramEnvironment.FiltrState.game_session_length_mean;
                checkBox18.Checked = ProgramEnvironment.FilterBoolState[17];

                textBox19.Text = ProgramEnvironment.FiltrState.game_session_length_std;
                checkBox19.Checked = ProgramEnvironment.FilterBoolState[18];

                textBox20.Text = ProgramEnvironment.FiltrState.game_session_length_sum;
                checkBox20.Checked = ProgramEnvironment.FilterBoolState[19];

                textBox21.Text = ProgramEnvironment.FiltrState.game_completion_rate;
                checkBox21.Checked = ProgramEnvironment.FilterBoolState[20];

                textBox22.Text = ProgramEnvironment.FiltrState.user_anon_id;
                checkBox22.Checked = ProgramEnvironment.FilterBoolState[21];

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listOfRule = new List<Func<List<BlobDataContract>, List<BlobDataContract>>>();
            if (textBox1.Text != string.Empty)
            {
                var splitKeys = textBox1.Text.Split(',');
                listOfRule.Add(x => new ClientCountryOrRegion(x).RuleForList(splitKeys, checkBox1.Checked));
                ProgramEnvironment.FiltrState.client_CountryOrRegion = textBox1.Text;
                ProgramEnvironment.FilterBoolState[0] = checkBox1.Checked;
            }
            if (textBox2.Text != string.Empty)
            {
                var splitKeys = textBox2.Text.Split(',');
                listOfRule.Add(x => new ClientStateOrProvince(x).RuleForList(splitKeys, checkBox2.Checked));
                ProgramEnvironment.FiltrState.client_StateOrProvince = textBox2.Text;
                ProgramEnvironment.FilterBoolState[1] = checkBox2.Checked;
            }
            if (textBox3.Text != string.Empty)
            {
                var splitKeys = textBox3.Text.Split(',');
                listOfRule.Add(x => new ClientCity(x).RuleForList(splitKeys, checkBox3.Checked));
                ProgramEnvironment.FiltrState.client_City = textBox3.Text;
                ProgramEnvironment.FilterBoolState[2] = checkBox3.Checked;
            }
            if (textBox4.Text != string.Empty)
            {
                var splitKeys = textBox4.Text.Split(',');
                listOfRule.Add(x => new ClientOS(x).RuleForList(splitKeys, checkBox4.Checked));
                ProgramEnvironment.FiltrState.client_OS = textBox4.Text;
                ProgramEnvironment.FilterBoolState[3] = checkBox4.Checked;
            }
            if (textBox5.Text != string.Empty)
            {
                var splitKeys = textBox5.Text.Split(',');
                listOfRule.Add(x => new ClientModel(x).RuleForList(splitKeys, checkBox5.Checked));
                ProgramEnvironment.FiltrState.client_Model = textBox5.Text;
                ProgramEnvironment.FilterBoolState[4] = checkBox5.Checked;
            }
            if (textBox6.Text != string.Empty)
            {
                var splitKeys = textBox6.Text.Split(',');
                listOfRule.Add(x => new ClientBrowser(x).RuleForList(splitKeys, checkBox6.Checked));
                ProgramEnvironment.FiltrState.client_Browser = textBox6.Text;
                ProgramEnvironment.FilterBoolState[5] = checkBox6.Checked;
            }
            if (textBox7.Text != string.Empty)
            {
                var splitKeys = textBox7.Text.Split(',');
                listOfRule.Add(x => new SessionLandingPageVector(x).RuleForList(splitKeys, checkBox7.Checked));
                ProgramEnvironment.FiltrState.session_landing_page_vector = textBox7.Text;
                ProgramEnvironment.FilterBoolState[6] = checkBox7.Checked;
            }
            if (textBox8.Text != string.Empty)
            {
                var splitKeys = textBox8.Text.Split(',');
                listOfRule.Add(x => new SessionDaytimeVector(x).RuleForList(splitKeys, checkBox8.Checked));
                ProgramEnvironment.FiltrState.session_daytime_vector = textBox8.Text;
                ProgramEnvironment.FilterBoolState[7] = checkBox8.Checked;
            }
            if (textBox9.Text != string.Empty)
            {
                var splitKeys = textBox9.Text.Split(',');
                listOfRule.Add(x => new SessionWeekend(x).RuleForList(splitKeys, checkBox9.Checked));
                ProgramEnvironment.FiltrState.session_weekend = textBox9.Text;
                ProgramEnvironment.FilterBoolState[8] = checkBox9.Checked;
            }
            if (textBox13.Text != string.Empty)
            {
                var splitKeys = textBox13.Text.Split(',');
                listOfRule.Add(x => new NSession(x).RuleForList(splitKeys, checkBox15.Checked));
                ProgramEnvironment.FiltrState.n_session = textBox13.Text;
                ProgramEnvironment.FilterBoolState[9] = checkBox15.Checked;
            }
            if (textBox10.Text != string.Empty)
            {
                var splitKeys = textBox10.Text.Split(',');
                listOfRule.Add(x => new SessionLengthMean(x).RuleForList(splitKeys, checkBox10.Checked));
                ProgramEnvironment.FiltrState.session_length_mean = textBox10.Text;
                ProgramEnvironment.FilterBoolState[10] = checkBox10.Checked;
            }
            if (textBox11.Text != string.Empty)
            {
                var splitKeys = textBox11.Text.Split(',');
                listOfRule.Add(x => new SessionLengthStd(x).RuleForList(splitKeys, checkBox11.Checked));
                ProgramEnvironment.FiltrState.session_length_std = textBox11.Text;
                ProgramEnvironment.FilterBoolState[11] = checkBox11.Checked;
            }
            if (textBox12.Text != string.Empty)
            {
                var splitKeys = textBox12.Text.Split(',');
                listOfRule.Add(x => new SessionLengthSum(x).RuleForList(splitKeys, checkBox12.Checked));
                ProgramEnvironment.FiltrState.session_length_sum = textBox12.Text;
                ProgramEnvironment.FilterBoolState[12] = checkBox12.Checked;
            }
            if (textBox14.Text != string.Empty)
            {
                var splitKeys = textBox14.Text.Split(',');
                listOfRule.Add(x => new GameCategoryVector(x).RuleForList(splitKeys, checkBox13.Checked));
                ProgramEnvironment.FiltrState.game_category_vector = textBox14.Text;
                ProgramEnvironment.FilterBoolState[13] = checkBox13.Checked;
            }
            if (textBox15.Text != string.Empty)
            {
                var splitKeys = textBox15.Text.Split(',');
                listOfRule.Add(x => new UserGameVector(x).RuleForList(splitKeys, checkBox14.Checked));
                ProgramEnvironment.FiltrState.user_game_vector = textBox15.Text;
                ProgramEnvironment.FilterBoolState[14] = checkBox14.Checked;
            }
            //////
            if (textBox16.Text != string.Empty)
            {
                var splitKeys = textBox16.Text.Split(',');
                listOfRule.Add(x => new NGameSesion(x).RuleForList(splitKeys, checkBox16.Checked));
                ProgramEnvironment.FiltrState.n_game_session = textBox16.Text;
                ProgramEnvironment.FilterBoolState[15] = checkBox16.Checked;
            }
            if (textBox17.Text != string.Empty)
            {
                var splitKeys = textBox17.Text.Split(',');
                listOfRule.Add(x => new GameSessionWeekend(x).RuleForList(splitKeys, checkBox17.Checked));
                ProgramEnvironment.FiltrState.game_session_weekend = textBox17.Text;
                ProgramEnvironment.FilterBoolState[16] = checkBox17.Checked;
            }
            if (textBox18.Text != string.Empty)
            {
                var splitKeys = textBox18.Text.Split(',');
                listOfRule.Add(x => new GameSessionLengthMean(x).RuleForList(splitKeys, checkBox18.Checked));
                ProgramEnvironment.FiltrState.game_session_length_mean = textBox18.Text;
                ProgramEnvironment.FilterBoolState[17] = checkBox18.Checked;
            }
            if (textBox19.Text != string.Empty)
            {
                var splitKeys = textBox19.Text.Split(',');
                listOfRule.Add(x => new GameSessionLengthStd(x).RuleForList(splitKeys, checkBox19.Checked));
                ProgramEnvironment.FiltrState.game_session_length_std = textBox19.Text;
                ProgramEnvironment.FilterBoolState[18] = checkBox19.Checked;
            }
            if (textBox20.Text != string.Empty)
            {
                var splitKeys = textBox20.Text.Split(',');
                listOfRule.Add(x => new GameSessionLengthSum(x).RuleForList(splitKeys, checkBox20.Checked));
                ProgramEnvironment.FiltrState.game_session_length_sum = textBox20.Text;
                ProgramEnvironment.FilterBoolState[19] = checkBox20.Checked;
            }
            if (textBox21.Text != string.Empty)
            {
                var splitKeys = textBox21.Text.Split(',');
                listOfRule.Add(x => new GameCompletionRate(x).RuleForList(splitKeys, checkBox21.Checked));
                ProgramEnvironment.FiltrState.game_completion_rate = textBox21.Text;
                ProgramEnvironment.FilterBoolState[20] = checkBox21.Checked;
            }
            if (textBox22.Text != string.Empty)
            {
                var splitKeys = textBox22.Text.Split(',');
                listOfRule.Add(x => new UserAnonId(x).RuleForList(splitKeys, checkBox22.Checked));
                ProgramEnvironment.FiltrState.user_anon_id = textBox22.Text;
                ProgramEnvironment.FilterBoolState[21] = checkBox21.Checked;
            }




            ProgramEnvironment.MlServiceLink = LicnkTextBox.Text;
            ProgramEnvironment.ListOfRule = listOfRule;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
