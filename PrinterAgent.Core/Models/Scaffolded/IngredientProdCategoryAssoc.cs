using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Ingredient_ProdCategoryAssoc")]
public partial class IngredientProdCategoryAssoc
{
    [Key]
    public long Id { get; set; }

    public long? IngredientId { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? Sort { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public double? MinQty { get; set; }

    public double? MaxQty { get; set; }

    public bool? CanSavePrice { get; set; }
}
