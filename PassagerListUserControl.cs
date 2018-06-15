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
    public partial class PassagerListUserControl : UserControl
    {
        static Passagers[,] array = new Passagers[Plane.NUMROW, Plane.NUMSEAT];

        public PassagerListUserControl()
        {
            InitializeComponent();
                     
        }

        // NEED TO UPDATE
        private void FillPassagers()
        {
            LstViewName.Clear();
            LstViewLastName.Clear();
            LstViewRow.Clear();
            LstViewSeat.Clear();
            for (int i = 1; i < Plane.NUMROW; i++)
            {
                for (int j = 1; j < Plane.NUMSEAT; j++)
                {
                    array[i, j] = Plane.ReadPassagers(i, j);
                    if (array[i, j].row == 0 || array[i, j].seat == 0)
                    {

                    }
                    else
                    {
                        LstViewName.Items.Add(array[i, j].name);
                        LstViewLastName.Items.Add(array[i, j].lastName);
                        LstViewRow.Items.Add(array[i, j].row.ToString());
                        LstViewSeat.Items.Add(array[i, j].seat.ToString());
                    }
                }
            }
        }

        // crap
        private void PassagersLst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassagerListUserControl_Load(object sender, EventArgs e)
        {

        }

        private void PassagerListUserControl_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void PassagerListUserControl_Enter(object sender, EventArgs e)
        {

        }

        private void PassagerListUserControl_Move(object sender, EventArgs e)
        {
            
        }

        private void PassagerListUserControl_VisibleChanged(object sender, EventArgs e)
        {
            FillPassagers();
        }
    }
}
