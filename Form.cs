using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlaneSeatingApp
{
    public partial class WelcomeForm : Form
    {
        const int NUMROW = 10;
        const int NUMSEAT = 2;
        const int NUMFIRSTCLASSROW = 2;

        // array for free or taken seat :: question, is seat taken
        static bool[,] planeArray = new bool[NUMROW, NUMSEAT]; // default value of bool array is FALSE ! 
        // array of struct
        static Passagers[,] arrayPassagers = new Passagers[NUMROW, NUMSEAT];


        // on opening app
        public WelcomeForm()
        {
            InitializeComponent();

            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;

            homeUserControl1.BringToFront();
            
        }

        // on press quit button
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // on click home button
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;

            homeUserControl1.BringToFront();
        }

        // crap
        private void FirstClassUserControl1_Load(object sender, EventArgs e)
        {

        }

        // on click first class check in button
        private void FirstClassBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = FirstClassBtn.Height;
            SidePanel.Top = FirstClassBtn.Top;

            firstClassUserControl2.BringToFront();
            
        }

        // on click economy class check in button
        private void EconomyClassBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EconomyClassBtn.Height;
            SidePanel.Top = EconomyClassBtn.Top;

            economyClassUserControl2.BringToFront();
        }

        // method for check in seat in first class
        public static int CheckInFirstClassSeat(string name, string lastName)
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
                        //MessageBox.Show(name + lastName);
                        return 1;
                    }
                }
            }
            // if no free seat
            return -1;
        }
















        // crap 
        private void economyClassUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void firstClassUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void economyClassUserControl2_Load_1(object sender, EventArgs e)
        {

        }

        private void firstClassUserControl2_Load_1(object sender, EventArgs e)
        {

        }
    }
 

}
