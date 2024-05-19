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
    public partial class ViewCharacter : Form
    {
        public struct character
        {
            public int Id_character;
            public string name;
            public int level, Id_race, Id_class, Id_alignment, Id_armor, Id_weapon, Id_spell;

            public character(int id, string nm, int lv, int rc, int cl, int al, int ar, int wp, int sp)
            {
                Id_character = id;
                name = nm;
                level = lv; Id_race = rc; Id_class = cl; Id_alignment = al; Id_armor = ar; Id_weapon = wp; Id_spell = sp;
            }
        }
        private List<character> characters = new List<character>();

        public struct racebond
        {
            public int Id_race;
            public string name;
            public racebond(int rc, string nrc)
            {
                Id_race = rc; name = nrc;
            }
        }
        List<racebond> racebonds = new List<racebond>();

        public struct classbond
        {
            public int Id_class;
            public string name;
            public classbond(int cl, string ncl)
            {
                Id_class = cl; name = ncl;
            }
        }
        List<classbond> classbonds = new List<classbond>();

        public struct alignbond
        {
            public int Id_alignment;
            public string name;
            public alignbond(int al, string nal)
            {
                Id_alignment = al; name = nal;
            }
        }
        List<alignbond> alignbonds = new List<alignbond>();

        public struct armorbond
        {
            public int Id_armor;
            public string name;
            public armorbond(int ar, string nar)
            {
                Id_armor = ar; name = nar;
            }
        }
        List<armorbond> armorbonds = new List<armorbond>();

        public struct weaponbond
        {
            public int Id_weapon;
            public string name;
            public weaponbond(int wp, string nwp)
            {
                Id_weapon = wp; name = nwp;
            }
        }
        List<weaponbond> weaponbonds = new List<weaponbond>();

        public struct spellbond
        {
            public int Id_spell;
            public string name;
            public spellbond(int sp, string nsp)
            {
                Id_spell = sp; name = nsp;
            }
        }
        List<spellbond> spellbonds = new List<spellbond>();

        


        public ViewCharacter()
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
                SqlCommand cmd = new SqlCommand("SELECT Character.*, Race.name, Class.name, Alignment.name, Armor.name, Weapon.name, Spell.name FROM Race, Class, Alignment, Armor, Weapon, Spell, Character WHERE Character.Id_race = Race.Id_race AND Character.Id_class = Class.Id_class " +
                    "AND Character.Id_alignment = Alignment.Id_Alignment AND Character.Id_armor = Armor.Id_armor AND Character.Id_weapon = Weapon.Id_weapon AND Character.Id_spell = Spell.Id_spell", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    character ch = new character((int)dr[0], (string)dr[1], (int)dr[2], (int)dr[3], (int)dr[4], (int)dr[5], (int)dr[6], (int)dr[7], (int)dr[8]);
                    characters.Add(ch);
                    racebond race = new racebond((int)dr[3], (string)dr[9]);
                    racebonds.Add(race);

                    classbond cls = new classbond((int)dr[4], (string)dr[10]);
                    classbonds.Add(cls);
                    
                    alignbond aln = new alignbond((int)dr[5], (string)dr[11]);
                    alignbonds.Add(aln);
                    
                    armorbond arm = new armorbond((int)dr[6], (string)dr[12]);
                    armorbonds.Add(arm);
                    
                    weaponbond wpn = new weaponbond((int)dr[7], (string)dr[13]);
                    weaponbonds.Add(wpn);
                    
                    spellbond spl = new spellbond((int)dr[8], (string)dr[14]);
                    spellbonds.Add(spl);
                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
        }

        private void InitializeState()
        {
            label9.Text = characters[cnt].name;
            label10.Text = characters[cnt].level.ToString();
            label11.Text = racebonds[cnt].name;
            label12.Text = classbonds[cnt].name;
            label13.Text = alignbonds[cnt].name;
            label14.Text = armorbonds[cnt].name;
            label15.Text = weaponbonds[cnt].name;
            label16.Text = spellbonds[cnt].name;

            textBox1.Text = (cnt + 1).ToString() + @"/" + characters.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCharacter e1 = new EditCharacter();
            this.Hide();
            e1.Con = con;
            e1.lonk.id = characters[cnt].Id_character;
            e1.lonk.name = label9.Text;
            e1.lonk.level = Convert.ToInt32(label10.Text);
            e1.lonk.race = label11.Text;
            e1.lonk.clas = label12.Text;
            e1.lonk.alignment = label13.Text;
            e1.lonk.armor = label14.Text;
            e1.lonk.weapon = label15.Text;
            e1.lonk.spell = label16.Text;
            e1.ShowDialog();
            characters.Clear();
            racebonds.Clear();
            classbonds.Clear();
            alignbonds.Clear();
            armorbonds.Clear();
            weaponbonds.Clear();
            spellbonds.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCharacter a1 = new AddCharacter();
            this.Hide();
            a1.Con = con;
            a1.ShowDialog();
            characters.Clear();
            racebonds.Clear();
            classbonds.Clear();
            alignbonds.Clear();
            armorbonds.Clear();
            weaponbonds.Clear();
            spellbonds.Clear();
            GetInfoFromDB();
            InitializeState();
            this.Show();
        }

        private void ViewCharacter_Load(object sender, EventArgs e)
        {
            GetInfoFromDB();
            InitializeState();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt--;
            if(cnt < 0)
            {
                cnt = characters.Count - 1;
            }
            InitializeState();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == characters.Count)
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Character] WHERE Id_character = @id", conn);
                    cmd.Parameters.AddWithValue("id", characters[cnt].Id_character);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
                
                characters.Clear();
                racebonds.Clear();
                classbonds.Clear();
                alignbonds.Clear();
                armorbonds.Clear();
                weaponbonds.Clear();
                spellbonds.Clear();
                cnt = 0;
                GetInfoFromDB();
                InitializeState();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
