using System.Transactions;

namespace To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to to do list program");
            string choice = "";
            List<string> list = new List<string>();
            while (choice!="e")
            {
                
                Console.WriteLine("what would you want to do");
                Console.WriteLine("enter 1 to add task to list");
                Console.WriteLine("enter 2 to remove from the list ");
                Console.WriteLine("enter 3 view the list ");
                Console.WriteLine("enter e to exit ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("please enter the task to add to the list");
                    string task = Console.ReadLine();
                    list.Add(task);
                }
                else if (choice == "2")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("The list is empty.");
                        continue;
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i} : {list[i]}");
                    }
                    Console.WriteLine("enter the number of the task you want to remove");
                    int num = Convert.ToInt32(Console.ReadLine());
                    list.RemoveAt(num);
                }
                else if (choice == "3")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("The list is empty.");
                        continue;
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i} : {list[i]}");
                    }
                }
                else if(choice=="e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            Console.WriteLine("thanks to use our program");
        }
    }
}
