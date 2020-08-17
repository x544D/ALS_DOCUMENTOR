using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALS_DOCU
{
    public partial class Form1 : Form
    {
        int mod = 0;
        Insert InsertUc = new Insert { Dock = DockStyle.Fill };
        Search SearchUC = new Search { Dock = DockStyle.Fill };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(InsertUc);
        }

        private void searchMod_Click(object sender, EventArgs e)
        {
            //mod = 1;
            if (mod == 1) MessageBox.Show("+ You are already in Insertion Mode !");
            else
            {
                mod = 1;
                MainPanel.Controls.Remove(InsertUc);
                MainPanel.Controls.Add(SearchUC);
            }
        }

        private void insertMod_Click(object sender, EventArgs e)
        {
            if (mod == 0) MessageBox.Show("+ You are already in Insertion Mode !");
            else
            {
                mod = 0;

                MainPanel.Controls.Remove(SearchUC);
                MainPanel.Controls.Add(InsertUc);
            }
        }
    }
}
