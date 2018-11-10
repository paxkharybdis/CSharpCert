namespace Fundamentals
{
    public class IndexerSample
    {
        
        private int[] _rooms = new int[5] { 100, 125, 130, 135, 140 };

        public int Length
        {
            get
            {
                return _rooms.Length;
            }
        }

        public int this[int index]
        {
            get { return _rooms[index]; }
            set { _rooms[index] = value; }
        }
    }
}