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
    public partial class AddWeapons : Form
    {
        public AddWeapons()
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Weapon](name, dmg_type, rarity) VALUES(@nm, @dtp, @rt)", conn);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("dtp", textBox2.Text);
                cmd.Parameters.AddWithValue("rt", textBox3.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();
                this.Close();
            }
        }
    }
}
