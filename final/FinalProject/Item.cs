public abstract class Item
{
    protected int _id;
    protected string _name;
    protected string _description;
    protected float _pricePaid;
    protected float _sellPrice;


    public Item(int id, string name, string description, float pricePaid, float sellPrice)
    {
        _id = id;
        _name = name;
        _description = description;
        _pricePaid = pricePaid;
        _sellPrice = sellPrice;
    }

    public string GetItemName()
    {
        return _name;
    }

    public float GetSellPrice()
    {
        return _sellPrice;
    }


    public abstract void ReturnItem();
    public abstract void SetItem();

    public abstract void GetItem();
    public abstract void SoldItem(float quantity);
    public abstract bool LowQuantity();

    public abstract void UpdateQuantity();
    public abstract void UpdateMinimum();
    public abstract void UpdatePaid();
    public abstract void SellName();

    public abstract string WriteFile();

    public abstract bool AcceptsFloat();



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
    
}