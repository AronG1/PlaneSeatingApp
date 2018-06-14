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
        // constants that declare plane, plane starts filling with [1, 1]
        public const int NUMROW = 10 + 1;
        public const int NUMSEAT = 3 + 1;
        const int NUMFIRSTCLASSROW = 3 + 1;
        const string fileName = "passagers.txt";

        // array for free or taken seat :: question, is seat taken
        static bool[,] planeArray = new bool[NUMROW, NUMSEAT]; // default value of bool array is FALSE ! 
        // array of struct
        static Passagers[,] arrayPassagers = new Passagers[NUMROW, NUMSEAT];

        // method for check in seat in first class
        public static int CheckInFirstClassSeat(string name, string lastName)
        {
            // check if is there free seat
            for (int i = 1; i < NUMFIRSTCLASSROW; i++)
            {
                for (int j = 1; j < NUMSEAT; j++)
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
                for (int j = 1; j < NUMSEAT; j++)
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

        // prints passager in file
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

        // read all passagers from file
        public static void ReadFromFile()
        {
            int i = 1, j = 1;
            int row = 1, seat = 1;
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
                    arrayPassagers[i, j].row = row;
                    arrayPassagers[i, j].seat = seat;
                    if (j < NUMSEAT - 1)
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        j = 1;
                    }

                } 
            }
            else
            {
                // error
            }
        }

        // return passagers
        public static Passagers ReadPassagers(int i, int j)
        {
            return arrayPassagers[i, j];
        }

    }
}
