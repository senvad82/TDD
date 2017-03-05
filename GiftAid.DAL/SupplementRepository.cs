using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftAid.DAL
{
    internal class Supplement
    {
        public string name;
        public decimal rate;
    }
    public class SupplementRepository: ISupplementRepository
    {
        
        List<Supplement> supplements = new List<Supplement>();
        public SupplementRepository()
        {
            supplements.Add(new Supplement() { name = "running", rate = 5m });
            supplements.Add(new Supplement() { name = "swimming", rate = 3m });
        }
        public decimal GetRate(string eventType)
        {
            var supp = supplements.Where(s => s.name == eventType).FirstOrDefault();
            return supp != null ? supp.rate : 0;
        }
        public void AddRate(string name,decimal rate)
        {
            supplements.Add(new Supplement() { name = name, rate = rate });
        }
    }
}