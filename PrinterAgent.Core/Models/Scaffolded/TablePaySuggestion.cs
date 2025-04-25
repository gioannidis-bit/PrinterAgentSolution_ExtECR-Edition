using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TablePaySuggestion")]
public partial class TablePaySuggestion
{
    [Key]
    public long Id { get; set; }

    public long? AccountId { get; set; }

    public long? GuestId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Amount { get; set; }

    public long? OrderDetailId { get; set; }

    public bool? IsUsed { get; set; }

    public long? CreditCodeId { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("TablePaySuggestions")]
    public virtual Account? Account { get; set; }

    [ForeignKey("CreditCodeId")]
    [InverseProperty("TablePaySuggestions")]
    public virtual CreditCode? CreditCode { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("TablePaySuggestions")]
    public virtual Guest? Guest { get; set; }

    [ForeignKey("OrderDetailId")]
    [InverseProperty("TablePaySuggestions")]
    public virtual OrderDetail? OrderDetail { get; set; }
}
