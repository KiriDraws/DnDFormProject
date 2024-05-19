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
    public partial class AddCharacter : Form
    {
        public AddCharacter()
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
                SqlCommand cmd = new SqlCommand("INSERT INTO [Character](name, level, Id_race, Id_class, Id_alignment, " +
                    "Id_armor, Id_weapon, Id_spell) VALUES(@nm, @lv, @rc, @cl, @al, @ar, @wp, @sp)", conn);
                cmd.Parameters.AddWithValue("nm", textBox1.Text); cmd.Parameters.AddWithValue("lv", textBox2.Text);
                cmd.Parameters.AddWithValue("rc", (int)comboBox1.SelectedValue); cmd.Parameters.AddWithValue("cl", (int)comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("al", (int)comboBox3.SelectedValue); cmd.Parameters.AddWithValue("ar", (int)comboBox4.SelectedValue);
                cmd.Parameters.AddWithValue("wp", (int)comboBox5.SelectedValue); cmd.Parameters.AddWithValue("sp", (int)comboBox6.SelectedValue);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();
                this.Close();
            }
        }

        private void AddCharacter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dndSusDataSet.Spell' table. You can move, or remove it, as needed.
            this.spellTableAdapter.Fill(this.dndSusDataSet.Spell);
            // TODO: This line of code loads data into the 'dndSusDataSet.Weapon' table. You can move, or remove it, as needed.
            this.weaponTableAdapter.Fill(this.dndSusDataSet.Weapon);
            // TODO: This line of code loads data into the 'dndSusDataSet.Armor' table. You can move, or remove it, as needed.
            this.armorTableAdapter.Fill(this.dndSusDataSet.Armor);
            // TODO: This line of code loads data into the 'dndSusDataSet.Alignment' table. You can move, or remove it, as needed.
            this.alignmentTableAdapter.Fill(this.dndSusDataSet.Alignment);
            // TODO: This line of code loads data into the 'dndSusDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dndSusDataSet.Class);
            // TODO: This line of code loads data into the 'dndSusDataSet.Race' table. You can move, or remove it, as needed.
            this.raceTableAdapter.Fill(this.dndSusDataSet.Race);

        }
    }
}
