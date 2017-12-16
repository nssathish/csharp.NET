using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int id;
        public string name;
        public List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }
        /*
         * Constructor overloading is not highly recommended (or) encouraged
         * since it is not sensible unless initializing the attributes of a class
         * has interdependent classes.
         */
        public Customer(int Id)
            :this()     //calling the "this" pointing to a constructor is encouraged at this level only since
        // it will impact the program readability
        {
            this.id = Id;
        }
        public Customer(int Id, string customerName)
            //: this()
            :this(Id)
        {
            this.id = Id;
            this.name = customerName;
        }
    }
}
