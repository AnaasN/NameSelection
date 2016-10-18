using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeSurNameSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//loop for test purposes
            {
                string UserFullName;
                string UserForename;
                string UserSurname;
                int LenghtOfUserFullName;
                int PositionOfComa;

                Console.WriteLine("Please Enter the Fullname in the following format: Surname,Firstname.");
                UserFullName = Console.ReadLine();
                LenghtOfUserFullName = UserFullName.Length;//use of a method
                PositionOfComa = UserFullName.IndexOf(',');// finds the position of ','
                UserSurname = UserFullName.Substring(0, PositionOfComa);//makes the surname equal to the characters from index 0 to where the coma is.
                UserForename = UserFullName.Substring(PositionOfComa, LenghtOfUserFullName - PositionOfComa);//makes forename the charcters from where the coma is to the end of the strin.
                UserForename = UserForename.Replace(',', ' ');//ask sir, to find a better alternative.
                Console.WriteLine("Firstname:{0}", UserForename);
                Console.WriteLine("Surname: {0}.", UserSurname);
            }
        }
    }
}
