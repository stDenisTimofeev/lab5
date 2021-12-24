using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab5
{
    class Data
    {
        public String Text { get; private set; }

        public String FileName { get; private set; }

        public Match Match { get; private set; }

        internal void ReadFromFile(string fileName)
        {
            if (fileName == "")
            {
                Console.WriteLine("Попытка открытия без задания имени");
                return;
            }

            using (StreamReader sr = new StreamReader(fileName))
            {
                this.Text = sr.ReadToEnd().Replace("\r", "");  //стандартный символ конца строки	
                this.FileName = fileName;
            }

        }

        internal void Find(string re)
        {
            if (this.Text == null)
            {
                Console.WriteLine("Попытка поиска без открытия файла");
                return;
            }

            this.Match = Regex.Match(this.Text, re);
        }

        internal void Next()
        {
            Match = Match?.NextMatch();
        }

        public void GetOfOrStatistics(out int ofc, out int orc)
        {
            ofc = 0; orc = 0;
            foreach (Match m in Regex.Matches(this.Text, @"\b(of|or)\b"))
            {
                if (m.Value == "of") ofc++; else orc++;

            }
        }

        public ISet<string> FindSentencesFirstWords()
        {
            ISet<string> words = new HashSet<string>();
            foreach (Match m in Regex.Matches(this.Text, @"[?.!]\s*([A-Z][a-z]*)[^.!]*\?"))
            {
                words.Add(m.Groups[1].Value);
            }
            return words;
        }

        public SortedDictionary<string, int> FirstLetterCounts()
        {
            SortedDictionary<string, int> counts = new SortedDictionary<string, int>();
            Regex r = new Regex(@"(?<=\s)[A-Za-zА-Яа-я]");
            foreach (Match m in r.Matches(this.Text))
            {
                string b = m.Value.ToUpper();
                if (counts.ContainsKey(b))
                {
                    counts[b]++;
                }
                else
                {
                    counts[b] = 1; // при чтении было бы исключение «ключ не найден»
                }
            }
            return counts;
        }

        public List<string> FindTheLongestAdjective()
        {
            List<string> adjectives = new List<string>();
            foreach (Match m in Regex.Matches(this.Text, @"\b[а-я]*(ые|ие|ых|их|ым|им|ыми|ими|юю|ой|яя|ая|ей)\b*"))
            {
                adjectives.Add(m.Groups[0].Value);
            }
            int size = adjectives.Count;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (adjectives[j].Length < adjectives[j + 1].Length)
                    {
                        string temp = adjectives[j];
                        adjectives[j] = adjectives[j + 1];
                        adjectives[j + 1] = temp;
                    }
                }
            }
            return adjectives;
        }

    }
}
