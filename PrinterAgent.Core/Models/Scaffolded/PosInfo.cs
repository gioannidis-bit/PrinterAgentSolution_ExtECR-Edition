using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfo")]
public partial class PosInfo
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column("FODay", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    public long? CloseId { get; set; }

    [Column("IPAddress")]
    [StringLength(50)]
    public string? Ipaddress { get; set; }

    public byte? Type { get; set; }

    [Column("wsIP")]
    [StringLength(50)]
    public string? WsIp { get; set; }

    [Column("wsPort")]
    [StringLength(50)]
    public string? WsPort { get; set; }

    public long? DepartmentId { get; set; }

    [StringLength(200)]
    public string? FiscalName { get; set; }

    public byte? FiscalType { get; set; }

    public bool? IsOpen { get; set; }

    public long? ReceiptCount { get; set; }

    public bool? ResetsReceiptCounter { get; set; }

    [StringLength(50)]
    public string? Theme { get; set; }

    public long? AccountId { get; set; }

    public bool? LogInToOrder { get; set; }

    public bool? ClearTableManually { get; set; }

    public bool? ViewOnly { get; set; }

    public bool? IsDeleted { get; set; }

    public int? InvoiceSumType { get; set; }

    public short? LoginToOrderMode { get; set; }

    public short? KeyboardType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerDisplayGif { get; set; }

    public int? DefaultHotelId { get; set; }

    [StringLength(200)]
    public string? NfcDevice { get; set; }

    [StringLength(100)]
    public string? Configuration { get; set; }

    [StringLength(150)]
    public string? SevenRoomsVenueId { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("PosInfos")]
    public virtual Account? Account { get; set; }

    [InverseProperty("PosInfo")]
    public virtual ICollection<ClientPo> ClientPos { get; set; } = new List<ClientPo>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<CreditTransaction> CreditTransactions { get; set; } = new List<CreditTransaction>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("PosInfos")]
    public virtual Department? Department { get; set; }

    [InverseProperty("PosInfo")]
    public virtual ICollection<EndOfDay> EndOfDays { get; set; } = new List<EndOfDay>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<EodaccountToPmsTransfer> EodaccountToPmsTransfers { get; set; } = new List<EodaccountToPmsTransfer>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Kd> Kds { get; set; } = new List<Kd>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Locker> Lockers { get; set; } = new List<Locker>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<MealConsumption> MealConsumptions { get; set; } = new List<MealConsumption>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    [InverseProperty("Pos")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PagePosAssoc> PagePosAssocs { get; set; } = new List<PagePosAssoc>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Payrole> Payroles { get; set; } = new List<Payrole>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PayrollNew> PayrollNews { get; set; } = new List<PayrollNew>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PdaModule> PdaModules { get; set; } = new List<PdaModule>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PdaSurveyAnswer> PdaSurveyAnswers { get; set; } = new List<PdaSurveyAnswer>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PdaSurveyQuestion> PdaSurveyQuestions { get; set; } = new List<PdaSurveyQuestion>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PosInfoDetail> PosInfoDetails { get; set; } = new List<PosInfoDetail>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PosInfoKdsAssoc> PosInfoKdsAssocs { get; set; } = new List<PosInfoKdsAssoc>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PosInfoKitchenInstructionAssoc> PosInfoKitchenInstructionAssocs { get; set; } = new List<PosInfoKitchenInstructionAssoc>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PosInfoPricelistAssoc> PosInfoPricelistAssocs { get; set; } = new List<PosInfoPricelistAssoc>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PosInfoRegionAssoc> PosInfoRegionAssocs { get; set; } = new List<PosInfoRegionAssoc>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<PosInfoStaffPositinAssoc> PosInfoStaffPositinAssocs { get; set; } = new List<PosInfoStaffPositinAssoc>();

    [InverseProperty("Pos")]
    public virtual ICollection<Quantity> Quantities { get; set; } = new List<Quantity>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<RegionLockerProduct> RegionLockerProducts { get; set; } = new List<RegionLockerProduct>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();

    [InverseProperty("PosInfo")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
