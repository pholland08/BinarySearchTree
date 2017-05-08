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
            _Count = 0;
            Root = null;
        }
        public BinarySearchTree(T info) : this()
        {
            Insert(info);
        }
        #endregion Constructors

        #region Methods
        // TODO Write method Insert
        public void Insert(T obj)
        {
            Insert(obj, ref _Root);
        }
        public void Insert(T obj, ref BinarySearchNode<T> Root)
        {
            _Count += 1;
            BinarySearchNode<T> newnode = new BinarySearchNode<T>(obj);
            // Check if root node is empty
            if (Root == null)
            {
                newnode.LeftChild = newnode.RightChild = newnode;
                //newnode.RightFlag = true; // newnode.LeftFlag set to false at instantiation 
                Root = newnode;
            }
            else
            {
                BinarySearchNode<T> current = Root;
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
        // TODO Write method FindIterative
        // TODO Write method FindRecursive
        // TODO Write method InOrderSuccessor
        // TODO Write method GetNodeInfo
        // Generic replacement for CustomerName and CustomerPhone
        public T GetNodeInfo(BinarySearchNode<T> node)
        {
            return node.Info;
        }
        #endregion Methods

    }

    // TODO Write class TreeStack for iterative methods
}
