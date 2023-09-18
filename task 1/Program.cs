using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region// variables



            #region // structural Engineer

            Console.WriteLine("What is the number of floors?");

            int Number_Of_Floors = int.Parse(Console.ReadLine());

            Console.WriteLine(Number_Of_Floors);
            #endregion



            #region// Architect

            Console.WriteLine("what's the length of the room");
            Double length = Double.Parse(Console.ReadLine());

            Console.WriteLine("what's the Width of the room");
            Double Width = Double.Parse(Console.ReadLine());

            Console.WriteLine("what's the Height of the room");
            Double Height = Double.Parse(Console.ReadLine());


            Console.WriteLine("length is : " + length + " Width is : " + Width + " Height is : " + Height);
            Console.WriteLine("Width is : " + Width);
            Console.WriteLine("Height is : " + Height);
            #endregion





            #region // MEP Engineer

            string HVAC1 = "HVAC1";
            string HVAC2 = "hvac2";

            Console.WriteLine("HVAC System 1 is  " + HVAC1);
            Console.WriteLine("HVAC System 2 is  " + HVAC2);

            String swap = HVAC1;
            HVAC1 = HVAC2;
            HVAC2 = swap;

            Console.WriteLine("New HVAC1 is:  " + HVAC1);
            Console.WriteLine("New HVAC2 is:  " + HVAC2);
            #endregion

            #endregion



            Operaters


            // 1- structural analysis


            Console.WriteLine("beam weight =   ");
            float weight = float. Parse(Console.ReadLine());

            Console.WriteLine("beam length = ");
            double length = Double.Parse(Console.ReadLine());

            double totalLength = weight * length;
            Console.WriteLine("total weight =   " + totalLength);


            // 

















        }
    }
}
