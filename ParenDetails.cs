using System;
namespace calculator2
{
    public class ParenDetails
    {
        public string Type { get; private set; }
        public int Index { get; private set; }

        public ParenDetails(string type, int index)
        {
            Type = type;
            Index = index;
        }
    }
}
