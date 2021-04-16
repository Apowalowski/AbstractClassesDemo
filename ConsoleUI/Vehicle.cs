using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class  Vehicle
    {
        public Vehicle()
        {

        }
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "default make";
        public string Model { get; set; } = "default model";
        public abstract void DriveAbstract(); //stubbed out method
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"this {GetType().Name} is virtually in drive.");
        }

    }
}
