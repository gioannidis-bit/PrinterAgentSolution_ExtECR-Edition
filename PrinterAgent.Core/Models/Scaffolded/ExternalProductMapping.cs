using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ExternalProductMapping")]
public partial class ExternalProductMapping
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    public int? ProductEnumType { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ExternalProductMappings")]
    public virtual Product? Product { get; set; }
}
