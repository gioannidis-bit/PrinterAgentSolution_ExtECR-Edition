using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Notification
{
    [Key]
    public long Id { get; set; }

    public string? Message { get; set; }

    [Column("MessageTS", TypeName = "datetime")]
    public DateTime? MessageTs { get; set; }

    public string? UserList { get; set; }

    [StringLength(150)]
    public string? Sender { get; set; }

    public long? PosInfoId { get; set; }

    public long? StoreId { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("Notifications")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("Notifications")]
    public virtual Store? Store { get; set; }
}
