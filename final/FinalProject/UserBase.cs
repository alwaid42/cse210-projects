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

    }

    public void DeleteUser()
    {
        
    }
}