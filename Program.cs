using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int    length = 12;
            const string str    = "abcdefghijklmnopqrstuvwxyz";
            const string num    = "0123456789";

            string all  = str + num;
            //MyTime time = new MyTime();
            //time.Now();
            string password = ""; 

            Console.WriteLine(all.Length);
            Random random = new Random((int)DateTime.Now.ToBinary());


            for(int cnt=0; cnt<length; cnt++)
            {
                Console.WriteLine();
                int    index = random.Next(all.Length);
                string temp  = all.Substring(36, 1);
                password += temp;
            }
            Console.WriteLine(password);
            Console.WriteLine("何かキーを押してください");
            Console.ReadKey();
        }
    }

    class MyTime
    {
        public int Now()
        {
            DateTime dateTime = DateTime.Now;
            int      now      = 0;

            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Day);

            Console.WriteLine(dateTime.Hour);
            Console.WriteLine(dateTime.Minute);
            Console.WriteLine(dateTime.Second);
            Console.WriteLine(dateTime.Millisecond);

            //Console.WriteLine(dateTime.ToString("yyyyMMddHHmmssfff"));

            //now = Int32.Parse(dateTime.ToString("yyyyMMddHHmmssfff"));
            //now = Int32.Parse(dateTime.ToString("yyyyMMdd"));
            //Console.WriteLine(now);

            long a=dateTime.ToBinary();
            Console.WriteLine(a);

            now = (int)a;
            Console.WriteLine(now);


            return now;

        }

    }
}
