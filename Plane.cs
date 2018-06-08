using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneSeatingApp
{
    class Plane
    {
        const int NUMROW = 10;
        const int NUMSEAT = 2;
        const int NUMFIRSTCLASSROW = 2;

        // array for free or taken seat :: question, is seat taken
        static bool[,] planeArray = new bool[NUMROW, NUMSEAT]; // default value of bool array is FALSE ! 
        // array of struct
        static Passagers[,] arrayPassagers = new Passagers[NUMROW, NUMSEAT];


        // method for check in seat in first class
        public static int CheckInFirstClassSeat(string name, string lastName)
        {
            // check if is there free seat
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
            // if there isn't free seat
            return -1;
        }


    }
}
