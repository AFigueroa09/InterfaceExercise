using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Classes
{
    internal class Truck: IVehicle, ICompany
    {
        public int MaxCargoWeight { get; set; }
        public bool IsEighteenWheeler { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool IsDriveable { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void DisplayDetails()
        {
            string isEighteenWheeler = IsEighteenWheeler ? "is" : "is not";
            string isActive = Active ? "is" : "is not";
            string isDriveable = IsDriveable ? "is" : "is not";

            Console.WriteLine($"{Name} owns a {Year} {Make} {Model} that {isDriveable} in driveable condition. It has {MaxCargoWeight}lbs weight limit. It {isActive} on active duty. It {isEighteenWheeler} an eighteen wheeler");
        }
    }

}
