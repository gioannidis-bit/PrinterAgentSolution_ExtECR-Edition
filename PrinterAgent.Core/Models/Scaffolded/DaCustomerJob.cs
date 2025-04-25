using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_CustomerJobs")]
public partial class DaCustomerJob
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }
}
