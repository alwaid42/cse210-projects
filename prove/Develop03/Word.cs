using System;

public class Word
{
    private string _singleWord;
    private bool _isHidden;

    public void SetWord(string word)
    {
        _singleWord = word;
        _isHidden = false;
    }

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

    public void Hide()
    {
        _isHidden = true;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }
}