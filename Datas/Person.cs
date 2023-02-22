namespace ToDo
{
    public class Person
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Person(string _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

    }
}