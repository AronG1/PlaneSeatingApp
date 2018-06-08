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
