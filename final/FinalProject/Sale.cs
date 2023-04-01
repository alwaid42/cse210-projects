public class Sale
{
    private List<ItemQuantity> _saleList;
    private float _totalPrice;
    private DateTime _saleDate;
    private int _userId;

    public void StartSale(int userID)
    {
        _totalPrice = 0;
        _saleDate = DateTime.Now;
        _userId = userID;
    }
    public void AddItem()
    {
        CalculateTotal();
    }
    public void RemoveItem()
    {
        CalculateTotal();
    }
    public void CalculateTotal()
    {
        foreach (ItemQuantity iq in _saleList)
        {
            _totalPrice += iq.ReturnSubTotal();
        }
    }
    public void FinishSale()
    {
        
    }
    public void CancelSale()
    {

    }
}