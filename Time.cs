class Time
{
    private DateTime CurrentTime { get; set; }

    public Time()
    {
        CurrentTime = DateTime.Now;
    }

    public void AddSeconds(int seconds)
    {
        CurrentTime = CurrentTime.AddSeconds(seconds);
    }

    public void AddSeconds(TimeSpan timeSpan)
    {
        CurrentTime = CurrentTime.Add(timeSpan);
    }
}