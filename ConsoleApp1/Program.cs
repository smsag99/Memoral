using memoral;
using memoral.DataLayer;
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
             List<Factore> sabad = new List<Factore>();
            Factore f = new Factore()
            {
                FactoreId = 10,
                Frq_request = 20,
                Date = DateTime.Now,
                Seller = 0,
            };

            sabad.Add(f);



            f = new Factore()
            {

                FactoreId = 11,
                Frq_request = 25,
                Date = DateTime.Now,
                Seller = 1,
            };
            sabad.Add(f);
            f = new Factore()
            {
                FactoreId = 12,
                Frq_request = 35,
                Date = DateTime.Now,
                Seller = 2,
            };
            sabad.Add(f);



            sabad.RemoveAll(ff => ff.FactoreId == 11);
            
            

            Console.WriteLine();
        }
    }
}
