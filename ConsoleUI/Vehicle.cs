using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        internal bool SideCart;

        // Create an abstract class called Vehicle
        // The vehicle class shall have three string properties Year, Make, and Model
        // Set the defaults to something generic in the Vehicle class
        public int Year { get; set; } = 2023;
        public string Make { get; set; } = "Porsche";
        public string Model { get; set; } = "Cayenne";
        public bool Hastrunk { get; internal set; }

        //abstract
        //Vehicle shall have an abstract method called DriveAbstract with no implementation
        public abstract void DriveAbstract();

        //virtual
        //Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is the default/base implementation for the DriveVirtual Method");
        }
    }
}
