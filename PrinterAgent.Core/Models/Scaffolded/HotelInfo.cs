using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("HotelInfo")]
public partial class HotelInfo
{
    [Key]
    public long Id { get; set; }

    public long? StoreId { get; set; }

    public int? HotelId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? HotelUri { get; set; }

    public byte? Type { get; set; }

    [StringLength(1000)]
    public string? RedirectToCustomerCard { get; set; }

    public short? PmsType { get; set; }

    [Column("DBUserName")]
    [StringLength(100)]
    public string? DbuserName { get; set; }

    [Column("DBPassword")]
    [StringLength(1000)]
    public string? Dbpassword { get; set; }

    [StringLength(500)]
    public string? HotelName { get; set; }

    [StringLength(500)]
    public string? ServerName { get; set; }

    [Column("MPEHotel")]
    public short? Mpehotel { get; set; }

    [Column("DBName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dbname { get; set; }

    [Column("allHotels")]
    public short? AllHotels { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HotelType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TcpHostName { get; set; }

    public int? TcpPort { get; set; }

    [StringLength(500)]
    public string? ExtApiUsername { get; set; }

    [StringLength(500)]
    public string? ExtApiPassword { get; set; }

    [StringLength(500)]
    public string? ExtApiMappingMethodOfPayments { get; set; }

    [StringLength(100)]
    public string? ModifyInfoCheckOutCheck { get; set; }

    [StringLength(100)]
    public string? ModifyInfoPeriodCheckOutCheck { get; set; }

    [InverseProperty("HotelInfo")]
    public virtual ICollection<PdaSurveyAnswer> PdaSurveyAnswers { get; set; } = new List<PdaSurveyAnswer>();

    [ForeignKey("StoreId")]
    [InverseProperty("HotelInfos")]
    public virtual Store? Store { get; set; }

    [InverseProperty("DefaultHotel")]
    public virtual ICollection<TrConfig> TrConfigs { get; set; } = new List<TrConfig>();

    [InverseProperty("Hotel")]
    public virtual ICollection<TrReservationCustomer> TrReservationCustomers { get; set; } = new List<TrReservationCustomer>();
}
