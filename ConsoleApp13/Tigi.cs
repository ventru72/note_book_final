using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
   public  struct Tigi
   {
        public string puki_puki;
        public int pawer;
        public string speed;
        public string Print()
        {
    return $"Как пукает Енот? {puki_puki} Как громко в Децибелах?" +
      $" Примерно {pawer} Децибела. Что Енот сделала потом? {speed}";
        }
        public Tigi(string puki_puki, int pawer, string speed)
        { 
            this.puki_puki= puki_puki;
            this.pawer= pawer;
            this.speed= speed;
        }
        public Tigi (int pawer, string speed)
        {
            this.puki_puki = string.Empty;
            this.pawer= pawer;
            this.speed= speed;
        }
        public Tigi(string puki_puki, int pawer ):
            this(puki_puki, pawer, string.Empty)
        {//можно еще задать значения здесь
            this.speed = "Щух - щух";
        }
        public Tigi(string puki_puki) :
            this(puki_puki, 0, string.Empty)
        {
        }
        

    }
}


