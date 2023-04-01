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
            Console.WriteLine($"ID: {count+1}. {u.GetUserName()}");
            count++;
        }
    }

    public void CreateUser()
    {
        Console.WriteLine("What is the name of the new user?");
        string newName = Console.ReadLine();
        User newUser = new User(newName);
        _base.Add(newUser);
        Console.WriteLine("New user Created.");
        SaveUsers();
    }

    public void DeleteUser()
    {   
        Console.WriteLine("What is the ID of the user you want to delete? ");
        int deleteId = int.Parse(Console.ReadLine());
        Console.WriteLine($"Are you sure you want to delete {_base[deleteId-1].GetUserName()}? yes or no");
        string decision = Console.ReadLine();
        if (decision == "yes")
        {
            _base.RemoveAt(deleteId-1);
            Console.WriteLine("User deleted");
            SaveUsers();
        }
        else if (decision == "no")
        {
            Console.WriteLine("Operation cancelled by the user.");
        }
        else
        {
            Console.WriteLine("Invalid option. Operation Cancelled.");
        }
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