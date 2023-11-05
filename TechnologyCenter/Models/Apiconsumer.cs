using System;
using System.Collections.Generic;

namespace TechnologyCenter.Web.Models
{
    public partial class Apiconsumer
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Salt { get; set; } = null!;
        public string ApplicationSecretKey { get; set; } = null!;
        public byte[]? PublicKey { get; set; }
        public byte[]? PrivateKey { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? Enabled { get; set; }
    }
}
