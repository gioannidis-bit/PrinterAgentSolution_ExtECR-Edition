using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_Options")]
public partial class BoOption
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Name { get; set; }

    [StringLength(250)]
    public string? StateRef { get; set; }

    public long? ActionId { get; set; }

    public int? MinorVersion { get; set; }

    [ForeignKey("ActionId")]
    [InverseProperty("BoOptions")]
    public virtual BoAction? Action { get; set; }

    [InverseProperty("Option")]
    public virtual ICollection<BoRoleAction> BoRoleActions { get; set; } = new List<BoRoleAction>();
}
