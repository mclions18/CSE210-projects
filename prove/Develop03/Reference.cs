class Reference
{
    //attributes
    private string _book;
    private int _chapter;
    private string _versestart;
    private string _verseend;
    private bool _versemulti = false;

    //behaviors
    public Reference(string b, int c, string v)
    {
        _book = b;
        _chapter = c;
        _versestart = v;
    }
    public Reference(string b, int c, string s, string e, bool x)
    {
        _book = b;
        _chapter = c;
        _versestart = s;
        _verseend = e;
        _versemulti = x;
    }
    public void Display()
    {
        if (_versemulti == true)
        {
            Console.Write(_book + " " + _chapter + ":" + _versestart + "-" + _verseend + " -");
        }
        else
        {
          Console.Write(_book + " " + _chapter + ":" + _versestart + " -");  
        }
    }
}