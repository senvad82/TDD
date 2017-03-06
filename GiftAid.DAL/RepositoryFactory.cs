using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftAid.DAL
{
    public class RepositoryFactory: IRepositoryFactory
    {
        public ITaxRepository GetTaxRepository()
        {
            return new TaxRepository();
        }
        public ISupplementRepository GetSupplementRepository()
        {
            return new SupplementRepository();
        }
    }
}