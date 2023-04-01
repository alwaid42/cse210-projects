using System;
using System.IO;

public class Identification
{
    private int _id;

    public Identification()
    {
        _id = 0;
    }

    public int NewID()
    {
        _id++;
        SaveId();
        return _id;
    }

    public void ReadId()
    {
        string filename = "id.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _id = int.Parse(line);
        }
    }

    public void SaveId()
    {
        string file = "id.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_id);
        }
    }
}