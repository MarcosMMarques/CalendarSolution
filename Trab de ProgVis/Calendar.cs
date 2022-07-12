using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_de_ProgVis
{
    public class Calendar
    {
        public Byte month { get; set; }
        public UInt16 year { get; set; }

        public Boolean isMonth()
        {
            if (month > 0 && month < 13)
            {
                return true;
            }
            else
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("The Month must follow a numerical format,\n such as 3 for March, and therefore must\n be from 1 to 12.");
                Console.WriteLine("-----------------------------------------");
                return false;
            }
        }
        public Boolean isYear()
        {
            if (year > 0 && year < 10000)
            {
                return true;
            }
            else
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("The year must follow the numerical format,\n such as '2022', and must be from 1 to 9999.");
                Console.WriteLine("--------------------------------------------");
                return false;
            }
        }

        public String GerarCalendario()
        {
            StringBuilder sb = new StringBuilder();
            DateTime startmonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int dayweek = Convert.ToInt32(startmonth.DayOfWeek.ToString("d"));
            sb.AppendLine("      "+startmonth.ToString("MMMM 'of' yyyy"));
            sb.AppendLine("-----------------------------");
            sb.AppendLine("  D   S   T   Q   Q   S   S  ");
            sb.AppendLine("-----------------------------");

            int x = 1;
            int n = 0;
            int[,] vector = new int[6, 7];
            int blankday = dayweek;
            sb.Append("  ");
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {

                        if (n < blankday)
                        {
                            vector[i, j] = ' ';
                            sb.Append("    ");
                            n++;
                        }
                        else if (x <= day)
                        {
                            vector[i, j] = x;
                            sb.Append("" + vector[i, j].ToString().PadLeft(2, '0') + "  ");
                            x++;
                            dayweek++;
                        }

                        if (dayweek % 7 == 0 && dayweek > 0)
                        {
                            sb.Append("\n  ");
                        }
                    }
                }
            Console.Clear();
            return sb.ToString();
        }
    }
}
