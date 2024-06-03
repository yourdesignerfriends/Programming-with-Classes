using System.Globalization;
/*
The Activity class should contain any attributes that are shared among all activities.

For each activity, they want to track the the date and the length of the activity in minutes.
calculation:
The distance
The speed (miles per hour or kilometers per hour)
The pace (minutes per mile or minutes per kilometer)

A summary in the form of:
03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km

The length of a lap in the lap pool is 50 meters.

The base class should contain virtual methods for:
getting the distance, speed, pace. 
These methods should be overridden in the derived classes.

GetSummary method to produce a string with all the summary information.

Math Hints:
- Distance (km) = swimming laps * 50 / 1000
- Pace (min per mile or min per km)= minutes / distance

Running: distance

- Speed (mph or kph) = (distance / minutes) * 60
- Speed = 60 / pace
- Pace = 60 / speed
*/
public class Activity
{
    private DateTime _date;
    private int _activityTime;

    // Get Date
    public string GetDate()
    {
        // Date Format: Day, month and year (03 Nov 2022)
        return _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
    }
    // Set Date
    private void SetDate()
    {
        Console.WriteLine("");
        Console.Write(" * Enter a date in dd MMM yyyy format (example 22 01 2024):\n - ");
        _date = DateTime.Parse(Console.ReadLine());
    }

    // Set Activity Time
    private void SetActivityTime()
    {
        Console.Write(" * Enter the time it took you to do this activity in minutes:\n - ");
        _activityTime = int.Parse(Console.ReadLine());
    }
    // Get Activity Time
    protected int GetActivityTime()
    {
        return _activityTime;
    }

    //In addition, the base class should contain virtual methods for getting the distance, speed, pace. 
    //These methods should be overridden in the derived classes.
    public virtual double CalculationDistance()
    {
        return 0;
    }

    public virtual double CalculationSpeed()
    {
        return 0;
    }

    public virtual double CalculationPace()
    {
        return 0;
    }
    public virtual string ActivityName()
    {
        return "";
    }

    public virtual void GetSummary()
    {
        // A summary in the form of:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        string summary = $"⭐️ {GetDate()} {ActivityName()} ({GetActivityTime()} min): Distance {CalculationDistance()} km, Speed: {CalculationSpeed()} kph, Pace: {CalculationPace()} min per km";
        Console.WriteLine(summary);
    }

    public void StartActivity()
    {
        SetDate();
        SetActivityTime();
    }
}