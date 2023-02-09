using System;

public class Scripture
{   
    //stores a Reference and List of word (Scripture text)
    private Reference _reference = new Reference();
    private List<Word> _text = new List<Word>();

   //Scripture Setter 
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

    //Scripture Getter, as the words are store in a list this creates a string containing the scripture text by adding all the words.
    public void GetScripture()
    {
        string text = string.Empty;
        foreach (Word s in _text)
        {
            text += " " + s.GetWord();
        }
        Console.WriteLine($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetVerse()}{text}");
    }

    //function that checks which words are hidden, then randomly select half of the not hidden words and hides them
    public void HideWords()
    {
        foreach (Word w in _text)
        {
            w.Hide();
        }
    }

    //function that checks if all the words are hidden
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