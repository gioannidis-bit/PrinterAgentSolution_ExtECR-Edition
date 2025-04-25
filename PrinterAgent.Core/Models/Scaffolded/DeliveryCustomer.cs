using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_Customers")]
public partial class DeliveryCustomer
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(80)]
    public string LastName { get; set; } = null!;

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(20)]
    public string? VatNo { get; set; }

    [Column("DOY")]
    [StringLength(50)]
    public string? Doy { get; set; }

    [StringLength(200)]
    public string? Floor { get; set; }

    [Column("email")]
    [StringLength(255)]
    public string? Email { get; set; }

    [StringLength(1500)]
    public string? Comments { get; set; }

    public int? CustomerType { get; set; }

    [StringLength(80)]
    public string? BillingName { get; set; }

    [StringLength(20)]
    public string? BillingVatNo { get; set; }

    [Column("BillingDOY")]
    [StringLength(50)]
    public string? BillingDoy { get; set; }

    [StringLength(80)]
    public string? BillingJob { get; set; }

    public long? DefaultPricelistId { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(255)]
    public string? ExtCustId { get; set; }

    public int? ExtType { get; set; }

    [Unicode(false)]
    public string? ExtObj { get; set; }

    [Column("GDPR_IsDeleted")]
    public bool? GdprIsDeleted { get; set; }

    [Column("GDPR_Marketing")]
    public bool? GdprMarketing { get; set; }

    [Column("GDPR_Returner")]
    public bool? GdprReturner { get; set; }

    [Column("GDPR_StaffId")]
    public bool? GdprStaffId { get; set; }

    [Column("GDPR_StaffName")]
    public bool? GdprStaffName { get; set; }

    [StringLength(20)]
    public string? PhoneComp { get; set; }

    public bool? SendSms { get; set; }

    public bool? SendEmail { get; set; }

    [StringLength(100)]
    public string? Proffesion { get; set; }

    public long? DaId { get; set; }

    [ForeignKey("CustomerType")]
    [InverseProperty("DeliveryCustomers")]
    public virtual DeliveryCustomersType? CustomerTypeNavigation { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<DeliveryCustomersBillingAddress> DeliveryCustomersBillingAddresses { get; set; } = new List<DeliveryCustomersBillingAddress>();

    [InverseProperty("Customer")]
    public virtual ICollection<DeliveryCustomersPhone> DeliveryCustomersPhones { get; set; } = new List<DeliveryCustomersPhone>();

    [InverseProperty("Customer")]
    public virtual ICollection<DeliveryCustomersPhonesAndAddress> DeliveryCustomersPhonesAndAddresses { get; set; } = new List<DeliveryCustomersPhonesAndAddress>();

    [InverseProperty("Customer")]
    public virtual ICollection<DeliveryCustomersShippingAddress> DeliveryCustomersShippingAddresses { get; set; } = new List<DeliveryCustomersShippingAddress>();

    [InverseProperty("DeliveryCustomer")]
    public virtual ICollection<InvoiceGuestsTran> InvoiceGuestsTrans { get; set; } = new List<InvoiceGuestsTran>();
}
