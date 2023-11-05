using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class SyncLog
    {
        public int Id { get; set; }
        public int SyncLogStatus { get; set; }
        public string? LogDescription { get; set; }
        public int NumberOfRequestsCreated { get; set; }
        public int NumberOfRequestsUpdated { get; set; }
        public int NumberOfUsersCreated { get; set; }
        public int NumberOfUsersUpdated { get; set; }
        public int NumberOfAddressesCreated { get; set; }
        public int NumberOfAddressesUpdated { get; set; }
        public int NumberOfPaymentTransactionsCreated { get; set; }
        public int NumberOfPaymentTransactionsUpdated { get; set; }
        public int NumberOfRequestPriceDifferenceCreated { get; set; }
        public int NumberOfRequestPriceDifferenceUpdated { get; set; }
        public int NumberOfShippingOrdersCreated { get; set; }
        public int NumberOfShippingOrdersUpdated { get; set; }
        public int NumberOfUserAddressesCreated { get; set; }
        public int NumberOfUserAddressesUpdated { get; set; }
        public int NumberOfUserProfilesCreated { get; set; }
        public int NumberOfUserProfilesUpdated { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public int Identifier { get; set; }
        public int NumberOfPreviousDays { get; set; }
    }
}
