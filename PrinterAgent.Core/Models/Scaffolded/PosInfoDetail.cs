using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfoDetail")]
public partial class PosInfoDetail
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? Counter { get; set; }

    [StringLength(50)]
    public string? Abbreviation { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public bool? ResetsAfterEod { get; set; }

    public short? InvoiceId { get; set; }

    [StringLength(250)]
    public string? ButtonDescription { get; set; }

    public short? Status { get; set; }

    public bool? CreateTransaction { get; set; }

    public byte? FiscalType { get; set; }

    public bool? IsInvoice { get; set; }

    public bool? IsCancel { get; set; }

    public int? GroupId { get; set; }

    public long? InvoicesTypeId { get; set; }

    public bool? IsPdaHidden { get; set; }

    public bool? IsDeleted { get; set; }

    public short? SendsVoidToKitchen { get; set; }

    [Column("PMSInvoiceId")]
    public long? PmsinvoiceId { get; set; }

    [StringLength(25)]
    public string? Background { get; set; }

    [StringLength(25)]
    public string? Color { get; set; }

    [StringLength(50)]
    public string? InvoiceSeries { get; set; }

    public bool? IsPreloadToEft { get; set; }

    [ForeignKey("InvoicesTypeId")]
    [InverseProperty("PosInfoDetails")]
    public virtual InvoiceType? InvoicesType { get; set; }

    [InverseProperty("PosInfoDetail")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [ForeignKey("PosInfoId")]
    [InverseProperty("PosInfoDetails")]
    public virtual PosInfo? PosInfo { get; set; }

    [InverseProperty("PosInfoDetail")]
    public virtual ICollection<PosInfoDetailExcludedAccount> PosInfoDetailExcludedAccounts { get; set; } = new List<PosInfoDetailExcludedAccount>();

    [InverseProperty("PosInfoDetail")]
    public virtual ICollection<PosInfoDetailPricelistAssoc> PosInfoDetailPricelistAssocs { get; set; } = new List<PosInfoDetailPricelistAssoc>();
}
