using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MyStack<T> : IEnumerable<T>, IDisposable
    {
        private int _top = 0;
        private int _size = 0;
        private T[] _stack = null;

        public MyStack(int size)
        {
            _size = size;
            _top = 0;
            _stack = new T[size];
        }

        public T this[int index]
        {
            get { return _stack[index]; }
        }

        public int Size
        {
            get { return _size; }
        }

        public int Length
        {
            get { return _top; }
        }

        public bool IsEmpty()
        {
            return _top == 0;
        }

        public bool IsFull()
        {
            return _top == _size;
        }

        public void clear()
        {
            _top = 0;
        }

        public void Push(T Node)
        {
            if (!IsFull())
            {
                _stack[_top] = Node;
                _top++;
            }
        }

        public T Pop()
        {
            T node = default(T);
            if (!IsEmpty())
            {
                node = _stack[_top];
                _top--;
            }
            return node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _stack.Length; i++)
            {
                if (_stack[i] != null)
                {
                    yield return _stack[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            _stack = null;
        }

    }
}
