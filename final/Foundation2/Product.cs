/*
Product
Contains the name, product id, price, and quantity of each product.
The total cost of this product is computed:
by multiplying the price per unit and the quantity. 
(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
*/
public class Product
{
    //Attributes
    private string _productName;
    private string _productID;
    private float _price;
    private int _quantity;

    // Get product name and set product name
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName()
    {
        Console.Write("Product name: ");
        // Product name is entered by the user
        _productName = Console.ReadLine();
    }

    // Get product Id and set product name
    public string GetProductID()
    {
        SetProductID();
        return _productID;
    }
    public void SetProductID()
    // Generating a number for the product ID.
    {
        string idNumber = "";
        Random random = new();
        for (int i = 0; i < 3; i++)
        {
            idNumber += random.Next(9);
        }
        _productID = $"#{idNumber}";
    }

    // Get product price and set product price
    public float GetPrice()
    {
        return _price;
    }
    public void SetPrice()
    {
        Console.Write("Price of Product: $");
        _price = float.Parse(Console.ReadLine());
    }

    // Get product Quantity and set product Quantity
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity()
    {
        Console.Write("Quantity of the Product: ");
        _quantity = int.Parse(Console.ReadLine());
    }

    // The total cost of this product is computed: by multiplying the price per unit and the quantity. 
    public float TotalPrice()
    {
        return _price * _quantity;
    }
}