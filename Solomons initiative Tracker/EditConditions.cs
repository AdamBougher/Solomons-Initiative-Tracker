namespace Solomons_initiative_Tracker
{
    public partial class EditConditions : Form
    {
        public int index = 0;

        public Dictionary<Condition, bool> Conditions = new();

        public EditConditions()
        {
            InitializeComponent();
        }


        private void EditConditions_Load(object sender, EventArgs e)
        {
            foreach (CheckBox cb in ConditionFLP.Controls.OfType<CheckBox>())
            {
                cb.Text = Condition.Conditions[index].Name;

                if(Conditions.ContainsKey(Condition.Conditions[index]))
                {
                    cb.Checked = true;
                }

                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in ConditionFLP.Controls.OfType<CheckBox>())
            {
                if (cb.Checked == true)
                {
                    Conditions[Condition.GetCondition(cb.Text)] = true;
                }
                else
                {
                    if(Conditions.ContainsKey(Condition.GetCondition(cb.Text)))
                    {
                        Conditions.Remove(Condition.GetCondition(cb.Text));
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
