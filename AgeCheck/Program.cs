using System;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutaja vanust ja kontrollib vanust

            Console.WriteLine("Sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et konto luua.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et kontot luua.");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et kontot luua.");

            }

            Console.WriteLine("Head päeva!");

        }
    }
}
