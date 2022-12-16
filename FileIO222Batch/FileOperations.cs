﻿using System;
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

        public static void ReadAllLines()
        {
            string path = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\DemoFile.txt";
            string[] lines;
            lines=File.ReadAllLines(path);
            Console.WriteLine("Total no.of lines are :"+lines.Length);
        }
    }
}
