using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TransferToPms_LastIds")]
public partial class TransferToPmsLastId
{
    [Key]
    public long Id { get; set; }

    public int? WebPosId { get; set; }

    public long? WebPosLastId { get; set; }
}
