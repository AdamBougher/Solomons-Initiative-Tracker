using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;

namespace Solomons_initiative_Tracker
{
    public partial class MainWindow : Form
    {
        private Dictionary<String, Character>? characterList = [];
        private Character? CurrentCharacter
        {
            get {
                if (characterList != null && characterList.Count > 0)
                {
                    try
                    {
                        if (InitiativeDGV.Rows.Count > 0)
                        {
                            return characterList[CurrentRow.Cells[dgvName].Value.ToString()];
                        }

                    } catch (NullReferenceException)
                    {
                        return null;
                    }
                }

                return null;
            }
        }

        private DataGridViewRow CurrentRow
        {
            get {
                return InitiativeDGV.Rows[InitiativeDGV.CurrentCell.RowIndex];
            }
        }

        //these are used to track combat round and combat selection
        private int round = 1, selected = -1;
        //constant names for datagridview coloumn names
        private const String dgvinitiative = "initiative", dgvAC = "AC", dgvHP = "HP", dgvName = "CharName";

        private readonly (Label x, CheckBox y)[] AbilityDisplay = new (Label x, CheckBox y)[6];


        public MainWindow()
        {
            InitializeComponent();
            AbilityDisplay[0] = (StrTB0, StrCB);
            AbilityDisplay[1] = (DexTB1, DexCB);
            AbilityDisplay[2] = (ConTB2, ConCB);
            AbilityDisplay[3] = (IntTB3, IntCB);
            AbilityDisplay[4] = (WisTB4, WisCB);
            AbilityDisplay[5] = (ChaTB5, ChaCB);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            characterList = [];
            RoundLable.Text = round.ToString();
        }

        #region InfoPannel
        private void UpdateCharacterInfoPane(Character c)
        {

            CharacterInformationTB.Text = c.Information;

            //update the ability score displays with character c
            UpdateAbilityScores(c);

            //update info labels
            UpdateLabel(c.AC, AClabel);
            UpdateLabel(c.Hp.GetCurrent(), HPlabel);
            UpdateLabel(c.Speed, speedLabel);

            //reset condition display 
            UpdateConditionView(c);



        }

        private void UpdateConditionView(Character c)
        {
            ConditionFLP.Controls.Clear();

            foreach (KeyValuePair<Condition, bool> condition in c.Conditions)
            {
                ConditionFLP.Controls.Add
                    (new PictureBox
                    {
                        Image = condition.Key.icon,
                        Size = new Size(30, 30),
                        Name = condition.Key.Name,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent,
                        BorderStyle = BorderStyle.Fixed3D
                    });
            }
        }

        private void UpdateAbilityScores(Character c)
        {
            //update the ability score displays with character c
            for (int i = 0; i < 6; i++)
            {
                AbilityDisplay[i].x.Text = c.AbilityScores[i].Score.ToString();

                AbilityDisplay[i].y.Checked = c.AbilityScores[i].Save;

            }
        }

        // this method updates character information on the fly, and makes sure it's saved to the character
        private void CharacterInformationTB_Leave(object sender, EventArgs e)
        {
            if (InitiativeDGV.Rows.Count < 1 || CurrentCharacter == null)
            {
                MessageBox.Show("ERROR: No Character data");
                CharacterInformationTB.Text = string.Empty;
                return;
            }


            if (CharacterInformationTB.Text.Length != CurrentCharacter.Information.Length)
            {
                CurrentCharacter.Information = CharacterInformationTB.Text;
            }
        }


        private static void UpdateLabel(String text, Label label) => label.Text = text;
        private static void UpdateLabel(int amt, Label label) => label.Text = amt.ToString();
        #endregion

        #region CharacterList&DGVActions

