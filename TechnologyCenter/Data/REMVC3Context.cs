
namespace TechnologyCenter.Web.Data
{
    public partial class REMVC3Context : DbContext
    {
        public REMVC3Context()
        {
        }

        public REMVC3Context(DbContextOptions<REMVC3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Apiconsumer> Apiconsumers { get; set; } = null!;
        public virtual DbSet<AreaType> AreaTypes { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> Users { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<CanceledRequestPriceDifferenceLog> CanceledRequestPriceDifferenceLogs { get; set; } = null!;
        public virtual DbSet<Complaint> Complaints { get; set; } = null!;
        public virtual DbSet<ComplaintReply> ComplaintReplies { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; } = null!;
        public virtual DbSet<Governorate> Governorates { get; set; } = null!;
        public virtual DbSet<InquiryRequest> InquiryRequests { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<PaymentTrasnsaction> PaymentTrasnsactions { get; set; } = null!;
        public virtual DbSet<PaymentTrasnsactionRequestPriceDifference> PaymentTrasnsactionRequestPriceDifferences { get; set; } = null!;
        public virtual DbSet<PaymentTrasnsactionShippingOrder> PaymentTrasnsactionShippingOrders { get; set; } = null!;
        public virtual DbSet<QuestionGroup> QuestionGroups { get; set; } = null!;
        public virtual DbSet<RefundRequest> RefundRequests { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestAreaDifferenceStatus> RequestAreaDifferenceStatuses { get; set; } = null!;
        public virtual DbSet<RequestPrice> RequestPrices { get; set; } = null!;
        public virtual DbSet<RequestPriceDifference> RequestPriceDifferences { get; set; } = null!;
        public virtual DbSet<RequestStatus> RequestStatuses { get; set; } = null!;
        public virtual DbSet<RequestStatusChange> RequestStatusChanges { get; set; } = null!;
        public virtual DbSet<RequestUnitTypeChangeLog> RequestUnitTypeChangeLogs { get; set; } = null!;
        public virtual DbSet<ShippingOrder> ShippingOrders { get; set; } = null!;
        public virtual DbSet<ShippingOrderStatus> ShippingOrderStatuses { get; set; } = null!;
        public virtual DbSet<ShippingPrice> ShippingPrices { get; set; } = null!;
        public virtual DbSet<SubUnitTypeEnumTable> SubUnitTypeEnumTables { get; set; } = null!;
        public virtual DbSet<SyncLog> SyncLogs { get; set; } = null!;
        public virtual DbSet<SystemIssue> SystemIssues { get; set; } = null!;
        public virtual DbSet<TransferRequestLog> TransferRequestLogs { get; set; } = null!;
        public virtual DbSet<UnitTypeEnumTable> UnitTypeEnumTables { get; set; } = null!;
        public virtual DbSet<UserAddress> UserAddresses { get; set; } = null!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Data Source=AHMEDSERVER\\SQLEXPRESS; Initial Catalog=REMVC3;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.DistrictId, "IX_Addresses_DistrictId");

                entity.HasIndex(e => e.RegionId, "IX_Addresses_RegionId");

                entity.HasIndex(e => e.RequestId, "IX_Addresses_RequestId")
                    .IsUnique();

                entity.Property(e => e.ApartmentNumber).HasMaxLength(200);

                entity.Property(e => e.EasternBorder)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EasternBorderLength)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FloorNumberText).HasMaxLength(200);

                entity.Property(e => e.MaritimeBorder)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MaritimeBorderLength)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StreetName).HasMaxLength(200);

