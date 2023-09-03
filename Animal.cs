class Animal
{
    private string Name { get; set; }
    private string Type { get; set; }
    private byte Age { get; set; }


    // Methods
    public Animal()
    {
        Name = string.Empty;
        Type = string.Empty;
        Age = 0;
    }

    public Animal(string name, string type, byte age)
    {
        this.Name = name;
        this.Type = type;
        this.Age = age;
    }
}