using System;

namespace shar_kurs_work.Controllers
{
    [Serializable]
    public class GameStats
    {
        public uint ErrorsNumber { get; set; }
        public uint CorrectAnswersNumber { get; set; }

        public GameStats()
        {
            ErrorsNumber = 0;
            CorrectAnswersNumber = 0;
        }

        public void AddStats(GameStats gameStats)
        {
            ErrorsNumber += gameStats.ErrorsNumber;
            CorrectAnswersNumber += gameStats.CorrectAnswersNumber;
        }
    }
}