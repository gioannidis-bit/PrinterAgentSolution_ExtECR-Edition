using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfoKdsAssoc")]
public partial class PosInfoKdsAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? KdsId { get; set; }

    [ForeignKey("KdsId")]
    [InverseProperty("PosInfoKdsAssocs")]
    public virtual Kd? Kds { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PosInfoKdsAssocs")]
    public virtual PosInfo? PosInfo { get; set; }
}
