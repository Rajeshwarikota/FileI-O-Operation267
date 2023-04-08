using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialiazationAndDeserialiazation
{
    class BinaryOperation
    {
        public static string path = @" C:\Users\LENOVO\source\repos\SerialiazationAndDeserialiazation\SerialiazationAndDeserialiazation\binary.txt";

        public static void Serialization()
        {
            List<Contact> list = new List<Contact>()
            {
              new Contact() { Id = 1, Address = "Hyderabad", Name = "Raji" },
              new Contact() { Id = 2, Address = "Delhi", Name = "Swetha" }
            };
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream FileStream = new FileStream(path, FileMode.OpenOrCreate);
                Formatter.Serialize(FileStream, list);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                list.Clear();
            }
        }
        public static void DeSerialization()
        {
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream FileStream = new FileStream(path, FileMode.Open);
                List<Contact> list = (List<Contact>)Formatter.Deserialize(FileStream);

                foreach (Contact contact in list)
                {
                    Console.WriteLine(contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
