public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string s, string c, string l, string C)
    {
        _streetAddress = s;
        _city = c;
        _stateOrProvince = l;
        _country = C;
    }
    public string FullAddress()
    {
        return _streetAddress + Environment.NewLine + _city + ", " + _stateOrProvince + Environment.NewLine + _country;
    }
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}