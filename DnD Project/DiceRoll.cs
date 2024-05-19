using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Project
{
    public partial class DiceRoll : Form
    {
        public DiceRoll()
        {
            InitializeComponent();
        }

        private void AllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cB = (CheckBox)sender;
            switch(cB.Text)
            {
                case "d4":
                    nUDd4.Visible = cB.Checked;
                    break;
                case "d6":
                    nUDd6.Visible = cB.Checked;
                    break;
                case "d10":
                    nUDd10.Visible = cB.Checked;
                    break;
                case "d12":
                    nUDd12.Visible = cB.Checked;
                    break;
                case "d20":
                    nUDd20.Visible = cB.Checked;
                    break;
                case "d100":
                    nUDd100.Visible = cB.Checked;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 450;
            nUDd4.Controls[0].Enabled = false; nUDd4.Controls[0].Hide();
            nUDd6.Controls[0].Enabled = false; nUDd6.Controls[0].Hide();
            nUDd10.Controls[0].Enabled = false; nUDd10.Controls[0].Hide();
            nUDd12.Controls[0].Enabled = false; nUDd12.Controls[0].Hide();
            nUDd20.Controls[0].Enabled = false; nUDd20.Controls[0].Hide();
            nUDd100.Controls[0].Enabled = false; nUDd100.Controls[0].Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int SUM = 0;
            Random rand = new Random();
            #region THROWURI DE DICE, CA SA FIE BEAUTIFUL
            if (cBd4.Checked)
            {
                int lim = (int)nUDd4.Value, thr, locsum = 0;
                List<int> res = new List<int>();
                string prop = "";

                for (int i = 1; i <= lim; i++)
                {
                    thr = rand.Next(1, 5);
                    res.Add(thr);
                    SUM += thr;
                }

                prop += (lim == 1 ? (lim + " d4: ") : (lim + " d4: "));
                for (int num = 0; num < res.Count(); num++)
                {
                    prop += (num == res.Count() - 1) ? (res[num] + " ") : (res[num] + " + ");
                    locsum += res[num];
                }
                prop += ("= " + locsum);
                listBox1.Items.Add(prop);
                listBox1.Items.Add("");
            }
            if (cBd6.Checked)
            {
                int lim = (int)nUDd6.Value, thr, locsum = 0;
                List<int> res = new List<int>();
                string prop = "";

                for (int i = 1; i <= lim; i++)
                {
                    thr = rand.Next(1, 7);
                    res.Add(thr);
                    SUM += thr;
                }

                prop += (lim == 1 ? (lim + " d6: ") : (lim + " d6: "));
                for (int num = 0; num < res.Count(); num++)
                {
                    prop += (num == res.Count() - 1) ? (res[num] + " ") : (res[num] + " + ");
                    locsum += res[num];
                }
                prop += ("= " + locsum);
                listBox1.Items.Add(prop);
                listBox1.Items.Add("");
            }
            if (cBd10.Checked)
            {
                int lim = (int)nUDd10.Value, thr, locsum = 0;
                List<int> res = new List<int>();
                string prop = "";

                for (int i = 1; i <= lim; i++)
                {
                    thr = rand.Next(1, 11);
                    res.Add(thr);
                    SUM += thr;
                }

                prop += (lim == 1 ? (lim + " d10: ") : (lim + " d10: "));
                for (int num = 0; num < res.Count(); num++)
                {
                    prop += (num == res.Count() - 1) ? (res[num] + " ") : (res[num] + " + ");
                    locsum += res[num];
                }
                prop += ("= " + locsum);
                listBox1.Items.Add(prop);
                listBox1.Items.Add("");
            }
            if (cBd12.Checked)
            {
                int lim = (int)nUDd12.Value, thr, locsum = 0;
                List<int> res = new List<int>();
                string prop = "";

                for (int i = 1; i <= lim; i++)
                {
                    thr = rand.Next(1, 13);
                    res.Add(thr);
                    SUM += thr;
                }

                prop += (lim == 1 ? (lim + " d12: ") : (lim + " d12: "));
                for (int num = 0; num < res.Count(); num++)
                {
                    prop += (num == res.Count() - 1) ? (res[num] + " ") : (res[num] + " + ");
                    locsum += res[num];
                }
                prop += ("= " + locsum);
                listBox1.Items.Add(prop);
                listBox1.Items.Add("");
            }
            if (cBd20.Checked)
            {
                int lim = (int)nUDd20.Value, thr, locsum = 0;
                List<int> res = new List<int>();
                string prop = "";

                for (int i = 1; i <= lim; i++)
                {
                    thr = rand.Next(1, 21);
                    res.Add(thr);
                    SUM += thr;
                }

                prop += (lim == 1 ? (lim + " d20: ") : (lim + " d20: "));
                for (int num = 0; num < res.Count(); num++)
                {
                    prop += (num == res.Count() - 1) ? (res[num] + " ") : (res[num] + " + ");
                    locsum += res[num];
                }
                prop += ("= " + locsum);
                listBox1.Items.Add(prop);
                listBox1.Items.Add("");
            }
            if (cBd100.Checked)
            {
                int lim = (int)nUDd100.Value, thr, locsum = 0;
                List<int> res = new List<int>();
                string prop = "";

                for (int i = 1; i <= lim; i++)
                {
                    thr = rand.Next(1, 101);
                    res.Add(thr);
                    SUM += thr;
                }

                prop += (lim == 1 ? (lim + " d100: ") : (lim + " d100: "));
                for (int num = 0; num < res.Count(); num++)
                {
                    prop += (num == res.Count() - 1) ? (res[num] + " ") : (res[num] + " + ");
                    locsum += res[num];
                }
                prop += ("= " + locsum);
                listBox1.Items.Add(prop);
                listBox1.Items.Add("");
            }
            #endregion

            listBox1.Items.Add("TOTAL: " + SUM);
            this.Width = 750;

        }
    }
}
