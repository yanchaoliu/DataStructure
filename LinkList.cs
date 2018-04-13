using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    // 链表节点
    public class Node<T>
    {

        public T Data { set; get; }

        public Node<T> Next { set; get; }

        public Node(T item)
        {
            this.Data = item;
            this.Next = null;
        }

        public Node()
        {
            this.Data = default(T);
            this.Next = null;
        }
    }

    //单链表
    class LinkList<T>
    {
        public Node<T> Head { set; get; }

        public LinkList()
        {
            Head = null;
        }

       /// <summary>
       /// add data to list
       /// </summary>
       /// <param name="item"></param>
        public void Append(T item)
        {
            Node<T> foot = new Node<T>(item);
            Node<T> A = new Node<T>();
            if (this.Head == null)
            {
                this.Head = foot;
                return;
            }
            A = Head;
            while (A.Next != null)
            {
                A = A.Next;
            }
            A.Next = foot;

        }
        /// <summary>
        /// get the length of list
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            int length = 0;
            Node<T> p = Head;
            while (p.Next != null)
            {
                p = p.Next;
                length++;
            }
            return length;
        }
        /// <summary>
        /// whether is emoty of the list
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (this.Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// insert data at the index of i
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i"></param>
        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 1 || i > this.GetLength())
            {
                Console.WriteLine("单链表为空或结点位置有误！");
                return;
            }
            if (i == 1)
            {
                Node<T> n = new Node<T>();
                n.Next = Head;
                Head = n;
                return;
            }

            Node<T> A = new Node<T>();
            Node<T> B = new Node<T>();
            B = Head;
            int index = 0;
            while (B.Next != null && index < i)
            {
                A = B;
                B = B.Next;
                index++;
            }
            if (index == i)
            {
                Node<T> c = new Node<T>(item);
                A.Next = c;
                c.Next = B;
            }
        }
        /// <summary>
        /// delete item which from i
        /// </summary>
        /// <param name="i"></param>
        public void Delete(int i)
        {
            if (IsEmpty() || i < 1 || i > this.GetLength())
            {
                Console.WriteLine("单链表为空或结点位置有误！");
                return;
            }
            Node<T> A = new Node<T>();
            if (i == 1)
            {
                A = Head;
                this.Head = Head.Next;
                return;
            }


            Node<T> p = new Node<T>();
            p = Head;
            int index = 1;
            while (p.Next != null && index < i)
            {
                A = p;
                p = p.Next;
                index++;
            }
            if (index == i)
            {
                A.Next = p.Next;
            }

        }
        /// <summary>
        /// get specific value at the index of i
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetValue(int i)
        {
            if (IsEmpty() || i < 1 || i > this.GetLength())
            {
                Console.WriteLine("单链表为空或结点位置有误！");
                return default(T);
            }
            Node<T> P = new Node<T>();
            P = Head;
            int index = 1;
            while (P.Next != null && index < i)
            {
                P = P.Next;
                index++;
            }
            return P.Data;
        }
        /// <summary>
        /// empty the link
        /// </summary>
        public void Clear() { Head = null; }

        /// <summary>
        /// reverse the link
        /// </summary>
        public void Reverse()
        {
            if (GetLength() == 1 || Head == null)
            {
                return;
            }
            Node<T> newNode = null;
            Node<T> tempNode = new Node<T>();
            Node<T> currentNode = Head;
            while (currentNode.Next != null)
            {
                tempNode = currentNode.Next;
                newNode = currentNode;
                currentNode.Next = newNode;
                currentNode = tempNode;
            }
            Head = newNode;

        }

        /// <summary>
        /// get the item from the tail 
        /// </summary>
        /// <param name="Head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public Node<T> FindEleFormTail(Node<T> Head, int k)
        {
            if (k < 1 || Head == null)
            {
                return null;
            }
            Node<T> p1 = Head;
            Node<T> p2 = Head;
            for (int i = 0; i < k; i++)
            {
                if (p1.Next != null)
                {
                    p1 = p1.Next;
                }
                else
                {
                    return null;
                }
                while (p1 != null)
                {
                    p1 = p1.Next;
                    p2 = p2.Next;
                }

            }
            return p2;
        }
    }
}
