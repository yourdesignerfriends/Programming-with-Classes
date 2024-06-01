/*
Order
Contains a list of products and a customer. 
- Can calculate the total cost of the order. 
- Can return a string for the packing label. 
- Can return a string for the shipping label.
The total price is calculated as the sum of the total cost of each product 
plus a one-time shipping cost.
This company is based in the USA. 
- If the customer lives in the USA, then the shipping cost is $5. 
- If the customer does not live in the USA, then the shipping cost is $35.
A packing label should list the name and product id of each product in the order.
A shipping label should list the name and address of the customer
*/
public class Order
{
    //Attributes
    private int _shippingCost;
    private float _subTotal;
    private int _usaShippingCost = 5;
    private int _notUsaShippingCost = 35; 
    private List<Product> _products = new();
    private List<Customer> _customers = new();

    // Contains a list of customer
    public void AddCustomer(Customer customer)
    {
         _customers.Add(customer);
    }
    // Contains a list of products
    public void AddProduct(Product item)
    {
        _products.Add(item);
    }

    // Can return a string for the packing label.
    public void GetPackingLabel()
    {
        Console.WriteLine("------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("⏺️  Packing label:");
        Console.ForegroundColor = ConsoleColor.Black;
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: {product.GetProductName()}\n- Product ID: {product.GetProductID()}");
        }
    }

    // Get Shipping Cost
    public int GetShippingCost()
    {
        return _shippingCost;
    }
    
    // Can return a string for the shipping label.
    public void GetShippinglabel()
    {
        foreach (Customer customer in _customers)
        {
            Address theAddress = customer.GetAddress();
            string theName = customer.GetName();
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("⏺️  Shipping label:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"- Name: {theName.ToUpper()}");
            Console.WriteLine($"{theAddress.DisplayFullAddress()}");
            Console.WriteLine("------------------------------------");
            _shippingCost = customer.IsInUSA() ? _usaShippingCost : _notUsaShippingCost;
        }
    }

    //The total price is calculated as the sum of the total cost of each product 
    //plus a one-time shipping cost.
    public float CalculatedTotal()
    {
        foreach (Product product in _products)
        {
            _subTotal += product.TotalPrice();
        }

        return _subTotal + GetShippingCost();
    }

    public void DisplayShippingInfo()
    {
        GetPackingLabel();
        GetShippinglabel();
        Console.WriteLine($"\nThe total purchase price plus shipping is ${CalculatedTotal()}\n");
    }
}