using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ExternalStateMatch")]
public partial class ExternalStateMatch
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    public long? Status { get; set; }

    public int? ExtType { get; set; }

    public int? MatchValue { get; set; }
}
