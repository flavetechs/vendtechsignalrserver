﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace signalrserver.Models.Context
{
    public partial class TransactionDetail
    {
        [Key]
        public long TransactionDetailsId { get; set; }
        public long UserId { get; set; }
        public string TransactionId { get; set; }
        public Nullable<long> MeterId { get; set; }
        public decimal Amount { get; set; }
        public string MeterNumber1 { get; set; }
        public Nullable<long> POSId { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public Nullable<int> PlatFormId { get; set; }
        public string MeterToken1 { get; set; }
        public string MeterToken2 { get; set; }
        public string MeterToken3 { get; set; }
        public System.DateTime RequestDate { get; set; }
        public decimal CurrentDealerBalance { get; set; }
        public string AccountNumber { get; set; }
        public string Customer { get; set; }
        public string RTSUniqueID { get; set; }
        public string ReceiptNumber { get; set; }
        public string ServiceCharge { get; set; }
        public string Tariff { get; set; }
        public string TaxCharge { get; set; }
        public decimal TenderedAmount { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Units { get; set; }
        public string SerialNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string DebitRecovery { get; set; }
        public string CostOfUnits { get; set; }
        public string VProvider { get; set; }
        public Nullable<bool> Finalised { get; set; }
        public Nullable<int> StatusRequestCount { get; set; }
        public Nullable<bool> Sold { get; set; }
        public string VoucherSerialNumber { get; set; }
        public string VendStatusDescription { get; set; }
        public string VendStatus { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string StatusResponse { get; set; }
        public string DateAndTimeSold { get; set; }
        public string DateAndTimeFinalised { get; set; }
        public string DateAndTimeLinked { get; set; }
        public Nullable<decimal> CurrentVendorBalance { get; set; }
        public Nullable<decimal> BalanceBefore { get; set; }
        public Nullable<int> QueryStatusCount { get; set; }

    }
}
