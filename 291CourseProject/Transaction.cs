using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _291CourseProject
{
    class Transaction
    {
        int Rental_ID;
        int Customer_ID;
        public Transaction(int Rental_ID, int Customer_ID)
        {
            this.Rental_ID = Rental_ID;
            this.Customer_ID = Customer_ID;
        }
        public Transaction() { }

        public override string ToString()
        {
            return this.Rental_ID.ToString();
        }

        public int getRentalID() { return this.Rental_ID; }
        public int getCustomerID() { return this.Customer_ID; }
    }
}