        private void AddCharacter(object sender, EventArgs e)
        {
            using var form = new Add_Character();
            form.Enabled = true;

            var result = form.ShowDialog();

            if (result == DialogResult.OK && form.CharacterData != null && characterList is not null)
            {
                CharacterData data = form.CharacterData;

                if (form.AmtToAdd > 1)
                {
                    string name = data.Name;

                    for (int i = 1; i <= form.AmtToAdd; i++)
                    {
                        data.Name = String.Format(name + " {0}", i);

                        characterList.TryAdd(data.Name, new(data));
                        AddToDGV(characterList[data.Name]);

                    }
                } else
                {

                    if (!characterList.TryAdd(data.Name, new(data)))
                    {
                        MessageBox.Show("ERROR: Character Already in List!");
                        return;
                    }

                    AddToDGV(characterList[data.Name]);
                }

                EditConditionBtn.Enabled = true;
            }

            void AddToDGV(Character x)
            {
                InitiativeDGV.Rows.Add(0, x.AC.ToString(), x.Hp.GetCurrent().ToString(), x.Name.ToString(), x.Class);
            }
        }
        private void RemoveFromList(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                string name = "Are you sure you want to remove " + CurrentCharacter.Name + "?";
                string caption = "Remove " + CurrentCharacter.Name;
                var result = MessageBox.Show(name, caption, MessageBoxButtons.YesNo);

                if (result == DialogResult.No || characterList is null)
                {
                    return;
                }

                characterList.Remove(CurrentCharacter.Name);

                InitiativeDGV.Rows.Remove(CurrentRow);
            } else
            {
                MessageBox.Show("ERROR: No Character To Remove");
            }

        }

        private void SortList(object sender, EventArgs e)
        {
            if (InitiativeDGV.Rows.Count > 1)
            {
                InitiativeDGV.Sort(this.InitiativeDGV.Columns[dgvinitiative], System.ComponentModel.ListSortDirection.Descending);
            } else
            {
                MessageBox.Show("ERROR: No Characters To Sort");
            }
        }

        private void DamageOrHeal(object sender, EventArgs e)
        {
            if (CurrentCharacter == null || sender.ToString() == null)
            {
                MessageBox.Show("ERROR: No Character Selected");
                return;
            }

            string check = sender.ToString();

            //if called by a controll with damage in it's name
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (check.Contains("Damage"))
            {

                int amt = GetAmountFromUser('D');

                //if we get a return of -1, damage was left without giving amt, so stop all processing
                if (amt == -1)
                {
                    return;
                }
                //if we make it here get the type of damage
                using var form = new DamageSelect();

                form.Text = "Damage " + CurrentCharacter.Name + " For " + amt.ToString();

                form.Enabled = true;

                var result = form.ShowDialog();

                //is damage is submitted, damage charater and update hp displays
                if (result == DialogResult.OK && form.dmg is not null)
                {
                    CurrentCharacter.DamageCharacter(amt, form.dmg);

                    HPlabel.Text = CurrentCharacter.Hp.GetCurrent().ToString();
                    CurrentRow.Cells[dgvHP].Value = CurrentCharacter.Hp.GetCurrent().ToString();
                }

            }

            if (check.Contains("Heal"))
            {
                int amt = GetAmountFromUser('H');

                CurrentCharacter.Hp.IncreaseCurrent(amt);

                HPlabel.Text = CurrentCharacter.Hp.GetCurrent().ToString();

                CurrentRow.Cells[dgvHP].Value = CurrentCharacter.Hp.GetCurrent().ToString();
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            int GetAmountFromUser(char state)
            {
                using var form = new GetAmt();

                switch (state)
                {
                    case 'D': form.Text = "Damage " + CurrentCharacter.Name; break;
                    case 'H': form.Text = "Heal " + CurrentCharacter.Name; break;
                }


                form.Enabled = true;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return form.amount;
                } else
                {
                    return -1;
                }
            }
        }

        private void InitiativeDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = InitiativeDGV.Rows[e.RowIndex];

            string rowName = row.Cells[dgvName].Value.ToString();

            if (rowName is not null && characterList is not null && characterList.TryGetValue(rowName, out Character character))
            {
                UpdateCharacterInfoPane(character);
            } else
            {
                CharacterInformationTB.Text = "Sorry...\nThere was an Error retriving this chracters information, Try again";
            }

        }
        private void InitiativeDGV_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e != null && e.Column.Index == 0)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));

