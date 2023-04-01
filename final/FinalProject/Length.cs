public class Length : Item
{
    private float _length;
    private float _minimumQuantity;

    public Length(int id, string name, string description, float length, float minimumQuantity, float pricePaid, float sellPrice) : base (id, name, description, pricePaid, sellPrice)
    {
        _length = length;
        _minimumQuantity = minimumQuantity;
        _pricePaid = pricePaid;
        _sellPrice = sellPrice;
    }

    public override void ReturnItem()
    {
        Console.WriteLine($"ID: | Item: {_name} | Descr: {_description} | Quant: {_length} | Minimun: {_minimumQuantity} | Paid :{_pricePaid} US$| Sell: {_sellPrice} US$");
    }

    public override void SetItem()
    {
        
    }
    public override void GetItem()
    {
        
    }
    public override void SoldItem()
    {
        
    }
    public override void BoughtItem()
    {
        
    }
    public override bool LowQuantity()
    {
        if (_minimumQuantity > _length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public override void UpdateQuantity()
    {
        Console.WriteLine("What is the new Value for 'Length': ");
        float newValue = float.Parse(Console.ReadLine());
        _length = newValue;
    }
    public override void UpdateMinimum()
    {
        Console.WriteLine("What is the new Value for 'Minimum Quantity': ");
        float newValue = float.Parse(Console.ReadLine());
        _minimumQuantity = newValue;
    }
    public override void UpdatePaid()
    {
        Console.WriteLine("What is the new Value for 'Price Paid': ");
        float newValue = float.Parse(Console.ReadLine());
        _pricePaid = newValue;
    }
    public override void SellName()
    {
        Console.WriteLine("What is the new Value for 'Sell Price': ");
        float newValue = float.Parse(Console.ReadLine());
        _sellPrice = newValue;
    }

    public override string WriteFile()
    {
        return $"Length||{_name}|{_description}|{_length}|{_minimumQuantity}|{_pricePaid}|{_sellPrice}";
    }
}