using System;

namespace BinarySearchTree
{
    public class MyCustomer : IComparable<MyCustomer>
    {
        public string name;
        public string phone;

        #region Constructors
        public MyCustomer()
        {
            name = "";
            phone = "";
        }
        public MyCustomer(string name, string phone) : this()
        {
            this.name = name;
            this.phone = phone;
        }
        #endregion Constructors

        #region Methods
        public int CompareTo(MyCustomer obj)
        {
            if (obj.name == null)
            {
                return 1;
            }
            else
            {
                return string.Compare(name, obj.name, true);
            }
        }

        public static MyCustomer[] BuildMCA(string[,] customers)
        {
            MyCustomer[] MCA = new MyCustomer[customers.Length / 2];
            for (int index = 0; index < customers.Length / 2; index++)
            {
                MCA[index] = new MyCustomer(customers[index, 0], customers[index, 1]);
            }
            return MCA;
        }
        #endregion Methods
    }
}
