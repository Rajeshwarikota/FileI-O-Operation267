using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiazationAndDeserialiazation
{
    internal class BasicOperations
    {
        public static void Operations()
        {

            bool chech = true;

            while (chech)
            {
                string path1 = ("C:/Users/LENOVO/source/repos/FileOperations/FileOperations/abcd.txt");
                string path2 = ("C:/Users/LENOVO/source/repos/FileOperations/FileOperations/TextFile.txt");
                Console.WriteLine("1) To read all Lines\n" +
                                   "2) To Read All Text\n" +
                                   "3) To Write All Text\n" +
                                   "4) To Append\n" +
                                   "5) To Delete Path\n" +
                                   "6) using FileStream\n" +
                                   "7) using FileStream and StreamWriter\n" +
                                   "8) using FileStream and StreamReader\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string[] Line;
                        Line = File.ReadAllLines(path1);
                        Console.WriteLine(Line[0]);
                        Console.WriteLine(Line[1]);
                        break;
                    case 2:
                        string Line2;
                        Line2 = File.ReadAllText(path1);
                        Console.WriteLine(Line2);
                        break;
                    case 3:
                        string[] data = { "Raji", "swetha", "Apurva" };
                        File.WriteAllLines(path1, data);
                        break;
                    case 4:
                        string data1 = "vinny";
                        File.AppendAllText(path1, data1);
                        Console.WriteLine(data1);
                        break;
                    case 5:
                        File.Delete(path1);
                        break;
                    case 6:
                        FileStream file = new FileStream(path2, FileMode.Create);
                        {
                            Console.WriteLine("File is created");
                            file.Close();
                        }
                        break;
                    case 7:
                        using (FileStream file1 = new FileStream(path2, FileMode.Create))
                        {
                            Console.WriteLine("File is created");
                            using (StreamWriter writer = new StreamWriter(file1))
                            {
                                writer.WriteLine("Rajeshwari kota");
                            }
                        }
                        break;
                    case 8:
                        using (FileStream file2 = new FileStream(path2, FileMode.Open))
                        using (StreamReader reader = new StreamReader(file2))
                        {
                            Console.WriteLine("File is open");
                            string fileContent = reader.ReadToEnd();
                            Console.WriteLine(fileContent);
                        }
                        break;
                }
            }
        }
    }
}
