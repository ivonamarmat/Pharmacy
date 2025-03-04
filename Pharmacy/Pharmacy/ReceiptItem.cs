namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptItem")]
    public partial class ReceiptItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiptItemId { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

       
        [DefaultValue((byte)0)]
        public byte? IsDeleted { get; set; }

        public virtual Product Product { get; set; }

        
    }
}
