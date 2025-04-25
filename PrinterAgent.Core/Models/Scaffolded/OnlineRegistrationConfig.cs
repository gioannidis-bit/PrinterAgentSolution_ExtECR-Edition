using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OnlineRegistrationConfig")]
public partial class OnlineRegistrationConfig
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DefaultAdult { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DefaultChild { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Year { get; set; }
}
