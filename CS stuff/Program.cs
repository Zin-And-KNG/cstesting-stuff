using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            while(true){
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
            }else if (operation == "x") {
                Console.WriteLine(num1 * num2);
            }else if (operation == "+"){
                Console.WriteLine(num1 + num2);
            }else if (operation == "-") {
                Console.WriteLine(num1 - num2);
            }else {
                Console.WriteLine("Not A Valid Option");
                continue;
            }
            break;
            }
           
            
        }
        
    }
}