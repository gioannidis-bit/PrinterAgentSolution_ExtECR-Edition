using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class ValidModule
{
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// Enum for 
    /// POS
    /// KDS
    /// TABLES
    /// DELIVERY
    /// </summary>
    public short? ModuleType { get; set; }

    public int? MaxInstances { get; set; }
}
