public class User
{
    //private string _uId;
    private string _userName;

    public User(string name)
    {
        _userName = name;
    }

    public string GetUserName()
    {
        return _userName;
    }
}