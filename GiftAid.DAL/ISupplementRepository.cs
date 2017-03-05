using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftAid.DAL
{
    public interface ISupplementRepository
    {
        void AddRate(string name, decimal rate);

        decimal GetRate(string eventType);

        //void AddRate(string name, decimal rate);

    }
}