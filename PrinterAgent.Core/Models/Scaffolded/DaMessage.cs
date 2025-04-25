using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_Messages")]
public partial class DaMessage
{
    [Key]
    public long Id { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("MainDAMessagesID")]
    public long? MainDamessagesId { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(1000)]
    public string? Email { get; set; }

    public bool? OnOrderCreate { get; set; }

    public bool? OnOrderUpdate { get; set; }

    public bool? OnNewCall { get; set; }

    [InverseProperty("Message")]
    public virtual ICollection<DaCustomerMessage> DaCustomerMessages { get; set; } = new List<DaCustomerMessage>();

    [InverseProperty("Header")]
    public virtual ICollection<DaMessagesDetail> DaMessagesDetails { get; set; } = new List<DaMessagesDetail>();

    [ForeignKey("MainDamessagesId")]
    [InverseProperty("DaMessages")]
    public virtual DaMainMessage? MainDamessages { get; set; }
}
