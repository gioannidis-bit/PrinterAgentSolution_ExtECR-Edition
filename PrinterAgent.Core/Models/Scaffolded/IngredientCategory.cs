using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class IngredientCategory
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public byte? Status { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public bool? IsUnique { get; set; }

    [InverseProperty("IngredientCategory")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
