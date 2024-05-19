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
    public partial class EditCharacter : Form
    {
        public EditCharacter()
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
            public int level;
            public string race;
            public string clas;
            public string alignment;
            public string armor;
            public string weapon;
            public string spell;
        }

        public link lonk;

        private void InitializeState()
        {
            textBox1.Text = lonk.name; textBox2.Text = Convert.ToString(lonk.level);
            comboBox1.Text = lonk.race; comboBox2.Text = lonk.clas;
            comboBox3.Text = lonk.alignment; comboBox4.Text = lonk.armor;
            comboBox5.Text = lonk.weapon; comboBox6.Text = lonk.spell;
        }

        private void EditCharacter_Load(object sender, EventArgs e)
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
            InitializeState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [character] SET name = @nm, level = @lv, Id_race = @rc, Id_class = @cl," +
                    " Id_alignment = @al, Id_armor = @ar, Id_weapon = @wp, Id_spell = @sp WHERE Id_character = @id", conn);
                cmd.Parameters.AddWithValue("id", lonk.id);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
