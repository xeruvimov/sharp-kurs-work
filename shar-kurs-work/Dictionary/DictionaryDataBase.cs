using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace shar_kurs_work.Dictionary
{
    public static class DictionaryDataBase
    {
        private const String PathToDictionary = ".\\dictionary.txt";
        public static Dictionary<string, string> Dictionary { get; set; }

        static DictionaryDataBase()
        {
            LoadDictionary();
        }

        private static void LoadDictionary()
        {
            Dictionary = new Dictionary<string, string>();
            String[] lines = File.ReadLines(PathToDictionary).ToArray();
            foreach (var line in lines)
            {
                String[] temp = line.Split(' ');
                Dictionary[temp[0]] = temp[1];
            }
        }

        public static bool FindPair(String key, String value)
        {
            return Dictionary[key].Equals(value);
        }
    }
}