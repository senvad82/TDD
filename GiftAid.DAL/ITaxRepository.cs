using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftAid.DAL
{
    public interface ITaxRepository
    {
        decimal GetRate();
    }
}