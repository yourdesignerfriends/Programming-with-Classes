/*
Address
The address contains a string for the street address, the city, state and country.
The address should have a method to return a string all of its fields together 
in one string (with newline characters where appropriate)
*/
public class Address
{
    //Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Get Street
    public string GetStreet()
    {
        return _street;
    }
    // Set Street
    private void SetStreet()
    {
        Console.WriteLine("");
        Console.Write(" * Enter street address:\n - ");
        _street = Console.ReadLine();
    }

    // Get City
    public string GetCity()
    {
        return _city;
    }
    // Set City
    private void SetCity()
    {
        Console.WriteLine("");
        Console.Write(" * Enter city name:\n - ");
        _city = Console.ReadLine();
    }

    // Get State
    public string GetState()
    {
        return _state;
    }
    // Set State
    private void SetState()
    {
        Console.WriteLine("");
        Console.Write(" * Enter state:\n - ");
        _state = Console.ReadLine();
    }

    // Get Country
    public string GetCountry()
    {
        return _country;
    }
    // Set Country
    private void SetCountry()
    {
        Console.WriteLine("");
        Console.Write(" * Enter country name:\n - ");
        _country = Console.ReadLine();
    }   

    public void SetAddress()
    {
        SetStreet();
        SetCity();
        SetState();
        SetCountry();
    }

    public string DisplayfullAddress()
    {
        string fullAddress = $" - Street: {GetStreet()}\n - City: {GetCity()}\n - State: {GetState()}\n - Country: {GetCountry()}";
        return fullAddress;
    }

}