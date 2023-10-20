using System;

namespace uppgift
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("skriv in ett tal");
            int tal= int.Parse(Console.ReadLine());
            Console.WriteLine("skriv in ett till tal");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" räknesätt");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. Subtration");
            Console.WriteLine("3. multiplikation");
            Console.WriteLine("4. division");
            int svar = int.Parse(Console.ReadLine());

            switch (svar)
            {
                case 1:
                    Console.WriteLine(tal + tal2);
                    break;

                    case 2: Console.WriteLine(tal - tal2);
                    break;

                case 3: 
                    Console.WriteLine(tal * tal2);
                    break;

                    case 4:
                    Console.WriteLine(tal / tal2);
                    break;

                    default
                    : Console.WriteLine("välj ett nummer från listan");
                    break;
            }
            Console.ReadKey();
            
            
                
            
            
        }
    }
}
