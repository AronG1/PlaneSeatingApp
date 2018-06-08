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
    public struct Passagers
    {
        public string name;
        public string lastName;
    }

    public partial class FirstClassUserControl : UserControl
    {
        int index = 0;


        // on "opening" first class form
        public FirstClassUserControl()
        {
            InitializeComponent();


            FirstClassMsgSucFail.Visible = false;
            WarningMessageFirstClass.Visible = false;
            CheckInFirstClassBtn.Enabled = false;
        }
        // crap
        private void FirstClassUserControl_Load(object sender, EventArgs e)
        {

        }

        // on click on check in btn
        private void Button1_Click(object sender, EventArgs e)
        {
            // checks if all fields are fill in - if not display warning message, if are check in
            if (NameFirstClassTextBx.Text == "" || LastNameFirstClassTxtBx.Text == "")
            {
                FirstClassMsgSucFail.Visible = false;
                WarningMessageFirstClass.Visible = true;
                CheckInFirstClassBtn.Enabled = false;
            }
            else
            {
                FirstClassMsgSucFail.Visible = false;
                WarningMessageFirstClass.Visible = false;
                CheckInFirstClassBtn.Enabled = false;

                //Plane plane1 = new Plane(); // create instance to plane class
                //index = plane1.CheckInFirstClassSeat(NameFirstClassTextBx.Text, LastNameFirstClassTxtBx.Text);

                string name = NameFirstClassTextBx.Text;
                string lastName = LastNameFirstClassTxtBx.Text;

                NameFirstClassTextBx.Text = "";
                LastNameFirstClassTxtBx.Text = "";
                // calls method for check in in first class, passing input of name and lastname, return 1 for sucess or -1 if there is no empty seat
                //index = WelcomeForm.CheckInFirstClassSeat(name, lastName);
                index = Plane.CheckInFirstClassSeat(name, lastName);
                if (index == 1)
                {
                    FirstClassMsgSucFail.Text = "Your seat is booked sucessfuly.";
                    FirstClassMsgSucFail.Visible = true;
                    
                }
                else
                {
                    FirstClassMsgSucFail.Text = "Unfortunatly, first class is full.";
                    FirstClassMsgSucFail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");
                    FirstClassMsgSucFail.Visible = true;
                }





            }
            
        }

        private void NameFirstClassTextBx_TextChanged(object sender, EventArgs e)
        {
            CheckInFirstClassBtn.Enabled = true;
            WarningMessageFirstClass.Visible = false;
            FirstClassMsgSucFail.Visible = false;
        }
        private void LastNameFirstClassTxtBx_TextChanged(object sender, EventArgs e)
        {
            CheckInFirstClassBtn.Enabled = true;
            WarningMessageFirstClass.Visible = false;
            FirstClassMsgSucFail.Visible = false;
        }



    }
}
