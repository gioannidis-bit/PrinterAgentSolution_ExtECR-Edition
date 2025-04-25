using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Kitchen")]
public partial class Kitchen
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public byte? Status { get; set; }

    public bool? IsDeleted { get; set; }

    [InverseProperty("Kitchen")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
