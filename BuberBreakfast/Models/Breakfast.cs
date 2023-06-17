namespace BuberBreakfast.Models
{
    public class Breakfast
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime LastModifiedDateTime { get; private set; }
        public List<string> Savory { get; private set; }
        public List<string> Sweet { get; private set; }

        public Breakfast(
            Guid id,
            string name,
            string description,
            DateTime startDateTime,
            DateTime lastModifiedDateTime,
            List<string> savory,
            List<string> sweet
        )
        {
            Id = id;
            Name = name;
            Description = description;
            StartDateTime = startDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            Savory = savory;
            Sweet = sweet;
        }

        public Breakfast() { }
    }
}
