using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_ScheduledTaskes")]
public partial class DaScheduledTaske
{
    [Key]
    public long Id { get; set; }

    [Column("StoreFullURL")]
    [StringLength(2000)]
    public string StoreFullUrl { get; set; } = null!;

    public long TableId { get; set; }

    public long StoreId { get; set; }

    public int Action { get; set; }

    public int Short { get; set; }

    public int FaildNo { get; set; }
}