                entity.Property(e => e.TribalBorder)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TribalBorderLength)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WesternBorder)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WesternBorderLength)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.DistrictId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Request)
                    .WithOne(p => p.Address)
                    .HasForeignKey<Address>(d => d.RequestId);
            });

            //modelBuilder.Entity<Apiconsumer>(entity =>
            //{
            //    entity.ToTable("APIConsumers");

            //    entity.Property(e => e.ApplicationSecretKey).HasMaxLength(256);

            //    entity.Property(e => e.Enabled)
            //        .IsRequired()
            //        .HasDefaultValueSql("(CONVERT([bit],(0)))");
            //});

            modelBuilder.Entity<AreaType>(entity =>
            {
                entity.HasKey(e => e.AreaTypeReference);

                entity.ToTable("AreaType");

                entity.Property(e => e.AreaTypeReference)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaType_Reference");

                entity.Property(e => e.AreaTypeArabicName)
                    .HasMaxLength(50)
                    .HasColumnName("AreaType_ArabicName");

                entity.Property(e => e.AreaTypeEnglishName)
                    .HasMaxLength(50)
                    .HasColumnName("AreaType_EnglishName");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.AddressId, "IX_AspNetUsers_AddressId");

                entity.HasIndex(e => e.MakerId, "IX_AspNetUsers_MakerId");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.ArabicFullName).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.UserType).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.Maker)
                    .WithMany(p => p.InverseMaker)
                    .HasForeignKey(d => d.MakerId);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.HasIndex(e => e.MakerId, "IX_Complaints_MakerId");

                entity.HasIndex(e => e.RequestId, "IX_Complaints_RequestId");

                entity.HasIndex(e => e.UserId, "IX_Complaints_UserId");

                entity.Property(e => e.UserId).HasDefaultValueSql("(N'0f0a1987-5b8e-4632-8b14-f4ca7c8b3316')");

                entity.HasOne(d => d.Maker)
                    .WithMany(p => p.ComplaintMakers)
                    .HasForeignKey(d => d.MakerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Complaints)
                    .HasForeignKey(d => d.RequestId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ComplaintUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ComplaintReply>(entity =>
            {
                entity.HasIndex(e => e.ComplaintId, "IX_ComplaintReplies_ComplaintId");

                entity.HasIndex(e => e.MakerId, "IX_ComplaintReplies_MakerId");

                entity.HasOne(d => d.Complaint)
                    .WithMany(p => p.ComplaintReplies)
                    .HasForeignKey(d => d.ComplaintId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Maker)
                    .WithMany(p => p.ComplaintReplies)
                    .HasForeignKey(d => d.MakerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasIndex(e => e.RegionId, "IX_Districts_RegionId");

                entity.Property(e => e.ArabicName).HasMaxLength(200);

                entity.Property(e => e.EnglishName).HasMaxLength(200);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<FrequentlyAskedQuestion>(entity =>
            {
                entity.HasIndex(e => e.GroupId, "IX_FrequentlyAskedQuestions_GroupId");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.FrequentlyAskedQuestions)
                    .HasForeignKey(d => d.GroupId);
            });

            modelBuilder.Entity<Governorate>(entity =>
            {
                entity.Property(e => e.ArabicName).HasMaxLength(200);

                entity.Property(e => e.EnglishName).HasMaxLength(200);
            });

            modelBuilder.Entity<InquiryRequest>(entity =>
            {
                entity.HasIndex(e => e.RequestId, "IX_InquiryRequests_RequestId")
                    .IsUnique();

                entity.HasOne(d => d.Request)
                    .WithOne(p => p.InquiryRequest)
                    .HasForeignKey<InquiryRequest>(d => d.RequestId);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasIndex(e => e.RegionId, "IX_Offices_RegionId");

                entity.Property(e => e.EnglishAddress).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Gpslocation)
                    .HasColumnName("GPSLocation")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RegionId).HasDefaultValueSql("((101))");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderStatus");

                entity.Property(e => e.OrderStatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentTrasnsaction>(entity =>
            {
                entity.HasIndex(e => e.InquiryRequestId, "IX_PaymentTrasnsactions_InquiryRequestId");

                entity.HasIndex(e => e.RequestId, "IX_PaymentTrasnsactions_RequestId");

                entity.HasIndex(e => e.UserId, "IX_PaymentTrasnsactions_UserId");

                entity.HasOne(d => d.InquiryRequest)
                    .WithMany(p => p.PaymentTrasnsactions)
                    .HasForeignKey(d => d.InquiryRequestId);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.PaymentTrasnsactions)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PaymentTrasnsactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PaymentTrasnsactionRequestPriceDifference>(entity =>
            {
                entity.HasKey(e => new { e.PaymentTrasnsactionsId, e.RequestPriceDifferencesId });

                entity.ToTable("PaymentTrasnsactionRequestPriceDifference");

                entity.HasIndex(e => e.RequestPriceDifferencesId, "IX_PaymentTrasnsactionRequestPriceDifference_RequestPriceDifferencesId");

                entity.HasOne(d => d.PaymentTrasnsactions)
                    .WithMany(p => p.PaymentTrasnsactionRequestPriceDifferences)
                    .HasForeignKey(d => d.PaymentTrasnsactionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RequestPriceDifferences)
                    .WithMany(p => p.PaymentTrasnsactionRequestPriceDifferences)
                    .HasForeignKey(d => d.RequestPriceDifferencesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PaymentTrasnsactionShippingOrder>(entity =>
            {
                entity.HasKey(e => new { e.PaymentTrasnsactionsId, e.ShippingOrdersId });

                entity.ToTable("PaymentTrasnsactionShippingOrder");

                entity.HasIndex(e => e.ShippingOrdersId, "IX_PaymentTrasnsactionShippingOrder_ShippingOrdersId");

                entity.HasOne(d => d.PaymentTrasnsactions)
                    .WithMany(p => p.PaymentTrasnsactionShippingOrders)
                    .HasForeignKey(d => d.PaymentTrasnsactionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShippingOrders)
                    .WithMany(p => p.PaymentTrasnsactionShippingOrders)
                    .HasForeignKey(d => d.ShippingOrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<QuestionGroup>(entity =>
            {
                entity.Property(e => e.ArabicName).HasDefaultValueSql("(N'')");

                entity.Property(e => e.EnglishName).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<RefundRequest>(entity =>
            {
                entity.HasIndex(e => e.MakerId, "IX_RefundRequests_MakerId");

                entity.HasIndex(e => e.PaymentTrasnsactionId, "IX_RefundRequests_PaymentTrasnsactionId");

                entity.HasIndex(e => e.RequestId, "IX_RefundRequests_RequestId");

                entity.HasIndex(e => e.UserId, "IX_RefundRequests_UserId");

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(14)
                    .HasColumnName("SSN");

                entity.Property(e => e.UserId).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Maker)
                    .WithMany(p => p.RefundRequestMakers)
                    .HasForeignKey(d => d.MakerId);

                entity.HasOne(d => d.PaymentTrasnsaction)
                    .WithMany(p => p.RefundRequests)
                    .HasForeignKey(d => d.PaymentTrasnsactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RefundRequests)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefundRequestUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasIndex(e => e.GovernorateId, "IX_Regions_GovernorateId");

                entity.Property(e => e.ArabicName).HasMaxLength(200);

                entity.Property(e => e.EnglishName).HasMaxLength(200);

                entity.Property(e => e.IsNotMilitary)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Governorate)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.GovernorateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Requests_UserId");

                entity.HasIndex(e => new { e.UserId, e.RequestNumber }, "Request_Number")
                    .IsUnique();

                entity.Property(e => e.BuildingArea).HasMaxLength(500);

                entity.Property(e => e.HasInquiryRequest)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.HasPriceDifference)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsArchived)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsPaid)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LandArea).HasMaxLength(500);

                entity.Property(e => e.RequestNumber).HasMaxLength(900);

                entity.Property(e => e.UserId).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RequestAreaDifferenceStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestAreaDifferenceStatus");

                entity.Property(e => e.RequestAreaDifferenceStatus1)
                    .HasMaxLength(50)
                    .HasColumnName("RequestAreaDifferenceStatus");
            });

            modelBuilder.Entity<RequestPriceDifference>(entity =>
            {
                entity.HasIndex(e => e.RequestId, "IX_RequestPriceDifferences_RequestId");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestPriceDifferences)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RequestStatus>(entity =>
            {
                entity.ToTable("RequestStatus");

                entity.Property(e => e.RequestStatusArabicName)
                    .HasMaxLength(100)
                    .HasColumnName("RequestStatus_ArabicName");

                entity.Property(e => e.RequestStatusEnglishName)
                    .HasMaxLength(100)
                    .HasColumnName("RequestStatus_EnglishName");

                entity.Property(e => e.RequestStatusReference).HasColumnName("RequestStatus_Reference");
            });

            modelBuilder.Entity<RequestStatusChange>(entity =>
            {
                entity.HasIndex(e => e.RequestId, "IX_RequestStatusChanges_RequestId");

                entity.Property(e => e.StatusChangeDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000+02:00')");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestStatusChanges)
                    .HasForeignKey(d => d.RequestId);
            });

            modelBuilder.Entity<ShippingOrder>(entity =>
            {
                entity.HasIndex(e => e.DistrictId, "IX_ShippingOrders_DistrictId");

                entity.HasIndex(e => e.OfficeId, "IX_ShippingOrders_OfficeId");

                entity.HasIndex(e => e.RegionId, "IX_ShippingOrders_RegionId");

                entity.HasIndex(e => e.RequestId, "IX_ShippingOrders_RequestId");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.RegionId).HasDefaultValueSql("((101))");

                entity.Property(e => e.StreetName).HasMaxLength(200);

                entity.Property(e => e.UniqueMark).HasMaxLength(200);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ShippingOrders)
                    .HasForeignKey(d => d.DistrictId);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.ShippingOrders)
                    .HasForeignKey(d => d.OfficeId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ShippingOrders)
                    .HasForeignKey(d => d.RegionId);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ShippingOrders)
                    .HasForeignKey(d => d.RequestId);
            });

            modelBuilder.Entity<ShippingOrderStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShippingOrderStatus");

                entity.Property(e => e.ShippingOrderStatus1)
                    .HasMaxLength(50)
                    .HasColumnName("ShippingOrderStatus");
            });

            modelBuilder.Entity<SubUnitTypeEnumTable>(entity =>
            {
                entity.ToTable("SubUnitTypeEnumTable");

                entity.Property(e => e.SubUnitTypeArabicName)
                    .HasMaxLength(100)
                    .HasColumnName("SubUnitType_ArabicName");

                entity.Property(e => e.SubUnitTypeEnglishName)
                    .HasMaxLength(100)
                    .HasColumnName("SubUnitType_EnglishName");

                entity.Property(e => e.SubUnitTypeReference).HasColumnName("SubUnitType_Reference");

                entity.Property(e => e.UnitTypeMainReference).HasColumnName("UnitType_MainReference");
            });

            modelBuilder.Entity<UnitTypeEnumTable>(entity =>
            {
                entity.ToTable("UnitTypeEnumTable");

                entity.Property(e => e.UnitTypeArabicName)
                    .HasMaxLength(100)
                    .HasColumnName("UnitType_ArabicName");

                entity.Property(e => e.UnitTypeEnglishName)
                    .HasMaxLength(100)
                    .HasColumnName("UnitType_EnglishName");

                entity.Property(e => e.UnitTypeReference).HasColumnName("UnitType_Reference");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasIndex(e => e.DistrictId, "IX_UserAddresses_DistrictId");

                entity.HasIndex(e => e.RegionId, "IX_UserAddresses_RegionId");

                entity.HasIndex(e => e.UserProfileId, "IX_UserAddresses_UserProfileId")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.RegionId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.DistrictId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UserProfile)
                    .WithOne(p => p.UserAddress)
                    .HasForeignKey<UserAddress>(d => d.UserProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserProfiles_UserId")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("(N'desc')");

                entity.Property(e => e.HasAnotherNumber)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.HasWhatsApp)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.HasWhatsApp2)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.TelephoneNumber).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserProfile)
                    .HasForeignKey<UserProfile>(d => d.UserId);
            });

            //modelBuilder.HasSequence<int>("RequestNumberSequence").StartsAt(9000);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
