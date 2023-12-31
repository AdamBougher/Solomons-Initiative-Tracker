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
    public partial class ConditionsMenu : Form
    {
        public ConditionsMenu()
        {
            InitializeComponent();
        }

        private void Conditions_Load(object sender, EventArgs e)
        {
            foreach (Condition condition in Condition.Conditions)
            {

                flowLayoutPanel.Controls.Add(new Label
                {
                    Text = condition.Name,
                    Font = new Font(Label.DefaultFont, FontStyle.Bold),
                    Margin = new Padding(5, 0, 0, 0)

                });

                flowLayoutPanel.Controls.Add(new TextBox {
                    Multiline = true,
                    ReadOnly = true,
                    Text = condition.Information,
                    Size = new Size(flowLayoutPanel.Width,50)
                    
                });

            }
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
