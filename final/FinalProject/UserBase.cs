using System;
using System.IO;

public class UserBase
{
    private List<User> _base = new List<User> ();

    public void ListUsers()
    {
        int count = 0;
        foreach(User u in _base)
        {
            Console.Write($"{count+1}. ");
            u.GetUserName();
            count++;
        }
    }

    public void CreateUser()
    {
        SaveUsers();
    }

    public void DeleteUser()
    {
        SaveUsers();
    }

    public void ReadUsers()
    {
        string filename = "users.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            User newUser = new User(line);

            _base.Add(newUser);
        }
    }

    public void SaveUsers()
    {
        string file = "users.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (User u in _base)
            {
                outputFile.WriteLine(u.GetUserName());
            }
        }
    }
}