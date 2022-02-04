using System;

namespace GradingIf
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

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Vale väärtus!");
            }
            

        }
    }
}
