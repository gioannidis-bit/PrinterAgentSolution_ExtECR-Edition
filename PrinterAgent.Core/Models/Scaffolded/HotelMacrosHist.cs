using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("HotelMacros_Hist")]
public partial class HotelMacrosHist
{
    [Key]
    [Column("hisId")]
    public long HisId { get; set; }

    public Guid? Id { get; set; }

    [Column(TypeName = "text")]
    public string? Model { get; set; }
}
