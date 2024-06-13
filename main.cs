using System;

class Program {
  public static void Main (string[] args) {
    int UserInput,sum;
        sum = 0;
    Console.WriteLine ("input a number");
      UserInput = int.Parse(Console.ReadLine());
    
    for( int i = 1 ; i < UserInput; i++)// repeats until i is equal to the user input
    { 
      if (UserInput % i == 0){
            sum = sum+i; // calculates if the sum of divisors equal user input 
      }
    }
    
    if(sum == UserInput)
    {
      Console.WriteLine("Perfect Number");
    }
    else{
      Console.WriteLine("Not a Perfect Number");
    }
}}