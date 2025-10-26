using System.ComponentModel.DataAnnotations;

class Word
{
    //attributes
    private bool _isHidden;
    private string _value;

    //behaviors
    public Word(string word)
    {
        _value = word;
        _isHidden = false;
    }
    public void Display()
    {
        if (_isHidden == false)
        {
            Console.Write(" " + _value);
        }
        else
        {
            Console.Write(" " + new string('_', _value.Length));
        }
    }
    public void SetIsHidden(bool b)
    {
        _isHidden = b;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}