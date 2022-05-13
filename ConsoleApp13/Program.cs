using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tigi_i_Enot tigi_I_Enot = new Tigi_i_Enot(); 
            tigi_I_Enot.Setkus("Котлета"); //(1)

            Tigi_i_Enot tigi_I_Enot1 = new Tigi_i_Enot();
            tigi_I_Enot1.Puk  = 20;//(2)

            Tigi_i_Enot tigi_I_Enot3 = new Tigi_i_Enot();
            tigi_I_Enot3.Enot_color = "Небесно Фиолетовый";
            //(3)
            Console.WriteLine(tigi_I_Enot.Getkus());
            Console.ReadKey();
        }
    }
}
