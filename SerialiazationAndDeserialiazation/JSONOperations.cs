using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiazationAndDeserialiazation
{
    class JSONOperations
    {
        public static string path = @"C:\Users\LENOVO\source\repos\SerialiazationAndDeserialiazation\SerialiazationAndDeserialiazation\JSONSerializer.json";

        public static void JSONSerialization()
        {
            List<Contact> list = new List<Contact>()
            {
                new Contact() { Id = 1, Address = "Hyderabad", Name = "Raji" },
                new Contact() { Id = 2, Address = "Delhi", Name = "asifa" },
                new Contact() { Id = 3, Address = "Bangalore", Name = "Neetha" }
            };
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(path, json);
        }
        public static void JSONDeSerialization()
        {
            string json = File.ReadAllText(path);
            List<Contact> list = JsonConvert.DeserializeObject<List<Contact>>(json);

            foreach (Contact contact in list)
            {
                Console.WriteLine(contact);
            }
        }
    }
}

