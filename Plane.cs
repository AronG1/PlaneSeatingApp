using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlaneSeatingApp
{
    class Plane
    {
        const int NUMROW = 10;
        const int NUMSEAT = 2;
        const int NUMFIRSTCLASSROW = 2;
        const string fileName = "passagers.txt";

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
                        PrintInFile(name, lastName, i, j);
                        return 1;
                    }
                }
            }
            // if there isn't free seat
            return -1;
        }

        // method for check in seat in economy class
        public static int CheckInEconomyClassSeat(string name, string lastName)
        {
            // check if is there free seat
            for (int i = NUMFIRSTCLASSROW; i < NUMROW; i++)
            {
                for (int j = 0; j < NUMSEAT; j++)
                {
                    if (planeArray[i, j] == false)
                    {
                        // book seat as taken in array and assign name and lastname to struct
                        planeArray[i, j] = true;
                        arrayPassagers[i, j].name = name;
                        arrayPassagers[i, j].lastName = lastName;
                        PrintInFile(name, lastName, i, j);
                        return 1;
                    }
                }
            }
            // if there isn't free seat
            return -1;
        }

        static private void PrintInFile(string name, string lastName, int row, int seat)
        {
            StreamWriter objWrite;
            objWrite = new StreamWriter(fileName, true);
            if (File.Exists(fileName) == true)
            {
                objWrite.WriteLine(name);
                objWrite.WriteLine(lastName);
                objWrite.WriteLine(row);
                objWrite.WriteLine(seat);
                objWrite.Close();
            }
            else
            {
                // error
            }
        }

        public static void ReadFromFile()
        {
            int i = 0, j = 0;
            int row = 0, seat = 0;
            string name, lastName;
            StreamReader objRead;
            objRead = new StreamReader(fileName);
            if (File.Exists(fileName) == true)
            {
                while (objRead.Peek() != -1)
                {
                    name = objRead.ReadLine();
                    lastName = objRead.ReadLine();
                    row = Convert.ToInt32(objRead.ReadLine());
                    seat = Convert.ToInt32(objRead.ReadLine());
                    planeArray[row, seat] = true;
                    arrayPassagers[i, j].name = name;
                    arrayPassagers[i, j].lastName = lastName;
                    if (j < NUMSEAT - 1)
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        j = 0;
                    }

                } 
            }
            else
            {
                // error
            }
        }

    }
}
