using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_ReservationCustomers")]
public partial class TrReservationCustomer
{
    /// <summary>
    /// Id Record Key
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// Protel Profile Id
    /// </summary>
    public int ProtelId { get; set; }

    /// <summary>
    /// ProtelName (encrypted)
    /// </summary>
    public byte[] ProtelName { get; set; } = null!;

    /// <summary>
    /// Name given by the customer (encrypted)
    /// </summary>
    public byte[] ReservationName { get; set; } = null!;

    /// <summary>
    /// Room number
    /// </summary>
    [StringLength(10)]
    public string RoomNum { get; set; } = null!;

    /// <summary>
    /// email (encrypted)
    /// </summary>
    public byte[] Email { get; set; } = null!;

    /// <summary>
    /// TR_Reservations.Id
    /// </summary>
    public long ReservationId { get; set; }

    public long? HotelId { get; set; }

    [ForeignKey("HotelId")]
    [InverseProperty("TrReservationCustomers")]
    public virtual HotelInfo? Hotel { get; set; }

    [ForeignKey("ReservationId")]
    [InverseProperty("TrReservationCustomers")]
    public virtual TrReservation Reservation { get; set; } = null!;
}
