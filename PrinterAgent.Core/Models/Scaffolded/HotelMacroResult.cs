using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class HotelMacroResult
{
    [Key]
    public Guid Id { get; set; }

    [Column(TypeName = "text")]
    public string? Model { get; set; }
}
