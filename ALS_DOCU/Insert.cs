using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ALS_DOCU
{
    public partial class Insert : UserControl
    {
        public Dictionary<string, List<List<string>>> doc ;
        string doc_txt = "als_documentation.txt";

        public Insert()
        {
            InitializeComponent();
        }



        private void Insert_Load(object sender, EventArgs e)
        {

            if (File.Exists(doc_txt))
            {
                GetFormats();
                FillCb();
            }
            else File.Create(doc_txt);
        }

        private void GetFormats()
        {
            string[] lines = File.ReadAllLines(doc_txt);
            string current = "";

            Dictionary<string, List<List<string>>> dico = new Dictionary<string, List<List<string>>>();
            bool isReadingDesc = false;
            int _lsNr = 0;

            foreach (var line in lines)
            {

                string _t = line.Trim(new char[] { ' ', '\t' });
                if (!string.IsNullOrEmpty(_t))
                {
                    if (isReadingDesc)
                    {
                        if (_t.StartsWith("]")) isReadingDesc = false;
                        else dico[current][_lsNr][1] += line;
                    }
                    else
                    {
                        if (_lsNr != 0) _lsNr++;

                        if (_t.StartsWith("+"))
                        {
                            current = _t.Replace("+", "");
                            dico.Add(current, new List<List<string>>());
                        }
                        else
                        {
                            if (_t.StartsWith("-")) dico[current][_lsNr][0] = line.Remove(0, 1); 
                            else if (_t.StartsWith("[")) isReadingDesc = true;
                        }
                    }
                }
            }

            doc = dico;
        }

        private void FillCb()
        {
            comboBox1.Items.Clear();
            #pragma warning disable IDE0059
            foreach (var item in doc.Keys) comboBox1.Items.Add(item);
            #pragma warning restore IDE0059
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!doc.Keys.Contains(newCatTxt.Text))
            {
                File.AppendAllText(doc_txt, "\n\n+" + newCatTxt.Text);
                GetFormats();
                FillCb();
                comboBox1.SelectedItem = newCatTxt.Text;
                newCatTxt.Clear();
            }
            else MessageBox.Show("This Category Already Exists !");
        }

        private void AddNewEntryBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PrototypeName.Text) && !string.IsNullOrEmpty(desc.Text) && comboBox1.SelectedIndex != -1)
            {
                doc[comboBox1.SelectedItem.ToString()].Add(new List<string>(new string[] {
                    PrototypeName.Text,
                    desc.Text
                }));

                WriteChanges();
            }
            else MessageBox.Show("+ Please Fill all infos .. !");
        }


        private void WriteChanges()
        {
            string str = string.Empty;

            foreach (var item in doc)
            {
                str += $"+{item.Key}\n\n";
                foreach (var ls in item.Value) str += $"-{ls[0]}\n[\n{ls[1]}\n]\n\n";
            }
            File.WriteAllText(doc_txt, str);
            
            desc.Clear();
            PrototypeName.Clear();
        }
    }
}
