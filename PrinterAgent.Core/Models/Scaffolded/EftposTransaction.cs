using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EFTPosTransactions")]
public partial class EftposTransaction
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ReceiptNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Result { get; set; }

    public long? ProvideOrigin { get; set; }

    public bool? EftIsPreloaded { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? StaffId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PosInfoId { get; set; }

    public bool? IsVoided { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }
}
