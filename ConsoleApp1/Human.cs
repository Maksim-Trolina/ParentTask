namespace ConsoleApp1
{
    internal class Human
    {
        public string Name { get; set; }
        IEnumerable<Human> children;
        public IEnumerable<Human> Children
        {
            get => children;
            set
            {
                if (value is not null && value.Count() > 2)
                    throw new ArgumentOutOfRangeException("Maximum two children");
                children = value;
            }
        }
    }
}
