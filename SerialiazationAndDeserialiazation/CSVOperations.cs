using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiazationAndDeserialiazation
{
    class CSVOperations
    {
        public static string path = @"C:\Users\LENOVO\source\repos\SerialiazationAndDeserialiazation\SerialiazationAndDeserialiazation\csvserializer.csv";

        public static void CsvSerialization()
        {
            Console.WriteLine("Current date:" + DateTime.Now);
            List<Contact> list = new List<Contact>()
            {
                new Contact() { Id = 1, Address = "Hyderabad", Name = "sailu",StartDate=DateTime.Now },
                new Contact() { Id = 2, Address = "Delhi", Name = "asifa",StartDate=DateTime.Now },
                new Contact() { Id = 3, Address = "Bangalore", Name = "Neetha",StartDate=DateTime.Now }
            };
            StreamWriter sw = new StreamWriter(path);
            try
            {
                CultureInfo culture = new CultureInfo("en-GB");
                CsvWriter writer = new CsvWriter(sw, culture);
                writer.WriteRecords(list);
                sw.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        public static void CsvDeSerialization()
        {
            StreamReader sr = new StreamReader(path);
            try
            {
                CultureInfo culture = new CultureInfo("en-GB");
                CsvReader reader = new CsvReader(sr, culture);
                List<Contact> list = reader.GetRecords<Contact>().ToList();
                foreach (Contact contact in list)
                {
                    Console.WriteLine(contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }
    }
}

