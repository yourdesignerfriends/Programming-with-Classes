/*
For this activity, they want to track:
- The date
- The length of the activity in minutes
Also track the following:
- Swimming: number of laps
*/
public class Swimming : Activity
{
    private double _numberOfLaps;

    private void SetSwimmingLaps()
    {
        Console.Write(" * Enter swimming laps:\n - ");
        _numberOfLaps = double.Parse(Console.ReadLine());
    }

    private double GetSwimmingLaps()
    {
        return _numberOfLaps;
    }

    //In addition, the base class should contain virtual methods for getting the distance, speed, pace. 
    //These methods should be overridden in the derived classes.
    public override double CalculationDistance()
    {
        // Distance (km) = swimming laps * 50 / 1000
        double computeDistance = (GetSwimmingLaps() * 50) / 1000;
        return computeDistance;
    }
    //These methods should be overridden in the derived classes.
    public override double CalculationSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        double computeLaps = (CalculationDistance() / GetActivityTime()) * 60;
        return Math.Round(computeLaps,1);
    }
    //These methods should be overridden in the derived classes.
    public override double CalculationPace()
    {
        // Pace (min per km) = minutes / distance
        double computePace = GetActivityTime() / CalculationDistance();
        return Math.Round(computePace, 2);
    }
    public override string ActivityName()
    {
        return "Swimming";
    }

    public void StartSwimming()
    {
        StartActivity();
        SetSwimmingLaps();
    }
}