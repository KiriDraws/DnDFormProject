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
    public partial class ViewWeapons : Form
    {
        public struct weapon
        {
            public int Id_weapon;
            public string name, dmg_type, rarity;

            public weapon(int id, string nm, string dtp, string ry)
            {
                Id_weapon = id;
                name = nm;
                dmg_type = dtp;
                rarity = ry;
            }
        }
        private List<weapon> weapons = new List<weapon>();

        public ViewWeapons()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Weapon", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    weapon ch = new weapon((int)dr[0], (string)dr[1], (string)dr[2], (string)dr[3]);
                    weapons.Add(ch);

                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
        }

        private void InitializeState()
        {
            label4.Text = weapons[cnt].name;
            label5.Text = weapons[cnt].dmg_type;
            label6.Text = weapons[cnt].rarity;


            textBox1.Text = (cnt + 1).ToString() + @"/" + weapons.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditWeapons e5 = new EditWeapons();
            this.Hide();
            e5.Con = con;
            e5.lonk.id = weapons[cnt].Id_weapon;
            e5.lonk.name = label4.Text;
            e5.lonk.dmg_type = label5.Text;
            e5.lonk.rarity = label6.Text;
            e5.ShowDialog();
            weapons.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddWeapons a5 = new AddWeapons();
            this.Hide();
            a5.Con = con;
            a5.ShowDialog();
            weapons.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void ViewWeapons_Load(object sender, EventArgs e)
        {
            GetInfoFromDB();
            InitializeState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt--;
            if (cnt < 0)
            {
                cnt = weapons.Count - 1;
            }
            InitializeState();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == weapons.Count)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM [Weapon] WHERE Id_weapon = @id", conn);
                cmd.Parameters.AddWithValue("id", weapons[cnt].Id_weapon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }

            weapons.Clear();
            cnt = 0;
            GetInfoFromDB();
            InitializeState();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
