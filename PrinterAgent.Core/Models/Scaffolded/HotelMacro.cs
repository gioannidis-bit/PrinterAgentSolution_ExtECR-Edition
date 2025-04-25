using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class HotelMacro
{
    [Key]
    public Guid Id { get; set; }

    [Column(TypeName = "text")]
    public string? Model { get; set; }

    [InverseProperty("MacroGuid")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
