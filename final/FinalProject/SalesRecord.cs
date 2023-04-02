public class SalesRecord
{
    private List<Sale> _salesRecord = new List<Sale>();

    public void AddSale(Sale sale)
    {
        _salesRecord.Add(sale);
    }
    public void LoadSales()
    {

    }
    public void SaveSales()
    {

    }
    public void SaleReport()
    {
        foreach (Sale sl in _salesRecord)
        {
            sl.DisplaySale();
            Console.WriteLine("");
        }
    }
}