using System;

namespace Day4
{
    class Day3Quiz
    {
        public static void Main(string[] args)
        {
            int pin = 123456, num;
            bool passcorrect = false;

            Console.WriteLine("Welcomes to the Bank of ISS");
            Console.Write("Enter your PIN: ");
            string input = Console.ReadLine();
            num = Int32.Parse(input);

            if (num == pin)
            {
                passcorrect = true;
            }

            else
            {
                for (int i = 1; i < 3; i++)
                {
                    if (passcorrect == false)
                    {
                        Console.WriteLine("Incorrect PIN. Please try again. You have " + (3-i) + " more tries.");
                        Console.Write("Enter your PIN: ");
                        num = Int32.Parse(Console.ReadLine());
                    }

                    if  (num == pin)
                    {
                        passcorrect = true;
                    }

                    else 
                    {
                        passcorrect = false;
                    }
                }
            }

            if (passcorrect == true)
            {
                Console.WriteLine("Pin accepted. You can access your account now.");
            }

            else 
            {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            }
        }
    }
}
