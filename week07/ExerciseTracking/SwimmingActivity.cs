using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
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