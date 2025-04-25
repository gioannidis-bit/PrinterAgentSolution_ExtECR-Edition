using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Timezone
{
    [Key]
    public long Id { get; set; }

    public long? PosId { get; set; }

    [StringLength(150)]
    public string? Code { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }
}
