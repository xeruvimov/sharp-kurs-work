using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace shar_kurs_work.Dictionary
{
    public static class DictionaryDataBase
    {
        private const string PathToDictionary = ".\\dictionary.txt";
        public static Dictionary<string, string> Dictionary { get; private set; }

        static DictionaryDataBase()
        {
            LoadDictionary();
        }

        private static void LoadDictionary()
        {
            try
            {
                Dictionary = new Dictionary<string, string>();
                var lines = File.ReadLines(PathToDictionary).ToArray();
                foreach (var line in lines)
                {
                    var temp = line.Split(' ');
                    Dictionary[temp[0]] = temp[1];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("File dictionary not load!");
            }
        }
    }
}