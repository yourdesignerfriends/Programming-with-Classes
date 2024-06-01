/*
Address
The address contains a string for the street address, the city, state/province, and country.
The address should have a method that can return whether it is in the USA or not.
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

    // Get street
    public string GetStreetAddress()
    {
        return _street;
    }

    // Get city
    public string GetCity()
    {
        return _city;
    }

    // Get state
    public string GetState()
    {
        return _state;
    }

    // Get country
    public string GetCountry()
    {
        return _country;
    }

    // The address should have a method that can return whether it is in the USA or not.
    public bool IsInUSA(string customerCountry)
    {
        if (customerCountry.ToLower() == "usa") return true;
        else return false;
    }
    public Address(string customerStreet, string customerCity, string customerState, string customerCountry)
    {
        _street = customerStreet;
        _city = customerCity;
        _state = customerState;
        _country = customerCountry;
    }

    // We will use this method to create the shipping label (in the order class)
    public string DisplayFullAddress()
    {
        string fullAddress = $"- Street: {GetStreetAddress()}\n- City: {GetCity()}\n- State: {GetState()}\n- Country: {GetCountry()}";;
        return fullAddress;
    }
}