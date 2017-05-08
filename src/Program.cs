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
        public class MyCustomer : IComparable<MyCustomer>
        {
            public string name;
            public string phone;

            #region Constructors
            private MyCustomer() { }
            public MyCustomer(string name, string phone) : this()
            {
                this.name = name;
                this.phone = phone;
            }
            #endregion Constructors

            #region Methods
            public int CompareTo(MyCustomer obj)
            {
                if (obj == null)
                {
                    return 1;
                }
                else
                {
                    return string.Compare(name, obj.name, true);
                }
            }
            #endregion Methods
        }
        #endregion MyCustomer

        static void Main(string[] args)
        {

        }

    }
}
