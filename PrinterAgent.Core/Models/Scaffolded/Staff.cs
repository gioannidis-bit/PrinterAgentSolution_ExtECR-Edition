using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Staff
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(500)]
    public string? ImageUri { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(250)]
    public string? Identification { get; set; }

    [Column("DASTORE")]
    public long? Dastore { get; set; }

    public bool? IsOnRoad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StatusTimeChanged { get; set; }

    [Column("isAdmin")]
    public bool? IsAdmin { get; set; }

    public bool? LogInAfterOrder { get; set; }

    public bool? AllowReporting { get; set; }

    [Column("isAssignedToRoute")]
    public bool? IsAssignedToRoute { get; set; }

    [InverseProperty("Staff")]
    public virtual ICollection<AssignedPosition> AssignedPositions { get; set; } = new List<AssignedPosition>();

    [InverseProperty("Staff")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [InverseProperty("Staff")]
    public virtual ICollection<DaLoyalPoint> DaLoyalPoints { get; set; } = new List<DaLoyalPoint>();

    [InverseProperty("Staff")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("Staff")]
    public virtual ICollection<MealConsumption> MealConsumptions { get; set; } = new List<MealConsumption>();

    [InverseProperty("Staff")]
    public virtual ICollection<OrderDetailInvoice> OrderDetailInvoices { get; set; } = new List<OrderDetailInvoice>();

    [InverseProperty("LoginStaff")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("Staff")]
    public virtual ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

    [InverseProperty("Staff")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty("Staff")]
    public virtual ICollection<OrdersStaff> OrdersStaffs { get; set; } = new List<OrdersStaff>();

    [InverseProperty("Staff")]
    public virtual ICollection<Payrole> Payroles { get; set; } = new List<Payrole>();

    [InverseProperty("Staff")]
    public virtual ICollection<PayrollNew> PayrollNews { get; set; } = new List<PayrollNew>();

    [InverseProperty("Staff")]
    public virtual ICollection<StaffAuthorization> StaffAuthorizations { get; set; } = new List<StaffAuthorization>();

    [InverseProperty("Staff")]
    public virtual ICollection<StaffCash> StaffCashes { get; set; } = new List<StaffCash>();

    [InverseProperty("Staff")]
    public virtual ICollection<StaffSecheduleDetail> StaffSecheduleDetails { get; set; } = new List<StaffSecheduleDetail>();

    [InverseProperty("Staff")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("Staff")]
    public virtual ICollection<WorkSheet> WorkSheets { get; set; } = new List<WorkSheet>();
}
