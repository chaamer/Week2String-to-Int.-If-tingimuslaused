using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {


            //programm küsib sünniaastat;
            //Programm arvutab kasut vanust;
            //kuvab vanust konsoolis;

            Console.WriteLine("Palun sisesta oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;
            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //String interpolation;
            Console.WriteLine($"Oled {userAge} aastat vana.");


        }
    }
}
