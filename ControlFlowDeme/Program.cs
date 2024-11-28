using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ControlFlowDeme
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  * If Else Statement *
            /*int Hour = 10;

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
            }*/

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


            /*  bool IsGoldCustomer = true;

              float Price = (IsGoldCustomer) ? 19.95f : 29.90f;
              {
                  Console.WriteLine(Price);
              } */

            // * Switch / Case Statement *

            var season = Season.Sammer;

            switch (season) 
            {
                case Season.Sammer :

                    Console.WriteLine("Its Perfect go to beach");
                    break;
                case Season.Rainy :
                    Console.WriteLine("Its Beautiful season");
                    break ;


                default:
                    Console.WriteLine("Its defficult to find season");
                    break;
            
            }



            
        }
    }
}
