using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement.Models
{
    public class StockAccount
    {
        public class StockAccountManagement
        {
            public string FilePath = @"R:\StockManagement\StockAccountManagement\StockAccountManagement\StockAccountManagement\StockShare.json";

            public void calculateValueOfEachStocks()
            {
                var jsonData = File.ReadAllText(FilePath);

                var StockShare = JsonConvert.DeserializeObject<StockModel>(jsonData);

                int totalValueOfStocks = 0;
                foreach (var Stocks in StockShare.Stocks)
                {
                    Console.WriteLine("Share Name : " + Stocks.shareName + "\t\t" + "Share Price : " + Stocks.sharePrice + "\t \t" + "Number of share : " + Stocks.numberOfShare);
                    int valueOfEachShare = Stocks.numberOfShare * Stocks.sharePrice;
                    Console.WriteLine(" Total value of Share : " + valueOfEachShare);
                    totalValueOfStocks += valueOfEachShare;
                    Console.WriteLine("");
                }
                Console.WriteLine(" \n Total Amount of All Stocks : " + totalValueOfStocks);
            }
        }
    }
}
