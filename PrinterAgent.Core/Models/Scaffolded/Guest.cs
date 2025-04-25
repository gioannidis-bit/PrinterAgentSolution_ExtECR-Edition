using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Guest")]
public partial class Guest
{
    [Key]
    public long Id { get; set; }

    [Column("arrivalDT", TypeName = "datetime")]
    public DateTime? ArrivalDt { get; set; }

    [Column("departureDT", TypeName = "datetime")]
    public DateTime? DepartureDt { get; set; }

    [Column("birthdayDT", TypeName = "datetime")]
    public DateTime? BirthdayDt { get; set; }

    [StringLength(150)]
    public string? Room { get; set; }

    public int? RoomId { get; set; }

    [StringLength(50)]
    public string? Arrival { get; set; }

    [StringLength(50)]
    public string? Departure { get; set; }

    [StringLength(150)]
    public string? ReservationCode { get; set; }

    public int? ProfileNo { get; set; }

    [StringLength(150)]
    public string? FirstName { get; set; }

    [StringLength(150)]
    public string? LastName { get; set; }

    [StringLength(150)]
    public string? Member { get; set; }

    [StringLength(150)]
    public string? Password { get; set; }

    [StringLength(550)]
    public string? Address { get; set; }

    [StringLength(550)]
    public string? City { get; set; }

    [StringLength(150)]
    public string? PostalCode { get; set; }

    [StringLength(150)]
    public string? Country { get; set; }

    [StringLength(150)]
    public string? Birthday { get; set; }

    [StringLength(550)]
    public string? Email { get; set; }

    [StringLength(150)]
    public string? Telephone { get; set; }

    [Column("VIP")]
    [StringLength(550)]
    public string? Vip { get; set; }

    public string? Benefits { get; set; }

    [StringLength(150)]
    public string? NationalityCode { get; set; }

    [StringLength(150)]
    public string? ConfirmationCode { get; set; }

    public int? Type { get; set; }

    [StringLength(150)]
    public string? Title { get; set; }

    public int? Adults { get; set; }

    public int? Children { get; set; }

    [StringLength(150)]
    public string? BoardCode { get; set; }

    [StringLength(150)]
    public string? BoardName { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }

    public int? ReservationId { get; set; }

    public bool? IsSharer { get; set; }

    public long? HotelId { get; set; }

    public int? ClassId { get; set; }

    [StringLength(100)]
    public string? ClassName { get; set; }

    public int? AvailablePoints { get; set; }

    [Column("fnbdiscount")]
    public int? Fnbdiscount { get; set; }

    [Column("ratebuy")]
    public int? Ratebuy { get; set; }

    public int? DaId { get; set; }

    public int? NoPos { get; set; }

    [InverseProperty("Guest")]
    public virtual ICollection<InvoiceGuestsTran> InvoiceGuestsTrans { get; set; } = new List<InvoiceGuestsTran>();

    [InverseProperty("Guest")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("Guest")]
    public virtual ICollection<MealConsumption> MealConsumptions { get; set; } = new List<MealConsumption>();

    [InverseProperty("Guest")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("Guest")]
    public virtual ICollection<PdaSurveyAnswer> PdaSurveyAnswers { get; set; } = new List<PdaSurveyAnswer>();

    [InverseProperty("Guest")]
    public virtual ICollection<TablePaySuggestion> TablePaySuggestions { get; set; } = new List<TablePaySuggestion>();
}
