using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchStack<T>
    {
        #region Fields
        StackNode<T> _Root;
        StackNode<T> _Top;
        public StackNode<T> Top
        {
            get
            {
                return _Top;
            }
        }
        #endregion Fields

        #region Constructors
        #endregion Constructors

        #region Methods
        public bool push(T info)
        {
            StackNode<T> newnode = new StackNode<T>(info);
            if (_Root == null)
            {
                _Root = new StackNode<T>();
                _Top = newnode;
                _Top.prev = _Root;
                _Root.next = _Top;
                return true;
            }
            else
            {
                newnode.prev = _Top;
                _Top.next = newnode;
                _Top = _Top.next;
                return true;
            }
        }
        public T pop()
        {
            if (Top != _Root)
            {
                T info = Top.info;
                _Top = _Top.prev;
                return info;
            }
            else
            {
                return default(T);
            }
            #endregion Methods
        }
    }
    public class StackNode<T>
    {
        #region Fields
        public StackNode<T> prev { get; set; }
        public StackNode<T> next { get; set; }
        public T info { get; set; }
        #endregion Fields

        #region Constructors
        internal StackNode()
        {
            info = default(T);
            prev = null;
            next = null;
        }
        public StackNode(T info) : this()
        {
            this.info = info;
        }

        #endregion Constructors

        #region Methods
        #endregion Methods
    }
}
