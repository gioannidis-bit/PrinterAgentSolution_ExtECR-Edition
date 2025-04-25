using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("Loyalty_Hist")]
public partial class LoyaltyHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

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
    public string? Channel { get; set; }

    public long? InvoicesId { get; set; }

    [Column(TypeName = "text")]
    public string? ErrorDescription { get; set; }

    [StringLength(50)]
    public string? GiftCardCouponType { get; set; }

    [StringLength(50)]
    public string? GiftCardCampaign { get; set; }

    [Column("DAOrderId")]
    public long? DaorderId { get; set; }
}
