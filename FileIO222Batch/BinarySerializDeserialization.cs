using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO222Batch
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"ID:{ID}  Phone:{Phone}  Name:{Name}  Address:{Address}";
        }
    }

    public class BinarySerializDeserialization
    {
        /// <summary>
        /// Converting an Object to a Binary format which is not in a human readable format is called Binary Serialization.
        /// </summary>
        public static void BinarySerialization()
        {
            try
            {
                string path = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\Sample.txt";
                List<Employee> employeeList = new List<Employee>()
                {
                new Employee(){ID = 1, Name = "Sachin", Phone = 98232233, Address = "bnglr" },
                new Employee(){ID = 2, Name = "Rajeev", Phone = 98232233, Address = "krntk" },
                new Employee(){ID = 3, Name = "Donald", Phone = 98232233, Address = "delhi" },
                new Employee(){ID = 4, Name = "Robert", Phone = 98232233, Address = "mumbai" }
                };
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                binaryFormatter.Serialize(stream, employeeList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Converting serialized data back to human readable form is called Deserialization
        /// </summary>
        public static void BinaryDeserialization()
        {
            string path = @"C:\Users\HP\Desktop\RFP222\FileIO222Batch\FileIO222Batch\Sample.txt";
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);
            List<Employee> result = (List<Employee>)binaryFormatter.Deserialize(fileStream); //Converting back to human readable form 
            foreach (Employee emp in result)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
