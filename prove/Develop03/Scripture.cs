using System.Diagnostics.Contracts;
using System.Globalization;

class Scripture
{
    //attributes
    private Reference _ref;
    private List<Word> _words;
    private List<int> _visibleIndexes;
    //behaviors
    public Scripture(Reference reference, string verses)
    {
        _ref = reference;
        _words = new List<Word>();
        _visibleIndexes = new List<int>();
        string[] words = verses.Split(" ");
        int i = 0;
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
            _visibleIndexes.Add(i);
            i += 1;
        }
    }
    public void Hide()
    {
        int num = 0;
        Random number = new Random();
        while (num < 3 && _visibleIndexes.Count > 0)
        {
            int randomNumber = number.Next(_visibleIndexes.Count);
            _words[_visibleIndexes[randomNumber]].SetIsHidden(true);
            _visibleIndexes.RemoveAt(randomNumber);
            num += 1;
        }
        if (_visibleIndexes.Count == 0)
        {
            Display();
            Console.WriteLine("\n\nThanks for memorizing! We hope to see you again soon!");
            Environment.Exit(0);
        }
    }
    public void Display()
    {
        _ref.Display();
        foreach (Word w in _words)
        {
            w.Display();
        }
    }
}