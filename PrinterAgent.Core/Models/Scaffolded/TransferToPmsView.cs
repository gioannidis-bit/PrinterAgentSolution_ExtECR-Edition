using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class TransferToPmsView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    [StringLength(150)]
    public string? RegNo { get; set; }

    [StringLength(100)]
    public string? PmsDepartmentId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(150)]
    public string? ProfileId { get; set; }

    [StringLength(150)]
    public string? ProfileName { get; set; }

    public long? TransactionId { get; set; }

    public short? TransferType { get; set; }

    [StringLength(50)]
    public string? RoomId { get; set; }

    [StringLength(150)]
    public string? RoomDescription { get; set; }

    [StringLength(50)]
    public string? ReceiptNo { get; set; }

    public long? PosInfoDetailId { get; set; }

    [Column("SendToPMS")]
    public bool? SendToPms { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Total { get; set; }

    [Column("SendToPmsTS", TypeName = "datetime")]
    public DateTime? SendToPmsTs { get; set; }

    [StringLength(1000)]
    public string? ErrorMessage { get; set; }

    [StringLength(150)]
    public string? PmsResponseId { get; set; }

    public Guid? TransferIdentifier { get; set; }

    [StringLength(300)]
    public string? PmsDepartmentDescription { get; set; }

    public short? Status { get; set; }

    public long? PosInfoId { get; set; }

    public long? EndOfDayId { get; set; }

    public long? HotelId { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Points { get; set; }

    [Column("PMSPaymentId")]
    public long? PmspaymentId { get; set; }

    [Column("PMSInvoiceId")]
    public long? PmsinvoiceId { get; set; }
}
