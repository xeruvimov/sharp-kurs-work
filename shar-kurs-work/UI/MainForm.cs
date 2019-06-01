using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using shar_kurs_work.Controllers;

namespace shar_kurs_work.UI
{
    public partial class MainForm : Form
    {
        private bool _learning;
        private GameStats _gameStats;

        public MainForm()
        {
            LoadStats();
            InitializeComponent();
        }

        private void easyLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewGame(LevelGame.Easy);
        }

        private void NewGame(LevelGame levelGame)
        {
            _learning = true;
            translateList.Visible = false;
            translateLabel.Visible = true;
            enterButton.Enabled = true;

            GameController.InitGame(levelGame);
            NextLearningWord();
        }

        private void NextLearningWord()
        {
            var currentPair = GameController.NextLearningPair();
            if (!currentPair.Equals(default(KeyValuePair<string, string>)))
            {
                currentWord.Text = currentPair.Key;
                translateLabel.Text = currentPair.Value;
            }
            else
            {
                StartTesting();
            }
        }

        private void NextTestingWord()
        {
            currentWord.Text = GameController.NextTestingWord();
            if (currentWord.Text == "")
            {
                EndGame();
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (_learning)
            {
                NextLearningWord();
            }
            else
            {
                CheckWordPair();
            }
        }

        private void mediumLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame(LevelGame.Medium);
        }

        private void hardLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewGame(LevelGame.Hard);
        }

        private void StartTesting()
        {
            _learning = false;

            translateLabel.Visible = false;
            translateList.Visible = true;

            translateList.DataSource = null;
            translateList.DataSource = GameController.CurrentListValue;
            NextTestingWord();
        }

        private void CheckWordPair()
        {
            if (!GameController.FindPair(currentWord.Text, translateList.SelectedItem.ToString()))
            {
                translateList.ClearSelected();
                MessageBox.Show("Error. Try again");
                GameController.CurrentGameStats.ErrorsNumber++;
            }
            else
            {
                GameController.CurrentGameStats.CorrectAnswersNumber++;
                NextTestingWord();
            }
        }

        private void EndGame()
        {
            _learning = true;
            translateList.Visible = false;
            translateLabel.Visible = true;
            enterButton.Enabled = false;
            translateLabel.Text = "WordTranslate";
            currentWord.Text = "Word";
            SaveStats();
            ShowStats(GameController.CurrentGameStats);
        }

        private void SaveStats()
        {
            _gameStats.AddStats(GameController.CurrentGameStats);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameStats));

            using (FileStream fs = new FileStream("gamestats.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, _gameStats);
            }
        }

        private void LoadStats()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameStats));

            try
            {
                using (FileStream fs = new FileStream("gamestats.xml", FileMode.OpenOrCreate))
                {
                    _gameStats = (GameStats) xmlSerializer.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                _gameStats = new GameStats();
            }
        }

        private void viewResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStats(_gameStats);
        }

        private static void ShowStats(GameStats gameStats)
        {
            MessageBox.Show("Number of correct answer: " + gameStats.CorrectAnswersNumber + "\nNumber of errors: " +
                            gameStats.ErrorsNumber);
        }

        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gameStats.ErrorsNumber = 0;
            _gameStats.CorrectAnswersNumber = 0;
            SaveStats();
        }

        private void translateList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && translateList.SelectedIndex != -1)
            {
                if (_learning)
                {
                    NextLearningWord();
                }
                else
                {
                    CheckWordPair();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is bug. You found her");
        }
    }
}