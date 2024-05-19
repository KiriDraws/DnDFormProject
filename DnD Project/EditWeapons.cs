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
    public partial class EditWeapons : Form
    {
        public EditWeapons()
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
            public string dmg_type;
            public string rarity;
        }

        public link lonk;

        private void InitializeState()
        {
            textBox1.Text = lonk.name; textBox2.Text = lonk.dmg_type; textBox3.Text = lonk.rarity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [weapon] SET name = @nm, dmg_type = @dtp, rarity = @rt WHERE Id_weapon = @id", conn);
                cmd.Parameters.AddWithValue("id", lonk.id);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("dtp", textBox2.Text);
                cmd.Parameters.AddWithValue("rt", textBox3.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                this.Close();
            }
        }

        private void EditWeapons_Load(object sender, EventArgs e)
        {
            InitializeState();
        }
    }
}
