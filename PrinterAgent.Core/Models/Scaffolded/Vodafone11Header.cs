using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Vodafone11Header
{
    [Key]
    public long Id { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public int? FromItems { get; set; }

    public int? RemoveItems { get; set; }
}
