namespace IntermediateScripting
{
    public class Player
    {
        private int _experience;
        
        public int Experience
        {
            get { return _experience; } 
            set { _experience = value; }
        }

        public int Level
        {
            get { return _experience / 1000; }
            set { _experience = value * 1000; }
        }

        public int Health { get; set; }
    }
}
