using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_Actions")]
public partial class BoAction
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? OptionName { get; set; }

    [StringLength(250)]
    public string? Icon { get; set; }

    [StringLength(250)]
    public string? CollapseValue { get; set; }

    [StringLength(250)]
    public string? StateRef { get; set; }

    public int? MajorVersion { get; set; }

    [InverseProperty("Action")]
    public virtual ICollection<BoOption> BoOptions { get; set; } = new List<BoOption>();

    [InverseProperty("Action")]
    public virtual ICollection<BoRoleAction> BoRoleActions { get; set; } = new List<BoRoleAction>();
}
