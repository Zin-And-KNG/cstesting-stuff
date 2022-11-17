using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Help me");
            Console.WriteLine("What is the first number?");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            float num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Operation?");
            string operation = Console.ReadLine();
            Console.WriteLine("The Solution to " + num1 + " " + operation + " " + num2 + " is:");
            if(operation == "/") {
                Console.WriteLine(num1 / num2);
            }else if (operation == "*") {
                Console.WriteLine(num1 * num2);
            }else if (operation == "+"){
                Console.WriteLine(num1 + num2);
            }else if (operation == "-") {
                Console.WriteLine(num1 - num2);
            }
            
        }
        
    }
}