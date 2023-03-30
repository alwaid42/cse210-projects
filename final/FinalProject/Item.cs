public abstract class Item
{
    protected string _name;
    protected string _description;

    public Item(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetItemName()
    {
        return _name;
    }


    public abstract void ReturnItem();
    public abstract void SetItem();

    public abstract void GetItem();
    public abstract void SoldItem();
    public abstract void BoughtItem();
    public abstract bool LowQuantity();

    public void UpdateName()
    {
        Console.WriteLine("What is the new Value for 'Name': ");
        string newValue = Console.ReadLine();
        _name = newValue;
    }
    public void UpdateDescription()
    {
        Console.WriteLine("What is the new Value for 'Description': ");
        string newValue = Console.ReadLine();
        _description = newValue;
    }
    public abstract void UpdateQuantity();
    public abstract void UpdateMinimum();
    public abstract void UpdatePaid();
    public abstract void SellName();

    public abstract string WriteFile();
}