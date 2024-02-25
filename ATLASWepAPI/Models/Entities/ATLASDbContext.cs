using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ATLASWepAPI.Models.Entities;

public partial class ATLASDbContext : DbContext
{
    public ATLASDbContext()
    {
    }

    public ATLASDbContext(DbContextOptions<ATLASDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AclRecord> AclRecords { get; set; }

    public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

    public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }

    public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }

    public virtual DbSet<Affiliate> Affiliates { get; set; }

    public virtual DbSet<AffiliateAgent> AffiliateAgents { get; set; }

    public virtual DbSet<AffiliateCommissionMapping> AffiliateCommissionMappings { get; set; }

    public virtual DbSet<AffiliatedCustomer> AffiliatedCustomers { get; set; }

    public virtual DbSet<AffiliatedOrder> AffiliatedOrders { get; set; }

    public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<BlogComment> BlogComments { get; set; }

    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }

    public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }

    public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Commission> Commissions { get; set; }

    public virtual DbSet<CommissionProduct> CommissionProducts { get; set; }

    public virtual DbSet<CommissionStore> CommissionStores { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }

    public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }

    public virtual DbSet<CustomerId> CustomerIds { get; set; }

    public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }

    public virtual DbSet<CustomerRole> CustomerRoles { get; set; }

    public virtual DbSet<CustomerUpload> CustomerUploads { get; set; }

    public virtual DbSet<CyberSourceCustomerToken> CyberSourceCustomerTokens { get; set; }

    public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }

    public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }

    public virtual DbSet<Download> Downloads { get; set; }

    public virtual DbSet<EmailAccount> EmailAccounts { get; set; }

    public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }

    public virtual DbSet<ForumsForum> ForumsForums { get; set; }

    public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }

    public virtual DbSet<ForumsPost> ForumsPosts { get; set; }

    public virtual DbSet<ForumsPostVote> ForumsPostVotes { get; set; }

    public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessages { get; set; }

    public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }

    public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }

    public virtual DbSet<GdprConsent> GdprConsents { get; set; }

    public virtual DbSet<GdprLog> GdprLogs { get; set; }

    public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }

    public virtual DbSet<GiftCard> GiftCards { get; set; }

    public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }

    public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<MailChimpSynchronizationRecord> MailChimpSynchronizationRecords { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }

    public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }

    public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }

    public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }

    public virtual DbSet<MigrationVersionInfo> MigrationVersionInfos { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsComment> NewsComments { get; set; }

    public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }

    public virtual DbSet<NopAdvanceUrlRedirect> NopAdvanceUrlRedirects { get; set; }

    public virtual DbSet<NsLicense> NsLicenses { get; set; }

    public virtual DbSet<NsQnAProductQa> NsQnAProductQas { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderNote> OrderNotes { get; set; }

    public virtual DbSet<OrderReferenceNumber> OrderReferenceNumbers { get; set; }

    public virtual DbSet<OrderSku> OrderSkus { get; set; }

    public virtual DbSet<PaymongoPaymentIntent> PaymongoPaymentIntents { get; set; }

    public virtual DbSet<PaynamicsPaymentIntent> PaynamicsPaymentIntents { get; set; }

    public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<PictureBinary> PictureBinaries { get; set; }

    public virtual DbSet<Poll> Polls { get; set; }

    public virtual DbSet<PollAnswer> PollAnswers { get; set; }

    public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }

    public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }

    public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }

    public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRanges { get; set; }

    public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }

    public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }

    public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }

    public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }

    public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }

    public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }

    public virtual DbSet<ProductVideo> ProductVideos { get; set; }

    public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }

    public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }

    public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }

    public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }

    public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }

    public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }

    public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }

    public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }

    public virtual DbSet<ReviewType> ReviewTypes { get; set; }

    public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }

    public virtual DbSet<SampleTable> SampleTables { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<SearchTerm> SearchTerms { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }

    public virtual DbSet<ShippingByWeightByTotalRecord> ShippingByWeightByTotalRecords { get; set; }

    public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<Slide> Slides { get; set; }

    public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }

    public virtual DbSet<SpecificationAttributeGroup> SpecificationAttributeGroups { get; set; }

    public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }

    public virtual DbSet<StateProvince> StateProvinces { get; set; }

    public virtual DbSet<StockQuantityHistory> StockQuantityHistories { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreMapping> StoreMappings { get; set; }

    public virtual DbSet<StorePickupPoint> StorePickupPoints { get; set; }

    public virtual DbSet<TaxCategory> TaxCategories { get; set; }

    public virtual DbSet<TaxRate> TaxRates { get; set; }

    public virtual DbSet<TaxTransactionLog> TaxTransactionLogs { get; set; }

    public virtual DbSet<TestTable> TestTables { get; set; }

    public virtual DbSet<TierPrice> TierPrices { get; set; }

    public virtual DbSet<TmpGuestsToDelete> TmpGuestsToDeletes { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }

    public virtual DbSet<UrlRecord> UrlRecords { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }

    public virtual DbSet<VendorAttributeValue> VendorAttributeValues { get; set; }

    public virtual DbSet<VendorNote> VendorNotes { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WidgetZone> WidgetZones { get; set; }

    public virtual DbSet<WidgetZoneSlide> WidgetZoneSlides { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALGOCHAD;Database=inhealth_prod_burn_test;ConnectRetryCount=0;User=sa;Password=jb123;Persist Security Info=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AclRecord>(entity =>
        {
            entity.ToTable("AclRecord");

            entity.Property(e => e.EntityName).HasMaxLength(400);

            entity.HasOne(d => d.CustomerRole).WithMany(p => p.AclRecords)
                .HasForeignKey(d => d.CustomerRoleId)
                .HasConstraintName("FK_AclRecord_CustomerRoleId_CustomerRole_Id");
        });

        modelBuilder.Entity<ActivityLog>(entity =>
        {
            entity.ToTable("ActivityLog");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.IpAddress).HasMaxLength(200);

            entity.HasOne(d => d.ActivityLogType).WithMany(p => p.ActivityLogs)
                .HasForeignKey(d => d.ActivityLogTypeId)
                .HasConstraintName("FK_ActivityLog_ActivityLogTypeId_ActivityLogType_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.ActivityLogs)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ActivityLog_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ActivityLogType>(entity =>
        {
            entity.ToTable("ActivityLogType");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Address_CountryId_Country_Id");

            entity.HasOne(d => d.StateProvince).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StateProvinceId)
                .HasConstraintName("FK_Address_StateProvinceId_StateProvince_Id");

            entity.HasMany(d => d.Customers).WithMany(p => p.Addresses)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerAddress",
                    r => r.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_CustomerAddresses_Customer_Id_Customer_Id"),
                    l => l.HasOne<Address>().WithMany()
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_CustomerAddresses_Address_Id_Address_Id"),
                    j =>
                    {
                        j.HasKey("AddressId", "CustomerId");
                        j.ToTable("CustomerAddresses");
                        j.IndexerProperty<int>("AddressId").HasColumnName("Address_Id");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("Customer_Id");
                    });
        });

        modelBuilder.Entity<AddressAttribute>(entity =>
        {
            entity.ToTable("AddressAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<AddressAttributeValue>(entity =>
        {
            entity.ToTable("AddressAttributeValue");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.AddressAttribute).WithMany(p => p.AddressAttributeValues)
                .HasForeignKey(d => d.AddressAttributeId)
                .HasConstraintName("FK_AddressAttributeValue_AddressAttributeId_AddressAttribute_Id");
        });

        modelBuilder.Entity<Affiliate>(entity =>
        {
            entity.ToTable("Affiliate");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.ReferralLink).HasMaxLength(400);

            entity.HasOne(d => d.Address).WithMany(p => p.Affiliates)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Affiliate_AddressId_Address_Id");
        });

        modelBuilder.Entity<AffiliateAgent>(entity =>
        {
            entity.HasKey(e => e.AffiliateAgentId).HasName("PK_Affiliate1");

            entity.ToTable("AffiliateAgent");

            entity.Property(e => e.AffiliateAgentId)
                .ValueGeneratedNever()
                .HasColumnName("affiliate_agent_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.ReferralCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referral_code");
            entity.Property(e => e.ReferralLink)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("referral_link");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.AffiliateAgentNavigation).WithOne(p => p.AffiliateAgent)
                .HasForeignKey<AffiliateAgent>(d => d.AffiliateAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AffiliateAgent_Customer2");
        });

        modelBuilder.Entity<AffiliateCommissionMapping>(entity =>
        {
            entity.ToTable("AffiliateCommissionMapping");

            entity.HasOne(d => d.Affiliate).WithMany(p => p.AffiliateCommissionMappings)
                .HasForeignKey(d => d.AffiliateId)
                .HasConstraintName("FK_AffiliateCommissionMapping_AffiliateId_Affiliate_Id");

            entity.HasOne(d => d.Commission).WithMany(p => p.AffiliateCommissionMappings)
                .HasForeignKey(d => d.CommissionId)
                .HasConstraintName("FK_AffiliateCommissionMapping_CommissionId_Commission_Id");
        });

        modelBuilder.Entity<AffiliatedCustomer>(entity =>
        {
            entity.HasKey(e => e.AffiliateCustomerId);

            entity.ToTable("AffiliatedCustomer");

            entity.Property(e => e.AffiliateCustomerId)
                .ValueGeneratedNever()
                .HasColumnName("affiliate_customer_id");
            entity.Property(e => e.AffiliateAgentId).HasColumnName("affiliate_agent_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.AffiliateAgent).WithMany(p => p.AffiliatedCustomers)
                .HasForeignKey(d => d.AffiliateAgentId)
                .HasConstraintName("FK_AffiliatedCustomer_AffiliateAgent");

            entity.HasOne(d => d.AffiliateCustomer).WithOne(p => p.AffiliatedCustomer)
                .HasForeignKey<AffiliatedCustomer>(d => d.AffiliateCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AffiliatedCustomer_Customer");
        });

        modelBuilder.Entity<AffiliatedOrder>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommissionStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalCommission).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<BackInStockSubscription>(entity =>
        {
            entity.ToTable("BackInStockSubscription");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.BackInStockSubscriptions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_BackInStockSubscription_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.BackInStockSubscriptions)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_BackInStockSubscription_ProductId_Product_Id");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.ToTable("Banner");
        });

        modelBuilder.Entity<BlogComment>(entity =>
        {
            entity.ToTable("BlogComment");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.BlogPost).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.BlogPostId)
                .HasConstraintName("FK_BlogComment_BlogPostId_BlogPost_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_BlogComment_CustomerId_Customer_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_BlogComment_StoreId_Store_Id");
        });

        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.ToTable("BlogPost");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.EndDateUtc).HasPrecision(6);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.StartDateUtc).HasPrecision(6);

            entity.HasOne(d => d.Language).WithMany(p => p.BlogPosts)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BlogPost_LanguageId_Language_Id");
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.ToTable("Campaign");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.DontSendBeforeDateUtc).HasPrecision(6);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);
        });

        modelBuilder.Entity<CategoryTemplate>(entity =>
        {
            entity.ToTable("CategoryTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<CheckoutAttribute>(entity =>
        {
            entity.ToTable("CheckoutAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CheckoutAttributeValue>(entity =>
        {
            entity.ToTable("CheckoutAttributeValue");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.CheckoutAttribute).WithMany(p => p.CheckoutAttributeValues)
                .HasForeignKey(d => d.CheckoutAttributeId)
                .HasConstraintName("FK_CheckoutAttributeValue_CheckoutAttributeId_CheckoutAttribute_Id");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasIndex(e => e.StateId, "IX_Cities_StateId");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Cities_StateId_StateProvince_Id");
        });

        modelBuilder.Entity<Commission>(entity =>
        {
            entity.ToTable("Commission");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PercentOrAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CommissionProduct>(entity =>
        {
            entity.ToTable("CommissionProduct");

            entity.HasOne(d => d.Commission).WithMany(p => p.CommissionProducts)
                .HasForeignKey(d => d.CommissionId)
                .HasConstraintName("FK_CommissionProduct_CommissionId_Commission_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.CommissionProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_CommissionProduct_ProductId_Product_Id");
        });

        modelBuilder.Entity<CommissionStore>(entity =>
        {
            entity.ToTable("CommissionStore");

            entity.HasOne(d => d.Commission).WithMany(p => p.CommissionStores)
                .HasForeignKey(d => d.CommissionId)
                .HasConstraintName("FK_CommissionStore_CommissionId_Commission_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.CommissionStores)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_CommissionStore_StoreId_Store_Id");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);
            entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<CrossSellProduct>(entity =>
        {
            entity.ToTable("CrossSellProduct");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.CurrencyCode).HasMaxLength(5);
            entity.Property(e => e.CustomFormatting).HasMaxLength(50);
            entity.Property(e => e.DisplayLocale).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.CannotLoginUntilDateUtc).HasPrecision(6);
            entity.Property(e => e.City).HasMaxLength(1000);
            entity.Property(e => e.Company).HasMaxLength(1000);
            entity.Property(e => e.County).HasMaxLength(1000);
            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.CustomCustomerAttributesXml).HasColumnName("CustomCustomerAttributesXML");
            entity.Property(e => e.Email).HasMaxLength(1000);
            entity.Property(e => e.EmailToRevalidate).HasMaxLength(1000);
            entity.Property(e => e.Fax).HasMaxLength(1000);
            entity.Property(e => e.FirstName).HasMaxLength(1000);
            entity.Property(e => e.Gender).HasMaxLength(1000);
            entity.Property(e => e.LastActivityDateUtc).HasPrecision(6);
            entity.Property(e => e.LastLoginDateUtc).HasPrecision(6);
            entity.Property(e => e.LastName).HasMaxLength(1000);
            entity.Property(e => e.Phone).HasMaxLength(1000);
            entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");
            entity.Property(e => e.StreetAddress).HasMaxLength(1000);
            entity.Property(e => e.StreetAddress2).HasMaxLength(1000);
            entity.Property(e => e.SystemName).HasMaxLength(400);
            entity.Property(e => e.TimeZoneId).HasMaxLength(1000);
            entity.Property(e => e.Username).HasMaxLength(1000);
            entity.Property(e => e.VatNumber).HasMaxLength(1000);
            entity.Property(e => e.ZipPostalCode).HasMaxLength(1000);

            entity.HasOne(d => d.BillingAddress).WithMany(p => p.CustomerBillingAddresses)
                .HasForeignKey(d => d.BillingAddressId)
                .HasConstraintName("FK_Customer_BillingAddress_Id_Address_Id");

            entity.HasOne(d => d.Currency).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Customer_CurrencyId_Currency_Id");

            entity.HasOne(d => d.Language).WithMany(p => p.Customers)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Customer_LanguageId_Language_Id");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.CustomerShippingAddresses)
                .HasForeignKey(d => d.ShippingAddressId)
                .HasConstraintName("FK_Customer_ShippingAddress_Id_Address_Id");

            entity.HasMany(d => d.CustomerRoles).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerRoleMapping",
                    r => r.HasOne<CustomerRole>().WithMany()
                        .HasForeignKey("CustomerRoleId")
                        .HasConstraintName("FK_Customer_CustomerRole_Mapping_CustomerRole_Id_CustomerRole_Id"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_CustomerRole_Mapping_Customer_Id_Customer_Id"),
                    j =>
                    {
                        j.HasKey("CustomerId", "CustomerRoleId");
                        j.ToTable("Customer_CustomerRole_Mapping");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("Customer_Id");
                        j.IndexerProperty<int>("CustomerRoleId").HasColumnName("CustomerRole_Id");
                    });
        });

        modelBuilder.Entity<CustomerAttribute>(entity =>
        {
            entity.ToTable("CustomerAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CustomerAttributeValue>(entity =>
        {
            entity.ToTable("CustomerAttributeValue");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.CustomerAttribute).WithMany(p => p.CustomerAttributeValues)
                .HasForeignKey(d => d.CustomerAttributeId)
                .HasConstraintName("FK_CustomerAttributeValue_CustomerAttributeId_CustomerAttribute_Id");
        });

        modelBuilder.Entity<CustomerId>(entity =>
        {
            entity.HasIndex(e => e.CustomerId1, "IX_CustomerIds_CustomerId");

            entity.Property(e => e.CustomerId1).HasColumnName("CustomerId");

            entity.HasOne(d => d.CustomerId1Navigation).WithMany(p => p.CustomerIds)
                .HasForeignKey(d => d.CustomerId1)
                .HasConstraintName("FK_CustomerIds_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<CustomerPassword>(entity =>
        {
            entity.ToTable("CustomerPassword");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPasswords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerPassword_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<CustomerRole>(entity =>
        {
            entity.ToTable("CustomerRole");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<CustomerUpload>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("CustomerUpload");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.FileType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithOne(p => p.CustomerUpload)
                .HasForeignKey<CustomerUpload>(d => d.CustomerId)
                .HasConstraintName("FK_CustomerUpload_Customer");
        });

        modelBuilder.Entity<CyberSourceCustomerToken>(entity =>
        {
            entity.ToTable("CyberSourceCustomerToken");

            entity.Property(e => e.CardExpirationMonth).HasMaxLength(2);
            entity.Property(e => e.CardExpirationYear).HasMaxLength(4);
            entity.Property(e => e.CyberSourceCustomerId).HasMaxLength(100);
            entity.Property(e => e.FirstSixDigitOfCard).HasMaxLength(6);
            entity.Property(e => e.InstrumentIdentifier).HasMaxLength(100);
            entity.Property(e => e.InstrumentIdentifierStatus).HasMaxLength(100);
            entity.Property(e => e.LastFourDigitOfCard).HasMaxLength(4);
            entity.Property(e => e.SubscriptionId).HasMaxLength(100);
            entity.Property(e => e.ThreeDigitCardType).HasMaxLength(3);
            entity.Property(e => e.TransactionId).HasMaxLength(100);

            entity.HasOne(d => d.Customer).WithMany(p => p.CyberSourceCustomerTokens)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CyberSourceCustomerToken_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<DeliveryDate>(entity =>
        {
            entity.ToTable("DeliveryDate");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.ToTable("Discount");

            entity.Property(e => e.CouponCode).HasMaxLength(100);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EndDateUtc).HasPrecision(6);
            entity.Property(e => e.MaximumDiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.StartDateUtc).HasPrecision(6);

            entity.HasMany(d => d.Categories).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountAppliedToCategory",
                    r => r.HasOne<Category>().WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Discount_AppliedToCategories_Category_Id_Category_Id"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK_Discount_AppliedToCategories_Discount_Id_Discount_Id"),
                    j =>
                    {
                        j.HasKey("DiscountId", "CategoryId");
                        j.ToTable("Discount_AppliedToCategories");
                        j.IndexerProperty<int>("DiscountId").HasColumnName("Discount_Id");
                        j.IndexerProperty<int>("CategoryId").HasColumnName("Category_Id");
                    });

            entity.HasMany(d => d.Manufacturers).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountAppliedToManufacturer",
                    r => r.HasOne<Manufacturer>().WithMany()
                        .HasForeignKey("ManufacturerId")
                        .HasConstraintName("FK_Discount_AppliedToManufacturers_Manufacturer_Id_Manufacturer_Id"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK_Discount_AppliedToManufacturers_Discount_Id_Discount_Id"),
                    j =>
                    {
                        j.HasKey("DiscountId", "ManufacturerId");
                        j.ToTable("Discount_AppliedToManufacturers");
                        j.IndexerProperty<int>("DiscountId").HasColumnName("Discount_Id");
                        j.IndexerProperty<int>("ManufacturerId").HasColumnName("Manufacturer_Id");
                    });

            entity.HasMany(d => d.Products).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountAppliedToProduct",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Discount_AppliedToProducts_Product_Id_Product_Id"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK_Discount_AppliedToProducts_Discount_Id_Discount_Id"),
                    j =>
                    {
                        j.HasKey("DiscountId", "ProductId");
                        j.ToTable("Discount_AppliedToProducts");
                        j.IndexerProperty<int>("DiscountId").HasColumnName("Discount_Id");
                        j.IndexerProperty<int>("ProductId").HasColumnName("Product_Id");
                    });
        });

        modelBuilder.Entity<DiscountRequirement>(entity =>
        {
            entity.ToTable("DiscountRequirement");

            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountRequirements)
                .HasForeignKey(d => d.DiscountId)
                .HasConstraintName("FK_DiscountRequirement_DiscountId_Discount_Id");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_DiscountRequirement_ParentId_DiscountRequirement_Id");
        });

        modelBuilder.Entity<DiscountUsageHistory>(entity =>
        {
            entity.ToTable("DiscountUsageHistory");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountUsageHistories)
                .HasForeignKey(d => d.DiscountId)
                .HasConstraintName("FK_DiscountUsageHistory_DiscountId_Discount_Id");

            entity.HasOne(d => d.Order).WithMany(p => p.DiscountUsageHistories)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_DiscountUsageHistory_OrderId_Order_Id");
        });

        modelBuilder.Entity<Download>(entity =>
        {
            entity.ToTable("Download");
        });

        modelBuilder.Entity<EmailAccount>(entity =>
        {
            entity.ToTable("EmailAccount");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Host).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
        {
            entity.ToTable("ExternalAuthenticationRecord");

            entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");
            entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

            entity.HasOne(d => d.Customer).WithMany(p => p.ExternalAuthenticationRecords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ExternalAuthenticationRecord_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsForum>(entity =>
        {
            entity.ToTable("Forums_Forum");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.LastPostTime).HasPrecision(6);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.ForumGroup).WithMany(p => p.ForumsForums)
                .HasForeignKey(d => d.ForumGroupId)
                .HasConstraintName("FK_Forums_Forum_ForumGroupId_Forums_Group_Id");
        });

        modelBuilder.Entity<ForumsGroup>(entity =>
        {
            entity.ToTable("Forums_Group");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);
        });

        modelBuilder.Entity<ForumsPost>(entity =>
        {
            entity.ToTable("Forums_Post");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .HasColumnName("IPAddress");
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Post_CustomerId_Customer_Id");

            entity.HasOne(d => d.Topic).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("FK_Forums_Post_TopicId_Forums_Topic_Id");
        });

        modelBuilder.Entity<ForumsPostVote>(entity =>
        {
            entity.ToTable("Forums_PostVote");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.ForumPost).WithMany(p => p.ForumsPostVotes)
                .HasForeignKey(d => d.ForumPostId)
                .HasConstraintName("FK_Forums_PostVote_ForumPostId_Forums_Post_Id");
        });

        modelBuilder.Entity<ForumsPrivateMessage>(entity =>
        {
            entity.ToTable("Forums_PrivateMessage");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.Subject).HasMaxLength(450);

            entity.HasOne(d => d.FromCustomer).WithMany(p => p.ForumsPrivateMessageFromCustomers)
                .HasForeignKey(d => d.FromCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_PrivateMessage_FromCustomerId_Customer_Id");

            entity.HasOne(d => d.ToCustomer).WithMany(p => p.ForumsPrivateMessageToCustomers)
                .HasForeignKey(d => d.ToCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_PrivateMessage_ToCustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsSubscription>(entity =>
        {
            entity.ToTable("Forums_Subscription");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsSubscriptions)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Subscription_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsTopic>(entity =>
        {
            entity.ToTable("Forums_Topic");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.LastPostTime).HasPrecision(6);
            entity.Property(e => e.Subject).HasMaxLength(450);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Topic_CustomerId_Customer_Id");

            entity.HasOne(d => d.Forum).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.ForumId)
                .HasConstraintName("FK_Forums_Topic_ForumId_Forums_Forum_Id");
        });

        modelBuilder.Entity<GdprConsent>(entity =>
        {
            entity.ToTable("GdprConsent");
        });

        modelBuilder.Entity<GdprLog>(entity =>
        {
            entity.ToTable("GdprLog");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
        });

        modelBuilder.Entity<GenericAttribute>(entity =>
        {
            entity.ToTable("GenericAttribute");

            entity.Property(e => e.CreatedOrUpdatedDateUtc)
                .HasPrecision(6)
                .HasColumnName("CreatedOrUpdatedDateUTC");
            entity.Property(e => e.Key).HasMaxLength(400);
            entity.Property(e => e.KeyGroup).HasMaxLength(400);
        });

        modelBuilder.Entity<GiftCard>(entity =>
        {
            entity.ToTable("GiftCard");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.PurchasedWithOrderItem).WithMany(p => p.GiftCards)
                .HasForeignKey(d => d.PurchasedWithOrderItemId)
                .HasConstraintName("FK_GiftCard_PurchasedWithOrderItemId_OrderItem_Id");
        });

        modelBuilder.Entity<GiftCardUsageHistory>(entity =>
        {
            entity.ToTable("GiftCardUsageHistory");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.GiftCard).WithMany(p => p.GiftCardUsageHistories)
                .HasForeignKey(d => d.GiftCardId)
                .HasConstraintName("FK_GiftCardUsageHistory_GiftCardId_GiftCard_Id");

            entity.HasOne(d => d.UsedWithOrder).WithMany(p => p.GiftCardUsageHistories)
                .HasForeignKey(d => d.UsedWithOrderId)
                .HasConstraintName("FK_GiftCardUsageHistory_UsedWithOrderId_Order_Id");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.Property(e => e.FlagImageFileName).HasMaxLength(50);
            entity.Property(e => e.LanguageCulture).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<LocaleStringResource>(entity =>
        {
            entity.ToTable("LocaleStringResource");

            entity.Property(e => e.ResourceName).HasMaxLength(200);

            entity.HasOne(d => d.Language).WithMany(p => p.LocaleStringResources)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_LocaleStringResource_LanguageId_Language_Id");
        });

        modelBuilder.Entity<LocalizedProperty>(entity =>
        {
            entity.ToTable("LocalizedProperty");

            entity.Property(e => e.LocaleKey).HasMaxLength(400);
            entity.Property(e => e.LocaleKeyGroup).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.LocalizedProperties)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_LocalizedProperty_LanguageId_Language_Id");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("Log");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.IpAddress).HasMaxLength(200);

            entity.HasOne(d => d.Customer).WithMany(p => p.Logs)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Log_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<MailChimpSynchronizationRecord>(entity =>
        {
            entity.ToTable("MailChimpSynchronizationRecord");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.ToTable("Manufacturer");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);
        });

        modelBuilder.Entity<ManufacturerTemplate>(entity =>
        {
            entity.ToTable("ManufacturerTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<MeasureDimension>(entity =>
        {
            entity.ToTable("MeasureDimension");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<MeasureWeight>(entity =>
        {
            entity.ToTable("MeasureWeight");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<MessageTemplate>(entity =>
        {
            entity.ToTable("MessageTemplate");

            entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Subject).HasMaxLength(1000);
        });

        modelBuilder.Entity<MigrationVersionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MigrationVersionInfo");

            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1024);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.EndDateUtc).HasPrecision(6);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.StartDateUtc).HasPrecision(6);

            entity.HasOne(d => d.Language).WithMany(p => p.News)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_News_LanguageId_Language_Id");
        });

        modelBuilder.Entity<NewsComment>(entity =>
        {
            entity.ToTable("NewsComment");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_NewsComment_CustomerId_Customer_Id");

            entity.HasOne(d => d.NewsItem).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.NewsItemId)
                .HasConstraintName("FK_NewsComment_NewsItemId_News_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_NewsComment_StoreId_Store_Id");
        });

        modelBuilder.Entity<NewsLetterSubscription>(entity =>
        {
            entity.ToTable("NewsLetterSubscription");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.Email).HasMaxLength(255);
        });

        modelBuilder.Entity<NopAdvanceUrlRedirect>(entity =>
        {
            entity.ToTable("NopAdvance_URL_Redirect");
        });

        modelBuilder.Entity<NsLicense>(entity =>
        {
            entity.ToTable("NS_License");
        });

        modelBuilder.Entity<NsQnAProductQa>(entity =>
        {
            entity.ToTable("NS_QnA_ProductQA");

            entity.HasIndex(e => e.CustomerId, "IX_NS_QnA_ProductQA_CustomerId");

            entity.HasIndex(e => e.ProductId, "IX_NS_QnA_ProductQA_ProductId");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.NsQnAProductQas)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_NS_QnA_ProductQA_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.NsQnAProductQas)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_NS_QnA_ProductQA_ProductId_Product_Id");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaidDateUtc).HasPrecision(6);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentTransactionNumber).HasMaxLength(50);
            entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCommission).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.BillingAddress).WithMany(p => p.OrderBillingAddresses)
                .HasForeignKey(d => d.BillingAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_BillingAddressId_Address_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_CustomerId_Customer_Id");

            entity.HasOne(d => d.PickupAddress).WithMany(p => p.OrderPickupAddresses)
                .HasForeignKey(d => d.PickupAddressId)
                .HasConstraintName("FK_Order_PickupAddressId_Address_Id");

            entity.HasOne(d => d.RewardPointsHistoryEntry).WithMany(p => p.Orders)
                .HasForeignKey(d => d.RewardPointsHistoryEntryId)
                .HasConstraintName("FK_Order_RewardPointsHistoryEntryId_RewardPointsHistory_Id");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.OrderShippingAddresses)
                .HasForeignKey(d => d.ShippingAddressId)
                .HasConstraintName("FK_Order_ShippingAddressId_Address_Id");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("OrderItem");

            entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RentalEndDateUtc).HasPrecision(6);
            entity.Property(e => e.RentalStartDateUtc).HasPrecision(6);
            entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderItem_OrderId_Order_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_OrderItem_ProductId_Product_Id");
        });

        modelBuilder.Entity<OrderNote>(entity =>
        {
            entity.ToTable("OrderNote");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderNotes)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderNote_OrderId_Order_Id");
        });

        modelBuilder.Entity<OrderReferenceNumber>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_OrderReferenceNumber_1");

            entity.ToTable("OrderReferenceNumber");

            entity.Property(e => e.OrderId).ValueGeneratedNever();
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Order).WithOne(p => p.OrderReferenceNumber)
                .HasForeignKey<OrderReferenceNumber>(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderReferenceNumber_Order");
        });

        modelBuilder.Entity<OrderSku>(entity =>
        {
            entity.ToTable("OrderSku");

            entity.Property(e => e.Alias).HasMaxLength(50);
            entity.Property(e => e.CardStatus).HasMaxLength(50);
            entity.Property(e => e.MemberName).HasMaxLength(100);
            entity.Property(e => e.SerialNumber).HasMaxLength(50);
            entity.Property(e => e.Sku).HasMaxLength(400);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderSkus)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSku_Order");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.OrderSkus)
                .HasForeignKey(d => d.OrderItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSku_OrderItem");
        });

        modelBuilder.Entity<PaymongoPaymentIntent>(entity =>
        {
            entity.ToTable("PaymongoPaymentIntent");

            entity.HasIndex(e => e.OrderId, "IX_PaymongoPaymentIntent_OrderId");

            entity.HasOne(d => d.Order).WithMany(p => p.PaymongoPaymentIntents)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_PaymongoPaymentIntent_OrderId_Order_Id");
        });

        modelBuilder.Entity<PaynamicsPaymentIntent>(entity =>
        {
            entity.ToTable("PaynamicsPaymentIntent");

            entity.HasIndex(e => e.OrderId, "IX_PaynamicsPaymentIntent_OrderId");

            entity.HasOne(d => d.Order).WithMany(p => p.PaynamicsPaymentIntents)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_PaynamicsPaymentIntent_OrderId_Order_Id");
        });

        modelBuilder.Entity<PermissionRecord>(entity =>
        {
            entity.ToTable("PermissionRecord");

            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);

            entity.HasMany(d => d.CustomerRoles).WithMany(p => p.PermissionRecords)
                .UsingEntity<Dictionary<string, object>>(
                    "PermissionRecordRoleMapping",
                    r => r.HasOne<CustomerRole>().WithMany()
                        .HasForeignKey("CustomerRoleId")
                        .HasConstraintName("FK_PermissionRecord_Role_Mapping_CustomerRole_Id_CustomerRole_Id"),
                    l => l.HasOne<PermissionRecord>().WithMany()
                        .HasForeignKey("PermissionRecordId")
                        .HasConstraintName("FK_PermissionRecord_Role_Mapping_PermissionRecord_Id_PermissionRecord_Id"),
                    j =>
                    {
                        j.HasKey("PermissionRecordId", "CustomerRoleId");
                        j.ToTable("PermissionRecord_Role_Mapping");
                        j.IndexerProperty<int>("PermissionRecordId").HasColumnName("PermissionRecord_Id");
                        j.IndexerProperty<int>("CustomerRoleId").HasColumnName("CustomerRole_Id");
                    });
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.ToTable("Picture");

            entity.Property(e => e.MimeType).HasMaxLength(40);
            entity.Property(e => e.SeoFilename).HasMaxLength(300);
        });

        modelBuilder.Entity<PictureBinary>(entity =>
        {
            entity.ToTable("PictureBinary");

            entity.HasOne(d => d.Picture).WithMany(p => p.PictureBinaries)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_PictureBinary_PictureId_Picture_Id");
        });

        modelBuilder.Entity<Poll>(entity =>
        {
            entity.ToTable("Poll");

            entity.Property(e => e.EndDateUtc).HasPrecision(6);
            entity.Property(e => e.StartDateUtc).HasPrecision(6);

            entity.HasOne(d => d.Language).WithMany(p => p.Polls)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_Poll_LanguageId_Language_Id");
        });

        modelBuilder.Entity<PollAnswer>(entity =>
        {
            entity.ToTable("PollAnswer");

            entity.HasOne(d => d.Poll).WithMany(p => p.PollAnswers)
                .HasForeignKey(d => d.PollId)
                .HasConstraintName("FK_PollAnswer_PollId_Poll_Id");
        });

        modelBuilder.Entity<PollVotingRecord>(entity =>
        {
            entity.ToTable("PollVotingRecord");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.PollVotingRecords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_PollVotingRecord_CustomerId_Customer_Id");

            entity.HasOne(d => d.PollAnswer).WithMany(p => p.PollVotingRecords)
                .HasForeignKey(d => d.PollAnswerId)
                .HasConstraintName("FK_PollVotingRecord_PollAnswerId_PollAnswer_Id");
        });

        modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
        {
            entity.ToTable("PredefinedProductAttributeValue");

            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductAttribute).WithMany(p => p.PredefinedProductAttributeValues)
                .HasForeignKey(d => d.ProductAttributeId)
                .HasConstraintName("FK_PredefinedProductAttributeValue_ProductAttributeId_ProductAttribute_Id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);
            entity.Property(e => e.AvailableEndDateTimeUtc).HasPrecision(6);
            entity.Property(e => e.AvailableStartDateTimeUtc).HasPrecision(6);
            entity.Property(e => e.BasepriceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BasepriceBaseAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Caption).HasMaxLength(400);
            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.Gtin).HasMaxLength(400);
            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);
            entity.Property(e => e.MarkAsNewEndDateTimeUtc).HasPrecision(6);
            entity.Property(e => e.MarkAsNewStartDateTimeUtc).HasPrecision(6);
            entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OverriddenGiftCardAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PreOrderAvailabilityStartDateTimeUtc).HasPrecision(6);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceDisplay).HasMaxLength(400);
            entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);
            entity.Property(e => e.Sku).HasMaxLength(400);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

            entity.HasMany(d => d.ProductTags).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductProductTagMapping",
                    r => r.HasOne<ProductTag>().WithMany()
                        .HasForeignKey("ProductTagId")
                        .HasConstraintName("FK_Product_ProductTag_Mapping_ProductTag_Id_ProductTag_Id"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_ProductTag_Mapping_Product_Id_Product_Id"),
                    j =>
                    {
                        j.HasKey("ProductId", "ProductTagId");
                        j.ToTable("Product_ProductTag_Mapping");
                        j.IndexerProperty<int>("ProductId").HasColumnName("Product_Id");
                        j.IndexerProperty<int>("ProductTagId").HasColumnName("ProductTag_Id");
                    });
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.ToTable("ProductAttribute");
        });

        modelBuilder.Entity<ProductAttributeCombination>(entity =>
        {
            entity.ToTable("ProductAttributeCombination");

            entity.Property(e => e.Gtin).HasMaxLength(400);
            entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);
            entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sku).HasMaxLength(400);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductAttributeCombinations)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductAttributeCombination_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductAttributeValue>(entity =>
        {
            entity.ToTable("ProductAttributeValue");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductAttributeMapping).WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(d => d.ProductAttributeMappingId)
                .HasConstraintName("FK_ProductAttributeValue_ProductAttributeMappingId_Product_ProductAttribute_Mapping_Id");
        });

        modelBuilder.Entity<ProductAvailabilityRange>(entity =>
        {
            entity.ToTable("ProductAvailabilityRange");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductCategoryMapping>(entity =>
        {
            entity.ToTable("Product_Category_Mapping");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Product_Category_Mapping_CategoryId_Category_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Category_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductManufacturerMapping>(entity =>
        {
            entity.ToTable("Product_Manufacturer_Mapping");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Product_Manufacturer_Mapping_ManufacturerId_Manufacturer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Manufacturer_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductPictureMapping>(entity =>
        {
            entity.ToTable("Product_Picture_Mapping");

            entity.HasOne(d => d.Picture).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_Product_Picture_Mapping_PictureId_Picture_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Picture_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
        {
            entity.ToTable("Product_ProductAttribute_Mapping");

            entity.HasOne(d => d.ProductAttribute).WithMany(p => p.ProductProductAttributeMappings)
                .HasForeignKey(d => d.ProductAttributeId)
                .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductAttributeId_ProductAttribute_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductProductAttributeMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductReview>(entity =>
        {
            entity.ToTable("ProductReview");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ProductReview_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductReview_ProductId_Product_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_ProductReview_StoreId_Store_Id");
        });

        modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
        {
            entity.ToTable("ProductReviewHelpfulness");

            entity.HasOne(d => d.ProductReview).WithMany(p => p.ProductReviewHelpfulnesses)
                .HasForeignKey(d => d.ProductReviewId)
                .HasConstraintName("FK_ProductReviewHelpfulness_ProductReviewId_ProductReview_Id");
        });

        modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
        {
            entity.ToTable("ProductReview_ReviewType_Mapping");

            entity.HasOne(d => d.ProductReview).WithMany(p => p.ProductReviewReviewTypeMappings)
                .HasForeignKey(d => d.ProductReviewId)
                .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ProductReviewId_ProductReview_Id");

            entity.HasOne(d => d.ReviewType).WithMany(p => p.ProductReviewReviewTypeMappings)
                .HasForeignKey(d => d.ReviewTypeId)
                .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ReviewTypeId_ReviewType_Id");
        });

        modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
        {
            entity.ToTable("Product_SpecificationAttribute_Mapping");

            entity.Property(e => e.CustomValue).HasMaxLength(4000);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSpecificationAttributeMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_ProductId_Product_Id");

            entity.HasOne(d => d.SpecificationAttributeOption).WithMany(p => p.ProductSpecificationAttributeMappings)
                .HasForeignKey(d => d.SpecificationAttributeOptionId)
                .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId_SpecificationAttributeOption_Id");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.ToTable("ProductTag");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.ToTable("ProductTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductVideo>(entity =>
        {
            entity.ToTable("ProductVideo");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductVideos)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductVideo_ProductId_Product_Id");

            entity.HasOne(d => d.Video).WithMany(p => p.ProductVideos)
                .HasForeignKey(d => d.VideoId)
                .HasConstraintName("FK_ProductVideo_VideoId_Video_Id");
        });

        modelBuilder.Entity<ProductWarehouseInventory>(entity =>
        {
            entity.ToTable("ProductWarehouseInventory");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductWarehouseInventories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductWarehouseInventory_ProductId_Product_Id");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ProductWarehouseInventories)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_ProductWarehouseInventory_WarehouseId_Warehouse_Id");
        });

        modelBuilder.Entity<QueuedEmail>(entity =>
        {
            entity.ToTable("QueuedEmail");

            entity.Property(e => e.Bcc).HasMaxLength(500);
            entity.Property(e => e.Cc)
                .HasMaxLength(500)
                .HasColumnName("CC");
            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.DontSendBeforeDateUtc).HasPrecision(6);
            entity.Property(e => e.From).HasMaxLength(500);
            entity.Property(e => e.FromName).HasMaxLength(500);
            entity.Property(e => e.ReplyTo).HasMaxLength(500);
            entity.Property(e => e.ReplyToName).HasMaxLength(500);
            entity.Property(e => e.SentOnUtc).HasPrecision(6);
            entity.Property(e => e.Subject).HasMaxLength(1000);
            entity.Property(e => e.To).HasMaxLength(500);
            entity.Property(e => e.ToName).HasMaxLength(500);

            entity.HasOne(d => d.EmailAccount).WithMany(p => p.QueuedEmails)
                .HasForeignKey(d => d.EmailAccountId)
                .HasConstraintName("FK_QueuedEmail_EmailAccountId_EmailAccount_Id");
        });

        modelBuilder.Entity<RecurringPayment>(entity =>
        {
            entity.ToTable("RecurringPayment");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.StartDateUtc).HasPrecision(6);

            entity.HasOne(d => d.InitialOrder).WithMany(p => p.RecurringPayments)
                .HasForeignKey(d => d.InitialOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecurringPayment_InitialOrderId_Order_Id");
        });

        modelBuilder.Entity<RecurringPaymentHistory>(entity =>
        {
            entity.ToTable("RecurringPaymentHistory");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.RecurringPayment).WithMany(p => p.RecurringPaymentHistories)
                .HasForeignKey(d => d.RecurringPaymentId)
                .HasConstraintName("FK_RecurringPaymentHistory_RecurringPaymentId_RecurringPayment_Id");
        });

        modelBuilder.Entity<RelatedProduct>(entity =>
        {
            entity.ToTable("RelatedProduct");
        });

        modelBuilder.Entity<ReturnRequest>(entity =>
        {
            entity.ToTable("ReturnRequest");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.ReturnRequests)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ReturnRequest_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ReturnRequestAction>(entity =>
        {
            entity.ToTable("ReturnRequestAction");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ReturnRequestReason>(entity =>
        {
            entity.ToTable("ReturnRequestReason");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ReviewType>(entity =>
        {
            entity.ToTable("ReviewType");

            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<RewardPointsHistory>(entity =>
        {
            entity.ToTable("RewardPointsHistory");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.EndDateUtc).HasPrecision(6);
            entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Customer).WithMany(p => p.RewardPointsHistories)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_RewardPointsHistory_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<SampleTable>(entity =>
        {
            entity.ToTable("SampleTable");

            entity.Property(e => e.Test)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.ToTable("ScheduleTask");

            entity.Property(e => e.LastEnabledUtc).HasPrecision(6);
            entity.Property(e => e.LastEndUtc).HasPrecision(6);
            entity.Property(e => e.LastStartUtc).HasPrecision(6);
            entity.Property(e => e.LastSuccessUtc).HasPrecision(6);
        });

        modelBuilder.Entity<SearchTerm>(entity =>
        {
            entity.ToTable("SearchTerm");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.ToTable("Shipment");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.DeliveryDateUtc).HasPrecision(6);
            entity.Property(e => e.ReadyForPickupDateUtc).HasPrecision(6);
            entity.Property(e => e.ShippedDateUtc).HasPrecision(6);
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Order).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_Shipment_OrderId_Order_Id");
        });

        modelBuilder.Entity<ShipmentItem>(entity =>
        {
            entity.ToTable("ShipmentItem");

            entity.HasOne(d => d.Shipment).WithMany(p => p.ShipmentItems)
                .HasForeignKey(d => d.ShipmentId)
                .HasConstraintName("FK_ShipmentItem_ShipmentId_Shipment_Id");
        });

        modelBuilder.Entity<ShippingByWeightByTotalRecord>(entity =>
        {
            entity.ToTable("ShippingByWeightByTotalRecord");

            entity.Property(e => e.AdditionalFixedCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LowerWeightLimit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalTo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PercentageRateOfSubtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RatePerWeightUnit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightTo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Zip).HasMaxLength(400);
        });

        modelBuilder.Entity<ShippingMethod>(entity =>
        {
            entity.ToTable("ShippingMethod");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasMany(d => d.Countries).WithMany(p => p.ShippingMethods)
                .UsingEntity<Dictionary<string, object>>(
                    "ShippingMethodRestriction",
                    r => r.HasOne<Country>().WithMany()
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_ShippingMethodRestrictions_Country_Id_Country_Id"),
                    l => l.HasOne<ShippingMethod>().WithMany()
                        .HasForeignKey("ShippingMethodId")
                        .HasConstraintName("FK_ShippingMethodRestrictions_ShippingMethod_Id_ShippingMethod_Id"),
                    j =>
                    {
                        j.HasKey("ShippingMethodId", "CountryId");
                        j.ToTable("ShippingMethodRestrictions");
                        j.IndexerProperty<int>("ShippingMethodId").HasColumnName("ShippingMethod_Id");
                        j.IndexerProperty<int>("CountryId").HasColumnName("Country_Id");
                    });
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.ToTable("ShoppingCartItem");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);
            entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RentalEndDateUtc).HasPrecision(6);
            entity.Property(e => e.RentalStartDateUtc).HasPrecision(6);
            entity.Property(e => e.UpdatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Customer).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ShoppingCartItem_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ShoppingCartItem_ProductId_Product_Id");
        });

        modelBuilder.Entity<Slide>(entity =>
        {
            entity.ToTable("Slide");

            entity.Property(e => e.EndDateUtc).HasPrecision(6);
            entity.Property(e => e.StartDateUtc).HasPrecision(6);
        });

        modelBuilder.Entity<SpecificationAttribute>(entity =>
        {
            entity.ToTable("SpecificationAttribute");

            entity.HasOne(d => d.SpecificationAttributeGroup).WithMany(p => p.SpecificationAttributes)
                .HasForeignKey(d => d.SpecificationAttributeGroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SpecificationAttribute_SpecificationAttributeGroupId_SpecificationAttributeGroup_Id");
        });

        modelBuilder.Entity<SpecificationAttributeGroup>(entity =>
        {
            entity.ToTable("SpecificationAttributeGroup");
        });

        modelBuilder.Entity<SpecificationAttributeOption>(entity =>
        {
            entity.ToTable("SpecificationAttributeOption");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

            entity.HasOne(d => d.SpecificationAttribute).WithMany(p => p.SpecificationAttributeOptions)
                .HasForeignKey(d => d.SpecificationAttributeId)
                .HasConstraintName("FK_SpecificationAttributeOption_SpecificationAttributeId_SpecificationAttribute_Id");
        });

        modelBuilder.Entity<StateProvince>(entity =>
        {
            entity.ToTable("StateProvince");

            entity.Property(e => e.Abbreviation).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.StateProvinces)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_StateProvince_CountryId_Country_Id");
        });

        modelBuilder.Entity<StockQuantityHistory>(entity =>
        {
            entity.ToTable("StockQuantityHistory");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Product).WithMany(p => p.StockQuantityHistories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_StockQuantityHistory_ProductId_Product_Id");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.ToTable("Store");

            entity.Property(e => e.CompanyAddress).HasMaxLength(1000);
            entity.Property(e => e.CompanyName).HasMaxLength(1000);
            entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);
            entity.Property(e => e.CompanyVat).HasMaxLength(1000);
            entity.Property(e => e.Hosts).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.Url).HasMaxLength(400);
        });

        modelBuilder.Entity<StoreMapping>(entity =>
        {
            entity.ToTable("StoreMapping");

            entity.Property(e => e.EntityName).HasMaxLength(400);

            entity.HasOne(d => d.Store).WithMany(p => p.StoreMappings)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_StoreMapping_StoreId_Store_Id");
        });

        modelBuilder.Entity<StorePickupPoint>(entity =>
        {
            entity.ToTable("StorePickupPoint");

            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PickupFee).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<TaxCategory>(entity =>
        {
            entity.ToTable("TaxCategory");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.ToTable("TaxRate");

            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<TaxTransactionLog>(entity =>
        {
            entity.ToTable("TaxTransactionLog");

            entity.Property(e => e.CreatedDateUtc).HasPrecision(6);
        });

        modelBuilder.Entity<TestTable>(entity =>
        {
            entity.ToTable("TestTable");

            entity.HasOne(d => d.Product).WithMany(p => p.TestTables)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_TestTable_ProductId_Product_Id");
        });

        modelBuilder.Entity<TierPrice>(entity =>
        {
            entity.ToTable("TierPrice");

            entity.Property(e => e.EndDateTimeUtc).HasPrecision(6);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StartDateTimeUtc).HasPrecision(6);

            entity.HasOne(d => d.CustomerRole).WithMany(p => p.TierPrices)
                .HasForeignKey(d => d.CustomerRoleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TierPrice_CustomerRoleId_CustomerRole_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.TierPrices)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_TierPrice_ProductId_Product_Id");
        });

        modelBuilder.Entity<TmpGuestsToDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_guestsToDelete");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.ToTable("Topic");
        });

        modelBuilder.Entity<TopicTemplate>(entity =>
        {
            entity.ToTable("TopicTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<UrlRecord>(entity =>
        {
            entity.ToTable("UrlRecord");

            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.ToTable("Vendor");

            entity.Property(e => e.Email).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTo).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VendorAttribute>(entity =>
        {
            entity.ToTable("VendorAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<VendorAttributeValue>(entity =>
        {
            entity.ToTable("VendorAttributeValue");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.VendorAttribute).WithMany(p => p.VendorAttributeValues)
                .HasForeignKey(d => d.VendorAttributeId)
                .HasConstraintName("FK_VendorAttributeValue_VendorAttributeId_VendorAttribute_Id");
        });

        modelBuilder.Entity<VendorNote>(entity =>
        {
            entity.ToTable("VendorNote");

            entity.Property(e => e.CreatedOnUtc).HasPrecision(6);

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorNotes)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_VendorNote_VendorId_Vendor_Id");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.ToTable("Video");

            entity.Property(e => e.VideoUrl).HasMaxLength(1000);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.ToTable("Warehouse");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<WidgetZone>(entity =>
        {
            entity.ToTable("WidgetZone");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.SystemName).HasMaxLength(200);
        });

        modelBuilder.Entity<WidgetZoneSlide>(entity =>
        {
            entity.ToTable("WidgetZoneSlide");

            entity.Property(e => e.OverrideDescription).HasMaxLength(255);

            entity.HasOne(d => d.Slide).WithMany(p => p.WidgetZoneSlides)
                .HasForeignKey(d => d.SlideId)
                .HasConstraintName("FK_WidgetZoneSlide_SlideId_Slide_Id");

            entity.HasOne(d => d.WidgetZone).WithMany(p => p.WidgetZoneSlides)
                .HasForeignKey(d => d.WidgetZoneId)
                .HasConstraintName("FK_WidgetZoneSlide_WidgetZoneId_WidgetZone_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
