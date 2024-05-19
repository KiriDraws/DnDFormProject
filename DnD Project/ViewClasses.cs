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
    public partial class ViewClasses : Form
    {
        public struct clas
        {
            public int Id_class;
            public string name, dmg_type, role;

            public clas(int id, string nm, string dtp, string rl)
            {
                Id_class = id;
                name = nm;
                dmg_type = dtp;
                role = rl;
            }
        }
        private List<clas> classes = new List<clas>();

        public ViewClasses()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Class", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clas ch = new clas((int)dr[0], (string)dr[1], (string)dr[2], (string)dr[3]);
                    classes.Add(ch);

                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
        }

        private void InitializeState()
        {
            label4.Text = classes[cnt].name;
            label5.Text = classes[cnt].dmg_type;
            label6.Text = classes[cnt].role;


            textBox1.Text = (cnt + 1).ToString() + @"/" + classes.Count.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            EditClasses e3 = new EditClasses();
            this.Hide();
            e3.Con = con;
            e3.lonk.id = classes[cnt].Id_class;
            e3.lonk.name = label4.Text;
            e3.lonk.dmg_type = label5.Text;
            e3.lonk.role = label6.Text;
            e3.ShowDialog();
            classes.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddClasses a3 = new AddClasses();
            this.Hide();
            a3.Con = con;
            a3.ShowDialog();
            classes.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void ViewClasses_Load(object sender, EventArgs e)
        {
            GetInfoFromDB();
            InitializeState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt--;
            if (cnt < 0)
            {
                cnt = classes.Count - 1;
            }
            InitializeState();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == classes.Count)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM [Class] WHERE Id_class = @id", conn);
                cmd.Parameters.AddWithValue("id", classes[cnt].Id_class);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }

            classes.Clear();
            cnt = 0;
            GetInfoFromDB();
            InitializeState();
        }
    }
}
