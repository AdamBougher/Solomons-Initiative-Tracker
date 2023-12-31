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
    public partial class GetAmt : Form
    {
        public int amount = 0;
        public GetAmt()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            amount = int.Parse(textBox1.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
