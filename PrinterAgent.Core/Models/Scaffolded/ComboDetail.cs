using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ComboDetail")]
public partial class ComboDetail
{
    [Key]
    public long Id { get; set; }

    public long? ComboId { get; set; }

    public long? ProductComboItemId { get; set; }

    [ForeignKey("ComboId")]
    [InverseProperty("ComboDetails")]
    public virtual Combo? Combo { get; set; }

    [ForeignKey("ProductComboItemId")]
    [InverseProperty("ComboDetails")]
    public virtual Product? ProductComboItem { get; set; }
}
