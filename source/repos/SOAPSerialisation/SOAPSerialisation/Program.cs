using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;


using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental1
{
    class Program
    {
        static PropertyListing CreateListing()
        {
            Random rnd = new Random();
            Property prop = new Property();
            PropertyListing listing = new PropertyListing();

            prop = new Property();

            // Create a few properties ready to be rented
            prop.PropertyCode = rnd.Next(100000, 999999);
            prop.PropertyType = TypeOfProperty.SingleFamily;
            prop.PropertyCondition = Condition.Excellent;
            prop.Bedrooms = 5;
            prop.Bathrooms = 3.5f;
            prop.Stories = 3;
            prop.MonthlyRent = 2650;
            listing[0] = prop;

            prop = new Property();
            prop.PropertyCode = rnd.Next(100000, 999999);
            prop.PropertyType = TypeOfProperty.Townhouse;
            prop.PropertyCondition = Condition.Excellent;
            prop.Bedrooms = 3;
            prop.Bathrooms = 2.5f;
            prop.Stories = 3;
            prop.MonthlyRent = 1750;
            listing[1] = prop;

            prop = new Property();
            prop.PropertyCode = rnd.Next(100000, 999999);
            prop.PropertyType = TypeOfProperty.SingleFamily;
            prop.PropertyCondition = Condition.Good;
            prop.Bedrooms = 4;
            prop.Bathrooms = 2.5f;
            prop.Stories = 2;
            prop.MonthlyRent = 2450;
            listing[2] = prop;

            prop = new Property();
            prop.PropertyCode = rnd.Next(100000, 999999);
            prop.PropertyType = TypeOfProperty.Appartment;
            prop.PropertyCondition = Condition.Excellent;
            prop.Bedrooms = 1;
            prop.Bathrooms = 1.0f;
            prop.Stories = 1;
            prop.MonthlyRent = 880;
            listing[3] = prop;

            prop = new Property();
            prop.PropertyCode = rnd.Next(100000, 999999);
            prop.PropertyType = TypeOfProperty.Townhouse;
            prop.PropertyCondition = Condition.Excellent;
            prop.Bedrooms = 3;
            prop.Bathrooms = 2.5f;
            prop.Stories = 2;
            prop.MonthlyRent = 1880;
            listing[4] = prop;

            prop = new Property();
            prop.PropertyCode = rnd.Next(100000, 999999);
            prop.PropertyType = TypeOfProperty.Appartment;
            prop.PropertyCondition = Condition.Good;
            prop.Bedrooms = 2;
            prop.Bathrooms = 1.0f;
            prop.Stories = 1;
            prop.MonthlyRent = 1050;
            listing[5] = prop;

            // Since we don't yet have a complete list of properties
            // Create some empty ones
            for (int i = 5; i < 100; i++)
            {
                prop = new Property();

                listing[i] = prop;
            }
            return listing;
        }

        static int Main()
        {
            PropertyListing props = CreateListing();
            Property prop = new Property();

            FileStream prpStream =
                new FileStream("properties.rnt",
                               FileMode.Create);
            SoapFormatter prpSoap = new SoapFormatter();

            prpSoap.Serialize(prpStream, props);

            for (int i = 0; i < 16; i++)
            {
                prop = props[i];
                Console.WriteLine("{0}.----------------------------------",
             i + 1);
                Console.WriteLine("Property #:   {0}", prop.PropertyCode);
                Console.WriteLine("Type:         {0}", prop.PropertyType);
                Console.WriteLine("Condition:    {0}",
            prop.PropertyCondition);
                Console.WriteLine("Bedrooms:     {0}", prop.Bedrooms);
                Console.WriteLine("Bathrooms:    {0}", prop.Bathrooms);
                Console.WriteLine("Stories:      {0}", prop.Stories);
                Console.WriteLine("Market Value: {0}\n", prop.MonthlyRent);
            }
            Console.WriteLine("======================================");

            return 0;
        }
    }
}