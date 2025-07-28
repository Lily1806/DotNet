using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai61
{
    internal class person
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string address {  get; set; }

        public virtual void Input()
        {
            Console.Write( "Nhập id: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhập name: ");
            name = Console.ReadLine();

            Console.Write("Nhập address: ");
            address = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write("{0, -10}{1, -20}{2, -25}", id, name, address);
        }


        public person() { }
        public person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public person(int id ) 
        { 
            this.id = id;
        }

    }
}
