using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CollectionDemo
{

    //Structure
    public struct Employee
    {
        public string name;
        public int empNo;
        public double salary;

        //this is a constructor
        Employee(string nam, int emp, double amt)
        {
            name = nam;
            empNo = emp;
            salary = amt;
        }
    }



    class Program
    {

        static int[] SortingArray(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    if (numArray[i] > numArray[j])

                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;

                    }
                }
            }
            return numArray;


        }
        static void Main(string[] args)
        {


            Employee employee = new Employee("Arvind", 1,100000);
            Console.WriteLine(employee.Print());

            //decare array of int of size 3
            //dataType[] arrayName = int dataType[size];

            //int[] numArray = new int[3];

            //numArray[0] = 232;
            //numArray[1] = 120;
            //numArray[2] = 100;
            //numArray[2] = 130;


            // Collection types
            //1. ArrayList  --manipulates with any type of data
            //2. List  --deals with similar type of data
            //3. Dictionary --deals with key-value pair
            //4. Hashtable --delas with key value pair 
            //5. SortedList --combination of array and hash table, used index and key to find the element
            //6. Stack --LIFO using push and pop
            //7. Queue --LIFO using enqueue and dequeue


            //ArrayList countryList = new ArrayList();

            //countryList.Add("India");
            //countryList.Add(100);
            //countryList.Add(150.55);
            //countryList.Add(true);


            //countryList.Add(new Person() { FirstName = "Arvind", LastName = "Kumar" });


            //for(int i=0; i<countryList.Count; i++)
            //{
            //    Console.WriteLine(countryList[i]);
            //}

            //Console.WriteLine(((Person)countryList[4]).FirstName);



            //Generic List

            //List<string> countryList1 = new List<string>();

            //countryList1.Add("India");
            //countryList1.Add("Nepal");

            //for(int j=0; j<countryList1.Count; j++)
            //{
            //    Console.WriteLine(countryList1[j]);
            //}

            string s = null;

            //int i=null;

            //value type can not handle the nullable type

            Nullable<int> i = 10;
            i = null;

            //other method to do same is 
            //Nullable type only work with value type  only
            int? x = 10;
            x = null;
            Console.WriteLine(x);

            if (x.HasValue)
            {
                Console.WriteLine("Value of x is :" + x);
            }
            else
            {
                Console.WriteLine("x has no value");
            }


            Console.ReadLine();


            /*int[] numArray = { 1, 5, 3, 4, 7, 6, 2, 8 };
            Console.WriteLine("Attay before sorting");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            int[] numArray1 = new int[numArray.Length];
            numArray1 = SortingArray(numArray);
            Console.WriteLine("Array after sorting");

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            Console.ReadLine();
            */

        }

       
    }
}
