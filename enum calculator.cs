

using System;
public enum Choiceenum
{
  Addition,Multiplication,Subtraction,Divide
}
class HelloWorld
{
  static void Main ()
  {
    int Number1=10,Number2=20;
    foreach (var item in Enum.GetValues (typeof (Choiceenum)))
    {
      Console.WriteLine (((int) item) + " " + item);
    } int Choice = Convert.ToInt32 (Console.ReadLine ());
    switch (Choice)
      {
      case (int) Choiceenum.Addition:
	Console.WriteLine ("Addition of two number is :- {0}",
			   (Number1 + Number2));
	break;
      case (int) Choiceenum.Multiplication:
	Console.WriteLine ("Addition of two number is :- {0}",
			   (Number1 * Number2));
	break;
      case (int) Choiceenum.Subtraction:
	Console.WriteLine ("Addition of two number is :- {0}",
			   (Number1 - Number2));
	break;
      case (int) Choiceenum.Divide:
	Console.WriteLine ("Addition of two number is :- {0}",
			   (Number1 / Number2));
	break;
      default:
	Console.WriteLine ("Please enter a valid Choice");
	break;
      }
    Console.ReadLine ();
  }
}
