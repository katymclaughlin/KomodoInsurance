namespace KomodoIns.Data;

public class Developer
{
    public Developer() {}
    
    public Developer (string name, Guid id, bool hasPluralsight) 
    {
        Name = name;
        Id = id;
        HasPluralsight = hasPluralsight;
    }

    public Developer(string name, Guid id)
    {
        Name = name;
        Id = id;
    }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public bool HasPluralsight { get; set; }
    
}
