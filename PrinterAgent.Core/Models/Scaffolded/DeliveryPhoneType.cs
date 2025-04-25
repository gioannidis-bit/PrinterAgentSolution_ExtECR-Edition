using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_PhoneTypes")]
public partial class DeliveryPhoneType
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Descr { get; set; } = null!;

    [InverseProperty("PhoneTypeNavigation")]
    public virtual ICollection<DeliveryCustomersPhone> DeliveryCustomersPhones { get; set; } = new List<DeliveryCustomersPhone>();
}
