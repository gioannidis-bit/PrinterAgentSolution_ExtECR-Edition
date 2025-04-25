using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("HotelCustomerDataConfig")]
public partial class HotelCustomerDataConfig
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string? Property { get; set; }

    [StringLength(100)]
    public string? FieldType { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    public int? Priority { get; set; }
}
