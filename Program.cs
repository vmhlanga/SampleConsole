using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Authentication.ExtendedProtection;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {


            foreach (var item in hexArray())
            {
                Console.WriteLine(item);
            }
           
            Console.ReadLine();
        }


        public static string[] hexArray() 
        {
            DateTime date = DateTime.Now;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            int epoc = (int)Math.Floor(diff.TotalSeconds);
            string hexval = epoc.ToString("X");

            List<string> list = new List<string>();
            
            /* Breakout Characters*/
            int chunkSize = 2;
            int stringLength = hexval.Length;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
              /*Add values to list*/  list.Add(hexval.Substring(i, chunkSize));
            }

            list.Add("12");
            /*Reverse values in list*/ list.Reverse();

            return list.ToArray();
        }

        

    }
    }







