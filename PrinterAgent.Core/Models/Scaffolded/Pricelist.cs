using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Pricelist")]
public partial class Pricelist
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public long? LookUpPriceListId { get; set; }

    public double? Percentage { get; set; }

    public byte? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeactivationDate { get; set; }

    public long? SalesTypeId { get; set; }

    public long? PricelistMasterId { get; set; }

    public bool? IsDeleted { get; set; }

    public short? Type { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [StringLength(80)]
    public string? PriceListTimezoneCode { get; set; }

    public bool? DefaultPriceList { get; set; }

    [InverseProperty("PriceList")]
    public virtual ICollection<AllowedMealsPerBoard> AllowedMealsPerBoards { get; set; } = new List<AllowedMealsPerBoard>();

    [InverseProperty("PriceList")]
    public virtual ICollection<BoDaPriceListStoreAssoc> BoDaPriceListStoreAssocs { get; set; } = new List<BoDaPriceListStoreAssoc>();

    [InverseProperty("PriceList")]
    public virtual ICollection<DastorePriceListAssoc> DastorePriceListAssocs { get; set; } = new List<DastorePriceListAssoc>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<PosInfoDetailPricelistAssoc> PosInfoDetailPricelistAssocs { get; set; } = new List<PosInfoDetailPricelistAssoc>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<PosInfoPricelistAssoc> PosInfoPricelistAssocs { get; set; } = new List<PosInfoPricelistAssoc>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<PriceListEffectiveHour> PriceListEffectiveHours { get; set; } = new List<PriceListEffectiveHour>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<PricelistDetail> PricelistDetails { get; set; } = new List<PricelistDetail>();

    [ForeignKey("PricelistMasterId")]
    [InverseProperty("Pricelists")]
    public virtual PricelistMaster? PricelistMaster { get; set; }

    [InverseProperty("Pricelist")]
    public virtual ICollection<PromotionsPricelist> PromotionsPricelists { get; set; } = new List<PromotionsPricelist>();

    [InverseProperty("PriceList")]
    public virtual ICollection<RegionLockerProduct> RegionLockerProducts { get; set; } = new List<RegionLockerProduct>();

    [InverseProperty("PriceList")]
    public virtual ICollection<TransferMapping> TransferMappings { get; set; } = new List<TransferMapping>();
}
