using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class DiscountTypeRule
{
    [Key]
    public long Id { get; set; }

    public long? DiscountTypeId { get; set; }

    public string? Timezones { get; set; }

    public string? ActiveDays { get; set; }

    public string? CustomerPolicy { get; set; }

    [ForeignKey("DiscountTypeId")]
    [InverseProperty("DiscountTypeRules")]
    public virtual DiscountType? DiscountType { get; set; }
}
