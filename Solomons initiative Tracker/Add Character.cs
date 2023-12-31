namespace Solomons_initiative_Tracker
{
    public partial class Add_Character : Form
    {

        public CharacterData? CharacterData;

        private string character_Name = "name";
        private int HP, AC;
        public int AmtToAdd;

        private (int score, bool save)[] abilities = new (int score, bool save)[6];

        private readonly (TextBox tb, CheckBox cb)[] AbilityBoxs = new (TextBox tb, CheckBox cb)[6];

        private static readonly Color color1 = Color.Red, color2 = Color.Green, color3 = Color.Gold;

        private readonly Dictionary<PictureBox, char> damages = [];



        public Add_Character()
        {
            InitializeComponent();
            AbilityBoxs[0] = (StrTB, StrCB);
            AbilityBoxs[1] = (DexTB, DexCB);
            AbilityBoxs[2] = (ConTB, ConCB);
            AbilityBoxs[3] = (IntTB, IntCB);
            AbilityBoxs[4] = (WisTB, WisCB);
            AbilityBoxs[5] = (ChaTB, ChaCB);
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Add_Character_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();

            foreach (Damage item in Damage.DamageTypes)
            {
                DamageFLP.Controls.Add(
                    new PictureBox
                    {
                        Image = item.icon,
                        Size = new Size(30, 30),
                        BorderStyle = BorderStyle.Fixed3D,
                        Name = item.Name,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent
                    });

            }

            foreach (PictureBox pb in DamageFLP.Controls.OfType<PictureBox>())
            {
                pb.MouseDown += ToggleDamage;

                toolTip1.SetToolTip(pb, pb.Name);

                damages.Add(pb, 'n');
            }

            ClassCombo.DataSource = Enum.GetValues(typeof(Class.Job));

        }

        private void ToggleDamage(object? sender, MouseEventArgs e)
        {
            Dictionary<Color, (Color, char)> colors = new()
            {
                { Color.Transparent,(color1,'V')},
                { color1, (color2,'R')},
                { color2, (color3,'I')},
                { color3, (Color.Transparent,'n')}
            };

            PictureBox pb = (PictureBox)sender;

            if(pb is null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                damages[pb] = colors[pb.BackColor].Item2;
                pb.BackColor = colors[pb.BackColor].Item1;

            }
            else if (pb.BackColor != Color.Transparent)
            {
                pb.BackColor = Color.Transparent;
                damages[pb] = 'n';
            }
        }

        private void BuildAbilityScores()
        {

            int[] statArr = new int[6];
            bool[] saveArr = new bool[6];

            for (int i = 0; i < 6; i++)
            {
                statArr[i] = int.Parse(AbilityBoxs[i].tb.Text);
                saveArr[i] = AbilityBoxs[i].cb.Checked;
            }


            abilities = Ability.BuildAbilityScores(statArr, saveArr);
        }

        public void BuildCharacter()
        {
            Dictionary<String, char> res;

            //make sure name is valid
            if (!ValidateName())
            {
                return;
            }

            //ensure proppor AC HP values
            if (!ValidateHPAC())
            {
                MessageBox.Show("Warning! Invalid HP or AC");
                return;
            };

            BuildAbilityScores();

            res = BuildResistance();

            if(ClassCombo.SelectedValue is null)
            {
                return;
            }

            if(Enum.TryParse(ClassCombo.SelectedValue.ToString(), out Class.Job job))
            {
                CharacterData = new CharacterData(character_Name, job, HP, AC, 30, OtherInfoTB.Text, abilities, res, []);
            } else
            {
                CharacterData = new CharacterData(character_Name, Class.Job.Other, HP, AC, 30, OtherInfoTB.Text, abilities, res, []);
            }


            
        }

        private Dictionary<String, char> BuildResistance()
        {
            Dictionary<String, char> cond = [];

            foreach (KeyValuePair<PictureBox, char> item in damages)
            {
                if (item.Value != 'n')
                {
                    cond.Add(item.Key.Name, item.Value);
                }

            }
            return cond;
        }

        public void LoadCharacterData(CharacterData data)
        {
            NameTB.Text = data.Name;
            HpTB.Text = data.Hp.ToString();
            AcTB.Text = data.Ac.ToString();
            OtherInfoTB.Text = data.Info;

            ClassCombo.SelectedIndex = (int)data.Job;

            for (int i = 0; i < 6; i++)
            {
                AbilityBoxs[i].tb.Text = data.Abilities[i].score.ToString();
                AbilityBoxs[i].cb.Checked = data.Abilities[i].save;
            }

            foreach (PictureBox pb in DamageFLP.Controls.OfType<PictureBox>())
            {
                if (data.Resistances is not null && data.Resistances.TryGetValue(pb.Name,out char val))
                {
                    switch (val)
                    {
                        case 'R': pb.BackColor = color1; break;
                        case 'V': pb.BackColor = color2; break;
                        case 'I': pb.BackColor = color3; break;
                    }

                    damages[pb] = data.Resistances[pb.Name];
                }
            }

        }

        private bool ValidateName()
        {
            if (NameTB.Text == string.Empty || NameTB is null)
            {
                MessageBox.Show("Waite! you need a name!");
                CharacterCombo.SelectedItem = null;
                return false;
            }

            character_Name = NameTB.Text;

            return true;
        }

        private bool ValidateHPAC()
        {
            if (HpTB.Text == string.Empty)
            {
                MessageBox.Show("Waite! you need HP or AC!");
                return false;
            }

            HP = int.Parse(HpTB.Text);

            if (AcTB.Text == "")
            {
                AC = 10;
            }
            else
            {
                AC = int.Parse(AcTB.Text);
            }




            return true;
        }
        private void IsNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BuildCharacter();
            
            if(!int.TryParse(amtToAddTB.Text,out AmtToAdd))
            {
                AmtToAdd = 1;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CharacterCombo is not null && CharacterCombo.SelectedItem is not null)
            {

                if (CharacterCombo.SelectedItem.ToString().Contains("Load"))
                {
                    load();
                } else if (CharacterCombo.SelectedItem.ToString().Contains("Save"))
                {
                    save();
                }
            }

            void load()
            {
                CharacterData data = JsonFileUtil.GetCharacterData();
                if (data != null)
                {
                    CharacterCombo.SelectedItem = null;
                    LoadCharacterData(data);

                    if (!CharacterCombo.Items.Contains(data.Name))
                    {
                        CharacterCombo.Items.Insert(0, data.Name);
                        CharacterCombo.SelectedIndex = 0;
                    }
                }
            }

            void save()
            {
                BuildCharacter();

                if (CharacterData != null)
                {
                    JsonFileUtil.WriteCharacter(CharacterData);
                }
            }

        }


    }
}
