//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp13
//{
//    internal struct Tigi_i_Enot
//    {   //Как лучше делать
//        public Tigi_i_Enot (string kus)
//        {
//            this.kus = kus;
//        }
//        //здесь обязательно приват
//        private string kus;
//        public string Getkus()
//        { //метод для чтения  (1)
//            return kus;  
//        }
//        public void Setkus(string New_kus)
//        {//метод для записи
//            this.kus = New_kus;
//        }
//          private int puk;
//        public Tigi_i_Enot(int puk)
//        {
//            this.puk = puk;
//        }
//        //имена полей пишем с маленькой буквы
//        //имена свойств с Большой
//        //имя свойства совпадает с именем поля
//        public int Puk
//        {//get - чтение (2)
//            get { return puk; } 
//            set { puk = value; }
//        }//set - запись
//        public string Enot_color { get; set; }
//        //можно добавить {private get; set; } (3)
//    }
//} 
