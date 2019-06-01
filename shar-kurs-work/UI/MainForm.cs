using System;
using System.Collections.Generic;
using System.Windows.Forms;
using shar_kurs_work.Controllers;

namespace shar_kurs_work.UI
{
    public partial class MainForm : Form
    {
        private bool _learning;

        public MainForm()
        {
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
                MessageBox.Show("Error. Try again");
            }
            else
            {
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
        }
    }
}