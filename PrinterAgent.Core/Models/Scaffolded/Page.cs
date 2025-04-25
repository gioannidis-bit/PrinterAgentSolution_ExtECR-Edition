using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Page
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? ExtendedDesc { get; set; }

    public bool? Status { get; set; }

    public short? Sort { get; set; }

    public long? DefaultPriceList { get; set; }

    public long? PageSetId { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("Page")]
    public virtual ICollection<PageButton> PageButtons { get; set; } = new List<PageButton>();

    [ForeignKey("PageSetId")]
    [InverseProperty("Pages")]
    public virtual PageSet? PageSet { get; set; }
}
