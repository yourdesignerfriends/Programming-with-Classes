// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
// Outdoor meetings: there is no limit on the number of attendees, but it is necessary that they pay attention to the weather forecast.
public class Outdoor : Event
{
    //Attributes
    private string _weatherForcast;

    // Set event name
    public Outdoor()
    {
        SetEventType("3");
    }

    // Get Weather Forecast
    public string GetWeatherForecast()
    {
        return _weatherForcast;
    }
    // Set Weather Forecast
    private void SetWeatherForecast()
    {
        Console.WriteLine("");
        Console.Write(" * Enter the Weather Forecast\n - ");
        _weatherForcast = Console.ReadLine(); 
    }
    public void BookOutdoorEvent()
    {
        SetWeatherForecast();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($" - Weather Forecast: {GetWeatherForecast()}\n");
        StandardDetails();
    }
}