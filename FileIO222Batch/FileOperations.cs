using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO222Batch
{
    public class FileOperations
    {
        /// <summary>
        /// Checking where file exixt or not
        /// </summary>
        public static void FileExist()
        {
            string path = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\DemoFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exist");
            }
            else
            {
                Console.WriteLine("File not exixt");
            }
        }

        /// <summary>
        /// ReadAllLines method , Geting all lines in file and storing in array of string "lines" and printing them
        /// </summary>
        public static void ReadAllLines()
        {
            string path = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\DemoFile.txt";
            string[] lines;
            lines=File.ReadAllLines(path);
            Console.WriteLine("Total no.of lines are :"+lines.Length);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }

        /// <summary>
        /// ReadAllText method, Geting all lines and printing them
        /// </summary>
        public static void ReadAllText()
        {
            string path = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\DemoFile.txt";
            string line;
            line = File.ReadAllText(path);
            Console.WriteLine(line);
        }

        /// <summary>
        /// Copy method
        /// </summary>
        public static void CopyFile()
        {
            string sourcePath = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\DemoFile.txt";
            string destPath= @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\CopyDemoFile.txt";
            //copying
            File.Copy(sourcePath, destPath);
        }
    }
}
