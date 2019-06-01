using System;
using System.Collections.Generic;
using System.Windows.Forms;
using shar_kurs_work.Controllers;

namespace shar_kurs_work.UI
{
    public partial class MainForm : Form
    {
        private bool Learning;
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
            Learning = true;
            translateList.Visible = false;
            translateLabel.Visible = true;

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
                Learning = false;
                StartTesting();
            }
        }

        private void NextTestingWord()
        {
            currentWord.Text = GameController.NextTestingWord();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (Learning)
            {
                NextLearningWord();
            }
            else
            {
                NextTestingWord();
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
            translateLabel.Visible = false;
            translateList.Visible = true;

            translateList.DataSource = GameController.CurrentListValue;
            NextTestingWord();
        }
    }
}