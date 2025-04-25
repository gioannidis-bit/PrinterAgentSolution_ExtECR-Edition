using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("initial_items")]
public partial class InitialItem
{
    [Column("code")]
    public double? Code { get; set; }

    [Column("description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("POOLBAR")]
    public double? Poolbar { get; set; }

    [StringLength(255)]
    public string? Ομάδα { get; set; }

    [Column("fpa")]
    public double? Fpa { get; set; }

    [StringLength(255)]
    public string? Κατηγορία { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(255)]
    public string? Ποσότητα { get; set; }

    [Column("MAIN BAR")]
    public double? MainBar { get; set; }

    [Column("RESTAURANT")]
    [StringLength(255)]
    public string? Restaurant { get; set; }

    [Column("WHITE VIEW")]
    [StringLength(255)]
    public string? WhiteView { get; set; }

    [Column("MINI BAR")]
    [StringLength(255)]
    public string? MiniBar { get; set; }

    [Column("MINI MARKET")]
    [StringLength(255)]
    public string? MiniMarket { get; set; }

    [Column("TENNIS")]
    public double? Tennis { get; set; }

    [Column("FUNCTION")]
    public double? Function { get; set; }

    [Column("MARATHA")]
    [StringLength(255)]
    public string? Maratha { get; set; }

    [Column("MARATHA ΠΡΟΣΩΠΙΚΟ")]
    [StringLength(255)]
    public string? MarathaΠροσωπικο { get; set; }

    [Column("MARATHA UMBRELLAS")]
    [StringLength(255)]
    public string? MarathaUmbrellas { get; set; }

    [Column("ΑΥΤ# POOL BAR")]
    public double? ΑυτPoolBar { get; set; }

    [Column("ΑΥΤ# MAIN BAR")]
    public double? ΑυτMainBar { get; set; }

    [Column("ΑΥΤ# RESTAURANT")]
    public double? ΑυτRestaurant { get; set; }

    [Column("ΑΥΤ# WHITE VIEW")]
    public double? ΑυτWhiteView { get; set; }

    [Column("ΑΥΤ# MINI BAR")]
    public double? ΑυτMiniBar { get; set; }

    [Column("ΑΥΤ# FUNCTION")]
    public double? ΑυτFunction { get; set; }

    [Column("ΑΥΤ# MARATHA")]
    public double? ΑυτMaratha { get; set; }

    [Column("ΑΥΤ# MARATHA UMBRELLAS")]
    public double? ΑυτMarathaUmbrellas { get; set; }

    [StringLength(255)]
    public string? F27 { get; set; }

    [Column("productid")]
    public double? Productid { get; set; }
}
