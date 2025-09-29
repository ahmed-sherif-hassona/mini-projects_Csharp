using System.Net.Http.Headers;

namespace Calculator
{
    internal class Program
    {
        delegate int CalculatorDelegate(int num1,int num2);
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine($"enter the first number: ");
            num1=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"enter the secend number: ");
            num2=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the operation (+, -, *, /): ");
            char oper=Convert.ToChar(Console.ReadLine());


            CalculatorDelegate dlg = null;

            switch (oper)
            {

                case '+':
                    dlg = add;
                    break;
                case '-':
                    dlg = subtract;
                    break;
                case '*':
                    dlg = multiply;
                    break;
                case '/':
                    dlg = divide;
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    return;

            }
            calculate(num1 ,num2,dlg);

        }
        static void calculate(int num1, int num2, CalculatorDelegate dlg)
        {
            int res = dlg(num1, num2);
            Console.WriteLine($"the result = {res}");
        }
        static int add(int num1, int num2) => num1 + num2;
        static int subtract(int num1, int num2) => num1 - num2;
        static int multiply(int num1, int num2) => num1 * num2;
        static int divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine(" Cannot divide by zero!");
                return 0;
            }
            return num1 / num2;
        }
    }
}
