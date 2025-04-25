﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("GuestFuture")]
public partial class GuestFuture
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }
}
