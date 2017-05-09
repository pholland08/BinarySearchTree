using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchNode<T> where T : IComparable<T>
    {
        #region Fields
        // Links
        private BinarySearchNode<T> _LeftChild;
        public BinarySearchNode<T> LeftChild
        {
            get { return _LeftChild; }
            set { _LeftChild = value; }
        }

        private BinarySearchNode<T> _RightChild;
        public BinarySearchNode<T> RightChild
        {
            get { return _RightChild; }
            set { _RightChild = value; }
        }

        // Threading flags
        private bool _LeftFlag;
        public bool LeftFlag
        {
            get { return _LeftFlag; }
            set { _LeftFlag = value; }
        }

        private bool _RightFlag;
        public bool RightFlag
        {
            get { return _RightFlag; }
            set { _RightFlag = value; }
        }

        private T _Info;
        public T Info
        {
            get { return _Info; }
            set { _Info = value; }
        }
        #endregion Fields

        #region Constructors
        internal BinarySearchNode()
        {
            LeftFlag = false;
            RightFlag = false;
            LeftChild = null;
            RightChild = null;
        }
        public BinarySearchNode(T Info) : this()
        {
            this.Info = Info;
        }
        public BinarySearchNode(T Info, BinarySearchNode<T> LeftChild, BinarySearchNode<T> RightChild) : this(Info)
        {
            this.LeftChild = LeftChild;
            this.RightChild = RightChild;
        }
        #endregion Constructors

        #region Methods

        #endregion Methods
    }
}
