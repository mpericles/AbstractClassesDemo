using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

internal class Car : Vehicle
{
public bool Hastrunk { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("Driving a Car with an Abstract Method");
    }
}
