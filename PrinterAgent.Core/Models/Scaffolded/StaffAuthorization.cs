using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("StaffAuthorization")]
public partial class StaffAuthorization
{
    [Key]
    public long Id { get; set; }

    public long? AuthorizedGroupId { get; set; }

    public long? StaffId { get; set; }

    [ForeignKey("AuthorizedGroupId")]
    [InverseProperty("StaffAuthorizations")]
    public virtual AuthorizedGroup? AuthorizedGroup { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("StaffAuthorizations")]
    public virtual Staff? Staff { get; set; }
}
