using System;

namespace MyStringBuilderWithLinkedList
{
    public class Item
    {
        private string data = string.Empty;

        public string Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else 
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public Item Next { get; set; }

        public Item(string data)
        {
            Data = data;
        }

        public override string ToString() => Data.ToString();
    }
}
