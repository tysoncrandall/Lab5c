using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number: ");
    var input_num = Console.ReadLine();
    double num1 = Convert.ToDouble(input_num);
    
    bool composite = false;    

    for (int i = 2; i < num1; i++)
    {
      if (num1 % i == 0) 
      {
        composite = true;
        break;
      }
    }
    if (composite == true)
    {
    Console.WriteLine (num1 + " is not prime");
    }
    else
    {
    Console.WriteLine (num1 + " is prime");
    }
  }
}