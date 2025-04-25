using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Product")]
public partial class Product
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? ExtraDescription { get; set; }

    [StringLength(500)]
    public string? SalesDescription { get; set; }

    public double? Qty { get; set; }

    public long? UnitId { get; set; }

    public int? PreparationTime { get; set; }

    public long? KdsId { get; set; }

    public long? KitchenId { get; set; }

    [StringLength(500)]
    public string? ImageUri { get; set; }

    public long? ProductCategoryId { get; set; }

    [StringLength(150)]
    public string? Code { get; set; }

    public bool? IsCustom { get; set; }

    public long? KitchenRegionId { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsCombo { get; set; }

    public bool? IsComboItem { get; set; }

    public bool? IsReturnItem { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public bool? PopNote { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<BoDaProductStoreAssoc> BoDaProductStoreAssocs { get; set; } = new List<BoDaProductStoreAssoc>();

    [InverseProperty("Product")]
    public virtual ICollection<BoardMeal> BoardMeals { get; set; } = new List<BoardMeal>();

    [InverseProperty("ProductComboItem")]
    public virtual ICollection<ComboDetail> ComboDetails { get; set; } = new List<ComboDetail>();

    [InverseProperty("ProductCombo")]
    public virtual ICollection<Combo> Combos { get; set; } = new List<Combo>();

    [InverseProperty("Product")]
    public virtual ICollection<DaLoyalRedeemFreeProduct> DaLoyalRedeemFreeProducts { get; set; } = new List<DaLoyalRedeemFreeProduct>();

    [InverseProperty("Product")]
    public virtual ICollection<DaOrderDetail> DaOrderDetails { get; set; } = new List<DaOrderDetail>();

    [InverseProperty("Product")]
    public virtual ICollection<DaShortageProd> DaShortageProds { get; set; } = new List<DaShortageProd>();

    [InverseProperty("Product")]
    public virtual ICollection<EnvironmentalFee> EnvironmentalFees { get; set; } = new List<EnvironmentalFee>();

    [InverseProperty("Product")]
    public virtual ICollection<ExternalProductMapping> ExternalProductMappings { get; set; } = new List<ExternalProductMapping>();

    [ForeignKey("KdsId")]
    [InverseProperty("Products")]
    public virtual Kd? Kds { get; set; }

    [ForeignKey("KitchenId")]
    [InverseProperty("Products")]
    public virtual Kitchen? Kitchen { get; set; }

    [ForeignKey("KitchenRegionId")]
    [InverseProperty("Products")]
    public virtual KitchenRegion? KitchenRegion { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("Product")]
    public virtual ICollection<PageButton> PageButtons { get; set; } = new List<PageButton>();

    [InverseProperty("Product")]
    public virtual ICollection<PricelistDetail> PricelistDetails { get; set; } = new List<PricelistDetail>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; } = new List<ProductBarcode>();

    [ForeignKey("ProductCategoryId")]
    [InverseProperty("Products")]
    public virtual ProductCategory? ProductCategory { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<ProductExtra> ProductExtras { get; set; } = new List<ProductExtra>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductForBarcodeEod> ProductForBarcodeEods { get; set; } = new List<ProductForBarcodeEod>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductRecipe> ProductRecipes { get; set; } = new List<ProductRecipe>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductsForEod> ProductsForEods { get; set; } = new List<ProductsForEod>();

    [InverseProperty("Product")]
    public virtual ICollection<Quantity> Quantities { get; set; } = new List<Quantity>();

    [InverseProperty("Product")]
    public virtual ICollection<RegionLockerProduct> RegionLockerProducts { get; set; } = new List<RegionLockerProduct>();

    [InverseProperty("Product")]
    public virtual ICollection<TransferMapping> TransferMappings { get; set; } = new List<TransferMapping>();

    [ForeignKey("UnitId")]
    [InverseProperty("Products")]
    public virtual Unit? Unit { get; set; }
}
