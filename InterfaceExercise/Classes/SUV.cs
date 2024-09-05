using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Classes
{
    internal class SUV: IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; }
        public int SaftetyRating { get; set; }

        public string Name { get; set; }
        public bool Active { get; set; }
        public bool IsDriveable { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void DisplayDetails()
        {
            string isActive = Active ? "is" : "is not";
            string isDriveable = IsDriveable ? "is" : "is not";

            Console.WriteLine($"{Name} owns a {Year} {Make} {Model} that {isDriveable} in driveable condition. It has {NumberOfSeats} seats. It {isActive} on active duty. It has a {SaftetyRating} star safety rating");
        }
    }
}
