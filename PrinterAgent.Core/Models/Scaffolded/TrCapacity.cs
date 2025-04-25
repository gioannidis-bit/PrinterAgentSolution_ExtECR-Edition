using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_Capacities")]
[Index("RestId", "Time", Name = "PK_TR_Capacities_Unique", IsUnique = true)]
public partial class TrCapacity
{
    /// <summary>
    /// Id Key Record
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// TR_Restaurants.Id
    /// </summary>
    public long RestId { get; set; }

    /// <summary>
    /// num of max customers
    /// </summary>
    public int Capacity { get; set; }

    /// <summary>
    /// 0:AllDay,1:Lunch,2:Dinner
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// Time ex: 23:30
    /// </summary>
    public TimeOnly Time { get; set; }

    [ForeignKey("RestId")]
    [InverseProperty("TrCapacities")]
    public virtual TrRestaurant Rest { get; set; } = null!;

    [InverseProperty("CapacityNavigation")]
    public virtual ICollection<TrOvewrittenCapacity> TrOvewrittenCapacities { get; set; } = new List<TrOvewrittenCapacity>();

    [InverseProperty("Capacity")]
    public virtual ICollection<TrReservation> TrReservations { get; set; } = new List<TrReservation>();
}
