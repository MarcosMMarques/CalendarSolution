using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trab_de_ProgVis
{
    internal static class Program
    {
        static void Main()
        {
        Calendar c = new Calendar();
            do
            {
                try
                {
                    Console.WriteLine("Type the desired month: ");
                    c.month = Convert.ToByte(Console.ReadLine());

                }
                catch(Exception)
                {

                }
            } while (c.isMonth() == false);

            do
            {
                try
                {
                    Console.WriteLine("Type the desired year: ");
                    c.year = Convert.ToUInt16(Console.ReadLine());
                }catch(Exception)
                {

                }
            } while (c.isYear() == false);
            
            Console.WriteLine(c.GerarCalendario());
        }
    }
}


