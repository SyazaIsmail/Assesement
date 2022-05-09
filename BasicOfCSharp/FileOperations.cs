using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfCSharp
{
    class FileOperations
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt", content);
        }
     
        public void UpdateFile()
        {
            string employee = "\nSyaza, 1, IPS";
            File.AppendAllText("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt", employee);
        }

        public void ReadFile()
        { string content = File.ReadAllText("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt");
            foreach(string str in contents)
            {
                Console.WriteLine(str);
            }
        }

        public void DeleteFile()
        {
            if (File.Exists("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt.txt"))
            {
                File.Delete("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt");
            }
        }
            
    }
}
