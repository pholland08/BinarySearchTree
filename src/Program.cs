using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Output file
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\philliph\\workspace\\C#\\BinarySearchTree\\BinarySearchTree\\BSTOutput.txt");


            // C-Option starting data
            string[,] input = { { "Ajose", "295-1492" },
                                { "Munoz", "291-1865" },
                                { "Kong", "295-1601" },
                                { "Saleem", "293-6122" },
                                { "Seddon", "295-1882" },
                                { "Najar", "291-7890" },
                                { "Voorhees", "294-8075" },
                                { "Sparks", "584-3622" } };
            // C-Option second data set
            string[,] input2 = { { "Devin", "294-1568" },
                                 { "Morah", "294-1882" },
                                 { "Zembo", "295-6622" } };

            //******************************************************************
            // Build customer arrays for batch insertions
            MyCustomer[] customers = MyCustomer.BuildMCA(input);
            MyCustomer[] customers2 = MyCustomer.BuildMCA(input2);

            //******************************************************************
            // Insert customers into tree
            BinarySearchTree<MyCustomer> bst = BinarySearchTree<MyCustomer>.BuildBST(customers);
            #region search

            //******************************************************************
            // Demonstrate iterative and recursive searches
            
            // Saleem
            file.WriteLine("\nSearching for Saleem...");
            string saleem = bst.IterativeSearch(customers[3]).Info.name;
            file.WriteLine("\tFound {0} using iterative", saleem);
            saleem = bst.RecursiveSearch(customers[3]).Info.name;
            file.WriteLine("\tFound {0} using recursive", saleem);

            // Acevedo
            file.WriteLine("\nSearching for Acevedo...");
            string acevedo = (bst.IterativeSearch(new MyCustomer("Acevedo", "")).Info == null) ? "nothing" : "error";
            file.WriteLine("\tFound {0} using iterative", acevedo);
            acevedo = (bst.RecursiveSearch(new MyCustomer("Acevedo", "")).Info == null) ? "nothing" : "error";
            file.WriteLine("\tFound {0} using recursive", acevedo);
            #endregion search

            //******************************************************************
            // Deomnstrate first traversal
            file.WriteLine("\nBeginning first traversal...");
            file.WriteLine("\tStarting at {0}", customers[5].name);
            BinarySearchNode<MyCustomer> current = bst.InorderSuccessor(customers[5]);
            do
            {
                if (current == bst.Root)
                {
                    current = current.LeftChild;
                }
                file.WriteLine("\tTraversed to {0}", current.Info.name);
                current = bst.InorderSuccessor(current.Info);
            } while (current.Info != customers[5]);
            file.WriteLine("\tTraversed to {0}", current.Info.name);

            //******************************************************************
            // Insert second data set
            bst.Insert(customers2[0]);
            bst.Insert(customers2[1]);
            bst.Insert(customers2[2]);

            //******************************************************************
            // Demonstrate second traversal
            file.WriteLine("\nBeginning second traversal...");
            file.WriteLine("\tStarting at bst.Root");
            current = bst.Root;
            do
            {
                if (current == bst.Root)
                {
                    current = current.LeftChild;
                }
                file.WriteLine("\tTraversed to {0}\t{1}", current.Info.name, current.Info.phone);
                current = bst.InorderSuccessor(current.Info);
            } while (current != bst.Root);

            file.Close();
        }
    }
}
