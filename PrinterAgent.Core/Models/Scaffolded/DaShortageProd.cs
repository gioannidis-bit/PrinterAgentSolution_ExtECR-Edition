using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_ShortageProds")]
public partial class DaShortageProd
{
    [Key]
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long StoreId { get; set; }

    public short ShortType { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("DaShortageProds")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("DaShortageProds")]
    public virtual DaStore Store { get; set; } = null!;
}
