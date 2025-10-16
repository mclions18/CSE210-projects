class Bin
{
    // attributes
    private string _denomination;
    private double _value;
    private int _count;

    //behaviors
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    // modifier method "Alter" set method

    public void Alter(int delta)
    {
        _count += delta;
    }

    public string GetDenomination()
    {
        return _denomination;
    }

    public int GetValue()
    {
        return _count;
    }

    public int GetCount()
    {
        return _count;
    }
}