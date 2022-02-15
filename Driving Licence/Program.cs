using System;

namespace Driving_Licence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sünniaastat ja arvutab vanust
            Console.WriteLine("Sisesta oma sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int yearOfBirth = 2022 - userAge;

            if (yearOfBirth > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba taodelda.");
            }
            else if (yearOfBirth < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada.");
            }
            else
            {
                Console.WriteLine("Oled täpselt piisavalt vana, juhiluba taodelda.");

            }

            Console.WriteLine("Head päeva!");
        }
    }
}
