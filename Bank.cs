class Bank
{
    private string Name { get; set; }
    private string Location { get; set; }

    public Bank()
    {
        Name = string.Empty;
        Location = string.Empty;
    }

    public Bank(string name, string location)
    {
        Name = name;
        Location = location;
    }
}
