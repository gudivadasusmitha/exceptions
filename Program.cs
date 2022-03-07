using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    internal class Program
    {
        //index out of range
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.ReadLine();
        }

    

        
        //entry point not found
        
        
        public static extern int GetMyNumber();
        public static void Main()
        {
            try
            {
               int number = GetMyNumber();
            }
            catch(EntryPointNotFoundException e)
            {
                Console.WriteLine("{0}:\n {1}", e.GetType().Name, e.Message);
                Console.ReadLine();
            }
        }
        
        
        //null reference exception
        
        public static void Main(String[] args)
        {
            int value = Int32.Parse(args[0]);
            List<string> names;
            if (value > 0)
                names = new List<string>[];
                names.Add("major major major");
        }

        //format exception
        public class example
        {
            public static void Main()
            {
                decimal price = 169.32m;
                Console.WriteLine("the cost is {0:Q2}.", price);
            }
        }
        
    }
        
}
