using System;

namespace PasswordGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            int PasswordLenght;
            string pswrd = string.Empty;
            Random rnd = new Random();
            Console.WriteLine("Enter desired lenght of a password");
            PasswordLenght = Convert.ToInt32(Console.ReadLine());
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ@$%&?#*{|abcdifghijklmnopqrstuvwxyz".ToCharArray();
            

            for (int i = 0; i < PasswordLenght; i++)
            {
                int num = rnd.Next(1,PasswordLenght);
                if (num%2 == 0)
                {
                    int rndnum = rnd.Next(0, letters.Length);
                    pswrd += letters[rndnum];

                }
                else
                {
                    pswrd += Convert.ToString(Randomizer());

                }

            }
            Console.Write(pswrd);
            Console.ReadKey();
        }
        static int Randomizer()
        {

            Random rnd = new Random();
            int value = rnd.Next(0, 9);

            return value;
        }
    }
}
