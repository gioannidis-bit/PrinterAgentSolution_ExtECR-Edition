using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_Reservations")]
[Index("RestId", "ReservationDate", "ReservationTime", "Status", Name = "PK_TR_Reservations_index1")]
public partial class TrReservation
{
    /// <summary>
    /// Id record key
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
    /// Num of people
    /// </summary>
    public int Couver { get; set; }

    /// <summary>
    /// Reservation Date
    /// </summary>
    public DateOnly ReservationDate { get; set; }

    /// <summary>
    /// TR_Capacities.Time
    /// </summary>
    public TimeOnly ReservationTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// 0: Active, 1: Cancel
    /// </summary>
    public int Status { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [ForeignKey("CapacityId")]
    [InverseProperty("TrReservations")]
    public virtual TrCapacity Capacity { get; set; } = null!;

    [InverseProperty("Reservation")]
    public virtual ICollection<TrReservationCustomer> TrReservationCustomers { get; set; } = new List<TrReservationCustomer>();
}
