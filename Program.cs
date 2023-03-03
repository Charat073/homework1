using System; 

namespace workshop2_1 
{
  class Program 
  {
        static void Main(string[] args) 
        {
          Console.Write("Enter password 6 digit: ");
          int password = int.Parse(Console.ReadLine());

          Console.Write("Enter the agency abbreviation (CIA,FBI,NSA): ");
          string agency = Console.ReadLine().ToUpper();

          bool check = false;

          if (agency == "CIA"){
              bool x = password % 3 == 0;
              bool y = password / 10 % 10 != 1 && password / 10 % 10 != 3 && password / 10 % 10 != 5;
              bool z = password / 1000 % 10 >= 6 && password / 1000 % 10 != 8;
              check = x && y && z;
          }
          else if (agency == "FBI"){
              bool a = false;
              int thousands = password / 100000;
              while (thousands >= 4 && thousands <= 7){
                  a = true;
                  break;
              }

              bool b = false;
              int hundreds = password / 100 % 10;
              while (hundreds % 2 == 0 && hundreds != 6){
                  b = true;
                  break;
              }

              bool c = false;
              int tensThousands = password / 10000 % 10;
              while (tensThousands % 2 == 1){
                  c = true;
                  break;
              }

              check = a && b && c;
          }
          else if (agency == "NSA"){
              bool factor30 = true;
              for (int i = 1; i <= 6; i++){
                  if (password % i != 0 || i == 4){
                      factor30 = false;
                      break;
                  }
              }
              bool divide3 = password / 100 % 3 == 0 && password / 100 % 2 != 0;
              bool number7 = false;
              for (int i = password; i > 0; i /= 10){
                  if (i % 10 == 7){
                      number7 = true;
                      break;
                  }
              }
              check = factor30 && divide3 && number7;
          }
          else{
              Console.WriteLine("You entered incorrectly. Please enter only (CIA FBI NSA).");
          }

          if (check){
              Console.WriteLine($"Password is correct.");
          }else{
              Console.WriteLine($"Password is incorrect.");
          }

          Console.ReadLine();
        }
    }
}
