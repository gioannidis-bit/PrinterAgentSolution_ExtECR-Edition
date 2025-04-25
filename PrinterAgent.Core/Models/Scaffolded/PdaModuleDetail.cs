using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PdaModuleDetail")]
public partial class PdaModuleDetail
{
    [Key]
    public long Id { get; set; }

    public long? PdaModuleId { get; set; }

    [Column("LastLoginTS", TypeName = "datetime")]
    public DateTime? LastLoginTs { get; set; }

    [Column("LastLogoutTS", TypeName = "datetime")]
    public DateTime? LastLogoutTs { get; set; }

    public long? StaffId { get; set; }

    [ForeignKey("PdaModuleId")]
    [InverseProperty("PdaModuleDetails")]
    public virtual PdaModule? PdaModule { get; set; }
}
