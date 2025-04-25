using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_DA_ProductStoreAssoc")]
public partial class BoDaProductStoreAssoc
{
    [Key]
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long PageSetId { get; set; }

    [Column("DAStoreId")]
    public long DastoreId { get; set; }

    [ForeignKey("DastoreId")]
    [InverseProperty("BoDaProductStoreAssocs")]
    public virtual DaStore Dastore { get; set; } = null!;

    [ForeignKey("PageSetId")]
    [InverseProperty("BoDaProductStoreAssocs")]
    public virtual PageSet PageSet { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("BoDaProductStoreAssocs")]
    public virtual Product Product { get; set; } = null!;
}
