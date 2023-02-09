using System;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _text = new List<Word>();

    public void SetScripture(string book, string chapter, string verse, List<string> text)
    {
        _reference.SetReference(book, chapter, verse);
        foreach(string words in text)
        {
            Word newWord = new Word();
            newWord.SetWord(words);
            _text.Add(newWord);
        }
    }

    public void GetScripture()
    {
        string text = string.Empty;
        foreach (Word s in _text)
        {
            text += " " + s.GetWord();
        }
        Console.WriteLine($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetVerse()}{text}");
    }

    public void HideWords()
    {
        foreach (Word w in _text)
        {
            w.Hide();
        }
    }

    public bool CompletelyHidden()
    {
        int counter = 0;
        int hiddenWords = 0;
        foreach (Word w in _text)
        {
            counter++;
            if(w.GetHidden())
            {
                hiddenWords++;
            }
        }
        if(counter == hiddenWords)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}