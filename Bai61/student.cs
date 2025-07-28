using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai61
{
    internal class student:person
    {
        public byte math {  get; set; } 
        public byte physic {  get; set; }

        public student() { }

        public student(int id, string name, string address, byte math, byte physic):base(id, name, address)
        {
            this.math = math;
            this.physic = physic;
        }

        public override void Input()
        {
            
            base.Input();
            Console.Write("Nhập điểm toán: ");
            math = Convert.ToByte(Console.ReadLine());

            Console.Write("Nhập điểm lý: ");
            physic = Convert.ToByte(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0, -10}{1, -10}", math, physic);

        }
        public float total() => math + physic;
    }
}
