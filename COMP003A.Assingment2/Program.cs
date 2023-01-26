/*
 * Author: Logan Smith
 * Couse: COMP-003A
 * Purpose: To complete Assignment 2; Learn about Console Properties, variables, etc
 */

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********************");
            Console.WriteLine("Console Section");
            Console.WriteLine("********************");

            //initialize console
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;




            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************");
            Console.WriteLine("String Section");
            Console.WriteLine("********************");

            //information collection
            Console.WriteLine("Input first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input middle name: ");
            string middleName = Console.ReadLine();
            Console.WriteLine("Input last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input age: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);

            //summarize information
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************");
            Console.WriteLine("Math Section");
            Console.WriteLine("********************");

            //get two inputs, prepare to combine
            Console.WriteLine("Type a number, any number (an integer actually pls): ");
            string integer1 = Console.ReadLine();
            Console.WriteLine("Type *another* number, and make it an integer: ");
            string integer2 = Console.ReadLine();


            //combine in fun ways
            Console.WriteLine($"{integer1} + {integer2} = {Convert.ToInt32(integer1) + Convert.ToInt32(integer2)}");
            Console.WriteLine($"{integer1} - {integer2} = {Convert.ToInt32(integer1) - Convert.ToInt32(integer2)}");
            Console.WriteLine($"{integer1} * {integer2} = {Convert.ToInt32(integer1) * Convert.ToInt32(integer2)}");
            Console.WriteLine($"{integer1} / {integer2} = {Convert.ToInt32(integer1) / Convert.ToInt32(integer2)}");
            Console.WriteLine($"{integer1} % {integer2} = {Convert.ToInt32(integer1) % Convert.ToInt32(integer2)}");





            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("********************");


            Console.WriteLine("Input a circle radius, if you would my good monarch: ");
            string radiusInput = Console.ReadLine();
            double radius = Convert.ToDouble(radiusInput);
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            //output circle stuff
            Console.WriteLine($"Here's your circle's area: {area}");
            Console.WriteLine($"Here's your circle's circumference: {circumference}");







        }
    }
}