namespace Customer.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string PermanentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments { get; set; }
        public CustomerType Type { get; set; }


        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if(customer == null)
            {
                return false;
            }
            else if(Object)
            {

            }

            return this.Equals(obj);
            //return base.Equals(obj);
        }
    }
}
