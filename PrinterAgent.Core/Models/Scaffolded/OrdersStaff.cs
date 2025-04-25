using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrdersStaff")]
public partial class OrdersStaff
{
    [Key]
    public long Id { get; set; }

    public long? StaffId { get; set; }

    public long? OrderId { get; set; }

    public byte? Type { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrdersStaffs")]
    public virtual Order? Order { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("OrdersStaffs")]
    public virtual Staff? Staff { get; set; }
}
