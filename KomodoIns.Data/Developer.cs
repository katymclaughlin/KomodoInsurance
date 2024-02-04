namespace KomodoIns.Data;

public class Developer
{
    public Developer() {}
    
    public Developer (string name, int id, bool hasPluralsight) 
    {
        Name = name;
        Id = id;
        HasPluralsight = hasPluralsight;
    }

    public Developer(string name, int id)
    {
        Name = name;
        Id = id;
    }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool HasPluralsight { get; set; }
    
}
