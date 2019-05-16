using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTL
{
    public partial class RegexFormView : Form
    {
        Regex r;
        public RegexFormView()
        {
            InitializeComponent();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (tbxPattern.Text.Equals(string.Empty) && tbxText.Text.Equals(string.Empty))
                return;

            string input = tbxText.Text;
            string output = "";
            string pattern = tbxPattern.Text;
            string history = "";

            try
            {
                history = rtbxPatternHistory.Lines.First();
            }catch(Exception exc) { }
            
            r = new Regex(pattern);

            MatchCollection matches = r.Matches(input);

            output += $"{matches.Count} matches were found\n";
            foreach (Match m in matches)
            {
                output += $"    '{m}' found at index {m.Index} to {m.Index + m.Length}\n";
            }

            rtbxPatternMatches.Text = output;
            
            if(!pattern.Equals(history))
                rtbxPatternHistory.Text = $"{tbxPattern.Text}\n" + rtbxPatternHistory.Text;
        }
        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader file = new StreamReader(openFileDialog1.OpenFile());
            string content = file.ReadToEnd();
            tbxText.Text = content;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
