using System;

namespace FileIO222Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO operations programs");
            while (true)
            {
                Console.WriteLine("Choose option\n1:File Exist\n2:Read all lines\n3:Read all text\n4:Copy");
                int option=int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FileOperations.FileExist();
                        break;
                    case 2:
                        FileOperations.ReadAllLines();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}
