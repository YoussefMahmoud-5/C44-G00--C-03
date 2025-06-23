using System.Security.Cryptography;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ////Ex1: 12 => Yes    ||      Ex2: 9 => No
            // Console.Write("Enter An Number : ");
            // int.TryParse(Console.ReadLine(), out int number);
            // if (number % 3 == 0 && number % 4 == 0)
            // {
            //     Console.WriteLine("Yes");
            // }
            // else
            // {
            //     Console.WriteLine("No");
            // }

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Ex1: -5 => negative     || Ex2: 12 => Positive
            //Console.Write("Enter An Number : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Postive");
            //}
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Enter three numbers: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //int.TryParse(Console.ReadLine(), out int num3);
            //int max, min;
            #region Max
            //if (num1 > num2 && num2 > num3)
            //{
            //    max = num1;
            //}
            //else if (num2 > num1 && num1 > num3)
            //{
            //    max = num2;
            //}
            //else
            //{
            //    max = num3;
            //}
            #endregion


            #region Min
            //if (num1 < num2 && num2 < num3)
            //{
            //    min = num1;
            //}
            //else if (num2 < num1 && num1 < num3)
            //{
            //    min = num2;
            //}
            //else
            //{
            //    min = num3;
            //}
            #endregion

            //Console.WriteLine($"Max element {max}");
            //Console.WriteLine($"Min element {min}");

            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter any number : ");
            //int.TryParse(Console.ReadLine(), out int value);
            //if (value % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else 
            //{
            //    Console.WriteLine("Number is odd");
            //}
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter any character: ");
            //char c = char.Parse(Console.ReadLine());
            //c = char.ToLower(c);

            //if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //int sum = 0;
            //Console.WriteLine("Enter marks of five subjects : ");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //    sum += marks[i];
            //}
            //double percentage = ((double)sum / 500) * 100;
            //Console.WriteLine($"Total Marks = {sum}");
            //Console.WriteLine($"Average Marks = {sum/marks.Length}");
            //Console.WriteLine($"Percentage = {percentage}%");

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month
            //Console.Write("Enter Month Number : ");
            //int month= int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28 or 29");
            //        break;
            //    default:
            //        Console.WriteLine("there is no Month with this number!!!!!!!!!!):");
            //        break;
            //}
            #endregion

            #region 12- Write a program to create a Simple Calculator
            //double num1, num2;
            //char c;
            //Console.WriteLine($"Enter two numbers and an operator ('+', '-', '*', '/') (: ");
            //Console.Write("Enter first number : ");
            //num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //num2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter operator : ");
            //c = char.Parse(Console.ReadLine());
            //if (c == '-')
            //{
            //    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //}
            //else if (c == '+')
            //{
            //    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //}
            //else if (c == '*')
            //{
            //    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //}
            //else if (c == '/')
            //{
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("we can't divid by zero !");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator! Please enter one of: ('+', '-', '*', '/') ! ): ");
            //}
            #endregion
        }
    }
}
