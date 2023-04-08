using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiazationAndDeserialiazation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....File I/O Operations....");
            Console.WriteLine("...Choose the Below Option...");
            Console.WriteLine("\n1:Basic Operations\n2:Binary operations\n3:Xml operations\n4:Csv operations\n5:JSON operations\n22:Default");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    BasicOperations.Operations();
                    break;
                case 2:
                    BinaryOperation.Serialization();
                    BinaryOperation.DeSerialization();
                    break;
            }
            Console.ReadLine();
        }
    }
}
