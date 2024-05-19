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
    public partial class AddClasses : Form
    {
        public AddClasses()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Class](name, dmg_type, role) VALUES(@nm, @dtp, @rl)", conn);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("dtp", textBox2.Text); cmd.Parameters.AddWithValue("rl", textBox3.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();
                this.Close();
            }
        }
    }
}
