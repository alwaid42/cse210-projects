using System;
using System.IO;

public class SalesRecord
{
    private List<Sale> _salesRecord = new List<Sale>();

    public void AddSale(Sale sale)
    {
        _salesRecord.Add(sale);
    }
    public void LoadSales()
    {
        string filename = "SalesRecord.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            char[] delimiterChars = {'|'};
            string[] parts = line.Split(delimiterChars);

            int id = int.Parse(parts[0]);
            float totalPrice = float.Parse(parts[1]);
            DateTime saleDate = DateTime.Parse(parts[2]);

            Sale newSale = new Sale();
            newSale.SaleRed(id, saleDate, totalPrice);

            _salesRecord.Add(newSale);
        }
    }

    public void SaveSales()
    {
        string file = "SalesRecord.txt";
        using (StreamWriter outputFile = File.AppendText(file))
        {
            foreach (Sale sl in _salesRecord)
            {
                if (sl.WasSaved())
                {

                }
                else
                {
                    outputFile.WriteLine(sl.WriteSale());
                    sl.SavedSale();
                }
                
            }
        }
    }
    public void SaleReport()
    {
        foreach (Sale sl in _salesRecord)
        {
            sl.DisplaySale();
            Console.WriteLine("");
        }
        Console.WriteLine("Press enter to go to the menu.");
        Console.ReadLine();
    }
}