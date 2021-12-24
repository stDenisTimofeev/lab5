using lab5.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class MainForm : Form
    {
        Data data = new Data();

        public MainForm()
        {
            InitializeComponent();
            this.lstbRegex.Items.Add(@"\b(\S)\S+(\S)\b");
            this.lstbRegex.Items.Add(@"\b(\S)\S*\1\b");
            this.lstbRegex.Items.Add(@"([LMXIV]+)\n");
            this.lstbRegex.Items.Add(@"\b\d{4}\b");

            this.lstbRegex.Items.Add(@"\b(([A-Z])[a-z]+)\?");
            this.lstbRegex.Items.Add(@"\s(k...)\s");
            this.lstbRegex.Items.Add(@"\b(of|or)\b"); 
            
            
            this.lstbRegex.Items.Add(@"\bо[а-я]+");
            this.lstbRegex.Items.Add(@"\bо[а-я]{5,}");
            this.lstbRegex.Items.Add(@"\bо\S+");
            this.lstbRegex.Items.Add(@"\b[а-я]*(ить|ать)\b");
            this.lstbRegex.Items.Add(@"[А-Я].*[.!?]+");
            
            
            this.lstbRegex.Click += (s, e) =>
            {
                this.txtbFindString.Text = lstbRegex.Text;
                Find(s, e);
            };
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // расширения
            dlg.FilterIndex = 1;
            DialogResult res = dlg.ShowDialog(); // показываем диалог и ждём ok или отмены
            if (res == DialogResult.OK) // если не нажали отмену
            {
                data.ReadFromFile(dlg.FileName);
                Console.WriteLine($"File is open: {dlg.FileName}");
                rtbFileText.Text = data.Text;
            }

        }

        private void Find(object sender, EventArgs e)
        {
            data.Find(txtbFindString.Text);
            this.ShowMatch();
        }

        private void ShowMatch()
        {
            Match m = data.Match; // получить m из data
            if (m != null && m.Success)
            {
                rtbFileText.SelectionBackColor = Color.White; // сброс подсветки
                rtbFileText.SelectionStart = m.Index;
                // начало - место, на котором
                // в строке найдено регулярное выражение
                rtbFileText.SelectionLength = m.Value.Length;
                // длина найденного фрагмента
                rtbFileText.ScrollToCaret(); // прокрутка на выделенное место
                rtbFileText.SelectionBackColor = Color.Yellow; // подсветка

                rtbSearchResult.Text = $"Найдено[{m.Index}]: ##{m.Value}##\n";
                for (int i = 0; i < m.Groups.Count; i++)
                {
                    rtbSearchResult.Text += String.Format("Groups[{0}]={1}\n", i, m.Groups[i]);
                }


            }

        }

        private void NextMatch(object sender, EventArgs e)
        {
            data.Next();
            this.ShowMatch();
        }

        private void DownAnyKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Find(sender, e);
                e.SuppressKeyPress = true; // дальше событие нажатие кнопки игнорируется
            }

        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            Settings.Default.FileName = data.FileName;
            Settings.Default.Save();

        }

        private void LoadSettings(object sender, EventArgs e)
        {
            data.ReadFromFile(Settings.Default.FileName);
            Console.WriteLine($"File is open: {data.FileName}");
            rtbFileText.Text = data.Text;
        }

        private void ofOrClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ofc, orc;
            data.GetOfOrStatistics(out ofc, out orc);
            rtbSearchResult.Text = $" of: {ofc}, or: {orc}";

        }

        private void firstWordInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISet<String> words = data.FindSentencesFirstWords();
            rtbSearchResult.Text = String.Join(", ", words);

        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new StatisticsForm(data.FirstLetterCounts()).Show();
        }

        private void OpenIndividualTask(object sender, EventArgs e)
        {
            List<String> adjectives = data.FindTheLongestAdjective();
            for (int i = 0; i < 16; i++)
            {
                if (i == 0)
                {
                    rtbSearchResult.Text = rtbSearchResult.Text + adjectives[i];
                }
                else
                {
                    rtbSearchResult.Text = rtbSearchResult.Text + ", " + adjectives[i];
                }
                
            }
            
            
        }
    }
}

