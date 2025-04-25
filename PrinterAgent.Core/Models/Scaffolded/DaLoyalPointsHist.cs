using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("DA_LoyalPoints_Hist")]
public partial class DaLoyalPointsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? CustomerId { get; set; }

    public int? Points { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public long? OrderId { get; set; }

    public long? StoreId { get; set; }

    public long? StaffId { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }

    public int? AvailablePoints { get; set; }
}
