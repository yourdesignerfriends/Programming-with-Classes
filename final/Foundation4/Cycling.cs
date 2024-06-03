/*
For this activity, they want to track:
- The date
- The length of the activity in minutes
Also track the following:
- Cycling: speed
*/
public class Cycling : Activity
{
    private double _clyclingSpeed;

    private void SetCyclingSpeed()
    {
        Console.Write(" * Enter cycling speed in kph:\n - ");
        _clyclingSpeed = double.Parse(Console.ReadLine());
    }

    private double GetCyclingSpeed()
    {
        return _clyclingSpeed;
    }

    //In addition, the base class should contain virtual methods for getting the distance, speed, pace. 
    //These methods should be overridden in the derived classes.
    public override double CalculationDistance()
    {
        double computeDistance = (GetCyclingSpeed() * GetActivityTime()) / 60;
        return Math.Round(computeDistance, 1);
    }

    public override double CalculationSpeed()
    {
        return _clyclingSpeed;
    }

    public override double CalculationPace()
    {
        double computePace = 60 / GetCyclingSpeed();
        return computePace;
    }
    public override string ActivityName()
    {
        return "Cycling";
    }

    public void StartCycling()
    {
        StartActivity();
        SetCyclingSpeed();
    }
}