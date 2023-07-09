using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Mortocycle : Vehicle
    {
        public bool SideCart { get; set; } = false;
        
        //public virtual void DriveAbstract()
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a Mortocycle with an Abstract Method");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Driving a Mortocycle with a Virtual Method");
        }
    }
}
