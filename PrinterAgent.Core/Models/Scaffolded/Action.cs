using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Action
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [InverseProperty("Action")]
    public virtual ICollection<AuthorizedGroupDetail> AuthorizedGroupDetails { get; set; } = new List<AuthorizedGroupDetail>();
}
