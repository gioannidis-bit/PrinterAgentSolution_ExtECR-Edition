using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Pda_SurveyAnswer")]
public partial class PdaSurveyAnswer
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? HotelInfoId { get; set; }

    public long? SurveyQuestionId { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Rating { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public long? GuestId { get; set; }

    [StringLength(150)]
    public string? FirstName { get; set; }

    [StringLength(150)]
    public string? LastName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Birtday { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArrivalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepartureDate { get; set; }

    public int? RoomId { get; set; }

    [StringLength(150)]
    public string? Room { get; set; }

    [StringLength(550)]
    public string? Address { get; set; }

    [StringLength(550)]
    public string? City { get; set; }

    [StringLength(150)]
    public string? PostalCode { get; set; }

    [StringLength(150)]
    public string? Country { get; set; }

    [StringLength(550)]
    public string? Email { get; set; }

    [StringLength(150)]
    public string? Telephone { get; set; }

    public int? ProfileNo { get; set; }

    public int? ReservationId { get; set; }

    [StringLength(150)]
    public string? ReservationCode { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("PdaSurveyAnswers")]
    public virtual Guest? Guest { get; set; }

    [ForeignKey("HotelInfoId")]
    [InverseProperty("PdaSurveyAnswers")]
    public virtual HotelInfo? HotelInfo { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PdaSurveyAnswers")]
    public virtual PosInfo? PosInfo { get; set; }
}
