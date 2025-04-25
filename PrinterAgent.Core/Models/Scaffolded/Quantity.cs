using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Quantity
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    public long? PosId { get; set; }

    public long? Qty { get; set; }

    [ForeignKey("PosId")]
    [InverseProperty("Quantities")]
    public virtual PosInfo? Pos { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("Quantities")]
    public virtual Product? Product { get; set; }
}
