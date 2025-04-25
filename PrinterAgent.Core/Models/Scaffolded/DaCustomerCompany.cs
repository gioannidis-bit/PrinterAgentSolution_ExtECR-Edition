using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_CustomerCompany")]
public partial class DaCustomerCompany
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [InverseProperty("DaCustomerCompany")]
    public virtual ICollection<DaCustomer> DaCustomers { get; set; } = new List<DaCustomer>();
}
