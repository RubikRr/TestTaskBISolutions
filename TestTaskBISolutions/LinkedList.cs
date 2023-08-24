using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TestTaskBISolutions
{

    public class LinkedList : IEnumerable
    {
        private int count;
        private LinkedListNode head;
        private LinkedListNode tail;


        public void Add(int data)
        {
            var newNode = new LinkedListNode(data);

            if (head == null)
                head = newNode;
            else
                tail!.Next = newNode;
            tail = newNode;

            count++;
        }

        public void AddFirst(int data)
        {
            var newNode = new LinkedListNode(data);
            newNode.Next = head;
            head = newNode;

            if (count == 0)
                head = tail;
            count++;
        }

        public void Remove(int data)
        {
            LinkedListNode current = head;
            LinkedListNode previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;


                }
                previous = current;
                current = current.Next;
            }
        }

        public bool Contains(int data)
        {
            var current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public void Sort()
        {
            head =mergeSort(head);
        }
        LinkedListNode sortNodes(LinkedListNode nodeA, LinkedListNode nodeB)
        {
            LinkedListNode result = null;
            if (nodeA == null)
                return nodeB;
             if (nodeB == null)
                return nodeA;

            if (nodeA.Data <= nodeB.Data)
            {
                result = nodeA;
                result.Next = sortNodes(nodeA.Next, nodeB);
            }
            else
            {
                result = nodeB;
                result.Next = sortNodes(nodeA, nodeB.Next);
            }
            return result;
        }

       LinkedListNode mergeSort(LinkedListNode node)
          {
              if (node == null || node.Next == null)
                return node;

            LinkedListNode middle = getMiddleNode(node);
            LinkedListNode nextofmiddle = middle.Next;

             middle.Next = null;

             LinkedListNode left = mergeSort(node);

            LinkedListNode right = mergeSort(nextofmiddle);

            LinkedListNode sortedlist = sortNodes(left, right);

            return sortedlist;
        }

       
        LinkedListNode getMiddleNode(LinkedListNode startNode)
        {
            if (startNode == null)
                return startNode;
            LinkedListNode twoStepNode = startNode.Next;
            LinkedListNode oneStepNode = startNode;

            while (twoStepNode != null)
            {
                twoStepNode = twoStepNode.Next;
                if (twoStepNode != null)
                {
                    oneStepNode = oneStepNode.Next;
                    twoStepNode = twoStepNode.Next;
                }
            }
            return oneStepNode;
        }

        public string ToString()
        {
            var current = head;
            var ans = "";
            while (current != null)
            {
                ans += $"{current.Data} ";
                current=current.Next;
            }
            return ans;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
