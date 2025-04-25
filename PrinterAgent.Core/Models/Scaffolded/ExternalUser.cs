using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class ExternalUser
{
    [Key]
    [StringLength(50)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    public string Password { get; set; } = null!;
}
