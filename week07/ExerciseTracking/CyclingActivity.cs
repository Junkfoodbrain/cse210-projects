using System;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
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