using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_CustomersPhones")]
public partial class DeliveryCustomersPhone
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("CustomerID")]
    public long CustomerId { get; set; }

    [StringLength(20)]
    public string PhoneNumber { get; set; } = null!;

    public int PhoneType { get; set; }

    public bool? IsSelected { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ExtKey { get; set; }

    public int? ExtType { get; set; }

    [Unicode(false)]
    public string? ExtObj { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DeliveryCustomersPhones")]
    public virtual DeliveryCustomer Customer { get; set; } = null!;

    [InverseProperty("Phone")]
    public virtual ICollection<DeliveryCustomersPhonesAndAddress> DeliveryCustomersPhonesAndAddresses { get; set; } = new List<DeliveryCustomersPhonesAndAddress>();

    [ForeignKey("PhoneType")]
    [InverseProperty("DeliveryCustomersPhones")]
    public virtual DeliveryPhoneType PhoneTypeNavigation { get; set; } = null!;
}
