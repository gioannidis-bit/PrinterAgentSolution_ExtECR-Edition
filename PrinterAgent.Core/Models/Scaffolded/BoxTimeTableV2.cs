using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BoxTimeTableV2")]
public partial class BoxTimeTableV2
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string? Day { get; set; }

    public bool? IsOpen { get; set; }

    public string? WorkingHours { get; set; }

    [Column("DA_StoreId")]
    public long? DaStoreId { get; set; }
}
