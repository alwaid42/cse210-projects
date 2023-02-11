using System;

public class Word
{
    //stores each word and if its hidden or not.
    private string _singleWord;
    private bool _isHidden;

    //Set the word value. By default all words are not hidden when set.
    public void SetWord(string word)
    {
        _singleWord = word;
        _isHidden = false;
    }

    //Function that returns the word if not hidden and a string of underscores if the word is hidden.
    public string GetWord()
    {
        if(_isHidden == false)
        {
            return _singleWord;
        }
        else
        {   
            int stringLenghth = _singleWord.Length;
            string hiddenWord = new String('_', stringLenghth);
            return hiddenWord;
        }
    }

    //Function that changes the value of isHidden to true. (Or hides the word)
    public void Hide()
    {
        _isHidden = true;
    }

    //Function that turns a word into not hidden
    /*
    public voide Show()
    {
        _isHidden = false;
    }
    */

    // Function that checks if the word is hidden.
    public bool GetHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}