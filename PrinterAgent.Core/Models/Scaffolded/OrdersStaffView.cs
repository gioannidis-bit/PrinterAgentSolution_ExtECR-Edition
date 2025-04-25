using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class OrdersStaffView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public long? StaffId { get; set; }

    public long? OrderId { get; set; }

    public byte? Type { get; set; }
}
