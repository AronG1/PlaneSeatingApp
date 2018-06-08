using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneSeatingApp
{
    public partial class EconomyClassUserControl : UserControl
    {
        int index = 0;
        public EconomyClassUserControl()
        {
            InitializeComponent();

            EconomyClassMsgSucFail.Visible = false;
            WarningMessageEconomyClass.Visible = false;
            CheckInEconomyBtn.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (NameEconomyTxtBx.Text == "" || LastNameEconomyTxtBx.Text == "")
            {
                EconomyClassMsgSucFail.Visible = false;
                WarningMessageEconomyClass.Visible = true;
                CheckInEconomyBtn.Enabled = false;
            }
            else
            {
                EconomyClassMsgSucFail.Visible = false;
                WarningMessageEconomyClass.Visible = false;
                CheckInEconomyBtn.Enabled = false;

                string name = NameEconomyTxtBx.Text;
                string lastName = LastNameEconomyTxtBx.Text;

                NameEconomyTxtBx.Text = "";
                LastNameEconomyTxtBx.Text = "";

                index = Plane.CheckInEconomyClassSeat(name, lastName);
                if (index == 1)
                {
                    EconomyClassMsgSucFail.Text = "Your seat is booked sucessfuly.";
                    EconomyClassMsgSucFail.Visible = true;
                }
                else
                {
                    EconomyClassMsgSucFail.Text = "Unfortunatly, economy class is full.";
                    EconomyClassMsgSucFail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");
                    EconomyClassMsgSucFail.Visible = true;
                }
            }
        }

        private void NameEconomyTxtBx_TextChanged(object sender, EventArgs e)
        {
            CheckInEconomyBtn.Enabled = true;
            WarningMessageEconomyClass.Visible = false;
            EconomyClassMsgSucFail.Visible = false;
        }

        private void LastNameEconomyTxtBx_TextChanged(object sender, EventArgs e)
        {
            CheckInEconomyBtn.Enabled = true;
            WarningMessageEconomyClass.Visible = false;
            EconomyClassMsgSucFail.Visible = false;
        }
    }
}
