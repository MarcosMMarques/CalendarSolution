﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_de_ProgVis
{
    public class Calendario
    {
        public Byte mes { get; set; }
        public UInt16 ano { get; set; }

        public Boolean isMesValido()
        {
            if (mes > 0 && mes < 13)
            {
                return true;
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("O Mês deve seguir o formato númerico,\n tal como 3 para março,\n e portanto, deve ser de 1 a 12.");
                Console.WriteLine("----------------------------------------");
                return false;
            }
        }
        public Boolean isAnoValido()
        {
            if (ano > 0 && ano < 10000)
            {
                return true;
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("O ano deve seguir o formato númerico,\n tal como '2022', e deve ser de 1 a 9999.");
                Console.WriteLine("----------------------------------------");
                return false;
            }
        }

        public String GerarCalendario()
        {
            StringBuilder sb = new StringBuilder();
            DateTime iniciomes = new DateTime(ano, mes, 1);
            int dia = DateTime.DaysInMonth(ano, mes);
            int diasemana = Convert.ToInt32(iniciomes.DayOfWeek.ToString("d"));
            sb.AppendLine("      "+ iniciomes.ToString("MMMM 'de' yyyy"));
            sb.AppendLine("-----------------------------");
            sb.AppendLine("  D   S   T   Q   Q   S   S  ");
            sb.AppendLine("-----------------------------");

            int x = 1;
            int n = 0;
            int[,] vetor = new int[6, 7];
            int diavazio = diasemana;
            sb.Append("  ");
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {

                        if (n < diavazio)
                        {
                            vetor[i, j] = ' ';
                            sb.Append("    ");
                            n++;
                        }
                        else if (x <= dia)
                        {
                            vetor[i, j] = x;
                            sb.Append("" + vetor[i, j].ToString().PadLeft(2, '0') + "  ");
                            x++;
                            diasemana++;
                        }

                        if (diasemana % 7 == 0 && diasemana > 0)
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