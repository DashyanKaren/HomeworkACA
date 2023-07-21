namespace MyStringBuilderWithLinkedList
{
    public class LinkedListString
    {
        public Item Head { get; private set; }

        public Item Tail { get; private set; }

        public int Count { get; private set; }

        public LinkedListString(string data)
        {
            var item = new Item(data);
            SetHeadAndTail(item);
        }

        public LinkedListString()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public override string ToString()
        {
            var result = string.Empty;
            if (Head != null)
            {
                var tempHead= Head;
                while (tempHead != null)
                {
                    result += tempHead;
                    tempHead = tempHead.Next;
                }
            }
            return result;
        }

        private void SetHeadAndTail(Item item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(string data)
        {
            var item = new Item(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else { SetHeadAndTail(item); }
        }
    }
}
