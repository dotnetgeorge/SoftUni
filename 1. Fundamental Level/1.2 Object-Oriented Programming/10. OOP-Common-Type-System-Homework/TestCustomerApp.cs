/*
Problem 2.	Customer
Define a class Customer, which contains data about a customer 
    – first name, middle name and last name, ID (EGN), permanent address, mobile phone, e-mail, list of payments and customer type. 
•	Define a class Payment which holds a product name and price.
•	Define an enumeration for the customer type, holding the following types of customers: One-time , Regular, Golden, Diamond.
•	Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
•	Implement the ICloneable interface. 
    The Clone() method should make a deep copy of all object fields into a new object of type Customer.
•	Implement the IComparable<Customer> interface to compare customers 
    by full name (as first criteria, in lexicographic order) and by ID (as second criteria, in ascending order).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerАpp
{
    class TestCustomerApp
    {
        static void Main(string[] args)
        {
        }
    }
}
