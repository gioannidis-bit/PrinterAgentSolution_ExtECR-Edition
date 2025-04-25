using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("DeliveryRoutingHist")]
public partial class DeliveryRoutingHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Orders { get; set; }

    public long? StaffId { get; set; }

    [StringLength(150)]
    public string? StaffName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssignDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AcceptDate { get; set; }

    public string? RejectedNames { get; set; }

    public int? Status { get; set; }

    public int? AssignStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    public bool? Failure3th { get; set; }
}
