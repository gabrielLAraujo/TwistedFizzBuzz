using System.Collections.Generic;
using System.Text.RegularExpressions;

Console.WriteLine("Type a number range");
string numberRange = Console.ReadLine();
(int firstNumber, int secondNumber) = TwistedFizzBuzz.GetRange(numberRange);
TwistedFizzBuzz.CreateFizzBuzz(firstNumber, secondNumber, TwistedFizzBuzz.GetUserDivisorsAndStrs());

