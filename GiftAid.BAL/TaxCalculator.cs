using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiftAid.DAL;

namespace GiftAid.BAL
{
    public class TaxCalculator : ITaxCalculator
    {
        ITaxRepository taxRepo;
        ISupplementRepository suppRepo;
        public TaxCalculator(ITaxRepository repo, ISupplementRepository supp)
        {
            taxRepo = repo;
            suppRepo = supp;
        }
        public decimal GiftAidAmount(decimal donationAmount, string eventType)
        {
            var taxrate = taxRepo.GetRate() + suppRepo.GetRate(eventType);
                      
            return decimal.Round(donationAmount * (taxrate/(100-taxrate)),2,MidpointRounding.AwayFromZero);
        }
    }
}