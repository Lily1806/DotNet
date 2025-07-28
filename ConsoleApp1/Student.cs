using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public byte maths { get; set; }
        public byte physic { get; set; }

        public Student() { }

        public Student(int id, string name, string address, byte maths, byte physic)
            : base(id, name, address)
        {
            this.maths = maths;
            this.physic = physic;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập điểm math: ");
            maths = Convert.ToByte(Console.ReadLine());

            Console.Write("Nhập điểm physic: ");
            physic = Convert.ToByte(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-10}{1,-10}", maths, physic);
        }

        public float total() => maths + physic;

        public override bool Equals(object obj)
        {
            return obj is Student student && id == student.id;
        }
    }
}
