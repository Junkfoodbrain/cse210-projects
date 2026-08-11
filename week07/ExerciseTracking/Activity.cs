

public abstract class Activity
{
    private DateTime _date;
    private double _minutes;

    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    public double GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string name = GetType().Name.Replace("Activity", "");

        return $"{_date:dd MMM yyyy} {name} ({_minutes} min): Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}