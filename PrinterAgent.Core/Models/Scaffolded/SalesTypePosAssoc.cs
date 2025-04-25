using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("SalesType_Pos_Assoc")]
public partial class SalesTypePosAssoc
{
    [Key]
    public long Id { get; set; }

    public long? SalesTypeId { get; set; }

    public long? PosInfoId { get; set; }
}
