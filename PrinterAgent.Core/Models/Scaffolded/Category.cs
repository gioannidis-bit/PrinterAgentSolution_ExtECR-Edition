using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Category
{
    [Key]
    public long Id { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public byte? Status { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}
