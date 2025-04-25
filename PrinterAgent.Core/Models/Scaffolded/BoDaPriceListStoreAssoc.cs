using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_DA_PriceListStoreAssoc")]
public partial class BoDaPriceListStoreAssoc
{
    [Key]
    public long Id { get; set; }

    public long PriceListId { get; set; }

    [Column("DAStoreId")]
    public long DastoreId { get; set; }

    [ForeignKey("DastoreId")]
    [InverseProperty("BoDaPriceListStoreAssocs")]
    public virtual DaStore Dastore { get; set; } = null!;

    [ForeignKey("PriceListId")]
    [InverseProperty("BoDaPriceListStoreAssocs")]
    public virtual Pricelist PriceList { get; set; } = null!;
}
