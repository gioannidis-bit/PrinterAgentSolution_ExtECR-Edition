using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewDispatchPoint
{
    [Column("orderDay", TypeName = "datetime")]
    public DateTime? OrderDay { get; set; }

    public long EndOfDayId { get; set; }

    public int? Twenty { get; set; }

    public int? TwentyFive { get; set; }

    public int? Thirty { get; set; }

    public int? Forty { get; set; }

    public int? Fifty { get; set; }

    public int? FiftyPlus { get; set; }

    public int? TotalOrders { get; set; }

    public int? TwentyPoints { get; set; }

    public int? TwentyFivePoints { get; set; }

    public int? ThirtyPoints { get; set; }

    public int? FortyPoints { get; set; }

    public int? FiftyPoints { get; set; }

    public int? FiftyPlusPoints { get; set; }

    public double? Pst { get; set; }
}
