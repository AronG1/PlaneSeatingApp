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
        const int NUMROW = 10;
        const int NUMSEAT = 2;
        const int NUMFIRSTCLASSROW = 2;
        
        // array for free or taken seat :: question, is seat taken
        bool[,] planeArray = new bool[NUMROW, NUMSEAT]; // default value of bool array is FALSE ! 
        // array of struct
        Passagers[,] arrayPassagers = new Passagers[NUMROW, NUMSEAT];

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
                //// calls method for check in in first class, passing input of name and lastname, return 1 for sucess or -1 if there is no empty seat
                //index = plane1.CheckInFirstClassSeat(NameFirstClassTextBx.Text, LastNameFirstClassTxtBx.Text);
                NameFirstClassTextBx.Text = "";
                LastNameFirstClassTxtBx.Text = "";

                index = CheckInFirstClassSeat(NameFirstClassTextBx.Text, LastNameFirstClassTxtBx.Text);
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
        // method for check in seat in first class
        public int CheckInFirstClassSeat(string name, string lastName)
        {
            // check is there free seat
            for (int i = 0; i < NUMFIRSTCLASSROW; i++)
            {
                for (int j = 0; j < NUMSEAT; j++)
                {
                    if (planeArray[i, j] == false)
                    {
                        // book seat as taken in array and assign name and lastname to struct
                        planeArray[i, j] = true;
                        arrayPassagers[i, j].name = name;
                        arrayPassagers[i, j].lastName = lastName;
                        return 1;
                    }
                }
            }
            // if no free seat
            return -1;
        }


    }
}
