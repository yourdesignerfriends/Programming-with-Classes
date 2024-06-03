/*
For this activity, they want to track:
- The date
- The length of the activity in minutes
Also track the following:
- Running: distance
*/
public class Running : Activity
{
    private double _runningDistance;

    // Set Running Distance
    private void SetRunningDistance()
    {
        Console.Write(" * Enter the distance you ran in kilometers:\n - ");
        _runningDistance = double.Parse(Console.ReadLine());
    }
    // Get Running Distance
    private double GetRunningDistance()
    {
        return _runningDistance;
    }

    //In addition, the base class should contain virtual methods for getting the distance, speed, pace. 
    //These methods should be overridden in the derived classes.
    public override double CalculationDistance()
    {
        return _runningDistance;
    }

    // Speed (mph or kph) = (distance / minutes) * 60
    //Use method overriding for the calculation methods.
    public override double CalculationSpeed()
    {
        double computeSpeed = (GetRunningDistance() / GetActivityTime()) * 60;
        return Math.Round(computeSpeed, 1);
    }

    // Pace = 60 / speed
    //Use method overriding for the calculation methods.
    public override double CalculationPace()
    {
        double computePace = GetActivityTime() / GetRunningDistance();
        return Math.Round(computePace, 2);
    }
    public override string ActivityName()
    {
        return "Running";
    }

    public void StartRunning()
    {
        StartActivity();
        SetRunningDistance();
    }
}