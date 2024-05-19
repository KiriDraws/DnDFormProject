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
    public partial class ViewSpells : Form
    {
        public struct spell
        {
            public int Id_spell;
            public string name, dmg_type, level;

            public spell(int id, string nm, string dtp, string lv)
            {
                Id_spell = id;
                name = nm;
                dmg_type = dtp;
                level = lv;
            }
        }
        private List<spell> spells = new List<spell>();

        public ViewSpells()
        {
            InitializeComponent();
        }

        private static string con;
        public string Con
        {
            set
            {
                con = value;
            }
        }

        private int cnt = 0;

        private void GetInfoFromDB()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Spell", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    spell ch = new spell((int)dr[0], (string)dr[1], (string)dr[2], (string)dr[3]);
                    spells.Add(ch);

                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
        }

        private void InitializeState()
        {
            label4.Text = spells[cnt].name;
            label5.Text = spells[cnt].dmg_type;
            label6.Text = spells[cnt].level;


            textBox1.Text = (cnt + 1).ToString() + @"/" + spells.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditSpells e6 = new EditSpells();
            this.Hide();
            e6.Con = con;
            e6.lonk.id = spells[cnt].Id_spell;
            e6.lonk.name = label4.Text;
            e6.lonk.dmg_type = label5.Text;
            e6.lonk.level = label6.Text;
            e6.ShowDialog();
            spells.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSpells a6 = new AddSpells();
            this.Hide();
            a6.Con = con;
            a6.ShowDialog();
            spells.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void ViewSpells_Load(object sender, EventArgs e)
        {
            GetInfoFromDB();
            InitializeState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt--;
            if (cnt < 0)
            {
                cnt = spells.Count - 1;
            }
            InitializeState();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == spells.Count)
            {
                cnt = 0;
            }
            InitializeState();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Spell] WHERE Id_spell = @id", conn);
                cmd.Parameters.AddWithValue("id", spells[cnt].Id_spell);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }

            spells.Clear();
            cnt = 0;
            GetInfoFromDB();
            InitializeState();
        }
    }
}
