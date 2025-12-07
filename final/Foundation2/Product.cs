public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private double _quantity;
    public Product(string n, string id, double ppu, double q)
    {
        _name = n;
        _productID = id;
        _pricePerUnit = ppu;
        _quantity = q;
    }
    public double ProductCost()
    {
        return _pricePerUnit * _quantity;
    }
    public void ProductPackingLabel()
    {
         Console.WriteLine(_name.PadRight(20) + _productID.PadRight(14) + _quantity);
    }
}