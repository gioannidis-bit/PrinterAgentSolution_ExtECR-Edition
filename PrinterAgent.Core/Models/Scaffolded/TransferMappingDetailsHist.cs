using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("TransferMappingDetails_Hist")]
public partial class TransferMappingDetailsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? TransferMappingsId { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? ProductId { get; set; }
}
