using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        #region MyCustomer
        public class MyCustomer
        {
            public string name;
            public string phone;

            private MyCustomer() { }
            public MyCustomer(string name, string phone) : this()
            {
                this.name = name;
                this.phone = phone;
            }
        }
        #endregion MyCustomer

        static void Main(string[] args)
        {
            //BinarySearchNode<MyCustomer> bsn = new BinarySearchNode<MyCustomer>("phil","2818817146");
        }

    }
}
