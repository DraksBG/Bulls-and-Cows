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
            List<int> randomList = new List<int>();
            while (randomList.Count < 4)
            {
                Random a = new Random();
                // a = new Random();
                int myNumber = a.Next(1, 9);

                if (!randomList.Contains(myNumber))
                {
                    randomList.Add(myNumber);
                }
            }
            string nums = string.Join("", randomList.ToArray());
            int num = int.Parse(nums);
            return num;
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
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        //return true if game is still running
        static bool Update(int remember, int input, out int bulls, out int cows)
        {
            bulls = GetBulls(remember,input);
            cows = GetCows(remember, input);
            if (bulls == 4)
            {
                return false;   
            }
            return true;
            
          
        }

        static void Draw(int bulls, int cows)
        {

            Console.WriteLine("Numbers of Bulls is : " + bulls);
            Console.WriteLine();
            Console.WriteLine("Numbers of Cows is : " + cows);
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
