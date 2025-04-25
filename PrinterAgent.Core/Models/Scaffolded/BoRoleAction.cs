using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_RoleActions")]
public partial class BoRoleAction
{
    [Key]
    public long Id { get; set; }

    public long? Roleid { get; set; }

    public long? ActionId { get; set; }

    public long? OptionId { get; set; }

    [ForeignKey("ActionId")]
    [InverseProperty("BoRoleActions")]
    public virtual BoAction? Action { get; set; }

    [ForeignKey("OptionId")]
    [InverseProperty("BoRoleActions")]
    public virtual BoOption? Option { get; set; }

    [ForeignKey("Roleid")]
    [InverseProperty("BoRoleActions")]
    public virtual BoRole? Role { get; set; }
}
