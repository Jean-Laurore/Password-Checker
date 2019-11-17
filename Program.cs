using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      //defining all standards for a password
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!,-'/`_*$";
      
      //Ask the user for a password to input
      Console.WriteLine("Please enter a password: ");
      string password = Console.ReadLine();
      
      //Score the user's password: one point for each standard satified.
      int score = 0;
      
      //Use an if statement if the password is greater tha or equal to minimun lenght. add point to the score.
      if (password.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
      Console.WriteLine(score);
      
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
  }
}
