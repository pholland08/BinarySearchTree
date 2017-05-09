using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        #region Fields
        private BinarySearchNode<T> _Root;
        public BinarySearchNode<T> Root
        {
            get { return _Root; }
            set { _Root = value; }
        }
        private int _Count;
        public int Count
        {
            get { return _Count; }
        }
        #endregion Fields

        #region Constructors
        public BinarySearchTree()
        {
            Root = new BinarySearchNode<T>();
            Root.RightChild = Root.LeftChild = Root;
            Root.RightFlag = true;
        }
        public BinarySearchTree(T info) : this()
        {
            Insert(info);
        }
        #endregion Constructors

        #region Methods
        // Iterative Insert method
        public void Insert(T obj)
        {
            Insert(obj, ref _Root);
        }
        public void Insert(T obj, ref BinarySearchNode<T> Root)
        {
            BinarySearchNode<T> newnode = new BinarySearchNode<T>(obj);
            // Check if root node is empty
            if (Root.LeftChild == Root)
            {
                newnode.LeftChild = newnode.RightChild = Root;
                Root.LeftChild = newnode;
                Root.LeftFlag = true;
            }
            else
            {
                BinarySearchNode<T> current = Root.LeftChild;
                bool finished = false;
                while (!finished)
                {
                    if (current.Info.CompareTo(newnode.Info) < 1)
                    {
                        if (!current.RightFlag)
                        {
                            newnode.RightChild = current.RightChild;
                            newnode.RightFlag = current.RightFlag;
                            current.RightChild = newnode;
                            current.RightFlag = true;
                            newnode.LeftChild = current; // newnode.LeftFlag set to false at instantiation
                            finished = true;
                        }
                        else
                        {
                            current = current.RightChild;
                        }
                    }
                    else
                    {
                        if (!current.LeftFlag)
                        {
                            newnode.LeftChild = current.LeftChild;
                            newnode.LeftFlag = current.LeftFlag;
                            current.LeftChild = newnode;
                            current.LeftFlag = true;
                            newnode.RightChild = current; // newnode.RightFlag set to false at instantiation
                            finished = true;
                        }
                        else
                        {
                            current = current.LeftChild;
                        }
                    }
                }
            }
        }

        // Iterative search method
        public BinarySearchNode<T> IterativeSearch(T obj)
        {
            BinarySearchNode<T> current = Root.LeftChild;
            bool finished = false;
            while (!finished)
            {
                if (current != Root)
                {
                    if (current.Info.CompareTo(obj) == 0)
                    {
                        finished = true;
                    }
                    else if (current.Info.CompareTo(obj) == -1)
                    {
                        current = current.RightChild;
                    }
                    else
                    {
                        current = current.LeftChild;
                    }
                }
                else
                {
                    current = new BinarySearchNode<T>();
                    finished = true;
                }
            }
            return current;

        }

        // Recursive search method
        public BinarySearchNode<T> RecursiveSearch(T obj)
        {
            return RecursiveSearch(Root.LeftChild, obj);
        }
        public BinarySearchNode<T> RecursiveSearch(BinarySearchNode<T> current, T obj)
        {

            if (current == Root)
            {
                return current;
            }
            else if (current.Info.CompareTo(obj) == 0)
            {
                return current;
            }
            else if (current.Info.CompareTo(obj) == -1)
            {
                return RecursiveSearch(current.RightChild, obj);
            }
            else // If reached, current.Info must > obj
            {
                return RecursiveSearch(current.LeftChild, obj);
            }
        }

        // InOrderSuccessor method
        public BinarySearchNode<T> InorderSuccessor(T obj)
        {
            BinarySearchNode<T> P = RecursiveSearch(Root.LeftChild, obj);
            BinarySearchNode<T> Q = P.RightChild;
            if (!P.RightFlag)
            {
                return Q;
            }
            else
            {
                while (Q.LeftFlag)
                {
                    Q = Q.LeftChild;
                }
                return Q;
            }
        }

        // Generic replacement for CustomerName and CustomerPhone methods
        public T GetNodeInfo(BinarySearchNode<T> node)
        {
            return node.Info;
        }

        // BuildTree method
        public static BinarySearchTree<T> BuildBST(T[] arr)
        {
            BinarySearchTree<T> bst = new BinarySearchTree<T>();
            foreach (T obj in arr)
            {
                bst.Insert(obj);
            }
            return bst;
        }
                
        #endregion Methods

    }

    // TODO Write class TreeStack for iterative methods
}
