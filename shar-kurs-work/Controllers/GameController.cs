using System;
using System.Collections.Generic;
using System.Linq;
using shar_kurs_work.Dictionary;

namespace shar_kurs_work.Controllers
{
    public static class GameController
    {
        private static Random rnd = new Random();

        public static Dictionary<string, string> GetWords(LevelGame levelGame)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            List<KeyValuePair<string, string>> tmp = DictionaryDataBase.Dictionary.ToList();
            Shuffle(tmp);

            for (int i = 0; i < (int) levelGame; i++)
            {
                result.Add(tmp[i].Key, tmp[i].Value);
            }

            return result;
        }

        private static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}