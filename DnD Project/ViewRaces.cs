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
    public partial class ViewRaces : Form
    {

        public struct race
        {
            public int Id_race;
            public string name, racial, size, speed;

            public race(int id, string nm, string rl, string sz, string sp)
            {
                Id_race = id;
                name = nm;
                racial = rl;
                size = sz;
                speed = sp;
            }
        }
        private List<race> races = new List<race>();

        public ViewRaces()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Race", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    race ch = new race((int)dr[0], (string)dr[1], (string)dr[2], (string)dr[3], (string)dr[4]);
                    races.Add(ch);

                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
        }

        private void InitializeState()
        {
            label5.Text = races[cnt].name;
            label6.Text = races[cnt].racial;
            label7.Text = races[cnt].size;
            label8.Text = races[cnt].speed;


            textBox1.Text = (cnt + 1).ToString() + @"/" + races.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRaces e2 = new EditRaces();
            this.Hide();
            e2.Con = con;
            e2.lonk.id = races[cnt].Id_race;
            e2.lonk.name = label5.Text;
            e2.lonk.racial = label6.Text;
            e2.lonk.size = label7.Text;
            e2.lonk.speed = label8.Text;
            e2.ShowDialog();
            races.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRaces a2 = new AddRaces();
            this.Hide();
            a2.Con = con;
            a2.ShowDialog();
            races.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void ViewRaces_Load(object sender, EventArgs e)
        {
            GetInfoFromDB();
            InitializeState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt--;
            if (cnt < 0)
            {
                cnt = races.Count - 1;
            }
            InitializeState();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == races.Count)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM [Race] WHERE Id_race = @id", conn);
                cmd.Parameters.AddWithValue("id", races[cnt].Id_race);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }

            races.Clear();
            cnt = 0;
            GetInfoFromDB();
            InitializeState();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
