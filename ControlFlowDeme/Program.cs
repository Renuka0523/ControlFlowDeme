using System.Runtime.CompilerServices;

namespace ControlFlowDeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Hour = 10;

            if (Hour > 0 && Hour < 12) 
            {
                Console.WriteLine("It's Morning");
            
            }
            else if (Hour >= 12 && Hour < 18) 
            {
                Console.WriteLine("It's Afternoon");
            }
            else
            {
                Console.WriteLine("It's Evenning");
            }

                 /* int Age = 20;

            if (Age > 0 && Age < 10)
            {
                Console.WriteLine("He is Child ");
            }
            else if (Age >= 10 && Age < 25)
            {
                Console.WriteLine("He is Mature");
            }

            else 
            {
                Console.WriteLine("He is Elder");
            
            }*/
            
        }
    }
}
