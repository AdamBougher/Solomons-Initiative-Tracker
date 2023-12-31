using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solomons_initiative_Tracker
{
    public partial class DamageSelect : Form
    {

        public Damage? dmg;

        public DamageSelect()
        {
            InitializeComponent();
        }

        private void DamageSelect_Load(object sender, EventArgs e)
        {
            foreach(Damage dmg in Damage.DamageTypes)
            {
                DamageCombo.Items.Add(dmg.Name);
            }
        }

        private void DamageCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if(DamageCombo is null || DamageCombo.SelectedItem is null)
            {
                return;
            }

            dmg = Damage.GetDamage(DamageCombo.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
        }
    }
}
