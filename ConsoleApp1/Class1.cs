using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Class1
    {
        public worker[] work;
        //индексация, но можно и без нее
        //делает обращение более коротким
        //public worker this [int index]
        //    {
        //    get { return work [index]; }
        //    set { work [index] = value; }
        //}
        public Class1( params worker[] Args)
        {//используя ключевое слово params, мы можем
         //передавать неопределенное количество параметров
            work = Args;
         }//Сам параметр с ключевым словом params при определении
          //метода должен представлять одномерный массив того типа,
          //данные которого мы собираемся использовать. При вызове
          //метода на место параметра с модификатором params мы можем
          //передать как отдельные значения, так и массив значений, либо
          //вообще не передавать параметры. Количество передаваемых
          //значений в метод неопределено, однако все эти значения
          //должны соответствовать типу параметра с params.
    }
}
