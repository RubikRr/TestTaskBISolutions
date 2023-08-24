namespace TestTaskBISolutions
{
    public class LinkedListNode:IComparable<LinkedListNode>
    {
        public int Data { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(int data) { Data = data; }

        public int CompareTo(LinkedListNode? other)
        {
            if (Data == other.Data) 
                return 0;
            else if (Data > other.Data) 
                return 1;
            else
                return -1;
        }
    }
}
