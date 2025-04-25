using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_LoyalPoints")]
public partial class DaLoyalPoint
{
    [Key]
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public int Points { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    public long OrderId { get; set; }

    public long StoreId { get; set; }

    public long? StaffId { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }

    public int? AvailablePoints { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DaLoyalPoints")]
    public virtual DaCustomer Customer { get; set; } = null!;

    [ForeignKey("StaffId")]
    [InverseProperty("DaLoyalPoints")]
    public virtual Staff? Staff { get; set; }
}
