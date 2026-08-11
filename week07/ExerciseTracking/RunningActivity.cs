using System;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {

    }

    public override double GetSpeed()
    {

    }
    
    public override double GetPace()
    {
        
    }
}