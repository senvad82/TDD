using System;
using GiftAid.BAL;
using GiftAid.DAL;
namespace GiftAidCalculator.TestConsole
{
	public static class Program
	{
		static void Main(string[] args)
		{
            ITaxCalculator taxCalc;
            taxCalc = new TaxCalculator(new TaxRepository(), new SupplementRepository());
            // Calc Gift Aid Based on Previous
            Console.WriteLine("Please Enter donation amount:");
			Console.WriteLine(taxCalc.GiftAidAmount(decimal.Parse(Console.ReadLine()),string.Empty));
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}

		public static decimal GiftAidAmount(decimal donationAmount,decimal currentTaxRate, string eventtype)
		{
            var currenRate = currentTaxRate;
            if (eventtype == "running")
            {
                currenRate = currenRate + 5;
            }
            else if(eventtype == "swimming")
            {
                currenRate = currenRate + 3;
            }
			var gaRatio = currenRate / (100 - currenRate);
			return decimal.Round(donationAmount * gaRatio,2,MidpointRounding.AwayFromZero);
		}
	}
}
