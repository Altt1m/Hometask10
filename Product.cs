class Product
{
    private string Name { get; set; }
    private decimal Price { get; set; }
    private int Quantity { get; set; }

    public Product()
    {
        Name = "";
        Price = 0;
        Quantity = 0;
    }

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}