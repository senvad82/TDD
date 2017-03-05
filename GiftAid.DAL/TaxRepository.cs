using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftAid.DAL
{
    public class TaxRepository: ITaxRepository
    {
        decimal taxRate = 20m;
        public decimal GetRate()
        {
            return taxRate;
        }
        public void SetRate(decimal rate)
        {
            taxRate = rate;
        }
    }
}