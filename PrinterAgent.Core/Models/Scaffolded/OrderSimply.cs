using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class OrderSimply
{
    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? StoreName { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? StoreNumber { get; set; }

    public int? TotalOrders { get; set; }

    public int CallCenterOrders { get; set; }

    public int WebOrders { get; set; }

    [Column("EFoodOrders")]
    public int EfoodOrders { get; set; }

    public int DeliverasOrders { get; set; }

    [Column("EKlicOrders")]
    public int EklicOrders { get; set; }
}
