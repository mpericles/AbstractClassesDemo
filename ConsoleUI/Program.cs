using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            //List<int> list = new List<int>();
            List<Vehicle> vehicleList = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            //object initializer Syntax
            Car car1 = new Car()
            {
                Hastrunk = true,
                Make = "Ford",
                Model = "F150",
                Year = 2018
            };

            //need to call the method
            //The actual object has to exist before you call the method
            //not a static method it is an instance method so u need to use the instance
            //car1.DriveAbstract();
            //car1.DriveVirtual();
            //we can do this in the foreach loop

            Mortocycle motorcycle1 = new Mortocycle()
            {
                SideCart = true,
                Make = "Harley",
                Model = "x3000",
                Year = 2018
            };

            //Constructor Syntax
            //Vehicle vehicle = new Vehicle();  //cannot instanciate abstractclass
            Vehicle car2 = new Car()
            {
                Hastrunk = true,
                Make = "Genesis",
                Model = "X70",
                Year = 2023
            };

            Vehicle motorcycle2 = new Mortocycle()
            {
                SideCart = true,
                Make = "Honda",
                Model = "Q4",
                Year = 2023
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            //List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(motorcycle1);
            vehicleList.Add(motorcycle2);
            vehicleList.Add(car1);
            vehicleList.Add(car2);

            foreach (Vehicle vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Year);
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }
            //Extra Credit
            Console.WriteLine("Extra Credit");
            Console.WriteLine("for Extra credit attempt to print the intenal properties for Car and mortocycle");
            Console.WriteLine("this is the full details of the first car including Trunk");
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Year);
            Console.WriteLine($"The first car trunk status is: {car1.Hastrunk}");
            Console.WriteLine();

            Console.WriteLine("this is the full details of the first Mortocycle including SideCart");
            Console.WriteLine(motorcycle1.Model);
            Console.WriteLine(motorcycle1.Make);
            Console.WriteLine(motorcycle1.Year);
            Console.WriteLine(motorcycle1.SideCart);
            Console.WriteLine($"The first Mortocycle SideCart status is: {(motorcycle1.SideCart)}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("this is trunk details of the second car including Trunk");
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.Make);
            Console.WriteLine(car2.Year);
            Console.WriteLine("The Second car trunk status is");
            Console.WriteLine(value: car2.Hastrunk);
            //Console.WriteLine($"The Second car trunk status is: {(value: car2.Hastrunk)}");
            Console.WriteLine();


            Console.WriteLine("this is the Sidecart detail of the second mortocycle including SideCart");
            Console.WriteLine(motorcycle2.Model);
            Console.WriteLine(motorcycle2.Make);
            Console.WriteLine(motorcycle2.Year);
            Console.WriteLine("The Second Mortocycle SideCart status is");
            Console.WriteLine(value: motorcycle2.SideCart);


            // Call each of the drive methods for one car and one motorcycle

            #endregion


            Console.ReadLine();
        }
    }
}
