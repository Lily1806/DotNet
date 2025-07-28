using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai62
{
    internal class Vehicles
    {
        public string id {  get; set; }
        public string marker {  get; set; }
        public string model {  get; set; }
        public int year {  get; set; }
        public double price {  get; set; }

        public Vehicles() { }

        public Vehicles(string id)
        {
            this.id = id;
        }

        public Vehicles(string id, string marker, string model, int year, double price)
        {
            this.id = id;
            this.marker = marker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            //Console.Write("Nhập Id: ");
            //id = Console.ReadLine();

            Console.Write("Nhập maker: ");
            marker = Console.ReadLine();

            Console.Write("Nhập model: ");
            model = Console.ReadLine();

            Console.Write("Nhập year: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Nhập price: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write("{0, -10}{1, -20}{2, -20}{3, -20}{4, -15}", id, marker, model, year, price);
        }

        public override bool Equals(object obj)
        {
            return obj is Vehicles vehicles &&
                   id == vehicles.id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
