using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
[Table("DA_OrderNo")]
public partial class DaOrderNo
{
    public long? OrderNo { get; set; }
}
