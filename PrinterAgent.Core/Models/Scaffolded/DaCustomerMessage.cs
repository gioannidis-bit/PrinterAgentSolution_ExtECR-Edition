using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_CustomerMessages")]
public partial class DaCustomerMessage
{
    [Key]
    public long Id { get; set; }

    public long? CustomerId { get; set; }

    public long? MessageId { get; set; }

    public long? MessageDetailsId { get; set; }

    [Column("MainDAMessageId")]
    public long? MainDamessageId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public long? StaffId { get; set; }

    [StringLength(1000)]
    public string? MessageText { get; set; }

    public long? OrderId { get; set; }

    public long? StoreId { get; set; }

    public bool? IsTemporary { get; set; }

    public short? Origin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedDate { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DaCustomerMessages")]
    public virtual DaCustomer? Customer { get; set; }

    [ForeignKey("MainDamessageId")]
    [InverseProperty("DaCustomerMessages")]
    public virtual DaMainMessage? MainDamessage { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("DaCustomerMessages")]
    public virtual DaMessage? Message { get; set; }

    [ForeignKey("MessageDetailsId")]
    [InverseProperty("DaCustomerMessages")]
    public virtual DaMessagesDetail? MessageDetails { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("DaCustomerMessages")]
    public virtual DaOrder? Order { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("DaCustomerMessages")]
    public virtual DaStore? Store { get; set; }
}
