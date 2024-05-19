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
    public partial class ViewArmors : Form
    {

        public struct armor
        {
            public int Id_armor;
            public string name, type;

            public armor(int id, string nm, string tp)
            {
                Id_armor = id;
                name = nm;
                type = tp;
            }
        }
        private List<armor> armors = new List<armor>();

        public ViewArmors()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Armor", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    armor ch = new armor((int)dr[0], (string)dr[1], (string)dr[2]);
                    armors.Add(ch);
                    
                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
        }

        private void InitializeState()
        {
            label3.Text = armors[cnt].name;
            label4.Text = armors[cnt].type;


            textBox1.Text = (cnt + 1).ToString() + @"/" + armors.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditArmors e4 = new EditArmors();
            this.Hide();
            e4.Con = con;
            e4.lonk.id = armors[cnt].Id_armor;
            e4.lonk.name = label3.Text;
            e4.lonk.type = label4.Text;
            e4.ShowDialog();
            armors.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddArmors a4 = new AddArmors();
            this.Hide();
            a4.Con = con;
            a4.ShowDialog();
            armors.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void ViewArmors_Load(object sender, EventArgs e)
        {
            GetInfoFromDB();
            InitializeState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt--;
            if (cnt < 0)
            {
                cnt = armors.Count - 1;
            }
            InitializeState();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == armors.Count)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM [Armor] WHERE Id_armor = @id", conn);
                cmd.Parameters.AddWithValue("id", armors[cnt].Id_armor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }

            armors.Clear();
            cnt = 0;
            GetInfoFromDB();
            InitializeState();

        }
    }
}
