﻿using System;

namespace BLL.Entities
{
    public class AgreementPosition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SettlementModelId { get; set; }
        public string KTM { get; set; }
        public string Descriptor { get; set; }
        public int CurrencyId { get; set; }
        public DateTime? BillingPeriodStart { get; set; }
        public DateTime? BillingPeriodEnd { get; set; }
        public bool IsIndifinitePeriod { get; set; }
        public bool IsChargedFromFirstSale { get; set; }
        public int BillingPeriod { get; set; }
        public int FreeCopies { get; set; }
        public DateTime? AgreementExpirationDate { get; set; }
        public DateTime? WFMagDeliveryDate { get; set; }
        public DateTime? WFMagFirstSaleDate { get; set; }
        public decimal WFMagNetto { get; set; }
        public decimal WFMagBrutto { get; set; }
        public decimal WFMagPZ { get; set; }
        public decimal ModelMinimumPrice { get; set; }
        public decimal ModelPercent { get; set; }
        public decimal ModelWholesalePrice { get; set; }
        public decimal ModelSinglePrice { get; set; }
        public decimal ModelFixedPriceForCopy { get; set; }
    }
}
