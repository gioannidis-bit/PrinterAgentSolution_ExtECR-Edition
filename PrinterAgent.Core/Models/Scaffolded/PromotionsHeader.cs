using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Promotions_Headers")]
public partial class PromotionsHeader
{
    [Key]
    public long Id { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [StringLength(100)]
    public string? Code { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Discount { get; set; }

    public bool? AskOperator { get; set; }

    [StringLength(1000)]
    public string? ReceiptNote { get; set; }

    public int? DiscountType { get; set; }

    public bool? AskCode { get; set; }

    public bool IsDeleted { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("Header")]
    public virtual ICollection<PromotionsCombo> PromotionsCombos { get; set; } = new List<PromotionsCombo>();

    [InverseProperty("Header")]
    public virtual ICollection<PromotionsDiscount> PromotionsDiscounts { get; set; } = new List<PromotionsDiscount>();
}
