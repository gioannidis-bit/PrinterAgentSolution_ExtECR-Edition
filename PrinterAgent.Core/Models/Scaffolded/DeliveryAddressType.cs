using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_AddressTypes")]
public partial class DeliveryAddressType
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Home, Company ...
    /// </summary>
    [StringLength(20)]
    public string Descr { get; set; } = null!;

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<DeliveryCustomersBillingAddress> DeliveryCustomersBillingAddresses { get; set; } = new List<DeliveryCustomersBillingAddress>();

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<DeliveryCustomersShippingAddress> DeliveryCustomersShippingAddresses { get; set; } = new List<DeliveryCustomersShippingAddress>();
}
