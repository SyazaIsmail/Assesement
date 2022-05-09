using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfCSharp
{
    class assesement
    {
        public void DataEntry()
        {
            
            Console.WriteLine ("Welcome! Please enter your selection: \n" +
                "1. Add Data\n" +
                "2. Update Data\n" +
                "3. Delete Data\n" +
                "4. Display Data\n" +
                "\n" +
                "If you wish to Exit, press 0");

            string choice = Console.ReadLine();

            bool keepRunning = true;
            while (keepRunning)
            {
                if (choice == "1")
                {
                    string detail = Environment.NewLine+"Name, ID, Dept \n";
                    File.WriteAllText("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt", detail);

                    Console.WriteLine("Please enter the Name, ID and Dept");
                    string message = Console.ReadLine();
                    File.AppendAllText("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt", message);
                }
                if (choice == "2")
                {
                    keepRunning = false;
                    break;
                }
                if (choice == "3")
                {
                    if (File.Exists("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt"))
                    {
                        File.Delete("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt");
                    }
                }
                if (choice == "4")
                {
                    string content = File.ReadAllText("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt");
                    Console.WriteLine(content);
                    string[] contents = File.ReadAllLines("C://Users/syaza_ismail/Desktop/FSDTraining/employee.txt");
                    foreach (string detail in contents)
                    {
                        string id = detail.Split(",")[0];
                        Console.WriteLine(detail);
                    }
                }
                if (choice == "0")
                {
                    keepRunning = false;
                    break;
                }
                else
                {
                    keepRunning = false;
                    break;

                }
            }






            //Console.WriteLine(message);
        }

        //    public void Do()
        //   {
        //       bool keepRunning = true;
        //        while (keepRunning)
        //        {
        //            string message = Console.ReadLine();

        //            if (message == "0")
        //            {
        //                Console.WriteLine("End Windows");
        //                keepRunning = false;
        //                break;
        //            }
        //        }
        //   }


    }
}
