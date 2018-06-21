using System.Collections.Generic;

namespace BLL.Entities
{
    public class BillingPeriod
    {
        public int PeriodId { get; set; }
        public string Name { get; set; }

        public static List<BillingPeriod> GetBillingPeriods()
        {
            List<BillingPeriod> lstPeriods = new List<BillingPeriod>();

            lstPeriods.Add(new BillingPeriod() { PeriodId = 1, Name = "Miesięczny" });
            lstPeriods.Add(new BillingPeriod() { PeriodId = 3, Name = "Kwartalny" });
            lstPeriods.Add(new BillingPeriod() { PeriodId = 6, Name = "Półroczny" });
            lstPeriods.Add(new BillingPeriod() { PeriodId = 12, Name = "Roczny" });

            return lstPeriods;
        }
    }
}
