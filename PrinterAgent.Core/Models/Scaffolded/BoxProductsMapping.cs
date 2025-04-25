using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BoxProductsMapping")]
public partial class BoxProductsMapping
{
    [Key]
    public long Id { get; set; }

    public long? MainProductForBoxCode { get; set; }

    public string? ChoicesCodes { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductDescription { get; set; }
}
