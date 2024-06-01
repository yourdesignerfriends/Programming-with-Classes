/*
Customer
The customer contains a name and an address.
The name is a string, but the Address is a class.
The customer should have a method that can return whether they live in the USA or not. 
(Hint this should call a method on the address to find this.)
*/
public class Customer
{
    //Attributes
    private string _nameOfCustomer;
    private Address _address;

    // Get the Name of Customer and Set the Name of Customer
    public string GetName()
    {
        return _nameOfCustomer;
    }
    public void SetName()
    {
        Console.Write("May I have the customer's name?: ");
        _nameOfCustomer = Console.ReadLine();
        Console.WriteLine("");
    }

    // Get address and set the address
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(string customerStreet, string customerCity, string customerState, string customerCountry)
    {
        _address = new(customerStreet: customerStreet, customerCity: customerCity, customerState: customerState, customerCountry: customerCountry);
    }

    // The customer should have a method that can return whether they live in the USA or not.
    // (Hint this should call a method on the address to find this.)
    public bool IsInUSA()
    {
        return _address.IsInUSA(_address.GetCountry());
    }

}