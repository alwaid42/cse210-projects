using System;
using System.IO;

public class UserIdentification
{
    private int _id;

    public UserIdentification()
    {
        _id = 0;
    }

    public int NewUserID()
    {
        _id++;
        SaveUserId();
        return _id;
    }

    public void ReadUserId()
    {
        string filename = "userid.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _id = int.Parse(line);
        }
    }

    public void SaveUserId()
    {
        string file = "userid.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_id);
        }
    }
}