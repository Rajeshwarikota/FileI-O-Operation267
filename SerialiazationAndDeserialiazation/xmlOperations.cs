using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialiazationAndDeserialiazation
{
    class xmlOperations
    {
         public static string path = @"C:\Users\LENOVO\source\repos\SerialiazationAndDeserialiazation\SerialiazationAndDeserialiazation\xmlserialization.xml";

        public static void XmlSerialization()
        {
            List<Contact> list = new List<Contact>()
            {
                new Contact() { Id = 4, Address = "Hyderabad", Name = "sailu" },
                new Contact() { Id = 5, Address = "Delhi", Name = "asifa" },
                new Contact() { Id = 6, Address = "Bangalore", Name = "Neetha" }
            };
            StreamWriter sw = new StreamWriter(path);
            try
            {
                XmlSerializer xML = new XmlSerializer(typeof(List<Contact>));
                xML.Serialize(sw, list);
                Console.ReadLine();
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
        public static void XmlDeSerialization()
        {
            StreamReader sr = new StreamReader(path);
            try
            {
                XmlSerializer xML = new XmlSerializer(typeof(List<Contact>));
                List<Contact> list = (List<Contact>)xML.Deserialize(sr);

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
