using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai62
{
    internal class Car:Vehicles
    {
        public string color {  get; set; }

        public Car() { }
        public Car(string id, string marker, string model, int year, double price, string color):base(id, marker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            
            base.Input();
            Console.WriteLine("Nhập color: ");
            color = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0, -15}", color);
        }
    }
}
