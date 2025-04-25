using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_StoresWoltAssoc")]
public partial class DaStoresWoltAssoc
{
    [Key]
    public long Id { get; set; }

    [Column("DA_StoreId")]
    public long? DaStoreId { get; set; }

    [StringLength(500)]
    public string? ExtVenueId { get; set; }

    [StringLength(500)]
    public string? WoltApiKey { get; set; }

    [StringLength(500)]
    public string? DriveVenueId { get; set; }

    [ForeignKey("DaStoreId")]
    [InverseProperty("DaStoresWoltAssocs")]
    public virtual DaStore? DaStore { get; set; }
}
