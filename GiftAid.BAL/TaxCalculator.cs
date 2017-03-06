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
        IRepositoryFactory repoFactory;
        public TaxCalculator(IRepositoryFactory repo)
        {
           repoFactory = repo;
            taxRepo = repo.GetTaxRepository();
            suppRepo = repo.GetSupplementRepository();
        }
        public decimal GiftAidAmount(decimal donationAmount, string eventType)
        {
            var taxrate = taxRepo.GetRate() + suppRepo.GetRate(eventType);
                      
            return decimal.Round(donationAmount * (taxrate/(100-taxrate)),2,MidpointRounding.AwayFromZero);
        }
    }
}