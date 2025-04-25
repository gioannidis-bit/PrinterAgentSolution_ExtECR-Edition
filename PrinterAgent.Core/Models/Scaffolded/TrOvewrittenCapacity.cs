using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_OvewrittenCapacities")]
public partial class TrOvewrittenCapacity
{
    /// <summary>
    /// Id Record key
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// TR_Restaurants.Id
    /// </summary>
    public long RestId { get; set; }

    /// <summary>
    /// TR_Capacities.Id
    /// </summary>
    public long CapacityId { get; set; }

    /// <summary>
    /// num of max customers
    /// </summary>
    public int Capacity { get; set; }

    /// <summary>
    /// Date of overwrite
    /// </summary>
    public DateOnly Date { get; set; }

    [ForeignKey("CapacityId")]
    [InverseProperty("TrOvewrittenCapacities")]
    public virtual TrCapacity CapacityNavigation { get; set; } = null!;

    [ForeignKey("RestId")]
    [InverseProperty("TrOvewrittenCapacities")]
    public virtual TrRestaurant Rest { get; set; } = null!;
}
