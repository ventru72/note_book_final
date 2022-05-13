using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapicnaya_book
{
    internal struct add_zapic
    {
        // private int number;
        private int number;
        private string name;
        private string last_name;
        //private int debt;
        //private DateTime date_to_give;

        public add_zapic(int number, string name, string last_name)
        {
            this.number = number;
            this.name = name;
            this.last_name = last_name;

        }
        /// <summary>
        /// Метод ввода данных в поля с клавиатуры
        /// </summary>
        /// <returns></returns>
        /// 
        public string Number { get { return name; } set { name = value; } }
        public string Name { get { return name; } set { name = value; } } //свойства записи и чтения
       public string Last_name { get { return last_name; } set { last_name = value; } }
        public string Add_Name()
        {
           
            string name = Console.ReadLine();
            return name;
        }
        public int Get_number(int number)
        {
            return number;
        }
        public string Get_name(string name)
        {
            return name;
        }
        public string Get_last_name(string last_name)
        {
            return last_name;
        }
        /// <summary>
        /// Метод вывода на экран введенных данных полей
        /// </summary>
        public string Print()
        {
            return $"{name}    {last_name}.";
            //Console.WriteLine($"Имя должника: {name}. Фамилия должника: {last_name}.");
        }

    }
}
