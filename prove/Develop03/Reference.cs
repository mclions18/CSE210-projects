class Reference
{
    //attributes
    private string _book;
    private int _chapter;
    private string _verse1;

    //behaviors
    public Reference(string b, int c, string v)
    {
        _book = b;
        _chapter = c;
        _verse1 = v;
    }
    public void Display()
    {
        Console.Write(_book + " " + _chapter + ":" + _verse1 + " -");
    }
}