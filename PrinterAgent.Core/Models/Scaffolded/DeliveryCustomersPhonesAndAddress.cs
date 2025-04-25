using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_CustomersPhonesAndAddress")]
public partial class DeliveryCustomersPhonesAndAddress
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("CustomerID")]
    public long CustomerId { get; set; }

    [Column("PhoneID")]
    public long PhoneId { get; set; }

    [Column("AddressID")]
    public long AddressId { get; set; }

    public short IsShipping { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DeliveryCustomersPhonesAndAddresses")]
    public virtual DeliveryCustomer Customer { get; set; } = null!;

    [ForeignKey("PhoneId")]
    [InverseProperty("DeliveryCustomersPhonesAndAddresses")]
    public virtual DeliveryCustomersPhone Phone { get; set; } = null!;
}
