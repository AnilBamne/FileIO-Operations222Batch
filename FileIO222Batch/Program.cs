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
                try
                {
                    Console.WriteLine("\nChoose option\n1:File Exist\n2:Read all lines\n3:Read all text\n4:Copy file\n5:Delete file\n6:Read From Stream Reader\n7:Stream writer class\n8:BinarySerialization\n9:BinaryDeserialization\n0:Exit loop");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            FileOperations.FileExist();
                            break;
                        case 2:
                            FileOperations.ReadAllLines();
                            break;
                        case 3:
                            FileOperations.ReadAllText();
                            break;
                        case 4:
                            FileOperations.CopyFile();
                            break;
                        case 5:
                            FileOperations.DeleteFile();
                            break;
                        case 6:
                            FileOperations.ReadFromStreamReader();
                            break;
                        case 7:
                            FileOperations.WriteUsingStreamWriter();
                            break;
                        case 8:
                            BinarySerializDeserialization.BinarySerialization();
                            break;
                        case 9:
                            BinarySerializDeserialization.BinaryDeserialization();
                            break;
                        case 0:
                            //to exit of loop
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input , please enter valid option");
                }
                
            }
        }
    }
}
