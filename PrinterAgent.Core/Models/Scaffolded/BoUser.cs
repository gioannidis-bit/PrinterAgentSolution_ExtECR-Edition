using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_Users")]
public partial class BoUser
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Name { get; set; }

    [StringLength(150)]
    public string? Username { get; set; }

    [StringLength(200)]
    public string? Password { get; set; }

    [StringLength(150)]
    public string? Email { get; set; }

    public long? Roleid { get; set; }

    public bool? IsActive { get; set; }

    [ForeignKey("Roleid")]
    [InverseProperty("BoUsers")]
    public virtual BoRole? Role { get; set; }
}
