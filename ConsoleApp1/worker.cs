using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct worker
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }

        public worker(int Id, string Name, string Las_name)
        {
            this.Id = Id;
            this.Name = Name;   
            this.Last_name = Las_name;
        }
        public string Print()
        {
           return $"ИД {Id}, {Name} {Last_name}";
        }

    }
}
//public int Id
//{
//    get { return Id; }
//    set { Id = value; }
//}
//public string Name
//{
//    get { return Name; }
//    set { Name = value; }
//}
//public string Last_name
//{
//    get { return Last_name; }
//    set { Last_name = value; }
//}