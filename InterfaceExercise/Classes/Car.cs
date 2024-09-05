using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Classes
{
    internal class Car: IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public int Mileage { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool IsDriveable { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void DisplayDetails()
        {
            string hasTrunk = HasTrunk ? "has" : "doesn't have";
            string isActive = Active ? "is" : "is not";
            string isDriveable = IsDriveable ? "is" : "is not";

            Console.WriteLine($"{Name} owns a {Year} {Make} {Model} that {isDriveable} in driveable condition. It's current mileage is {Mileage}. It {isActive} on active duty. It {hasTrunk} a trunk.");
        }
    }
}
