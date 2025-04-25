using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("AuthorizedGroupDetail")]
public partial class AuthorizedGroupDetail
{
    [Key]
    public long Id { get; set; }

    public long? AuthorizedGroupId { get; set; }

    public long? ActionId { get; set; }

    [ForeignKey("ActionId")]
    [InverseProperty("AuthorizedGroupDetails")]
    public virtual Action? Action { get; set; }

    [ForeignKey("AuthorizedGroupId")]
    [InverseProperty("AuthorizedGroupDetails")]
    public virtual AuthorizedGroup? AuthorizedGroup { get; set; }
}
