using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class OnlineRegistrationView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    [StringLength(300)]
    public string BarCode { get; set; } = null!;

    [StringLength(100)]
    public string FirtName { get; set; } = null!;

    [StringLength(100)]
    public string LastName { get; set; } = null!;

    [StringLength(100)]
    public string Mobile { get; set; } = null!;

    public int Dates { get; set; }

    public int Children { get; set; }

    public int Adults { get; set; }

    public int PaymentType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ChildTicket { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AdultTicket { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDate { get; set; }

    public int TotalChildren { get; set; }

    public int TotalAdults { get; set; }

    public int ChildrenEntered { get; set; }

    public int AdultsEntered { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RemainingAmount { get; set; }

    public int Status { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(80)]
    public string? OrderNumber { get; set; }

    public bool? Gdpr { get; set; }

    [Column("isAnonymized")]
    public bool? IsAnonymized { get; set; }
}
