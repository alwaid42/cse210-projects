public class Volume : Item
{
    private float _volume;
    private float _minimumQuantity;

    public Volume(int id, string name, string description, float volume, float minimumQuantity, float pricePaid, float sellPrice) : base (id, name, description, pricePaid, sellPrice)
    {
        _volume = volume;
        _minimumQuantity = minimumQuantity;
        _pricePaid = pricePaid;
        _sellPrice = sellPrice;
    }

    public override void ReturnItem()
    {
        Console.WriteLine($"ID: {_id}| Item: {_name} | Descr: {_description} | Quant: {_volume} | Minimun: {_minimumQuantity} | Paid: {_pricePaid} US$| Sell: {_sellPrice} US$");
    }

    public override void SetItem()
    {
        
    }
    public override void GetItem()
    {
        
    }
    public override void SoldItem(float quantity)
    {
        _volume -= quantity;
    }
    
    public override bool LowQuantity()
    {
        if (_minimumQuantity > _volume)
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
        Console.WriteLine("What is the new Value for 'Volume': ");
        float newValue = float.Parse(Console.ReadLine());
        _volume = newValue;
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
        return $"Volume|{_id}|{_name}|{_description}|{_volume}|{_minimumQuantity}|{_pricePaid}|{_sellPrice}";
    }

    public override bool AcceptsFloat()
    {
        return true;
    }
}