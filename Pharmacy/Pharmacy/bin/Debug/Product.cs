namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ReceiptItems = new HashSet<ReceiptItem>();
        }

        public Product(Product product)
        {
            this.Name = product.Name;
            this.Quantity = product.Quantity;
            this.ManufacturerId = product.ManufacturerId;
            this.Description = product.Description;
            this.PriceId = product.PriceId;
            this.IsDeleted = IsDeleted;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Quantity { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? ManufacturerId { get; set; }

        public int? PriceId { get; set; }

        [DefaultValue((byte)0)]
        public byte? IsDeleted { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Price Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}
