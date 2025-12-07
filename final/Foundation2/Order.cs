public class Order
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();
    private double _totalCost;
    private double _shippingUSA = 5;
    private double _shippingElse = 35;
    public Order(Customer c, params Product[] product)
    {
        _customer = c;
        foreach (Product p in product)
        {
            _productList.Add(p);
        }
    }
    public void TotalCost()
    {
        Console.WriteLine();
        foreach (Product p in _productList)
        {
            _totalCost += p.ProductCost();
        }
        if (_customer.IsUSA())
        {
            _totalCost += _shippingUSA;
        }
        else
        {
            _totalCost += _shippingElse;
        }
        Console.WriteLine($"Total Price:\n{_totalCost.ToString("F2")}");
    }
    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine("Item:".PadRight(20) + "ID:".PadRight(14) + "OTY");
        foreach (Product p in _productList)
        {
            p.ProductPackingLabel();
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        _customer.CustomerShippingLabel();
    }
}