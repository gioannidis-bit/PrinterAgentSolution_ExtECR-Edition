using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PagePosAssoc")]
public partial class PagePosAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PageSetId { get; set; }

    public long? PosInfoId { get; set; }

    [ForeignKey("PageSetId")]
    [InverseProperty("PagePosAssocs")]
    public virtual PageSet? PageSet { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PagePosAssocs")]
    public virtual PosInfo? PosInfo { get; set; }
}
