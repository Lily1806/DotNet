using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai62
{
    internal class Truck:Vehicles
    {
        public int truckload {  get; set; }
        public override void Input()
        {
            
            base.Input();
            Console.WriteLine("Nhập truckload: ");
            truckload = int.Parse(Console.ReadLine());


        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0, -15}", truckload);
        }
    }
}
