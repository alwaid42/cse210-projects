public class ItemQuantity
{
    private string _itemId;
    private float _quantity;

    public void SetQuantity(string id, float quantity)
    {
        _itemId = id;
        _quantity = quantity;
    }

    public float GetQuantity()
    {
        return _quantity;
    }

    public string GetQuantityId()
    {
        return _itemId;
    }
}