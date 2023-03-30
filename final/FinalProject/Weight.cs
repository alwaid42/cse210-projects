public class Weight : Item
{
    private float _weight;
    private float _minimumQuantity;
    private float _pricePaid;
    private float _sellPrice;

    public Weight(string id, string name, string description, float weight, float minimumQuantity, float pricePaid, float sellPrice) : base (id, name, description)
    {
        _weight = weight;
        _minimumQuantity = minimumQuantity;
        _pricePaid = pricePaid;
        _sellPrice = sellPrice;
    }

    public override void ReturnItem()
    {
        Console.WriteLine($"ID: {_id} | Item: {_name} | Descr: {_description} | Quant: {_weight} | Minimun: {_minimumQuantity} | Paid: {_pricePaid} US$| Sell: {_sellPrice} US$");
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
        Console.WriteLine("What is the new Value for 'Weight': ");
        float newValue = float.Parse(Console.ReadLine());
        _weight = newValue;
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
        return $"Unit|{_id}|{_name}|{_description}|{_weight}|{_minimumQuantity}|{_pricePaid}|{_sellPrice}";
    }
}