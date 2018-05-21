using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Curs01
{
    class Program
    {
        static void Main(string[] args)
        {
                Random randomNumber = new Random();
                intguess = randomNumber.Next(1, 100);

                Console.WriteLine("Introduceti un mumar intre 1 si 100!");
            tryAgain: int input = int.Parse(str);
                Console.WriteLine(nr)
    
            while (input!= guess)
                {
                    if (input < guess)
                    {
                        Console.WriteLine("Numarul introdus este prea mic. Mai incearca!");
                        goto tryAgain;
                    }
                    else
                    {
                        Console.WriteLine("Numarul introdus este prea mare. Mai incearca!");
                        goto tryAgain;
                    }
                }
                Console.WriteLine("Ati ghicit Numarul!");
                Console.ReadKey();
            }
        }
    }
