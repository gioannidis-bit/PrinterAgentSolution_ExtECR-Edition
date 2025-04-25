using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_MessagesDetails")]
public partial class DaMessagesDetail
{
    [Key]
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    public bool? ToOrder { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(1000)]
    public string? Email { get; set; }

    public bool? OnOrderCreate { get; set; }

    public bool? OnOrderUpdate { get; set; }

    public bool? OnNewCall { get; set; }

    [InverseProperty("MessageDetails")]
    public virtual ICollection<DaCustomerMessage> DaCustomerMessages { get; set; } = new List<DaCustomerMessage>();

    [ForeignKey("HeaderId")]
    [InverseProperty("DaMessagesDetails")]
    public virtual DaMessage? Header { get; set; }
}
