using System;

namespace _48._uzd_Method_PrintMyName
{
    class Program
    {
        static void Main()
        {
            PrintNameSurname(GetNameSurname());
        }

        static string GetNameSurname()
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();

            Console.Write("Enter surname: ");
            var surname = Console.ReadLine();

            return $"{name} {surname}";

        }
        static void PrintNameSurname(string FullName)
        {
            Console.WriteLine(FullName);
        }
    }
}
// Izveidot divas metodes GetNameSurname un PrintNameSurname. 
// Metodei GetNameSurname ir no lietotāja jāpaprasa vārds uzvārds un kā string jāatgriež metodei PrintNameSurname, 
// kura šo tekstu izdrukās console.
