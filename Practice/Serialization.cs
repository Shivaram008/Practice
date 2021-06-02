using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Practice
{
    [Serializable]
    class Serialization
    {
        public int ID;
        public String Name;
        public static string path = @"C:\Users\Ram Cheruku\source\repos\Practice\Practice\file6.txt";
        static void Main(string[] args)
        {
            Serialization obj = new Serialization();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Serialization objnew = (Serialization)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}
