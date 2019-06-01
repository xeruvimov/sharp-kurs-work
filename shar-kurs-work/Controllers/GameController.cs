using System;
using System.Collections.Generic;
using System.Linq;
using shar_kurs_work.Dictionary;

namespace shar_kurs_work.Controllers
{
    public static class GameController
    {
        private static readonly Random Rnd = new Random();
        public static Dictionary<string, string> Dict { get; private set; }
        private static Dictionary<string, string>.Enumerator _itr;

        private static List<string> CurrentListKey { get; } = new List<string>();
        private static List<string>.Enumerator _wordItr;
        public static List<string> CurrentListValue { get; } = new List<string>();

        public static void InitGame(LevelGame levelGame)
        {
            Dict = GetWords(levelGame);
            _itr = Dict.GetEnumerator();

            foreach (var keyValuePair in Dict)
            {
                CurrentListKey.Add(keyValuePair.Key);
                CurrentListValue.Add(keyValuePair.Value);
            }

            Shuffle(CurrentListKey);
            Shuffle(CurrentListValue);

            _wordItr = CurrentListKey.GetEnumerator();
        }

        private static Dictionary<string, string> GetWords(LevelGame levelGame)
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

        public static KeyValuePair<string, string> NextLearningPair()
        {
            _itr.MoveNext();
            return _itr.Current;
        }

        public static string NextTestingWord()
        {
            _wordItr.MoveNext();
            return _wordItr.Current;
        }

        public static bool FindPair(string key, string value)
        {
            return Dict[key].Equals(value);
        }

        private static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}