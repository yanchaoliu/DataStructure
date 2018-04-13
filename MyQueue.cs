using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructure
{
    class MyQueue<T> : IDisposable
    {
        private T[] queue = null;

        private int length = 0;

        private int capacity;
        private int head = 0;
        private int tail = 0;
        public MyQueue(int capacity)
        {
            this.capacity = capacity;
            this.head = 0;
            this.tail = 0;
            this.length = 0;
            this.queue = new T[capacity];
        }

        public void Clear()
        {
            head = 0;
            tail = 0;
            length = 0;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }
        public bool IsFull()
        {
            return length == capacity;
        }

        public int Length()
        {
            return this.length;
        }

        public void EnQueue(T item)
        {
            if (!IsFull())
            {
                this.queue[tail] = item;
                length++;
                tail = (++tail) % capacity; ;
            }
        }

        public T Dequeue()
        {
            T node = default(T);
            if (!IsEmpty())
            {
                node = queue[head];
                head = (++head) % capacity;
            }
            return node;
        }
        public void Dispose()
        {
            queue = null;
        }
    }
}
