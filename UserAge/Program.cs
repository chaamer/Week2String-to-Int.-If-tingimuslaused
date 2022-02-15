using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Programm küsib kasutaja vanust
            //Arvutab sünniaastat
            //Kuvab sünniaasta konsoolis
            //"Oled sündinud aastal {yearOfBirth}

            Console.WriteLine("Palun sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2022 - userAge;
            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //String interpolation;
            Console.WriteLine($"Oled {yearOfBirth} aastat vana.");
        }
    }
}
