using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm küsib, mis hinde kasutaja sai
            // Kui kasutaja sai "A", konsool kuvab "Suurepärane!"
            // Kui tulemus "B", konsool kuvab "Väga hea!"
            // Kui tulemus "C", konsool kuvab "Hea!"
            // Kui tulemus "D", konsool kuvab "Rahuldav"
            // Kui tulemus "E", konsool kuvab "Kasin"
            // Kui tulemus "F", konsool kuvab "Puudulik"
            // Kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus"

            Console.WriteLine("Sisesta oma hinne:");
            //char = character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;
            }

        }
    }
}
