using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EFoodBucket")]
public partial class EfoodBucket
{
    [Key]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? Json { get; set; }

    public bool? IsDeleted { get; set; }

    public DateOnly? CreateDate { get; set; }
}
