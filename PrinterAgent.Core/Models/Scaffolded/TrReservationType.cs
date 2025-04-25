using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_ReservationTypes")]
public partial class TrReservationType
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string Description { get; set; } = null!;

    public int Type { get; set; }
}
