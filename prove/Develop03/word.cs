using System;

class Word
{
    private string _word;
    private Boolean _revealed;

    
    public Word(string word)
    {
        _word = word;
        _revealed = true;
    }

    public void Display()
    {
        if (_revealed == false)
        {
            _word = new string('_', _word.Length);
        }
        Console.Write(_word + " ");
    }
    
    public Boolean Hide()
    {
        _revealed = false;
        return _revealed;
    }

}