using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int pm = 0, pt = 0, pn = 0, v, ppm, ppt, ppn;
            for (int i = 1; i <= 69; i++)
            { 
            Console.WriteLine("Ingrese la edad de un estudiante del turno mañana");
            v = int.Parse(Console.ReadLine());
            if (pm == 0)
                {
                    pm = v;
                }
            else
                {
                    pm = pm + v;
                }
            }
            ppm = pm / 50;
            for (int i = 1; i <= 60; i++)
            {
                Console.WriteLine("Ingrese la edad de un estudiante del turno tarde");
                v = int.Parse(Console.ReadLine());
                if (pt == 0)
                {
                    pt = v;
                }
                else
                {
                    pt = pm + v;
                }
            }
            ppt = pt / 60;
            for (int i = 1; i <= 110; i++)
            {
                Console.WriteLine("Ingrese la edad de un estudiante del turno noche");
                v = int.Parse(Console.ReadLine());
                if (pn == 0)
                {
                    pn = v;
                }
                else
                {
                    pn = pn + v;
                }
            }
            ppn = pn / 110;
            Console.WriteLine("El promedio del turno mañana es {0}, el del tarde es {1}, el del noche es {2}", ppm, ppt, ppn);
            if(ppm > ppt && ppm > ppn)
            {
                Console.WriteLine("El promedio mas alto es el de la mañana");
            }
            else if (ppn > ppt)
            {
                Console.WriteLine("El promedio mas alto es el de la noche");
            }
            else
            {
                Console.WriteLine("El promedio mas alto es el de la tarde");
            }
            Console.ReadKey();
        }
    }
}
