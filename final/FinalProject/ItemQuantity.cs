public class ItemQuantity
{
    private string _itemId;
    private double _quantity;

    public void SetQuantity(string id, double quantity)
    {
        _itemId = id;
        _quantity = quantity;
    }

    public double GetQuantity()
    {
        return _quantity;
    }

    public string GetQuantityId()
    {
        return _itemId;
    }
}