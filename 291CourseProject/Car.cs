using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _291CourseProject
{
    class Car
    {
        string Car_ID;
        string Type_ID;
        public Car(string carID, string typeID)
        {
            this.Car_ID = carID;
            this.Type_ID = typeID;
        }

        public override string ToString()
        {
            return this.Type_ID;
        }

        public string getCarID() { return this.Car_ID; }
        public string getTypeID() { return this.Type_ID; }
    }
}
