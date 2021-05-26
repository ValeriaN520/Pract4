using System;
using System.Collections;
namespace Практическая_работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l1 = new ArrayList() { 'j', 6, 'i', 'S', 'O', 8, 'Y', 12, 13, 't', 'z', 'h', 5, 'L' };
            string t = "";
            for (int i = 0; i < l1.Count; i++)
            {
                t += l1[i] + "  ";
            }
            Console.WriteLine("Начальная коллекция: " + t);
            ArrayList nl = new ArrayList();
            string a = "";
            for (int i = 0; i < l1.Count; i++)
            {
                if (Char.IsNumber(l1[i].ToString().ToCharArray()[0]) == false)
                {
                    if (Char.IsUpper(l1[i].ToString().ToCharArray()[0]))
                    {
                        nl.Add(l1[i]);
                    }
                    l1.RemoveAt(i);
                    i--;
                }
                else
                {
                    a += l1[i] + "  ";
                }
            }
            Console.WriteLine("Коллекция без букв: " + a);
            a = "";
            for (int i = 0; i < nl.Count; i++)
            {
                a += nl[i] + "  ";
            }
            Console.WriteLine("Коллекция заглавных букв: " + a);
        }
    }
}