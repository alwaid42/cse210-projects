public class Sale
{
    private List<ItemQuantity> _saleList = new List<ItemQuantity>();
    private float _totalPrice;
    private DateTime _saleDate;
    private int _userId;

    public void StartSale(int userID)
    {
        _totalPrice = 0;
        _saleDate = DateTime.Now;
        _userId = userID;
    }
    public void AddItem(Stock myStock)
    {
        myStock.ListItems();
        Console.WriteLine("Which item in the stock you want to add?");
        int include = int.Parse(Console.ReadLine());
        Console.WriteLine("How many you want to buy?");
        float quantity = float.Parse(Console.ReadLine());
        float sellPrice = myStock.FindSellPrice(include-1);
        ItemQuantity myItemQuantity = new ItemQuantity();
        myItemQuantity.SetQuantity(include-1, quantity, sellPrice);
        _saleList.Add(myItemQuantity);
        CalculateTotal();
    }
    public void RemoveItem()
    {
        int count = 1;
        foreach (ItemQuantity iq in _saleList)
        {
            Console.Write($"{count}. ");
            iq.DisplayItemQuantity();
        }
        Console.WriteLine("Which item number in the list you want to remove?");
        int remove = int.Parse(Console.ReadLine());
        _saleList.RemoveAt(remove-1);
        Console.WriteLine("Item Removed from the shopping list.");
        CalculateTotal();
    }
    public void CalculateTotal()
    {
        foreach (ItemQuantity iq in _saleList)
        {
            _totalPrice += iq.ReturnSubTotal();
        }
    }

    public void PrintTotal()
    {
        Console.WriteLine($"Total Price: {_totalPrice}");
    }

    
    public void DisplaySale()
    {
        Console.WriteLine($"Sale Date {_saleDate} | Seller ID {_userId}");
        foreach (ItemQuantity iq in _saleList)
        {
            iq.DisplayItemQuantity();
        }
        Console.WriteLine($"Total Price: {_totalPrice}");
    }

    public void FinishSale(Stock myStock)
    {
        foreach (ItemQuantity iq in _saleList)
        {
            myStock.SubtractSoldItem(iq.GetQuantityId(), iq.GetQuantity());
        }
    }
}