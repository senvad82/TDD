using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftAid.BAL
{
    public interface ITaxCalculator
    {
        decimal GiftAidAmount(decimal donationAmount, string eventType);
    }
}