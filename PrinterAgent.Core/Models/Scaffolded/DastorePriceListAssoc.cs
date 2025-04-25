using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DAStore_PriceListAssoc")]
public partial class DastorePriceListAssoc
{
    [Key]
    public long Id { get; set; }

    public long PriceListId { get; set; }

    [Column("DAStoreId")]
    public long DastoreId { get; set; }

    public int PriceListType { get; set; }

    [ForeignKey("DastoreId")]
    [InverseProperty("DastorePriceListAssocs")]
    public virtual DaStore Dastore { get; set; } = null!;

    [ForeignKey("PriceListId")]
    [InverseProperty("DastorePriceListAssocs")]
    public virtual Pricelist PriceList { get; set; } = null!;
}
