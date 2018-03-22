using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Cyberadmin\Desktop\PrimeGenerator\Primes.txt");

                int counter = 3;
                bool prime = true;

                while (counter > 0)
                {
                    int divider = 3;


                    while (divider <= Math.Sqrt(counter))
                    {


                    }
                    if (counter % divider == 0)
                    {
                        prime = false;
                        break;

                    }
                    else divider = divider + 1;
                }

                if (prime == true)
                {
                    sw.WriteLine(counter);
                }

                counter += 2;
                prime = true;



            }
            catch
            {
                Console.WriteLine("Well, that's it.");
                Console.ReadLine();
            }
        }
    }
}
