class Car
{   
    private string Company { get; set; }
    private string Model { get; set; }
    private int Velocity { get; set; }


    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }

    public void Accelerate(int speed)
    {
        Console.WriteLine("Now your speed is {0}", speed);
    }
}
