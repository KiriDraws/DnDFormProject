namespace DnD_Project
{
    partial class EditCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCharacter));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.raceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dndSusDataSet = new DnD_Project.dndSusDataSet();
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.alignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.armorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.spellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceTableAdapter = new DnD_Project.dndSusDataSetTableAdapters.RaceTableAdapter();
            this.classTableAdapter = new DnD_Project.dndSusDataSetTableAdapters.ClassTableAdapter();
            this.alignmentTableAdapter = new DnD_Project.dndSusDataSetTableAdapters.AlignmentTableAdapter();
            this.armorTableAdapter = new DnD_Project.dndSusDataSetTableAdapters.ArmorTableAdapter();
            this.weaponTableAdapter = new DnD_Project.dndSusDataSetTableAdapters.WeaponTableAdapter();
            this.spellTableAdapter = new DnD_Project.dndSusDataSetTableAdapters.SpellTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dndSusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(134, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 25);
            this.textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 25);
            this.textBox1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Spells";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Weapons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Armor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Alignment";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DataSource = this.raceBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 26);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.ValueMember = "Id_race";
            // 
            // raceBindingSource1
            // 
            this.raceBindingSource1.DataMember = "Race";
            this.raceBindingSource1.DataSource = this.dndSusDataSet;
            // 
            // dndSusDataSet
            // 
            this.dndSusDataSet.DataSetName = "dndSusDataSet";
            this.dndSusDataSet.EnforceConstraints = false;
            this.dndSusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raceBindingSource
            // 
            this.raceBindingSource.DataMember = "Race";
            this.raceBindingSource.DataSource = this.dndSusDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.DataSource = this.classBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 26);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.ValueMember = "Id_class";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dndSusDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox3.DataSource = this.alignmentBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(134, 183);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 26);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.ValueMember = "Id_alignment";
            // 
            // alignmentBindingSource
            // 
            this.alignmentBindingSource.DataMember = "Alignment";
            this.alignmentBindingSource.DataSource = this.dndSusDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox4.DataSource = this.armorBindingSource;
            this.comboBox4.DisplayMember = "name";
            this.comboBox4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(134, 218);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(130, 26);
            this.comboBox4.TabIndex = 45;
            this.comboBox4.ValueMember = "Id_armor";
            // 
            // armorBindingSource
            // 
            this.armorBindingSource.DataMember = "Armor";
            this.armorBindingSource.DataSource = this.dndSusDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox5.DataSource = this.weaponBindingSource;
            this.comboBox5.DisplayMember = "name";
            this.comboBox5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(134, 253);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(130, 26);
            this.comboBox5.TabIndex = 46;
            this.comboBox5.ValueMember = "Id_weapon";
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataMember = "Weapon";
            this.weaponBindingSource.DataSource = this.dndSusDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox6.DataSource = this.spellBindingSource;
            this.comboBox6.DisplayMember = "name";
            this.comboBox6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(134, 288);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(130, 26);
            this.comboBox6.TabIndex = 47;
            this.comboBox6.ValueMember = "Id_spell";
            // 
            // spellBindingSource
            // 
            this.spellBindingSource.DataMember = "Spell";
            this.spellBindingSource.DataSource = this.dndSusDataSet;
            // 
            // raceTableAdapter
            // 
            this.raceTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // alignmentTableAdapter
            // 
            this.alignmentTableAdapter.ClearBeforeFill = true;
            // 
            // armorTableAdapter
            // 
            this.armorTableAdapter.ClearBeforeFill = true;
            // 
            // weaponTableAdapter
            // 
            this.weaponTableAdapter.ClearBeforeFill = true;
            // 
            // spellTableAdapter
            // 
            this.spellTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 48;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCharacter";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Edit Characters";
            this.Load += new System.EventHandler(this.EditCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dndSusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private dndSusDataSet dndSusDataSet;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private dndSusDataSetTableAdapters.RaceTableAdapter raceTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private dndSusDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource alignmentBindingSource;
        private dndSusDataSetTableAdapters.AlignmentTableAdapter alignmentTableAdapter;
        private System.Windows.Forms.BindingSource armorBindingSource;
        private dndSusDataSetTableAdapters.ArmorTableAdapter armorTableAdapter;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private dndSusDataSetTableAdapters.WeaponTableAdapter weaponTableAdapter;
        private System.Windows.Forms.BindingSource spellBindingSource;
        private dndSusDataSetTableAdapters.SpellTableAdapter spellTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource raceBindingSource1;
    }
}