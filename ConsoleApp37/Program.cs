using System;
namespace InlUppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande och välj sedan hur många steg ifrån vänsterkanten den ska vara.");
            string med = Console.ReadLine();
            int avs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < med.Length; i++)
            {
                for (int j = 0; j < avs; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(med[i]);

            }
        }
    }
}