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
        #endregion Fields

        #region Constructors
        public BinarySearchTree()
        {
            Root = null;
        }
        public BinarySearchTree(T info) : this()
        {
            BinarySearchNode<T> node = new BinarySearchNode<T>(info);
            Root = node;
            Root.RightFlag = true;
            Root.RightChild = Root;
            Root.LeftChild = Root;
        }
        #endregion Constructors

        #region Methods
        // TODO Write method Insert
        public bool Insert(T obj)
        {
            BinarySearchNode<T> newnode = new BinarySearchNode<T>(obj);
            // Check if root node is empty
            if (Root == null)
            {
                Root = newnode;
                Root.RightFlag = true;
                Root.RightChild = Root;
                Root.LeftChild = Root;
                return true;
            }
            // TODO Add method body
            return false;
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
