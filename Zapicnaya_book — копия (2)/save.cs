using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zapicnaya_book
{
  /// <summary>
  /// Заполнение массива и запись в файл.
  /// </summary>
    internal struct save
    {
        /// <summary>
        ///  метод - Заполнение массива и запись в файл.
        /// </summary>
        public void Save_field()
        {
            string adres_field = @"E:\dolg.txt";
            
            using (StreamWriter sw = new StreamWriter(adres_field, true))
            {
                ConsoleKey key_w = new ConsoleKey(); //выход из цикла вайл добавления записей

                //Array_book array_Book = new Array_book();//реализация через массив
                //array_Book.arr = new add_zapic[10];

                List_book list_Book = new List_book();
                list_Book.list = new List<add_zapic>();

                int count1 = 0;
                int number = 1;
                string name = string.Empty;
                string last_name = string.Empty;
                while (key_w != ConsoleKey.Enter)
                { 
                    Console.Write("Введите имя должника: ");
                    name = Console.ReadLine();
                    Console.Write("\nВведите Фамилию должника: ");
                    last_name = Console.ReadLine();
                    list_Book.list.Add(new add_zapic(number, name, last_name));
                    sw.Write($"{list_Book.list[count1].Get_number(number)} ");
                    sw.Write($"{list_Book.list[count1].Get_name(name)} ");
                    sw.WriteLine($"{list_Book.list[count1].Get_last_name(last_name)} ");
                    //array_Book.arr[count] = new add_zapic(_name, _Lname); реализация добавления записи через массив
                    //sw.Write($"{array_Book.arr[count].Get_name(_name)} ");
                    //sw.WriteLine($"{array_Book.arr[count].Get_last_name(_Lname)} ");

                    Console.WriteLine($"\nЗапись добавленна!");
                    Console.WriteLine($"Нажмите (Space) что бы продолжить ввод. Нажмите (Enter) если хотите остановить ввод записей! ");
                    key_w = Console.ReadKey().Key;
                    number++;
                     count1++;
                }
              
                sw.Close();
                
            }
        }
        /// <summary>
        ///  метод - Загрузка из файла и заполнение  массива структур.
        /// </summary>
        public void Load_field()
        {
            
            string adres_field = @"E:\dolg.txt";
            List_book list_Book = new List_book();
            list_Book.list = new List<add_zapic>();
           
            int number = 1;
            string name = string.Empty;
            string last_name = string.Empty;
            using (StreamReader sr = new StreamReader(adres_field))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr_st_line = line.Split(' ');
                        number = int.Parse( arr_st_line[0]);
                        name = arr_st_line[1];
                        last_name = arr_st_line[2];
                        list_Book.list.Add(new add_zapic(number, name, last_name));
                }
                sr.Close();

            }
            Console.WriteLine($"Номер  Имя    Фамилия   " );
             
            foreach (add_zapic item in list_Book.list)
            {
                Console.WriteLine(item.Print());
            }
           
        }
        /// <summary>
        /// Добавление записи - для метода  Load_field()
        /// </summary>
        public void Add_next()
        {
            Console.WriteLine($"Нажмите (Space) что бы добавить запись. Нажмите (Enter) если хотите выйти! ");

            ConsoleKey key_w = new ConsoleKey();
            key_w = Console.ReadKey().Key;
            if (key_w != ConsoleKey.Enter)
            {
                Save_field();
            }
        }
        /// <summary>
        /// Редактирование записи
        /// </summary>
        public void Delete()
        {

            string adres_field = @"E:\dolg.txt";
            List_book list_Book = new List_book();
            list_Book.list = new List<add_zapic>();
           
            int number = 1;
            string name = string.Empty;
            string last_name = string.Empty;
            using (StreamReader sr = new StreamReader(adres_field))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr_st_line = line.Split(' ');
                    number = int.Parse(arr_st_line[0]);
                    name = arr_st_line[1];
                    last_name = arr_st_line[2];
                    list_Book.list.Add(new add_zapic(number, name, last_name));
                }
                sr.Close();

            }
            Console.WriteLine($"Номер  Имя    Фамилия   ");

           
            ConsoleKey key_w = new ConsoleKey();
             
            using (StreamWriter sw = new StreamWriter(adres_field ))
            {
                while (key_w != ConsoleKey.Enter)
            {
                    foreach (add_zapic item in list_Book.list)
                    {
                        Console.WriteLine(item.Print());
                    }
                    Console.WriteLine($"Выбирите запись которую нужно удалить.");


                string number_str = Console.ReadLine();
                int number_l = int.Parse(number_str);
                list_Book.list.RemoveAt(number_l-1);
                    for (int i = 0; i < list_Book.list.Count; i++)
                    {   if (list_Book.list[i].Number > number_l)
                        {
                            int number1 = list_Book.list[i].Number - 1;
                            sw.Write($"{list_Book.list[i].Get_number(number1)} ");
                        }
                        else
                        {
                            int number1 = list_Book.list[i].Number;
                            sw.Write($"{list_Book.list[i].Get_number(number1)} ");
                        }
                        string name1 = list_Book.list[i].Name;
                        string last_name1 = list_Book.list[i].Last_name;


                       
                        sw.Write($"{list_Book.list[i].Get_name(name1)} ");
                        sw.WriteLine($"{list_Book.list[i].Get_last_name(last_name1)} ");
                    }
                    Console.WriteLine($"Нажмите (Space) если хотите удалить еще запись. Нажмите (Enter) для выхода! ");
                key_w = Console.ReadKey().Key;
                
            }
                sw.Close();
            }
          
        }
        /// <summary>
        /// Редоктирование записи
        /// </summary>
        public void Editing()
        {

            string adres_field = @"E:\dolg.txt";
            List_book list_Book = new List_book();
            list_Book.list = new List<add_zapic>();
            add_zapic add_zapic = new add_zapic();
            int number = 1;
            string name = string.Empty;
            string last_name = string.Empty;
            using (StreamReader sr = new StreamReader(adres_field))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr_st_line = line.Split(' ');
                    number = int.Parse(arr_st_line[0]);
                    name = arr_st_line[1];
                    last_name = arr_st_line[2];
                    list_Book.list.Add(new add_zapic(number, name, last_name));
                }
                sr.Close();

            }
            Console.WriteLine($"Номер  Имя    Фамилия   ");

            foreach (add_zapic item in list_Book.list)
            {
                Console.WriteLine(item.Print());
            }
            ConsoleKey key_w = new ConsoleKey();
            while (key_w != ConsoleKey.Enter)
            {
                using (StreamWriter sw = new StreamWriter(adres_field))
            {
               
                    Console.WriteLine($"Выбирите запись которую нужно отредактировать.");


                    string number_str = Console.ReadLine();
                    int number_l = int.Parse(number_str);
                    list_Book.list.RemoveAt(number_l - 1);
                    Console.Write("Введите имя должника: ");
                    name = Console.ReadLine();
                    Console.Write("\nВведите Фамилию должника: ");
                    last_name = Console.ReadLine();
                    number = number_l;
                    list_Book.list.Insert(number_l - 1, new add_zapic(number, name, last_name));
                   for(int i = 0; i < list_Book.list.Count; i++)
                    {
                        
                        int number1 = list_Book.list[i].Number;
                        string name1 = list_Book.list[i].Name;
                        string last_name1 = list_Book.list[i].Last_name;
                        sw.Write($"{list_Book.list[i].Get_number(number1)} ");
                        sw.Write($"{list_Book.list[i].Get_name(name1)} ");
                        sw.WriteLine($"{list_Book.list[i].Get_last_name(last_name1)} ");
                    }

                    sw.Close();
                    Console.WriteLine($"Нажмите (Space) если хотите отредактировать еще запись. Нажмите (Enter) для выхода! ");
                    key_w = Console.ReadKey().Key;

                }
                
            }



        }
        public void Import()
        {

            string adres_field = @"E:\dolg.txt";
            List_book list_Book = new List_book();
            list_Book.list = new List<add_zapic>();
            add_zapic add_zapic = new add_zapic();
            int number = 1;
            string name = string.Empty;
            string last_name = string.Empty;
            using (StreamReader sr = new StreamReader(adres_field))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr_st_line = line.Split(' ');
                    number = int.Parse(arr_st_line[0]);
                    name = arr_st_line[1];
                    last_name = arr_st_line[2];
                    list_Book.list.Add(new add_zapic(number, name, last_name));
                }
                sr.Close();

            }
            Console.WriteLine($"Номер  Имя    Фамилия   ");

            foreach (add_zapic item in list_Book.list)
            {
                Console.WriteLine(item.Print());
            }
            string adres_field_import = @"E:\dolg_import.txt";
            using (StreamWriter sw = new StreamWriter(adres_field_import))
                {

                    Console.WriteLine($"Введите диапазон записей который нужно импортировать (Число 1 - начало. Число 2 - конец).");

                    Console.Write("Число 1: ");
                    string number_str = Console.ReadLine();
                    int number_1 = int.Parse(number_str);
                    Console.Write("\nЧисло 2: ");
                    number_str = Console.ReadLine();
                    int number_2 = int.Parse(number_str);
                    //List_book list_Book_import = new List_book(); как вариант но не заработало что то
                    //list_Book_import.list = new List<add_zapic>();
                    //list_Book_import.list = list_Book.list.GetRange(number_1-1, number_2);
                   
                    number = number_1;
                    list_Book.list.Insert(number_1 - 1, new add_zapic(number, name, last_name));
                    for (int i = number_1; i < number_2+1; i++)
                    {

                        int number1 = list_Book.list[i].Number;
                        string name1 = list_Book.list[i].Name;
                        string last_name1 = list_Book.list[i].Last_name;
                        sw.Write($"{list_Book.list[i].Get_number(number1)} ");
                        sw.Write($"{list_Book.list[i].Get_name(name1)} ");
                        sw.WriteLine($"{list_Book.list[i].Get_last_name(last_name1)} ");
                    }
                Console.WriteLine($"Нажмите (Enter) для завершения.");
                sw.Close();
                    

                }

            



        }

    }
    
}
