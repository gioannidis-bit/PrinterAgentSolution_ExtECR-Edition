using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_CustomersTypes")]
public partial class DeliveryCustomersType
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Descr { get; set; } = null!;

    [InverseProperty("CustomerTypeNavigation")]
    public virtual ICollection<DeliveryCustomer> DeliveryCustomers { get; set; } = new List<DeliveryCustomer>();
}
