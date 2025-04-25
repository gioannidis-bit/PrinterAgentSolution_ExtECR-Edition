using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EmailConfig")]
public partial class EmailConfig
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string Smtp { get; set; } = null!;

    public int Port { get; set; }

    public bool Ssl { get; set; }

    [StringLength(100)]
    public string Username { get; set; } = null!;

    [StringLength(100)]
    public string Sender { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public bool IsActive { get; set; }
}
