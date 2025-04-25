using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_PageSetStoreAssoc")]
public partial class DaPageSetStoreAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PageSetId { get; set; }

    [Column("DA_StoreId")]
    public long? DaStoreId { get; set; }

    [ForeignKey("DaStoreId")]
    [InverseProperty("DaPageSetStoreAssocs")]
    public virtual DaStore? DaStore { get; set; }

    [ForeignKey("PageSetId")]
    [InverseProperty("DaPageSetStoreAssocs")]
    public virtual PageSet? PageSet { get; set; }
}
