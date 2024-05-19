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
    public partial class EditRaces : Form
    {
        public EditRaces()
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

        public struct link
        {
            public int id;
            public string name;
            public string racial;
            public string size;
            public string speed;
        }

        public link lonk;

        private void InitializeState()
        {
            textBox1.Text = lonk.name; textBox2.Text = lonk.racial; textBox3.Text = lonk.size; textBox4.Text = lonk.speed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [race] SET name = @nm, racial = @ra, size = @sz, speed = @sp WHERE Id_race = @id", conn);
                cmd.Parameters.AddWithValue("id", lonk.id);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("ra", textBox2.Text);
                cmd.Parameters.AddWithValue("sz", textBox3.Text); cmd.Parameters.AddWithValue("sp", textBox4.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                this.Close();
            }
        }

        private void EditRaces_Load(object sender, EventArgs e)
        {
            InitializeState();
        }
    }
}
