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
    public partial class EditArmors : Form
    {
        public EditArmors()
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
            public string type;
        }

        public link lonk;

        private void InitializeState()
        {
            textBox1.Text = lonk.name; textBox2.Text = lonk.type;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [armor] SET name = @nm, type = @tp WHERE Id_armor = @id", conn);
                cmd.Parameters.AddWithValue("id", lonk.id);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("tp", textBox2.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                this.Close();
            }
        }

        private void EditArmors_Load(object sender, EventArgs e)
        {
            InitializeState();
        }
    }
}
