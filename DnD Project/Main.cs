using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DnD_Project
{
    public partial class Main : Form
    {
        private static string amogus = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Furry\Desktop\Atestat Info\DnD\DnD Project\DnD Project\bin\Debug\dndDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(amogus);

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCharacter f1 = new ViewCharacter();
            this.Hide();
            f1.Con = amogus;
            f1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewRaces f2 = new ViewRaces();
            this.Hide();
            f2.Con = amogus;
            f2.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewClasses f3 = new ViewClasses();
            this.Hide();
            f3.Con = amogus;
            f3.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewArmors f4 = new ViewArmors();
            this.Hide();
            f4.Con = amogus;
            f4.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewWeapons f5 = new ViewWeapons();
            this.Hide();
            f5.Con = amogus;
            f5.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewSpells f6 = new ViewSpells();
            this.Hide();
            f6.Con = amogus;
            f6.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DiceRoll f7 = new DiceRoll();
            this.Hide();
            f7.ShowDialog();
            this.Show();
        }
    }
}
