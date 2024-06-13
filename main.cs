using System;

class Program {
  public static void Main (string[] args) {
    int UserInput,sum=0;
    Console.WriteLine ("input a number");
      UserInput = int.Parse(Console.ReadLine());
    for( int i = 1 ; i < UserInput; i++)
    { 
      if (UserInput % i == 0){
        sum = sum+i;
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