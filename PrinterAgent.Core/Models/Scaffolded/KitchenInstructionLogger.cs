using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("KitchenInstructionLogger")]
public partial class KitchenInstructionLogger
{
    [Key]
    public long Id { get; set; }

    public long? KicthcenInstuctionId { get; set; }

    public long? StaffId { get; set; }

    public long? PdaModulId { get; set; }

    public long? ClientId { get; set; }

    public long? PosInfoId { get; set; }

    [Column("SendTS", TypeName = "datetime")]
    public DateTime? SendTs { get; set; }

    [Column("ReceivedTS", TypeName = "datetime")]
    public DateTime? ReceivedTs { get; set; }

    public long? EndOfDayId { get; set; }

    public short? Status { get; set; }

    public long? TableId { get; set; }

    [StringLength(200)]
    public string? ExtecrName { get; set; }

    [StringLength(2000)]
    public string? Description { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("KitchenInstructionLoggers")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [ForeignKey("KicthcenInstuctionId")]
    [InverseProperty("KitchenInstructionLoggers")]
    public virtual KitchenInstruction? KicthcenInstuction { get; set; }
}
