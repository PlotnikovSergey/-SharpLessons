using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp7Lesson
{
    public partial class Form1 : Form
    {
        GameUgadayChislo gameUgadayChislo;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameUgadayChislo = new GameUgadayChislo();
            UpdateInfo();
        }

        void UpdateInfo()
        {
            labelNumberOfTries.Text = gameUgadayChislo.TriesCount.ToString();
            labelInfo.Text = gameUgadayChislo.info;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameUgadayChislo == null) return;
            if (textBox1.Text.Trim() != "")
            gameUgadayChislo.guess = Int32.Parse(textBox1.Text);
            gameUgadayChislo.CheckCount();
            UpdateInfo();
        }
    }
}
