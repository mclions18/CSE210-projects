using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;
    private bool _usResident;
    public Customer(string n, Address a)
    {
        _name = n;
        _address = a;
        if (_address.InUSA() == true)
        {
            _usResident = true;
        }
        else
        {
            _usResident = false;
        }
    }
    public bool IsUSA()
    {
        return _usResident;
    }
    public void CustomerShippingLabel()
    {
        Console.WriteLine($"{_name}\n{_address.FullAddress()}");
    }
}