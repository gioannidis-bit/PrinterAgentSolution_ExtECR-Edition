using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("AuthorizedGroup")]
public partial class AuthorizedGroup
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? ExtendedDescription { get; set; }

    [InverseProperty("AuthorizedGroup")]
    public virtual ICollection<AuthorizedGroupDetail> AuthorizedGroupDetails { get; set; } = new List<AuthorizedGroupDetail>();

    [InverseProperty("AuthorizedGroup")]
    public virtual ICollection<StaffAuthorization> StaffAuthorizations { get; set; } = new List<StaffAuthorization>();
}
