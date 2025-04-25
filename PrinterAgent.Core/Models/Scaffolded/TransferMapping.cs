using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class TransferMapping
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string? PmsDepartmentId { get; set; }

    [StringLength(250)]
    public string? PmsDepDescription { get; set; }

    public long? ProductId { get; set; }

    public long? SalesTypeId { get; set; }

    public double? VatPercentage { get; set; }

    public long? PosDepartmentId { get; set; }

    public long? PriceListId { get; set; }

    public int? VatCode { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? HotelId { get; set; }

    [StringLength(100)]
    public string? TipsPmsDepartmentId { get; set; }

    [ForeignKey("PosDepartmentId")]
    [InverseProperty("TransferMappings")]
    public virtual Department? PosDepartment { get; set; }

    [ForeignKey("PriceListId")]
    [InverseProperty("TransferMappings")]
    public virtual Pricelist? PriceList { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("TransferMappings")]
    public virtual Product? Product { get; set; }

    [ForeignKey("ProductCategoryId")]
    [InverseProperty("TransferMappings")]
    public virtual ProductCategory? ProductCategory { get; set; }

    [ForeignKey("SalesTypeId")]
    [InverseProperty("TransferMappings")]
    public virtual SalesType? SalesType { get; set; }

    [InverseProperty("TransferMappings")]
    public virtual ICollection<TransferMappingDetail> TransferMappingDetails { get; set; } = new List<TransferMappingDetail>();
}
