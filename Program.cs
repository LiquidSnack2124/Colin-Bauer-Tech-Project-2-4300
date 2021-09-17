/*
 Author: Colin Bauer
Date: 9/16/2021
Comments: This is my grade calculator coded in C#
*/



using System;

namespace Colin_Bauer_Tech_Project_2_4300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the grade you expect to get in ISM 4300.....Enter Q if you wish to exit the Program");
            bool Repeat = true;
            while (Repeat)
            {
                try
                {
                    string input = Console.ReadLine();

                    if (String.Equals("q",input.ToLower()))
                    {
                        System.Environment.Exit(0);
                    }
                    decimal Score = decimal.Parse(input);


                    string Grade = "";


                    if (Score > 100)
                    {
                        Console.WriteLine("Please enter a number below 100");
                    }
                    else if (Score >= 90)
                    {
                        Grade = "A";
                    }
                    else if (Score >= 80)
                    {
                        Grade = "B";
                    }
                    else if (Score >= 70)
                    {
                        Grade = "C";
                    }
                    else if (Score >= 60)
                    {
                        Grade = "D";
                    }
                    else if (Score >= 0)
                    {
                        Grade = "F";
                    }
                    else
                    {
                        Console.WriteLine("Invalid Score");
                    }
                    Console.WriteLine(Grade);


                }
                catch (Exception E)
                {
                    Console.WriteLine("Please use a decimal number");
                }
                
            }

        }
    }
}
