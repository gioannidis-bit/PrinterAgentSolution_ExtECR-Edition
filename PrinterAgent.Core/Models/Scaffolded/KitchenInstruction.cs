using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("KitchenInstruction")]
public partial class KitchenInstruction
{
    [Key]
    public long Id { get; set; }

    public long? KitchenId { get; set; }

    [StringLength(300)]
    public string? Message { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [InverseProperty("KicthcenInstuction")]
    public virtual ICollection<KitchenInstructionLogger> KitchenInstructionLoggers { get; set; } = new List<KitchenInstructionLogger>();

    [InverseProperty("KitchenInstruction")]
    public virtual ICollection<PosInfoKitchenInstructionAssoc> PosInfoKitchenInstructionAssocs { get; set; } = new List<PosInfoKitchenInstructionAssoc>();
}
