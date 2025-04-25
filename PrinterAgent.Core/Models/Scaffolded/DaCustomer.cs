using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_Customers")]
public partial class DaCustomer
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(500)]
    public string? Password { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string LastName { get; set; } = null!;

    [StringLength(20)]
    public string? Phone1 { get; set; }

    [StringLength(20)]
    public string? Phone2 { get; set; }

    [StringLength(20)]
    public string? Mobile { get; set; }

    public long? BillingAddressesId { get; set; }

    [StringLength(20)]
    public string? VatNo { get; set; }

    [StringLength(100)]
    public string? Doy { get; set; }

    [StringLength(200)]
    public string? JobName { get; set; }

    public long? LastAddressId { get; set; }

    [StringLength(1500)]
    public string? Notes { get; set; }

    [StringLength(1500)]
    public string? SecretNotes { get; set; }

    [StringLength(1500)]
    public string? LastOrderNote { get; set; }

    [Column("GTPR_Marketing")]
    public bool? GtprMarketing { get; set; }

    [Column("GTPR_Returner")]
    public bool? GtprReturner { get; set; }

    public bool? Loyalty { get; set; }

    [StringLength(200)]
    public string? SessionKey { get; set; }

    [StringLength(50)]
    public string? ExtId1 { get; set; }

    [StringLength(50)]
    public string? ExtId2 { get; set; }

    [StringLength(50)]
    public string? ExtId3 { get; set; }

    [StringLength(50)]
    public string? ExtId4 { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    public string? PhoneComp { get; set; }

    public bool SendSms { get; set; }

    public bool SendEmail { get; set; }

    [StringLength(100)]
    public string? Proffesion { get; set; }

    [StringLength(50)]
    public string? EmailOld { get; set; }

    [StringLength(500)]
    public string? AuthToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public string? Metadata { get; set; }

    public int? IsAnonymous { get; set; }

    [Column("DA_CustomerJobsId")]
    public long? DaCustomerJobsId { get; set; }

    [Column("DA_CustomerCompanyId")]
    public long? DaCustomerCompanyId { get; set; }

    [ForeignKey("DaCustomerCompanyId")]
    [InverseProperty("DaCustomers")]
    public virtual DaCustomerCompany? DaCustomerCompany { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<DaCustomerMessage> DaCustomerMessages { get; set; } = new List<DaCustomerMessage>();

    [InverseProperty("Customer")]
    public virtual ICollection<DaCustomersToken> DaCustomersTokens { get; set; } = new List<DaCustomersToken>();

    [InverseProperty("Customer")]
    public virtual ICollection<DaLoyalPoint> DaLoyalPoints { get; set; } = new List<DaLoyalPoint>();

    [InverseProperty("Customer")]
    public virtual ICollection<DaOrder> DaOrders { get; set; } = new List<DaOrder>();
}
