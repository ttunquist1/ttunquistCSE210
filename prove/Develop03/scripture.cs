using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.Display());
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public void Hide(int numWordsToHide)
    {
        for (int i = 0; i < numWordsToHide; i++)
        {
            int randomIndex = _random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }
}