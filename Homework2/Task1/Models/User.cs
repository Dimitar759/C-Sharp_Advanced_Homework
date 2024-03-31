namespace Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public User(string id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }





    }
}
