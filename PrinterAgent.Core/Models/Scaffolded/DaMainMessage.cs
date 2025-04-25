using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_MainMessages")]
public partial class DaMainMessage
{
    [Key]
    public long Id { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(1000)]
    public string? Email { get; set; }

    public bool? OnOrderCreate { get; set; }

    public bool? OnOrderUpdate { get; set; }

    public bool? OnNewCall { get; set; }

    [InverseProperty("MainDamessage")]
    public virtual ICollection<DaCustomerMessage> DaCustomerMessages { get; set; } = new List<DaCustomerMessage>();

    [InverseProperty("MainDamessages")]
    public virtual ICollection<DaMessage> DaMessages { get; set; } = new List<DaMessage>();
}
