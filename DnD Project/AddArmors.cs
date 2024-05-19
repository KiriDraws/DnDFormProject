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
    public partial class AddArmors : Form
    {
        public AddArmors()
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
                SqlCommand cmd = new SqlCommand("INSERT INTO [Armor](name, type) VALUES(@nm, @tp)", conn);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("tp", textBox2.Text);          
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();
                this.Close();
            }
        }

        private void AddArmors_Load(object sender, EventArgs e)
        {

        }
    }
}
