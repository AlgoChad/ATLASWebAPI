using ATLASWepAPI.Models.Entities;

namespace ATLASWepAPI.Models.DataTransferObjects
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public string CustomOrderNumber { get; set; } = null!;

        public List<OrderItem> OrderItems { get; set; } = null!;

        public List<OrderNote> OrderNotes { get; set; } = null!;

        public class OrderItem
        {
            public int Id { get; set; }

            public int OrderId { get; set; }

            public int ProductId { get; set; }

            public Guid OrderItemGuid { get; set; }

            public int Quantity { get; set; }

            public decimal UnitPriceInclTax { get; set; }

            public decimal UnitPriceExclTax { get; set; }

            public decimal PriceInclTax { get; set; }

            public decimal PriceExclTax { get; set; }

            public decimal DiscountAmountInclTax { get; set; }

            public decimal DiscountAmountExclTax { get; set; }

            public decimal OriginalProductCost { get; set; }

            public string? AttributeDescription { get; set; }

            public string? AttributesXml { get; set; }

            public int DownloadCount { get; set; }

            public bool IsDownloadActivated { get; set; }

            public int? LicenseDownloadId { get; set; }

            public decimal? ItemWeight { get; set; }

            public DateTime? RentalStartDateUtc { get; set; }

            public DateTime? RentalEndDateUtc { get; set; }

            public int? MagentoOrderItemId { get; set; }
        }

        public class OrderNote
        {
            public int Id { get; set; }

            public string Note { get; set; } = null!;

            public int OrderId { get; set; }

            public int DownloadId { get; set; }

            public bool DisplayToCustomer { get; set; }

            public DateTime CreatedOnUtc { get; set; }
        }
    }
}
