public class ItemQuantity
{
    private int _itemId;
    private float _quantity;
    private float _sellPrice;
    private float _subTotal;

    public void SetQuantity(int id, float quantity, float sellPrice)
    {
        _itemId = id;
        _quantity = quantity;
        _sellPrice = sellPrice;
        _subTotal = quantity * sellPrice;
    }

    public float ReturnSubTotal()
    {
        return _subTotal;
    }

    public float GetQuantity()
    {
        return _quantity;
    }

    public int GetQuantityId()
    {
        return _itemId;
    }

    public void DisplayItemQuantity()
    {
        Console.WriteLine($"Item id: {_itemId} | Quantity: {_quantity} | Price: {_sellPrice}| Subtotal: {_subTotal}");
    }

    
}