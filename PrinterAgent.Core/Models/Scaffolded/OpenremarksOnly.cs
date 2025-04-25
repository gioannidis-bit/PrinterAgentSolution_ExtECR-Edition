using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class OpenremarksOnly
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

    [Column("pos")]
    [StringLength(250)]
    public string? Pos { get; set; }

    [Column("qty")]
    public double? Qty { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Total { get; set; }

    public long? ProductId { get; set; }

    [Column("catid")]
    public long Catid { get; set; }

    [StringLength(150)]
    public string? Category { get; set; }
}
