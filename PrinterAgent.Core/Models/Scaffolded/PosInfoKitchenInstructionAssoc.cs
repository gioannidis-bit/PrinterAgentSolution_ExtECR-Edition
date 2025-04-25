using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfo_KitchenInstruction_Assoc")]
public partial class PosInfoKitchenInstructionAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? KitchenInstructionId { get; set; }

    [ForeignKey("KitchenInstructionId")]
    [InverseProperty("PosInfoKitchenInstructionAssocs")]
    public virtual KitchenInstruction? KitchenInstruction { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PosInfoKitchenInstructionAssocs")]
    public virtual PosInfo? PosInfo { get; set; }
}