#pragma warning restore CS8604 // Possible null reference argument.
                e.Handled = true;//pass by the default sorting

            }
        }
        
        private void InitiativeDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            if (InitiativeDGV.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        #endregion

        private void Column1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (InitiativeDGV.Rows.Count < 2) { return; }

            if (InitiativeDGV.Rows.Count > 1)
            {

                if (selected == -1)
                {
                    var result = MessageBox.Show("Are you sure you want to Start Combat?", "Roll Initiative?", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No) { return; }

                    CombatBtn.Text = "Next";

                    endToolStripMenuItem.Visible = true;
                    clearToolStripMenuItem1.Visible = false;
                }

                if (selected < InitiativeDGV.Rows.Count - 1)
                {
                    selected++;
                } else
                {
                    round++;
                    RoundLable.Text = round.ToString();
                    selected = 0;
                    InitiativeDGV.Rows[^1].Selected = false;
                    //change current name
                }

                if (selected >= 1)
                {
                    InitiativeDGV.Rows[selected - 1].Selected = false;
                }

                InitiativeDGV.Rows[selected].Selected = true;
                currentNameLbl.Text = InitiativeDGV.Rows[selected].Cells["CharName"].Value.ToString();
            }

        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure you want to clear the list?", "Are you Sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && characterList is not null)
            {
                InitiativeDGV.Rows.Clear();
                characterList.Clear();
                RoundLable.Text = String.Empty;
                currentNameLbl.Text = string.Empty;
                CombatBtn.Text = "Start";
                UpdateCharacterInfoPane(new(new()));
            }

        }

        private void EditCondition_Click(object sender, EventArgs e)
        {

            if (CurrentCharacter == null)
            {
                return;
            }

            //get what conditions effect the user
            using var form = new EditConditions();

            //populate form with characters conditions
            form.Conditions = CurrentCharacter.Conditions;


            var result = form.ShowDialog();

            //wipe Conditions and rebuild, i feel like there is a better siloution to this, but i feel like 2 for loops is worse and that's all i can think of
            CurrentCharacter.Conditions = [];

            if (form.Conditions.Count > 0)
            {
                foreach (KeyValuePair<Condition, bool> cond in form.Conditions)
                {
                    if (!CurrentCharacter.Conditions.ContainsKey(cond.Key))
                    {
                        CurrentCharacter.Conditions.TryAdd(cond.Key, false);
                    }

                }
            }

            UpdateConditionView(CurrentCharacter);
        }

        private void ToggleModifier(object sender, EventArgs e)
        {
            if (CurrentCharacter == null)
            {
                return;
            }
            char abs;

            if (sender is Control control)
            {
                abs = control.Name[^1];

                int index = abs - '0';

                //if current text is the score then set text to modifier
                if (control.Text == CurrentCharacter.AbilityScores[index].Score.ToString())
                {
                    int val = CurrentCharacter.AbilityScores[index].Modifier;

                    if (val >= 0)
                    {
                        control.Text = String.Format("+{0}", val);
                        return;
                    }

                    control.Text = val.ToString();
                    return;
                } else
                {
                    control.Text = CurrentCharacter.AbilityScores[index].Score.ToString();
                    return;
                }


            }

        }

        //show new form area
        private void ConditionsMenuItem_Click(object sender, EventArgs e)
        {
            ConditionsMenu conditions = new();

            conditions.Show();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new();

            about.Show();
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to End Combat?", "Are They Done?", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) { return; }

            InitiativeDGV.Rows[selected].Selected = false;
            CombatBtn.Text = "Start";
            round = 0;
            RoundLable.Text = string.Empty;
            RoundLable.Text = string.Empty;
            selected = -1;
            currentNameLbl.Text = string.Empty;

            endToolStripMenuItem.Visible = false;
            clearToolStripMenuItem1.Visible = true;
        }
    }
}