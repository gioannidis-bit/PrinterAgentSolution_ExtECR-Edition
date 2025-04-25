using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Loyalty")]
public partial class Loyalty
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Day { get; set; }

    [StringLength(50)]
    public string? LoyalltyId { get; set; }

    [StringLength(50)]
    public string? CouponCode { get; set; }

    [StringLength(50)]
    public string? GiftcardCode { get; set; }

    [StringLength(50)]
    public string? CouponType { get; set; }

    [StringLength(50)]
    public string? Campaign { get; set; }

    [StringLength(50)]
    public string Channel { get; set; } = null!;

    public long? InvoicesId { get; set; }

    [Column(TypeName = "text")]
    public string? ErrorDescription { get; set; }

    [StringLength(50)]
    public string? GiftCardCouponType { get; set; }

    [StringLength(50)]
    public string? GiftCardCampaign { get; set; }

    [Column("DAOrderId")]
    public long? DaorderId { get; set; }

    [ForeignKey("DaorderId")]
    [InverseProperty("Loyalties")]
    public virtual DaOrder? Daorder { get; set; }

    [ForeignKey("InvoicesId")]
    [InverseProperty("Loyalties")]
    public virtual Invoice? Invoices { get; set; }
}
