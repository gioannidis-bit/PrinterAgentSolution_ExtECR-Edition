using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class Openremark
{
    [Column("foday", TypeName = "datetime")]
    public DateTime? Foday { get; set; }

    [Column("creationts", TypeName = "datetime")]
    public DateTime? Creationts { get; set; }

    [Column("counter")]
    public long? Counter { get; set; }

    [Column("price", TypeName = "money")]
    public decimal? Price { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [Column("itemremark")]
    [StringLength(150)]
    public string? Itemremark { get; set; }

    [Column("catid")]
    public long Catid { get; set; }

    [StringLength(150)]
    public string? Category { get; set; }
}
