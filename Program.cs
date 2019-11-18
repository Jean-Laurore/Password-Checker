using System;


namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jean Laurore
             * 11-17-19
             * Password Checker
             */

            //defining all standards for a password
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!,-'/`_*$";

            //Score the user's password: one point for each standard satified.
            int score = 0;

            //Ask the user for a password to input
            Console.WriteLine("Please enter a password: ");
            string password = Console.ReadLine();


            //Use an if statement if the password is greater tha or equal to minimun lenght. add point to the score.
            if (password.Length >= minLength)
            {
                score++;
            }
            if (Contains(password, uppercase))
            {
                score++;
            }
            if (Contains(password, lowercase))
            {
                score++;
            }
            if (Contains(password, digits))
            {
                score++;
            }
            if (Contains(password, specialChars))
            {
                score++;
            }
            Console.WriteLine("Your password strength is " + score + ".");

            switch (score)

            {
                case 4:
                case 5:
                    Console.WriteLine("Extremely strong password.");
                    break;
                case 3:
                    Console.WriteLine("Strong password.");
                    break;
                case 2:
                    Console.WriteLine("Medium password.");
                    break;
                case 1:
                    Console.WriteLine("Weak password.");
                    break;
                default:
                    Console.WriteLine("The password doesn’t meet any of the standards.");
                    break;
            }
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}
