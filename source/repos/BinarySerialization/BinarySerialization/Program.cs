using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    [Serializable]
    class Tutorial
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Arvind.Sahu\Desktop\Assignment\BinarySerial.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\Users\Arvind.Sahu\Desktop\Assignment\BinarySerial.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}
