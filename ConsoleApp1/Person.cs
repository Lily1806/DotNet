using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Person() { }

        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.Write("Nhập id: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhập name: ");
            name = Console.ReadLine();

            Console.Write("Nhập address: ");
            address = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write("{0,-10}{1,-15}{2,-20}", id, name, address);
        }
    }
}
