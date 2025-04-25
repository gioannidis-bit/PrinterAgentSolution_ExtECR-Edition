using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class ProductCategory
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public byte? Type { get; set; }

    public byte? Status { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    public long? CategoryId { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [StringLength(25)]
    public string? Background { get; set; }

    [InverseProperty("ProductCategory")]
    public virtual ICollection<AllowedMealsPerBoardDetail> AllowedMealsPerBoardDetails { get; set; } = new List<AllowedMealsPerBoardDetail>();

    [ForeignKey("CategoryId")]
    [InverseProperty("ProductCategories")]
    public virtual Category? Category { get; set; }

    [InverseProperty("ProdCategory")]
    public virtual ICollection<DaLoyalRedeemFreeProduct> DaLoyalRedeemFreeProducts { get; set; } = new List<DaLoyalRedeemFreeProduct>();

    [InverseProperty("ProductCategory")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    [InverseProperty("ProductCategory")]
    public virtual ICollection<TransferMapping> TransferMappings { get; set; } = new List<TransferMapping>();
}
