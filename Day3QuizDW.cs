using System;

namespace Day4
{
    class Day3QuizDW
    {
        public static void Main(string[] args)
        {
            int pin = 123456, num, counter = 0;
            bool passcorrect = false;
            bool countercheck = false;

            Console.WriteLine("Welcomes to the Bank of ISS");


            do
            {
                Console.Write("Enter your PIN: ");
                string input = Console.ReadLine();
                num = Int32.Parse(input);

                if (num == pin)
                {
                    passcorrect = true;
                }

                else if (counter == 2)
                {
                    countercheck = true;       
                }

                else
                {
                    Console.WriteLine("Incorrect PIN. Please try again. You have " + (2 - counter) + " more tries.");
                }

                    counter++;
               
            }
            while ((passcorrect == false) && (countercheck == false));

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
