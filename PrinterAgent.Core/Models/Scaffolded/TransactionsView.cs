using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class TransactionsView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Day { get; set; }

    public long? PosInfoId { get; set; }

    public long? StaffId { get; set; }

    public long? OrderId { get; set; }

    public short? TransactionType { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public long? DepartmentId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public long? AccountId { get; set; }

    public short? InOut { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Vat { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Tax { get; set; }

    public long? EndOfDayId { get; set; }

    [StringLength(500)]
    public string? ExtDescription { get; set; }

    public long? InvoicesId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? SupplierId { get; set; }
}
