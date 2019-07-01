using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulsAndCows
{
    class Program
    {
        static int RandomNum()
        {
            Random r = new Random();
            int n = r.Next(1000, 9999);

            return n;
        }

        //static int GetBulls(int numbers, int input)
        static int GetBulls(int numbers, int input)
        {
            int bulls = 0;
            char[] inputString = input.ToString().ToCharArray();
            char[] secretNum = numbers.ToString().ToCharArray();

           
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == secretNum[i])
                {
                    bulls++;
                }

            }
            Console.WriteLine(bulls);
            return bulls;
        }

        //static int GetCows(int number, int input)
        static int GetCows(int number, int input)
        {
            char[] inputString = input.ToString().ToCharArray();
            char[] secretNum = number.ToString().ToCharArray();
           int  cows = 0;
            for (int i = 0; i < secretNum.Length; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (j != i)
                    {
                        if (inputString[j] == secretNum[i])
                        {
                            cows++;
                        }
                    }
                }
            }
            Console.WriteLine(cows);
            return cows;
        }

        static int GetInput()
        {
            throw new NotImplementedException();
        }

        //return true if game is still running
        static bool Update(int remember, int input, out int bulls, out int cows)
        {
            throw new NotImplementedException();
        }

        static void Draw(int bulls, int cows)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            int Remember = RandomNum();
            
            while (true)
            {
                int input = GetInput();
                bool gameIsRunning = Update(Remember, input, out int bulls, out int cows);
                Draw(bulls, cows);

                if(!gameIsRunning)
                {
                    break;
                }

                //int input = int.Parse(Console.ReadLine());

                //Console.WriteLine(Remember);
                //Console.WriteLine("Numbers of Bulls is : ");
                //Bulls(Remember, input, out int bulls);
                //Console.WriteLine();
                //Console.WriteLine("Numbers of Cows is :");
                //Cows(Remember, input, out int cows);

                //if (bulls == 4)
                //{
                //    break;
                //}
            }
            





        }
    }
}
