public class Unit : Item
{
    private float _unit;
    private float _minimumQuantity;
    private float _pricePaid;
    private float _sellPrice;

    public Unit(string id, string name, string description, float unit, float minimumQuantity, float pricePaid, float sellPrice) : base (id, name, description)
    {
        _unit = unit;
        _minimumQuantity = minimumQuantity;
        _pricePaid = pricePaid;
        _sellPrice = sellPrice;
    }

    public override void ReturnItem()
    {
        Console.WriteLine($"ID: {_id} | Item: {_name} | Descr: {_description} | Quant: {_unit} | Minimun: {_minimumQuantity} | Paid: {_pricePaid} US$| Sell: {_sellPrice} US$");
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
    public override void LowQuantity()
    {
        
    }

    public override void UpdateQuantity()
    {
        Console.WriteLine("What is the new Value for 'Unit': ");
        float newValue = float.Parse(Console.ReadLine());
        _unit = newValue;
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
        return $"Unit|{_id}|{_name}|{_description}|{_unit}|{_minimumQuantity}|{_pricePaid}|{_sellPrice}";
    }

}