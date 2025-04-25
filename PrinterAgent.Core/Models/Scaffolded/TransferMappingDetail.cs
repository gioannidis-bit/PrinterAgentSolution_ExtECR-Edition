using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class TransferMappingDetail
{
    [Key]
    public long Id { get; set; }

    public long? TransferMappingsId { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? ProductId { get; set; }

    [ForeignKey("TransferMappingsId")]
    [InverseProperty("TransferMappingDetails")]
    public virtual TransferMapping? TransferMappings { get; set; }
}
