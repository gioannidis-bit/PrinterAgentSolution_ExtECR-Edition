using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_DA_PageSetStoreAssoc")]
public partial class BoDaPageSetStoreAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PageSetId { get; set; }

    [Column("DA_StoreId")]
    public long? DaStoreId { get; set; }

    [ForeignKey("DaStoreId")]
    [InverseProperty("BoDaPageSetStoreAssocs")]
    public virtual DaStore? DaStore { get; set; }

    [ForeignKey("PageSetId")]
    [InverseProperty("BoDaPageSetStoreAssocs")]
    public virtual PageSet? PageSet { get; set; }
}
