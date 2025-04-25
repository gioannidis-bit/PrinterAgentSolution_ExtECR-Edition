using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_Stores")]
public partial class DaStore
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    [StringLength(200)]
    public string? Title2 { get; set; }

    [StringLength(1500)]
    public string? Notes { get; set; }

    public int DeliveryTime { get; set; }

    public int TakeOutTime { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [StringLength(200)]
    public string? Description2 { get; set; }

    [StringLength(100)]
    public string? Doy { get; set; }

    [StringLength(20)]
    public string? VatNo { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? Phone1 { get; set; }

    [StringLength(20)]
    public string? Phone2 { get; set; }

    [StringLength(20)]
    public string? Fax { get; set; }

    public long? AddressId { get; set; }

    [StringLength(500)]
    public string? Image { get; set; }

    [StringLength(500)]
    public string? Thumbnail { get; set; }

    [StringLength(500)]
    public string WebApi { get; set; } = null!;

    public int PosId { get; set; }

    [StringLength(200)]
    public string StoreId { get; set; } = null!;

    public int PosStaffId { get; set; }

    [StringLength(50)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    public string Password { get; set; } = null!;

    public short StoreStatus { get; set; }

    [Column("RGB")]
    [StringLength(10)]
    public string? Rgb { get; set; }

    [StringLength(100)]
    public string? CronScheduler { get; set; }

    [Column("isAllowedToHaveCreditCard")]
    public bool? IsAllowedToHaveCreditCard { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextUpdate { get; set; }

    public int? PreparationTime { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("DaStores")]
    public virtual DaAddress? Address { get; set; }

    [InverseProperty("DaStore")]
    public virtual ICollection<BoDaPageSetStoreAssoc> BoDaPageSetStoreAssocs { get; set; } = new List<BoDaPageSetStoreAssoc>();

    [InverseProperty("Dastore")]
    public virtual ICollection<BoDaPriceListStoreAssoc> BoDaPriceListStoreAssocs { get; set; } = new List<BoDaPriceListStoreAssoc>();

    [InverseProperty("Dastore")]
    public virtual ICollection<BoDaProductStoreAssoc> BoDaProductStoreAssocs { get; set; } = new List<BoDaProductStoreAssoc>();

    [InverseProperty("Store")]
    public virtual ICollection<DaCustomerMessage> DaCustomerMessages { get; set; } = new List<DaCustomerMessage>();

    [InverseProperty("Store")]
    public virtual ICollection<DaGeoPolygon> DaGeoPolygons { get; set; } = new List<DaGeoPolygon>();

    [InverseProperty("Store")]
    public virtual ICollection<DaOrder> DaOrders { get; set; } = new List<DaOrder>();

    [InverseProperty("DaStore")]
    public virtual ICollection<DaPageSetStoreAssoc> DaPageSetStoreAssocs { get; set; } = new List<DaPageSetStoreAssoc>();

    [InverseProperty("Store")]
    public virtual ICollection<DaShortageProd> DaShortageProds { get; set; } = new List<DaShortageProd>();

    [InverseProperty("DaStore")]
    public virtual ICollection<DaStoresWoltAssoc> DaStoresWoltAssocs { get; set; } = new List<DaStoresWoltAssoc>();

    [InverseProperty("Dastore")]
    public virtual ICollection<DastorePriceListAssoc> DastorePriceListAssocs { get; set; } = new List<DastorePriceListAssoc>();
}
