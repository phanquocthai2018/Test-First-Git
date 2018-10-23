using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = DateTime.Now.ToLocalTime();
            Console.WriteLine(dateTime1);
            DateTime dateTime2 = dateTime1.AddDays(2);
            Console.WriteLine(dateTime2);
            DateTime dateTime3 = dateTime2.AddHours(5);
            Console.WriteLine(dateTime3);

            DateTime dateTime4 = DateTime.UtcNow.Date;
            for (int i = 0; i < 10; i++)
            {
                //DateTime dateTime1 = DateTime.Now.ToLocalTime();

                for (int j = 0; j < 24; j++)
                {
                    Console.WriteLine(dateTime4);
                    dateTime4 = dateTime4.AddHours(1);

                }
                dateTime4 = dateTime4.AddDays(-2).Date;
                Console.WriteLine(dateTime4);
            }
        }
    }
}
